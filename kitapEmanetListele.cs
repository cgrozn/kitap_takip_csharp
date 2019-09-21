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

namespace gorselodevim
{
    public partial class kitapEmanetIade : Form
    {
        public kitapEmanetIade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Emanet where uye_ad like '%" + textBox1.Text.ToString() + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data1.DataSource = dt;
        }

        private void data1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = data1.CurrentRow;
            emanet_id.Text = satir.Cells[0].Value.ToString();



            dtA.Text = satir.Cells[3].Value.ToString();
            dtV.Text = satir.Cells[4].Value.ToString();

            e_uye_id.Text = satir.Cells[1].Value.ToString();
            e_k_ad.Text = satir.Cells[8].Value.ToString();
            e_k_yazar.Text = satir.Cells[9].Value.ToString();
            e_k_sayi.Text = satir.Cells[10].Value.ToString();

            e_k_id.Text = satir.Cells[2].Value.ToString();
            e_uye_ad.Text = satir.Cells[5].Value.ToString();
            e_uye_tel.Text = satir.Cells[7].Value.ToString();
            e_uye_adres.Text = satir.Cells[6].Value.ToString();
        }
        void listeleme()
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select  *from Emanet", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data1.DataSource = dt;
        }

        private void kitapEmanetIade_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void e_iade_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            foreach (DataGridViewRow item in data1.SelectedRows)
            {
                int id = (int)item.Cells[0].Value;
                SqlCommand cmd = new SqlCommand("delete from Emanet where emanet_id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Kitaplar Alındı");
                SqlCommand komut = new SqlCommand("update Kitap set kitap_sayi=kitap_sayi+1 where kitap_id='" + e_k_id.Text + "'", con);
                //  komut.Parameters.AddWithValue("@sayi", id);
                komut.ExecuteNonQuery();
                e_uye_id.Text = "";
                e_k_id.Text = "";
                dtA.Text = "";
                dtV.Text = "";
                e_uye_tel.Text = "";
                e_uye_ad.Text = "";
                e_k_yazar.Text = "";
                e_k_yazar.Text = "";
                e_k_sayi.Text = "";
                e_uye_adres.Text = "";
                e_k_ad.Text = "";

                e_uye_ad.Focus();

            }
            listeleme();
        }

        private void e_guncelleme_Click(object sender, EventArgs e)
        {
            if (e_uye_id.Text == "" || e_k_id.Text == "" || dtA.Text == "" || dtV.Text == "" || e_uye_ad.Text == "" || e_uye_adres.Text == "" || e_uye_tel.Text == "" || e_k_ad.Text == "" || e_k_yazar.Text == "" || e_k_sayi.Text == "")
            {
                MessageBox.Show("Lütfen bos alan bırakmayın");
            }
            else
            {


                string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                int id = (int)data1.SelectedRows[0].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("update Emanet set emanetVermeTarih=@a,emanetGeriAlmaTarih=@b,uye_ad=@c,uye_adres=@d,uye_tel=@e,kitap_ad=@f,kitap_yazar=@g where emanet_id='"+id+"'", con);

         
                cmd.Parameters.AddWithValue("@a", dtA.Text);
                cmd.Parameters.AddWithValue("@b", dtV.Text);
                cmd.Parameters.AddWithValue("@c", e_uye_ad.Text);
                cmd.Parameters.AddWithValue("@d", e_uye_adres.Text);
                cmd.Parameters.AddWithValue("@e", e_uye_tel.Text);
                cmd.Parameters.AddWithValue("@f", e_k_ad.Text);
                cmd.Parameters.AddWithValue("@g", e_k_yazar.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Bilgiler Güncellendi");

                con.Close();

            }
            listeleme();


        }
    }
}

