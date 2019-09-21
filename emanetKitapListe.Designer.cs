namespace gorselodevim
{
    partial class emanetKitapListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtV = new System.Windows.Forms.DateTimePicker();
            this.dtA = new System.Windows.Forms.DateTimePicker();
            this.e_k_sayi = new System.Windows.Forms.TextBox();
            this.grup_uye_bilgi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.e_uye_adres = new System.Windows.Forms.TextBox();
            this.e_uye_tel = new System.Windows.Forms.TextBox();
            this.e_uye_ad = new System.Windows.Forms.TextBox();
            this.e_uye_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_k_yazar = new System.Windows.Forms.TextBox();
            this.e_k_ad = new System.Windows.Forms.TextBox();
            this.e_k_id = new System.Windows.Forms.TextBox();
            this.grup_kitap_bilgi = new System.Windows.Forms.GroupBox();
            this.emanet_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.grup_uye_bilgi.SuspendLayout();
            this.grup_kitap_bilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(297, 80);
            this.data1.Name = "data1";
            this.data1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data1.Size = new System.Drawing.Size(988, 358);
            this.data1.TabIndex = 16;
            this.data1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "İade Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ödünç Tarihi";
            // 
            // dtV
            // 
            this.dtV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtV.Location = new System.Drawing.Point(116, 197);
            this.dtV.Name = "dtV";
            this.dtV.Size = new System.Drawing.Size(120, 26);
            this.dtV.TabIndex = 10;
            // 
            // dtA
            // 
            this.dtA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtA.Location = new System.Drawing.Point(114, 165);
            this.dtA.Name = "dtA";
            this.dtA.Size = new System.Drawing.Size(122, 26);
            this.dtA.TabIndex = 3;
            // 
            // e_k_sayi
            // 
            this.e_k_sayi.Location = new System.Drawing.Point(114, 133);
            this.e_k_sayi.Name = "e_k_sayi";
            this.e_k_sayi.Size = new System.Drawing.Size(122, 26);
            this.e_k_sayi.TabIndex = 9;
            this.e_k_sayi.Text = "1";
            // 
            // grup_uye_bilgi
            // 
            this.grup_uye_bilgi.Controls.Add(this.label4);
            this.grup_uye_bilgi.Controls.Add(this.label3);
            this.grup_uye_bilgi.Controls.Add(this.label2);
            this.grup_uye_bilgi.Controls.Add(this.label1);
            this.grup_uye_bilgi.Controls.Add(this.e_uye_adres);
            this.grup_uye_bilgi.Controls.Add(this.e_uye_tel);
            this.grup_uye_bilgi.Controls.Add(this.e_uye_ad);
            this.grup_uye_bilgi.Controls.Add(this.e_uye_id);
            this.grup_uye_bilgi.Location = new System.Drawing.Point(21, 58);
            this.grup_uye_bilgi.Name = "grup_uye_bilgi";
            this.grup_uye_bilgi.Size = new System.Drawing.Size(269, 207);
            this.grup_uye_bilgi.TabIndex = 12;
            this.grup_uye_bilgi.TabStop = false;
            this.grup_uye_bilgi.Text = "Üye bilgi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Üye Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Üye ID";
            // 
            // e_uye_adres
            // 
            this.e_uye_adres.Location = new System.Drawing.Point(109, 121);
            this.e_uye_adres.Name = "e_uye_adres";
            this.e_uye_adres.Size = new System.Drawing.Size(136, 26);
            this.e_uye_adres.TabIndex = 3;
            // 
            // e_uye_tel
            // 
            this.e_uye_tel.Location = new System.Drawing.Point(109, 89);
            this.e_uye_tel.Name = "e_uye_tel";
            this.e_uye_tel.Size = new System.Drawing.Size(136, 26);
            this.e_uye_tel.TabIndex = 2;
            // 
            // e_uye_ad
            // 
            this.e_uye_ad.Location = new System.Drawing.Point(109, 57);
            this.e_uye_ad.Name = "e_uye_ad";
            this.e_uye_ad.Size = new System.Drawing.Size(136, 26);
            this.e_uye_ad.TabIndex = 1;
            // 
            // e_uye_id
            // 
            this.e_uye_id.Location = new System.Drawing.Point(109, 25);
            this.e_uye_id.Name = "e_uye_id";
            this.e_uye_id.Size = new System.Drawing.Size(136, 26);
            this.e_uye_id.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kitap Sayisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yazar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kitap AD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kitap ID";
            // 
            // e_k_yazar
            // 
            this.e_k_yazar.Location = new System.Drawing.Point(114, 96);
            this.e_k_yazar.Name = "e_k_yazar";
            this.e_k_yazar.Size = new System.Drawing.Size(122, 26);
            this.e_k_yazar.TabIndex = 3;
            // 
            // e_k_ad
            // 
            this.e_k_ad.Location = new System.Drawing.Point(114, 57);
            this.e_k_ad.Name = "e_k_ad";
            this.e_k_ad.Size = new System.Drawing.Size(122, 26);
            this.e_k_ad.TabIndex = 2;
            // 
            // e_k_id
            // 
            this.e_k_id.Location = new System.Drawing.Point(114, 25);
            this.e_k_id.Name = "e_k_id";
            this.e_k_id.Size = new System.Drawing.Size(122, 26);
            this.e_k_id.TabIndex = 1;
            // 
            // grup_kitap_bilgi
            // 
            this.grup_kitap_bilgi.Controls.Add(this.label10);
            this.grup_kitap_bilgi.Controls.Add(this.label9);
            this.grup_kitap_bilgi.Controls.Add(this.dtV);
            this.grup_kitap_bilgi.Controls.Add(this.dtA);
            this.grup_kitap_bilgi.Controls.Add(this.e_k_sayi);
            this.grup_kitap_bilgi.Controls.Add(this.label8);
            this.grup_kitap_bilgi.Controls.Add(this.label7);
            this.grup_kitap_bilgi.Controls.Add(this.label6);
            this.grup_kitap_bilgi.Controls.Add(this.label5);
            this.grup_kitap_bilgi.Controls.Add(this.e_k_yazar);
            this.grup_kitap_bilgi.Controls.Add(this.e_k_ad);
            this.grup_kitap_bilgi.Controls.Add(this.e_k_id);
            this.grup_kitap_bilgi.Location = new System.Drawing.Point(21, 271);
            this.grup_kitap_bilgi.Name = "grup_kitap_bilgi";
            this.grup_kitap_bilgi.Size = new System.Drawing.Size(260, 260);
            this.grup_kitap_bilgi.TabIndex = 13;
            this.grup_kitap_bilgi.TabStop = false;
            this.grup_kitap_bilgi.Text = "Kitap bilgi";
            // 
            // emanet_id
            // 
            this.emanet_id.Location = new System.Drawing.Point(145, 26);
            this.emanet_id.Name = "emanet_id";
            this.emanet_id.Size = new System.Drawing.Size(136, 26);
            this.emanet_id.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Emanet ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ad Göre Arama";
            // 
            // emanetKitapListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1297, 750);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emanet_id);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grup_uye_bilgi);
            this.Controls.Add(this.grup_kitap_bilgi);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "emanetKitapListe";
            this.Text = "emanetKitapListe";
            this.Load += new System.EventHandler(this.emanetKitapListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.grup_uye_bilgi.ResumeLayout(false);
            this.grup_uye_bilgi.PerformLayout();
            this.grup_kitap_bilgi.ResumeLayout(false);
            this.grup_kitap_bilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtV;
        private System.Windows.Forms.DateTimePicker dtA;
        private System.Windows.Forms.TextBox e_k_sayi;
        private System.Windows.Forms.GroupBox grup_uye_bilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox e_uye_adres;
        private System.Windows.Forms.TextBox e_uye_tel;
        private System.Windows.Forms.TextBox e_uye_ad;
        private System.Windows.Forms.TextBox e_uye_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox e_k_yazar;
        private System.Windows.Forms.TextBox e_k_ad;
        private System.Windows.Forms.TextBox e_k_id;
        private System.Windows.Forms.GroupBox grup_kitap_bilgi;
        private System.Windows.Forms.TextBox emanet_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;

    }
}
