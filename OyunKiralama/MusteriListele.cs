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
    public partial class MusteriListele : Form
    {
        Oyun_Kiralama oyun_kiralama = new Oyun_Kiralama();
        public MusteriListele()
        {
            InitializeComponent();
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
        private void YenileListele()
        {
            string cümle = "select *from Musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun_kiralama.listele(adtr2, cümle);
        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from Musteri where TC like '%"+textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun_kiralama.listele(adtr2, cümle);

        }

        private void iptalbuton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textTC.Text = satir.Cells[1].Value.ToString();
            textAD.Text = satir.Cells[2].Value.ToString();
            textSOYAD.Text = satir.Cells[3].Value.ToString();
            textMAIL.Text = satir.Cells[5].Value.ToString();
            textTEL.Text = satir.Cells[6].Value.ToString();
            textADRES.Text = satir.Cells[4].Value.ToString();
        }

        private void guncellebuton_Click(object sender, EventArgs e)
        {
            string cümle = "update Musteri set Ad=@Ad,Soyad=@Soyad,Email=@Email,Telefon=@Telefon,Adres=@Adres where TC=@TC";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@TC", textTC.Text);
            komut2.Parameters.AddWithValue("@Ad", textAD.Text);
            komut2.Parameters.AddWithValue("@Soyad", textSOYAD.Text);
            komut2.Parameters.AddWithValue("@Adres", textADRES.Text);
            komut2.Parameters.AddWithValue("@Email", textMAIL.Text);
            komut2.Parameters.AddWithValue("@Telefon", textTEL.Text);
            oyun_kiralama.CRUD(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from Musteri where MusteriID='"+satir.Cells["MusteriID"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();
            oyun_kiralama.CRUD(komut2, cümle);
            YenileListele();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
