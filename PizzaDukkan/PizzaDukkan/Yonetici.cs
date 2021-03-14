using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace PizzaDukkan
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        


        private void Yonetici_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 yeniform = new Form1();
            yeniform.Show();
            this.Hide();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True");

        SqlCommand komut;
        SqlDataReader oku;

        public static int gelenid;

      

        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Admin WHERE kullanici_ad='" + txtKullaniciAd.Text + "'";
            oku = komut.ExecuteReader();

            if (oku.Read() == true)
            {
                if (txtSifre.Text.Trim() == oku["sifre"].ToString().Trim())
                {
                    gelenid = Convert.ToInt32(oku["admin_id"].ToString().Trim());
                    Yonetici2.id = gelenid;
                    Yonetici2 yeniform = new Yonetici2();
                    yeniform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sifre Yanlış");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol edin");
            }
            baglanti.Close();
        }
    }
}
