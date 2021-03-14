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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection();


        private void Siparis_Load(object sender, EventArgs e)
        {
            BoyListe();
            SosListe();
            MalzemeListe();
            İcecekListe();
            SecenekListe();
        }




        private void BoyListe()
        {
            baglantı.ConnectionString = ("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Boyut";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string deger = dr["boyut_id"] + " - " + dr["boyut_ad"];
                cb_boy.Items.Add(deger);
            }

            baglantı.Close();
        }
        private void SosListe()
        {
            baglantı.ConnectionString = ("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Soslar";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string deger = dr["sos_id"] + " - " + dr["sos_ad"];
                cb_sos.Items.Add(deger);
            }
            baglantı.Close();
        }
        private void MalzemeListe()
        {
            baglantı.ConnectionString = ("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Malzemeler";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string deger = dr["malzeme_id"] + " - " + dr["malzeme_ad"];
                cb_malzeme.Items.Add(deger);
            }
            baglantı.Close();
        }
        private void İcecekListe()
        {
            baglantı.ConnectionString = ("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM İcecekler";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string deger = dr["icecek_id"] + " - " + dr["icecek_ad"];
                cb_icecek.Items.Add(deger);
            }
            baglantı.Close();
        }
        private void SecenekListe()
        {
            baglantı.ConnectionString = ("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Secenekler";
            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglantı.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string deger = dr["secenek_id"] + " - " + dr["secenek_ad"];
                cb_secenek.Items.Add(deger);
            }
            baglantı.Close();
        }





        private void MusteriEkle()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True");
            string sorgu = "insert into Musteri (musteri_ad,musteri_soyad,musteri_adres,musteri_tel) values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtAdres.Text + "','" + txtTel.Text + "')";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.CommandText = "Select SCOPE_IDENTITY()";
            int id = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            siparisEkle(id);
        }
        private void siparisEkle(int musteri_id)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True");
            string sorgu = "insert into Siparis(musteri_id,boyut_id,secenek_id,sos_id,icecek_id) values ('"+musteri_id+"','"+ cb_boy.CheckedItems[0].ToString().Split('-')[0].Trim() + "','"+ cb_secenek.CheckedItems[0].ToString().Split('-')[0].Trim() + "','"+ cb_sos.CheckedItems[0].ToString().Split('-')[0].Trim() + "','"+ cb_icecek.CheckedItems[0].ToString().Split('-')[0].Trim() + "')";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.CommandText = "Select SCOPE_IDENTITY()";
            int id = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            MalzemeEkle(id);
        }
        private void MalzemeEkle(int siparis_id)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True");

            string sorgu = "";
            foreach (var item in cb_malzeme.CheckedItems)
            {
                 sorgu += "insert into Siparis_Malzeme(Siparis_Id,Malzeme_Id) values ('"+siparis_id+"','"+item.ToString().Split('-')[0].Trim()+"');";
            }
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }






        private void button1_Click(object sender, EventArgs e)
        {
            Form1 yeniform = new Form1();
            yeniform.Show();
            this.Close();
        }






        private void btn_olustur_Click(object sender, EventArgs e)
        {
            MusteriEkle();
            MessageBox.Show("Siparişiniz oluşturuldu.");
        }

        private void cb_boy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
