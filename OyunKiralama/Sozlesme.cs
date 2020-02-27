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
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboboxTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Oyun_Kiralama oyun = new Oyun_Kiralama();

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Oyun";
            oyun.oyuncombolisteleme(comboBoxOyunAd, sorgu2);
            Yenile();
        }
        private void Yenile()
        {
            string sorgu3 = "select *from Kiralama ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun.listele(adtr2, sorgu3);
        }
        private void textTC_TextChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Musteri where TC like'" + textTC.Text + "'";
            oyun.TC_Ara(textTC,textMusteriID,textAD,textSOYAD,textMAIL,textTEL,textADRES,sorgu2);

            
        }

        private void comboBoxOyunAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Oyun where Oyun_Adi like'" +comboBoxOyunAd.SelectedItem+ "'";
            oyun.CombodanOyunAdArama(comboBoxOyunAd,textOyunID,textBarkod, textYapimci,textTur,textPlatform,textCikisTarih,textStok,pictureBox1,sorgu2);

        }

        private void hesaplabutton_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);
            int gunsayisi = gunfarki.Days;
            textgunsayisi.Text = gunsayisi.ToString();
            texttutar.Text = (gunsayisi * int.Parse(textgunlukucret.Text)).ToString();
            

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textucret_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kiralabuton_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into Kiralama(MusteriID,OyunID,KiraUcret,Cikis_Tarih,Donus_Tarih,Stok) values(@MusteriID,@OyunID,@KiraUcret,@Cikis_Tarih,@Donus_Tarih,@Stok)";
            SqlCommand komut = new SqlCommand(sorgu2);
            komut.Parameters.AddWithValue("@MusteriID",int.Parse(textMusteriID.Text));
            komut.Parameters.AddWithValue("@OyunID", int.Parse(textOyunID.Text));
            komut.Parameters.AddWithValue("@KiraUcret", int.Parse(texttutar.Text));
            komut.Parameters.AddWithValue("@Cikis_Tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Donus_Tarih", dateTimePicker2.Value);
            komut.Parameters.AddWithValue("@Stok", int.Parse(textAlinacakMiktar.Text));
            oyun.CRUD(komut, sorgu2);
            MessageBox.Show("Kiralandı.");
            string cumle = "select *from Kiralama";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun.listele(adtr2, cumle);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from Kiralama where KiralamaID='" + satir.Cells["KiralamaID"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            oyun.CRUD(komut2, cümle);
            string cumle = "select *from Kiralama";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun.listele(adtr2, cumle);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
