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

namespace OyunKiralama
{
    public partial class OyunEkle : Form
    {
        Oyun_Kiralama oyun_kiralama = new Oyun_Kiralama();
        public OyunEkle()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into Oyun(BarkodNo,Oyun_Adi,Yapimci,Oyun_Tur,Platform,Cikis_Tarih,Ucret,Stok,Resim) values(@BarkodNo,@Oyun_Adi,@Yapimci,@Oyun_Tur,@Platform,@Cikis_Tarih,@Ucret,@Stok,@Resim)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@BarkodNo",textBarkod.Text);
            komut2.Parameters.AddWithValue("@Oyun_Adi", textOyunAd.Text);
            komut2.Parameters.AddWithValue("@Yapimci", textYapimci.Text);
            komut2.Parameters.AddWithValue("@Oyun_Tur", comboboxTur.Text);
            komut2.Parameters.AddWithValue("@Platform", textPlatform.Text);
            komut2.Parameters.AddWithValue("@Cikis_Tarih", textCikisTarih.Text);
            komut2.Parameters.AddWithValue("@Ucret", textUcret.Text);
            komut2.Parameters.AddWithValue("@Stok", textStok.Text);
            komut2.Parameters.AddWithValue("@Resim", pictureBox1.ImageLocation);
            oyun_kiralama.CRUD(komut2, cumle);
            comboboxTur.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            MessageBox.Show("Oyun Kaydedildi.");

        }

        private void textADRES_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSOYAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OyunEkle_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
