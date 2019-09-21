using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselodevim
{
    public partial class emanetKitap : Form
    {
        public emanetKitap()
        {
            InitializeComponent();
        }
        void listeleme_Uye()
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select  uye_id,kullanici_ad,kullanici_tel,kullanici_adres from Uye ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data1.DataSource = dt;
        }
        void listeleme_Kitap()

        {
            string strt = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection conn = new SqlConnection(strt);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select kitap_sayi from Kitap", conn);
            SqlDataReader dr = cmd.ExecuteReader();
 //int sayi=0;
           while (dr.Read())
            {
              //  e_k_sayi22.Text = dr["kitap_sayi"].ToString();
               
              //  sayi = int.Parse(e_k_sayi22.Text);
          
               string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
               SqlConnection con = new SqlConnection(str);
               con.Open();
               int i = 0;
               SqlDataAdapter sda = new SqlDataAdapter("select kitap_id,kitap_ad,kitap_yazar,kitap_sayi from Kitap where kitap_sayi>'"+i+"' ", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               data2.DataSource = dt; 
           

            }
          //  MessageBox.Show(sayi.ToString());
        
       
           
           
         }
           
        

        private void emanetKitap_Load(object sender, EventArgs e)
        {
            listeleme_Uye();
            listeleme_Kitap();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (e_uye_id.Text == "" || e_k_id.Text == "" || dtA.Text == "" || dtV.Text == "" || e_uye_ad.Text == "" || e_uye_adres.Text == "" || e_uye_tel.Text == "" || e_k_ad.Text == "" || e_k_yazar.Text == "" || e_k_sayi22.Text == "")
            {
                MessageBox.Show("Lütfen bos alan bırakmayın");
            }
            else
            { 


            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Emanet(uye_id,kitap_id,emanetVermeTarih,emanetGeriAlmaTarih,uye_ad,uye_adres,uye_tel,kitap_ad,kitap_yazar,kitap_sayi) values(@a,@b,@c,@d,@e,@f,@g,@h,@aa,@ab)", con);

            cmd.Parameters.AddWithValue("@a", e_uye_id.Text);
            cmd.Parameters.AddWithValue("@b", e_k_id.Text);
            cmd.Parameters.AddWithValue("@c", dtA.Text);
            cmd.Parameters.AddWithValue("@d", dtV.Text);
            cmd.Parameters.AddWithValue("@e", e_uye_ad.Text);
            cmd.Parameters.AddWithValue("@f", e_uye_adres.Text);
            cmd.Parameters.AddWithValue("@g", e_uye_tel.Text);
            cmd.Parameters.AddWithValue("@h", e_k_ad.Text);
            cmd.Parameters.AddWithValue("@aa", e_k_yazar.Text);
           cmd.Parameters.AddWithValue("@ab", e_k_sayi22.Text);
         cmd.ExecuteNonQuery(); 
               
            MessageBox.Show(" Bilgiler Eklendi");
            //e_uye_id.Text = "";
            //e_k_id.Text = "";
            //    dtA.Text="";
            //        dtV.Text="";
            //            e_uye_tel.Text="";
            //            e_uye_ad.Text="";
            //                e_k_yazar.Text="";
            //                e_k_yazar.Text="";
            //                    e_k_sayi.Text="";
            //                e_uye_adres.Text="";
            //                e_k_ad.Text = "";

            //                e_uye_ad.Focus();
            //qlCommand cmd = new SqlCommand("update Kitap set kitd,kitap_sayfa=@e,_sciklama=@h where kitap_id='" + id + "'", con);
            //int id = 5;

            SqlCommand komut = new SqlCommand("update Kitap set kitap_sayi=kitap_sayi-1 where kitap_id='" + e_k_id.Text+ "'",con);
              //  komut.Parameters.AddWithValue("@sayi", id);
                   komut.ExecuteNonQuery(); 
          con.Close();
          listeleme_Uye();
          listeleme_Kitap();

                }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

      

        private void data2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = data2.CurrentRow;

            e_k_id.Text = satir.Cells[0].Value.ToString();
            e_k_ad.Text = satir.Cells[1].Value.ToString();
            e_k_yazar.Text = satir.Cells[2].Value.ToString();
        //  e_k_sayi22.Text = satir.Cells[3].Value.ToString();

        }

        private void data1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = data1.CurrentRow;

            e_uye_id.Text = satir.Cells[0].Value.ToString();
            e_uye_ad.Text = satir.Cells[1].Value.ToString();
            e_uye_tel.Text = satir.Cells[2].Value.ToString();
            e_uye_adres.Text = satir.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select uye_id,kullanici_ad,kullanici_tel,kullanici_adres from Uye where kullanici_ad like '%" + textBox1.Text.ToString() + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select kitap_id,kitap_ad,kitap_yazar,kitap_sayi from Kitap where kitap_ad like '%" + textBox2.Text.ToString() + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data2.DataSource = dt;
        }

       

      
        
        
    }
}
