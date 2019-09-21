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
    public partial class UyeGiris : Form
    {
        public UyeGiris()
        {
            InitializeComponent();
        }

        private void UyeGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try { 
            //    string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
            //    SqlConnection con = new SqlConnection(str);
            //    con.Open();
            //    string sql = "select * from Uye where kullanici_ad=@ad and kullanici_pass=@pass";
            //    SqlParameter prm = new SqlParameter("ad", textBox1.Text.Trim());
            //    SqlParameter prm1 = new SqlParameter("pass", textBox2.Text.Trim());
            //    SqlCommand cmd = new SqlCommand(sql,con);
            //    cmd.Parameters.Add(prm);
            //    cmd.Parameters.Add(prm1);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    if(dt.Rows.Count>0)
            //    {
            //        Form1 fr = new Form1();
            //        fr.Show();
            //    }
            //    }
            //  catch(Exception)
            //{
            //    MessageBox.Show("hatali giriş");
            //}
         
            //}
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\cagri\documents\visual studio 2013\Projects\gorselodevim\gorselodevim\kitapDB.mdf';Integrated Security=True";
             SqlConnection con = new SqlConnection(str);
           con.Open();
           SqlCommand cmd = new SqlCommand("select *from Uye where kullanici_ad='"+textBox1.Text+"'and kullanici_pass='"+textBox2.Text+"'",con);
           SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Yanlıs Kullunici veya şifre");
            }
        }
        }
    }

