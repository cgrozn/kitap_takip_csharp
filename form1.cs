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

namespace gorselodevim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_uye_ekle_Click(object sender, EventArgs e)
        {
            UyeEkleme uye_ekle = new UyeEkleme();
            uye_ekle.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeListeleme uyeliste = new UyeListeleme();
            uyeliste.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kitapEkle kitap = new kitapEkle();
            kitap.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kitapListele kitapliste = new kitapListele();
            kitapliste.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanetKitap emanet = new emanetKitap();
            emanet.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            emanetKitapListe liste = new emanetKitapListe();
            liste.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kitapEmanetIade iade = new kitapEmanetIade();
            iade.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UyeGiris giris = new UyeGiris();
           // giris.ShowDialog();
        }

      
    }
}
