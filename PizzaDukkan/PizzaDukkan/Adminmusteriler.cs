using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace PizzaDukkan
{
    public partial class Adminmusteriler : Form
    {
        public Adminmusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True");

        SqlCommand komut;
        SqlDataAdapter dr;
        DataTable tb;


        private void Adminmusteriler_Load(object sender, EventArgs e)
        {
            listele();

        }

        int id;

        private void listele()
        {
            baglanti.Open();
            string sorgu = "SELECT musteri_id,musteri_ad,musteri_soyad,musteri_adres,musteri_tel FROM Musteri";
            dr = new SqlDataAdapter(sorgu, baglanti);
            tb = new DataTable();
            dr.Fill(tb);
            dgvMusteriler.DataSource = tb;

            baglanti.Close();
        }


        public string SAd, Ssoyad, Sadres, Stel;

        private void dgvMusteriler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value.ToString());
            txtAd.Text = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvMusteriler.CurrentRow.Cells[2].Value.ToString();
            txtadres.Text = dgvMusteriler.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgvMusteriler.CurrentRow.Cells[4].Value.ToString();

            SAd = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
            Ssoyad = dgvMusteriler.CurrentRow.Cells[2].Value.ToString();
            Sadres = dgvMusteriler.CurrentRow.Cells[3].Value.ToString();
            Stel = dgvMusteriler.CurrentRow.Cells[4].Value.ToString();

        }



        private void SilinenKaydaEkle()
        {
            string sorgu = "insert into SilinenMusteriler (musteriAd,musteriSoyad,musteriAdres,musteriTel) values ('" +SAd+ "','" + Ssoyad + "','" + Sadres + "','" + Stel + "')";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {


            string sorgu = "DELETE FROM Musteri WHERE musteri_id='" + id + "'";
            komut = new SqlCommand(sorgu,baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SilinenKaydaEkle();
            listele();

         

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Musteri SET musteri_ad='"+txtAd.Text+"',musteri_soyad='"+txtSoyad.Text+"',musteri_adres='"+txtadres.Text+"',musteri_tel='"+txtTel.Text+ "' WHERE musteri_id='"+id+"'";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Müşteri kaydı güncellendi.");
        }


    }
}
