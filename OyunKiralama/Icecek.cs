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
    public partial class Icecek : Form
    {
        Oyun_Kiralama oyun_kiralama = new Oyun_Kiralama();
        public Icecek()
        {
            InitializeComponent();
        }
        private void YenileListele()
        {
            string cümle = "select *from Icecek";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun_kiralama.listele(adtr2, cümle);
        }

        private void Icecek_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textAd.Text = satir.Cells[1].Value.ToString();
            textMiktar.Text = satir.Cells[2].Value.ToString();
            textTarih.Text = satir.Cells[3].Value.ToString();

        }

        private void Eklebuton_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Icecek(UrunAd,UrunMiktar,SatinAlmaTarih) values(@UrunAd,@UrunMiktar,@SatinAlmaTarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@UrunAd", textAd.Text);
            komut2.Parameters.AddWithValue("@UrunMiktar", textMiktar.Text);
            komut2.Parameters.AddWithValue("@SatinAlmaTarih", textTarih.Text);
            oyun_kiralama.CRUD(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("İçecek Kaydedildi.");
            YenileListele();
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from Icecek where IcecekID='" + satir.Cells["IcecekID"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            oyun_kiralama.CRUD(komut2, cümle);
            YenileListele();
        }

        private void guncellebuton_Click(object sender, EventArgs e)
        {
            string cümle = "update Icecek set UrunAd=@UrunAd,UrunMiktar=@UrunMiktar,SatinAlmaTarih=@SatinAlmaTarih where UrunAd=@UrunAd";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@UrunAd", textAd.Text);
            komut2.Parameters.AddWithValue("@UrunMiktar", textMiktar.Text);
            komut2.Parameters.AddWithValue("@SatinAlmaTarih", textTarih.Text);
            oyun_kiralama.CRUD(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }
    }
}
