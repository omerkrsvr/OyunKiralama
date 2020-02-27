using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ADMİN KULLANICI GİRİSİ : Kullanici Adi : admin , Sifre: admin 
namespace OyunKiralama
{//ADMİN KULLANICI GİRİSİ : Kullanici Adi : admin , Sifre: admin 
    public partial class Giris : Form
    {
        //ADMİN KULLANICI GİRİSİ : Kullanici Adi : admin , Sifre: admin 
        SqlConnection baglanti = new SqlConnection("Data Source=OMER-KIRSEVER\\OMERK;Initial Catalog=OyunKiralama;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        AnaSayfa anasayfa = new AnaSayfa();
        //ADMİN KULLANICI GİRİSİ : Kullanici Adi : admin , Sifre: admin 
        public Giris()
        {
            InitializeComponent();
        }
        //ADMİN KULLANICI GİRİSİ : Kullanici Adi : admin , Sifre: admin 
        private void button1_Click(object sender, EventArgs e)
        {
            admin(kadi, sifre);
        }
        public SqlDataReader admin(TextBox kadi, TextBox sifre)
        {
            //ADMİN KULLANICI GİRİSİ : Kullanici Adi : admin , Sifre: admin 
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from Admin where KullaniciAd='"+kadi.Text+"'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if(sifre.Text==read["Sifre"].ToString())
                {

                    MessageBox.Show("Giriş Başarılı.");
                    anasayfa.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz.", "Hata1");
                }

            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata2");
            }
            baglanti.Close();
            return read;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
