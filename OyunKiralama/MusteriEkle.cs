using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OyunKiralama
{
    public partial class MusteriEkle : Form
    {
        Oyun_Kiralama oyun_kiralama = new Oyun_Kiralama();
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Musteri(TC,Ad,Soyad,Adres,Email,Telefon) values(@TC,@Ad,@Soyad,@Adres,@Email,@Telefon)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@TC", textTC.Text);
            komut2.Parameters.AddWithValue("@Ad", textAD.Text);
            komut2.Parameters.AddWithValue("@Soyad", textSOYAD.Text);
            komut2.Parameters.AddWithValue("@Adres", textADRES.Text);
            komut2.Parameters.AddWithValue("@Email", textMAIL.Text);
            komut2.Parameters.AddWithValue("@Telefon", textTEL.Text);
            oyun_kiralama.CRUD(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Müşteri Kaydedildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
