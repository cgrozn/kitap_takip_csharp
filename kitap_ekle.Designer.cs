namespace gorselodevim
{
    partial class kitapEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.k_adi = new System.Windows.Forms.TextBox();
            this.btn_kitap_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.k_yazar = new System.Windows.Forms.TextBox();
            this.k_basim = new System.Windows.Forms.TextBox();
            this.k_yayin = new System.Windows.Forms.TextBox();
            this.k_sayfa = new System.Windows.Forms.TextBox();
            this.k_turu = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.k_sayi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.k_acik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "K.Adı";
            // 
            // k_adi
            // 
            this.k_adi.Location = new System.Drawing.Point(218, 39);
            this.k_adi.Name = "k_adi";
            this.k_adi.Size = new System.Drawing.Size(170, 26);
            this.k_adi.TabIndex = 1;
            // 
            // btn_kitap_ekle
            // 
            this.btn_kitap_ekle.Location = new System.Drawing.Point(75, 423);
            this.btn_kitap_ekle.Name = "btn_kitap_ekle";
            this.btn_kitap_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_kitap_ekle.TabIndex = 2;
            this.btn_kitap_ekle.Text = "Ekle";
            this.btn_kitap_ekle.UseVisualStyleBackColor = true;
            this.btn_kitap_ekle.Click += new System.EventHandler(this.btn_kitap_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Basim Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yayınevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sayfa";
            // 
            // k_yazar
            // 
            this.k_yazar.Location = new System.Drawing.Point(218, 84);
            this.k_yazar.Name = "k_yazar";
            this.k_yazar.Size = new System.Drawing.Size(170, 26);
            this.k_yazar.TabIndex = 8;
            // 
            // k_basim
            // 
            this.k_basim.Location = new System.Drawing.Point(218, 246);
            this.k_basim.Name = "k_basim";
            this.k_basim.Size = new System.Drawing.Size(170, 26);
            this.k_basim.TabIndex = 10;
            // 
            // k_yayin
            // 
            this.k_yayin.Location = new System.Drawing.Point(218, 142);
            this.k_yayin.Name = "k_yayin";
            this.k_yayin.Size = new System.Drawing.Size(170, 26);
            this.k_yayin.TabIndex = 9;
            // 
            // k_sayfa
            // 
            this.k_sayfa.Location = new System.Drawing.Point(218, 294);
            this.k_sayfa.Name = "k_sayfa";
            this.k_sayfa.Size = new System.Drawing.Size(170, 26);
            this.k_sayfa.TabIndex = 11;
            // 
            // k_turu
            // 
            this.k_turu.FormattingEnabled = true;
            this.k_turu.Items.AddRange(new object[] {
            "Roman",
            "Şiir",
            "Makale",
            "Ders Kitabı"});
            this.k_turu.Location = new System.Drawing.Point(218, 376);
            this.k_turu.Name = "k_turu";
            this.k_turu.Size = new System.Drawing.Size(170, 27);
            this.k_turu.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // k_sayi
            // 
            this.k_sayi.Location = new System.Drawing.Point(218, 192);
            this.k_sayi.Name = "k_sayi";
            this.k_sayi.Size = new System.Drawing.Size(170, 26);
            this.k_sayi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kitap Sayisi";
            // 
            // k_acik
            // 
            this.k_acik.Location = new System.Drawing.Point(218, 335);
            this.k_acik.Name = "k_acik";
            this.k_acik.Size = new System.Drawing.Size(170, 26);
            this.k_acik.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Açıklama";
            // 
            // kitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(734, 640);
            this.Controls.Add(this.k_acik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.k_sayi);
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
            this.Controls.Add(this.btn_kitap_ekle);
            this.Controls.Add(this.k_adi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "kitapEkle";
            this.Text = "kitapEkle";
            this.Load += new System.EventHandler(this.kitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox k_adi;
        private System.Windows.Forms.Button btn_kitap_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox k_yazar;
        private System.Windows.Forms.TextBox k_basim;
        private System.Windows.Forms.TextBox k_yayin;
        private System.Windows.Forms.TextBox k_sayfa;
        private System.Windows.Forms.ComboBox k_turu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox k_sayi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox k_acik;
        private System.Windows.Forms.Label label8;
    }
}
