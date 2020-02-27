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
    public partial class OyunTarih : Form
    {
        Oyun_Kiralama oyun_kiralama = new Oyun_Kiralama();
        public OyunTarih()
        {
            InitializeComponent();
        }

        private void OyunTarih_Load(object sender, EventArgs e)
        {
            YenileOyunTarihListesi();
        }
        private void YenileOyunTarihListesi()
        {
            string cumle = "select *from OyunHistory";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun_kiralama.listele(adtr2, cumle);
        }
    }
}
