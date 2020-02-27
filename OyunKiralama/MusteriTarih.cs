﻿using System;
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
    public partial class MusteriTarih : Form
    {
        Oyun_Kiralama oyun_kiralama = new Oyun_Kiralama();
        public MusteriTarih()
        {
            InitializeComponent();
        }

        private void MusteriTarih_Load(object sender, EventArgs e)
        {
            YenileMusteriTarihListesi();
        }
        private void YenileMusteriTarihListesi()
        {
            string cumle = "select *from MusteriHistory";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oyun_kiralama.listele(adtr2, cumle);
        }
    }
}
