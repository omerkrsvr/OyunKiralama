using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunKiralama
{
    class Oyun_Kiralama
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=OMER-KIRSEVER\OMERK;Initial Catalog=OyunKiralama;Integrated Security=True");
        DataTable tablo;
        public void CRUD(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void oyuncombolisteleme(ComboBox combo,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                combo.Items.Add(read["Oyun_Adi"].ToString());

            }
            baglanti.Close();
        }
        public void TC_Ara(TextBox tc,TextBox id,TextBox ad,TextBox soyad,TextBox mail,TextBox tel, TextBox adres, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                id.Text = read["MusteriID"].ToString();
                ad.Text = read["Ad"].ToString();
                soyad.Text = read["Soyad"].ToString();
                mail.Text = read["Email"].ToString();
                tel.Text = read["Telefon"].ToString();
                adres.Text = read["Adres"].ToString();

            }
            baglanti.Close();


        }
        public void CombodanOyunAdArama(ComboBox oyunlar,TextBox oyunid,TextBox barkod, TextBox yapimci, TextBox tur, TextBox platform,TextBox tarih, TextBox stok, PictureBox resim,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                oyunid.Text = read["OyunID"].ToString();
                barkod.Text = read["BarkodNo"].ToString();
                yapimci.Text = read["Yapimci"].ToString();
                tur.Text = read["Oyun_Tur"].ToString();
                platform.Text = read["Platform"].ToString();
                tarih.Text = read["Cikis_Tarih"].ToString();
                stok.Text = read["Stok"].ToString();
                resim.ImageLocation = read["Resim"].ToString();

            }
            baglanti.Close();


        }
    }
}
