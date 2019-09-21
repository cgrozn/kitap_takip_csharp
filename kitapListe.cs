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
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void listeleme()
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select *from Kitap", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            DataGridViewRow satir = dataGridView1.CurrentRow;
            k_adi.Text = satir.Cells[1].Value.ToString();
            k_yazar.Text = satir.Cells[2].Value.ToString();
            k_yayin.Text = satir.Cells[3].Value.ToString();
            k_basim.Text = satir.Cells[4].Value.ToString();
            k_sayfa.Text = satir.Cells[5].Value.ToString();
            k_turu.Text = satir.Cells[6].Value.ToString();
            k_sayi.Text = satir.Cells[7].Value.ToString();
            k_acik.Text = satir.Cells[8].Value.ToString();
        }

        private void kitapListele_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void btn_kitap_guncelle_Click(object sender, EventArgs e)
        {
            if (k_adi.Text == "" ||k_acik.Text==""|| k_sayi.Text == "" || k_yazar.Text == "" || k_yayin.Text == "" || k_basim.Text == "" || k_sayfa.Text == "" || k_turu.Text == "")
            {
                MessageBox.Show("Lütfen bos alan bırakmayın");
            }
            else
            {


                string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("update Kitap set kitap_ad=@a,kitap_yazar=@b,kitap_yayinevi=@c,kitap_basim=@d,kitap_sayfa=@e,kitap_turu=@f,kitap_sayi=@g ,kitap_aciklama=@h where kitap_id='" + id + "'", con);


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
                k_acik.Text = "";
                k_sayi.Text= "";
                k_adi.Focus();
              

                con.Close();
            }
            listeleme();
        }

        private void kitap_sil_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = (int)item.Cells[0].Value;
                SqlCommand cmd = new SqlCommand("delete from Kitap where kitap_id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıtlar Silindi");


            }
            listeleme();
        }

        private void kitap_ara_TextChanged(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Kitap where kitap_ad like '%" + kitap_ara.Text.ToString() + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
