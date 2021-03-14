using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Adminsiparisler : Form
    {
        public Adminsiparisler()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection();


        private void Adminsiparisler_Load(object sender, EventArgs e)
        {
            Liste();
        }
        private void Liste()
        {
            baglantı.ConnectionString = ("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=pizzaci;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = @"select 
            s.siparis_id,
            musteri_ad + ' ' + musteri_soyad as musteriAdSoyad,
            boyut_ad,
            secenek_ad,
            sos_ad,
            icecek_ad,
            malzeme = STUFF((select m.malzeme_ad from Siparis_Malzeme sm
            inner join Malzemeler m on sm.Malzeme_Id = m.malzeme_id
            where sm.Siparis_Id = 17
            for xml path ('')),1,1,'')
            from siparis s
            inner join Musteri on s.musteri_id = musteri.musteri_id
            inner join Boyut on s.boyut_id = Boyut.boyut_id
            inner join Secenekler on s.secenek_id = Secenekler.secenek_id
            inner join Soslar on s.sos_id = Soslar.sos_id
            inner join İcecekler on s.icecek_id = İcecekler.icecek_id";

            komut.Connection = baglantı;
            komut.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komut;
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                item["malzeme"] = item["malzeme"].ToString().Replace("<malzeme_ad>","").Replace("</malzeme_ad>",",").Replace("malzeme_ad>", "");
            }
            gvListe.DataSource = dt;
          
        }
    }
}
