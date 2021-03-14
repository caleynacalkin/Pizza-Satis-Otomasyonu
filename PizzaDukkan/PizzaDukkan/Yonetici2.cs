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


namespace PizzaDukkan
{
    public partial class Yonetici2 : Form
    {
        public Yonetici2()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            
            Yonetici kapa = new Yonetici();
            kapa.Close();
            Form1 yeniform = new Form1();
            yeniform.Show();
            this.Close();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True");

        SqlCommand komut;
        SqlDataReader oku;
        public static int id;


        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            pnlAdminEkle.Visible = false;
            if (txtSifre.Text==txtSifreTekrar.Text)
            {
                baglanti.Open();
                string sorgu = "UPDATE Admin SET admin_ad='" + txtAd.Text + "',admin_soyad='" + txtSoyad.Text + "',sifre='" + Convert.ToInt32(txtSifre.Text) + "' WHERE admin_id='" + id + "'";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtSifreTekrar.Text = "";
                lblMesaj.Text = "";
                MessageBox.Show("Bilgileriniz güncellenmiştir");
                
            }
            else
            {
                lblMesaj.Text = "Şifreniz uyuşmamakta !!";
            }
        }



        private void Yonetici2_Load(object sender, EventArgs e)
        {
            pnlAdminEkle.Visible = false;
        
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Admin WHERE admin_id='" + id + "'";
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtKullaniciAd.Text = oku["kullanici_ad"].ToString();
                txtAd.Text = oku["admin_ad"].ToString();
                txtSoyad.Text = oku["admin_soyad"].ToString();
                txtSifre.Text = oku["sifre"].ToString().Trim();
            }
            baglanti.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.Text = "";
            lblMesaj.Text = "";
            Adminmusteriler ac = new Adminmusteriler();
            ac.Show();         
        }



        private void button2_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.Text = "";
            lblMesaj.Text = "";
            Adminsiparisler ac = new Adminsiparisler();
            ac.Show();         
        }



        private void button3_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.Text = "";
            lblMesaj.Text = "";
            Adminurunler ac = new Adminurunler();
            ac.Show();        
        }



        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.Text = "";
            lblMesaj.Text = "";
            pnlAdminEkle.Visible = true;
        }

        private void btnYeniAdminEkle_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text==txtYeniSifreTekrar.Text)
            {
                string sorgu = "insert into Admin (kullanici_ad,admin_ad,admin_soyad,sifre) values ('" + txtYeniKullaniciAd.Text + "','" + txtYeniAd.Text + "','" + txtYeniSoyad.Text + "','" + txtYeniSifre.Text + "')";
                komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Admin Eklendi :D");

                txtYeniAd.Text = "";
                txtYeniKullaniciAd.Text = "";
                txtYeniSifre.Text = "";
                txtYeniSoyad.Text = "";
                txtYeniSifreTekrar.Text = "";
                lblMesaj2.Text = "";
            }
            else
            {
                lblMesaj2.Text = "Şifre yanlış !";
            }
    
        }

        private void btnVeriTabaniYedek_Click(object sender, EventArgs e)
        {
            txtSifreTekrar.Text = "";
            lblMesaj.Text = "";



            SqlConnection bag = new SqlConnection();
            bag.ConnectionString = "Data Source = EBRU\\SQLEXPRESS; Initial Catalog = pizzaci; Integrated Security = True";
            string sorgu = "backup database model to disk='pizzaciYeni'";
            SqlCommand komut1 = new SqlCommand(sorgu, bag);
            bag.Open();
            komut1.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Yedek alındı");




        }

        private void btn_YedekYukle_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection();
            bag.ConnectionString = "Data Source = EBRU\\SQLEXPRESS; Initial Catalog = pizzaci; Integrated Security = True";
            string sorgu = "backup database model to disk='pizzaciYeni'";
            SqlCommand komut1 = new SqlCommand(sorgu, bag);
            bag.Open();
            komut1.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Veri tabanı import edildi");
        }
    }
}
