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
    public partial class UyeListeleme : Form
    {
        public UyeListeleme()
        {
            InitializeComponent();
        }

        void listeleme()
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select *from Uye", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UyeListeleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapDBDataSet.Uye' table. You can move, or remove it, as needed.
         
            listeleme();
        }

        private void UyeListeleme_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
           //uye_idd.Text = satir.Cells[0].Value.ToString();
            kullanici_adi.Text = satir.Cells[1].Value.ToString();
            kullanici_adres.Text = satir.Cells[2].Value.ToString();
            kullanici_tel.Text = satir.Cells[3].Value.ToString();
            kullanici_mail.Text = satir.Cells[4].Value.ToString();
            kullanici_pass.Text = satir.Cells[5].Value.ToString();
            kullanici_cins.Text = satir.Cells[6].Value.ToString();
        }

        private void btn_ekle_guncel_Click(object sender, EventArgs e)
        {
            if (kullanici_adi.Text == "" || kullanici_adres.Text == "" || kullanici_mail.Text == "" || kullanici_tel.Text == "" || kullanici_pass.Text == "" || kullanici_cins.Text == "")
            {
                MessageBox.Show("Lütfen bos alan bırakmayın");
            }
            else
            {


                string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                //MessageBox.Show(id.ToString());
                SqlCommand cmd = new SqlCommand("update Uye set kullanici_ad=@a,kullanici_adres=@b,kullanici_tel=@c,kullanici_mail=@d,kullanici_pass=@e,kullanici_cinsiyet=@f  where uye_id='" + id + "'", con);

                cmd.Parameters.AddWithValue("@a", kullanici_adi.Text);
                cmd.Parameters.AddWithValue("@b", kullanici_adres.Text);
                cmd.Parameters.AddWithValue("@c", kullanici_tel.Text);
                cmd.Parameters.AddWithValue("@d", kullanici_mail.Text);
                cmd.Parameters.AddWithValue("@e", kullanici_pass.Text);
                cmd.Parameters.AddWithValue("@f", kullanici_cins.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Bilgiler güncellendi");
                kullanici_adi.Text = "";
                kullanici_adres.Text = "";
                kullanici_tel.Text = "";
                kullanici_mail.Text = "";
                kullanici_pass.Text = "";
                kullanici_cins.Text = "";
                kullanici_adi.Focus();


                con.Close();
            }
            listeleme();
        }

        private void uye_ara_TextChanged(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Uye where kullanici_ad like '%" + uye_ara.Text.ToString() + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void uye_silme_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = (int)item.Cells[0].Value;
                SqlCommand cmd = new SqlCommand("delete from Uye where uye_id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıtlar Silindi");


            }
           listeleme();
        }
    }
}
