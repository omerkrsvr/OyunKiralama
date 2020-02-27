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
    public partial class Sirketler : Form
    {
        SqlConnection con = new SqlConnection("Data Source=OMER-KIRSEVER\\OMERK;Initial Catalog=OyunKiralama;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommand komut;
        DataTable tablo = new DataTable();

        public Sirketler()
        {
            InitializeComponent();
        }
        void KayitGoster()
        {
            tablo.Clear();
            adtr = new SqlDataAdapter("Goster", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void Sirketler_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void textBarkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            komut = new SqlCommand("Ekle2",con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SirketID", textID.Text);
            komut.Parameters.AddWithValue("Sirket_Adi",textAd.Text);
            komut.Parameters.AddWithValue("Sirket_Adres", textAdres.Text);
            komut.Parameters.AddWithValue("Sirket_Telefon", textTel.Text);
            komut.Parameters.AddWithValue("Sirket_Mail", textMail.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ekleme işlemi başarılı.");
            KayitGoster();

        }

        private void guncellebuton_Click(object sender, EventArgs e)
        {
            con.Open();
            komut = new SqlCommand("guncelle", con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SirketID", textID.Text);
            komut.Parameters.AddWithValue("Sirket_Adi", textAd.Text);
            komut.Parameters.AddWithValue("Sirket_Adres", textAdres.Text);
            komut.Parameters.AddWithValue("Sirket_Telefon", textTel.Text);
            komut.Parameters.AddWithValue("Sirket_Mail", textMail.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncellendi.");
            KayitGoster();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textID.Text = satir.Cells["SirketID"].Value.ToString();
            textAd.Text = satir.Cells["Sirket_Adi"].Value.ToString();
            textAdres.Text = satir.Cells["Sirket_Adres"].Value.ToString();
            textTel.Text = satir.Cells["Sirket_Telefon"].Value.ToString();
            textMail.Text = satir.Cells["Sirket_Mail"].Value.ToString();

        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            con.Open();
            komut = new SqlCommand("Silme", con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SirketID", textID.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Silme işlemi başarılı.");
            KayitGoster();
        }
    }
}
