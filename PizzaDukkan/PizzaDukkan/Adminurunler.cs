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
    public partial class Adminurunler : Form
    {
        public Adminurunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True");

        SqlCommand komut;
        SqlDataReader oku;
        SqlDataAdapter dr;
        DataTable tb;




        private void Adminurunler_Load(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;



            BoyutListele();
            İcecekListele();
            MalzemeListele();
            SeceneklerListele();
            SoslarListele();



            gvBoyut.Columns[0].Visible = false;
            gvİcecek.Columns[0].Visible = false;
            gvMalzeme.Columns[0].Visible = false;
            gvSecenek.Columns[0].Visible = false;
            gvSos.Columns[0].Visible = false;

        }
       
    


        private void BoyutListele()
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM Boyut";
            dr = new SqlDataAdapter(sorgu, baglanti);
            tb = new DataTable();
            dr.Fill(tb);
            gvBoyut.DataSource = tb;

            baglanti.Close();
        }
        private void İcecekListele()
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM İcecekler";
            dr = new SqlDataAdapter(sorgu, baglanti);
            tb = new DataTable();
            dr.Fill(tb);
            gvİcecek.DataSource = tb;

            baglanti.Close();
        }
        private void MalzemeListele()
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM Malzemeler";
            dr = new SqlDataAdapter(sorgu, baglanti);
            tb = new DataTable();
            dr.Fill(tb);
            gvMalzeme.DataSource = tb;

            baglanti.Close();
        }
        private void SeceneklerListele()
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM Secenekler";
            dr = new SqlDataAdapter(sorgu, baglanti);
            tb = new DataTable();
            dr.Fill(tb);
            gvSecenek.DataSource = tb;

            baglanti.Close();
        }
        private void SoslarListele()
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM Soslar";
            dr = new SqlDataAdapter(sorgu, baglanti);
            tb = new DataTable();
            dr.Fill(tb);
            gvSos.DataSource = tb;

            baglanti.Close();
        }




        int Boyutİd;
        private void gvBoyut_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Boyutİd = Convert.ToInt32(gvBoyut.CurrentRow.Cells[0].Value.ToString());
        }


        int İcecekİd;
        private void gvİcecek_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            İcecekİd = Convert.ToInt32(gvİcecek.CurrentRow.Cells[0].Value.ToString());
        }


        int Malzemeİd;
        private void gvMalzeme_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Malzemeİd = Convert.ToInt32(gvMalzeme.CurrentRow.Cells[0].Value.ToString());
        }


        int Secenekİd;
        private void gvSecenek_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Secenekİd = Convert.ToInt32(gvSecenek.CurrentRow.Cells[0].Value.ToString());
        }


        int Sosİd;
        private void gvSos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Sosİd = Convert.ToInt32(gvSos.CurrentRow.Cells[0].Value.ToString());
        }



        private void btnBoySil_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;


            string sorgu = "DELETE FROM Boyut WHERE boyut_id='" + Boyutİd + "'";
            komut = new SqlCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BoyutListele();
        }
        private void btnİcecekSil_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;

            string sorgu = "DELETE FROM İcecekler WHERE icecek_id='" + İcecekİd + "'";
            komut = new SqlCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            İcecekListele();
        }
        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;

            string sorgu = "DELETE FROM Malzemeler WHERE malzeme_id='" + Malzemeİd + "'";
            komut = new SqlCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MalzemeListele();
        }
        private void btnSecenekSil_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;

            string sorgu = "DELETE FROM Secenekler WHERE secenek_id='" + Secenekİd + "'";
            komut = new SqlCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SeceneklerListele();
        }
        private void btnSosSil_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;

            string sorgu = "DELETE FROM Soslar WHERE sos_id='" + Sosİd + "'";
            komut = new SqlCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SoslarListele();
        }



        private void btnBoyutEkle_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = true;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;

        }
        private void btnİcecekEkle_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = true;
        }
        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = true;
            pnlSecenek.Visible = false;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;
        }
        private void btnSecenekEkle_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = true;
            pnlSos.Visible = false;
            pnlİcecek.Visible = false;
        }
        private void btnSosEkle_Click(object sender, EventArgs e)
        {
            pnlBoyut.Visible = false;
            pnlMalzeme.Visible = false;
            pnlSecenek.Visible = false;
            pnlSos.Visible = true;
            pnlİcecek.Visible = false;
        }



        private void btnBoyutYeniEkle_Click(object sender, EventArgs e)
        {

            string sorgu = "insert into Boyut (boyut_ad) values ('"+txtEklenenBoy.Text+"')";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BoyutListele();

        }
        private void btnİcecekYeniEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into İcecekler (icecek_ad) values ('" + txtEklenenİcecek.Text + "')";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            İcecekListele();
        }
        private void btnMalzemeYeniEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Malzemeler (malzeme_ad) values ('" + txtEklenenMalzeme.Text + "')";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MalzemeListele();
        }
        private void btnSecenekYeniEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Secenekler (secenek_ad) values ('" + txtEklenenSecenek.Text + "')";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SeceneklerListele();
        }
        private void btnSosYeniEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Soslar (sos_ad) values ('" + txtEklenenSos.Text + "')";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SoslarListele();
        }
    }
}
