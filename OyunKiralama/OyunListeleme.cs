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
    public partial class OyunListeleme : Form
    {
        Oyun_Kiralama oyun_kiralama = new Oyun_Kiralama();
        public OyunListeleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBarkod.Text = satir.Cells["BarkodNo"].Value.ToString();
            textOyunAd.Text = satir.Cells["Oyun_Adi"].Value.ToString();
            textYapimci.Text = satir.Cells["Yapimci"].Value.ToString();
            comboboxTur.Text = satir.Cells["Oyun_Tur"].Value.ToString();
            textPlatform.Text = satir.Cells["Platform"].Value.ToString();
            textCikisTarih.Text = satir.Cells["Cikis_Tarih"].Value.ToString();
            textUcret.Text = satir.Cells["Ucret"].Value.ToString();
            textStok.Text = satir.Cells["Stok"].Value.ToString();
            pictureBox1.ImageLocation = satir.Cells["Resim"].Value.ToString();
        }

        private void OyunListeleme_Load(object sender, EventArgs e)
        {
            YenileOyunListesi();
        }
        private void YenileOyunListesi()
        {
            string cumle = "select *from Oyun";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun_kiralama.listele(adtr2, cumle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update Oyun set Oyun_Adi=@Oyun_Adi,Yapimci=@Yapimci,Oyun_Tur=@Oyun_Tur,Platform=@Platform,Cikis_Tarih=@Cikis_Tarih,Ucret=@Ucret,Stok=@Stok,Resim=@Resim where BarkodNo=@BarkodNo";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@BarkodNo", textBarkod.Text);
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
            YenileOyunListesi();
            pictureBox1.ImageLocation = "";
            MessageBox.Show("Güncellendi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from Oyun where OyunID='" + satir.Cells["OyunID"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            oyun_kiralama.CRUD(komut2, cümle);
            YenileOyunListesi();
            pictureBox1.ImageLocation = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from Oyun where Oyun_Adi like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun_kiralama.listele(adtr2, cümle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
