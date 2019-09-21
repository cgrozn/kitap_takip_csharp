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
    public partial class emanetKitapListe : Form
    {
        public emanetKitapListe()
        {
            InitializeComponent();
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
        private void emanetKitapListe_Load(object sender, EventArgs e)
        {
            listeleme();

        }

        private void data1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = data1.CurrentRow;
            emanet_id.Text = satir.Cells[0].Value.ToString();
          
         

            dtA.Text = satir.Cells[3].Value.ToString();
            dtV.Text=satir.Cells[4].Value.ToString();

            e_uye_id.Text = satir.Cells[1].Value.ToString();
            e_k_ad.Text = satir.Cells[8].Value.ToString();
            e_k_yazar.Text = satir.Cells[9].Value.ToString();
            e_k_sayi.Text = satir.Cells[10].Value.ToString();

            e_k_id.Text = satir.Cells[2].Value.ToString();
            e_uye_ad.Text = satir.Cells[5].Value.ToString();
            e_uye_tel.Text = satir.Cells[7].Value.ToString();
            e_uye_adres.Text = satir.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void e_sil_Click_1(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            foreach (DataGridViewRow item in data1.SelectedRows)
            {
                int id = (int)item.Cells[0].Value;
                SqlCommand cmd = new SqlCommand("delete from Emanet where emanet_id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıtlar Silindi");


            }
            listeleme();
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

      

      
    }
}
