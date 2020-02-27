using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunKiralama
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cikisbuton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void musteriekle_buton_Click(object sender, EventArgs e)
        {
            MusteriEkle ekle = new MusteriEkle();
            ekle.ShowDialog();
        }

        private void musterilistele_buton_Click(object sender, EventArgs e)
        {
            MusteriListele listele = new MusteriListele();
            listele.ShowDialog();

        }

        private void oyunekle_buton_Click(object sender, EventArgs e)
        {
            OyunEkle ekle = new OyunEkle();
            ekle.ShowDialog();
        }

        private void oyunlistele_buton_Click(object sender, EventArgs e)
        {
            OyunListeleme listele = new OyunListeleme();
            listele.ShowDialog();
        }

        private void kiralama_buton_Click(object sender, EventArgs e)
        {
            Sozlesme kira = new Sozlesme();
            kira.ShowDialog();
        }

        private void sirketekle_buton_Click(object sender, EventArgs e)
        {
            Sirketler sirket = new Sirketler();
            sirket.ShowDialog();
        }

        private void MusteriTarih_Click(object sender, EventArgs e)
        {
            MusteriTarih tarih = new MusteriTarih();
            tarih.ShowDialog();
        }

        private void oyuntarihbuton_Click(object sender, EventArgs e)
        {
            OyunTarih oyuntarih = new OyunTarih();
            oyuntarih.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KiralamaTarihcs kiralamatarih = new KiralamaTarihcs();
            kiralamatarih.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SirketTarih sirkettarih = new SirketTarih();
            sirkettarih.ShowDialog();
        }

        private void icecekbuton_Click(object sender, EventArgs e)
        {
            Icecek icecek = new Icecek();
            icecek.ShowDialog();
        }

        private void yiyecekbuton_Click(object sender, EventArgs e)
        {
            Gida gida = new Gida();
            gida.ShowDialog();
        }
    }
}
