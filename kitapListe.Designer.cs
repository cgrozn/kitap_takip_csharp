namespace gorselodevim
{
    partial class kitapListele
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
            this.button2 = new System.Windows.Forms.Button();
            this.k_turu = new System.Windows.Forms.ComboBox();
            this.k_sayfa = new System.Windows.Forms.TextBox();
            this.k_basim = new System.Windows.Forms.TextBox();
            this.k_yayin = new System.Windows.Forms.TextBox();
            this.k_yazar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kitap_guncelle = new System.Windows.Forms.Button();
            this.k_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitap_sil = new System.Windows.Forms.Button();
            this.kitap_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.k_sayi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.k_acik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // k_turu
            // 
            this.k_turu.FormattingEnabled = true;
            this.k_turu.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.k_turu.Location = new System.Drawing.Point(161, 262);
            this.k_turu.Name = "k_turu";
            this.k_turu.Size = new System.Drawing.Size(170, 27);
            this.k_turu.TabIndex = 26;
            // 
            // k_sayfa
            // 
            this.k_sayfa.Location = new System.Drawing.Point(159, 212);
            this.k_sayfa.Name = "k_sayfa";
            this.k_sayfa.Size = new System.Drawing.Size(170, 26);
            this.k_sayfa.TabIndex = 25;
            // 
            // k_basim
            // 
            this.k_basim.Location = new System.Drawing.Point(159, 164);
            this.k_basim.Name = "k_basim";
            this.k_basim.Size = new System.Drawing.Size(170, 26);
            this.k_basim.TabIndex = 24;
            // 
            // k_yayin
            // 
            this.k_yayin.Location = new System.Drawing.Point(159, 115);
            this.k_yayin.Name = "k_yayin";
            this.k_yayin.Size = new System.Drawing.Size(170, 26);
            this.k_yayin.TabIndex = 23;
            // 
            // k_yazar
            // 
            this.k_yazar.Location = new System.Drawing.Point(159, 57);
            this.k_yazar.Name = "k_yazar";
            this.k_yazar.Size = new System.Drawing.Size(170, 26);
            this.k_yazar.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sayfa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Basim Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Yayınevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yazarı";
            // 
            // btn_kitap_guncelle
            // 
            this.btn_kitap_guncelle.Location = new System.Drawing.Point(380, 167);
            this.btn_kitap_guncelle.Name = "btn_kitap_guncelle";
            this.btn_kitap_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_kitap_guncelle.TabIndex = 16;
            this.btn_kitap_guncelle.Text = "Güncelle";
            this.btn_kitap_guncelle.UseVisualStyleBackColor = true;
            this.btn_kitap_guncelle.Click += new System.EventHandler(this.btn_kitap_guncelle_Click);
            // 
            // k_adi
            // 
            this.k_adi.Location = new System.Drawing.Point(159, 12);
            this.k_adi.Name = "k_adi";
            this.k_adi.Size = new System.Drawing.Size(170, 26);
            this.k_adi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "K.Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(897, 218);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kitap_sil
            // 
            this.kitap_sil.Location = new System.Drawing.Point(380, 63);
            this.kitap_sil.Name = "kitap_sil";
            this.kitap_sil.Size = new System.Drawing.Size(75, 23);
            this.kitap_sil.TabIndex = 29;
            this.kitap_sil.Text = "Sil";
            this.kitap_sil.UseVisualStyleBackColor = true;
            this.kitap_sil.Click += new System.EventHandler(this.kitap_sil_Click);
            // 
            // kitap_ara
            // 
            this.kitap_ara.Location = new System.Drawing.Point(672, 200);
            this.kitap_ara.Name = "kitap_ara";
            this.kitap_ara.Size = new System.Drawing.Size(170, 26);
            this.kitap_ara.TabIndex = 30;
            this.kitap_ara.TextChanged += new System.EventHandler(this.kitap_ara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Arama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Kitap Sayisi";
            // 
            // k_sayi
            // 
            this.k_sayi.Location = new System.Drawing.Point(159, 308);
            this.k_sayi.Name = "k_sayi";
            this.k_sayi.Size = new System.Drawing.Size(170, 26);
            this.k_sayi.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Açıklama";
            // 
            // k_acik
            // 
            this.k_acik.Location = new System.Drawing.Point(159, 350);
            this.k_acik.Name = "k_acik";
            this.k_acik.Size = new System.Drawing.Size(170, 26);
            this.k_acik.TabIndex = 34;
            // 
            // kitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(907, 750);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.k_acik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.k_sayi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kitap_ara);
            this.Controls.Add(this.kitap_sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.k_turu);
            this.Controls.Add(this.k_sayfa);
            this.Controls.Add(this.k_basim);
            this.Controls.Add(this.k_yayin);
            this.Controls.Add(this.k_yazar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_kitap_guncelle);
            this.Controls.Add(this.k_adi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kitapListele";
            this.Text = "kitapListele";
            this.Load += new System.EventHandler(this.kitapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox k_turu;
        private System.Windows.Forms.TextBox k_sayfa;
        private System.Windows.Forms.TextBox k_basim;
        private System.Windows.Forms.TextBox k_yayin;
        private System.Windows.Forms.TextBox k_yazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kitap_guncelle;
        private System.Windows.Forms.TextBox k_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kitap_sil;
        private System.Windows.Forms.TextBox kitap_ara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox k_sayi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox k_acik;
    }
}
