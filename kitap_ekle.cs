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
    public partial class kitapEkle : Form
    {
        public kitapEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kitap_ekle_Click(object sender, EventArgs e)
        {
            if (k_adi.Text == ""||k_acik.Text=="" || k_yazar.Text == "" || k_sayi.Text == "" || k_yayin.Text == "" || k_basim.Text == "" || k_sayfa.Text == "" || k_turu.Text == "")
            {
                MessageBox.Show("Lütfen bos alan bırakmayın");
            }
            else
            {


                string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Kitap(kitap_ad,kitap_yazar,kitap_yayinevi,kitap_basim,kitap_sayfa,kitap_turu,kitap_sayi,kitap_aciklama) values(@a,@b,@c,@d,@e,@f,@g,@h)", con);

                cmd.Parameters.AddWithValue("@a", k_adi.Text);
                cmd.Parameters.AddWithValue("@b", k_yazar.Text);
                cmd.Parameters.AddWithValue("@c", k_yayin.Text);
                cmd.Parameters.AddWithValue("@d", k_basim.Text);
                cmd.Parameters.AddWithValue("@e", k_sayfa.Text);
                cmd.Parameters.AddWithValue("@f", k_turu.Text);
                cmd.Parameters.AddWithValue("@g", k_sayi.Text);
                cmd.Parameters.AddWithValue("@h", k_acik.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Bilgiler Eklendi");
                k_adi.Text = "";
                k_yazar.Text = "";
                k_yayin.Text = "";
                k_basim.Text = "";
                k_sayfa.Text = "";
                k_turu.Text = "";
                k_sayi.Text = "";
                k_acik.Text = "";
                k_adi.Focus();


                con.Close();
            }
        }

        private void kitapEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
