namespace gorselodevim
{
    partial class UyeListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanici_mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ekle_guncel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kullanici_cins = new System.Windows.Forms.ComboBox();
            this.kullanici_adres = new System.Windows.Forms.TextBox();
            this.kullanici_tel = new System.Windows.Forms.TextBox();
            this.kullanici_pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uye_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uye_silme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kullanici_mail
            // 
            this.kullanici_mail.Location = new System.Drawing.Point(196, 232);
            this.kullanici_mail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kullanici_mail.Name = "kullanici_mail";
            this.kullanici_mail.Size = new System.Drawing.Size(162, 26);
            this.kullanici_mail.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mail";
            // 
            // btn_ekle_guncel
            // 
            this.btn_ekle_guncel.AccessibleDescription = "";
            this.btn_ekle_guncel.Location = new System.Drawing.Point(186, 354);
            this.btn_ekle_guncel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ekle_guncel.Name = "btn_ekle_guncel";
            this.btn_ekle_guncel.Size = new System.Drawing.Size(99, 33);
            this.btn_ekle_guncel.TabIndex = 26;
            this.btn_ekle_guncel.Text = "Güncelle";
            this.btn_ekle_guncel.UseVisualStyleBackColor = true;
            this.btn_ekle_guncel.Click += new System.EventHandler(this.btn_ekle_guncel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 354);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kullanici_cins
            // 
            this.kullanici_cins.FormattingEnabled = true;
            this.kullanici_cins.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.kullanici_cins.Location = new System.Drawing.Point(196, 285);
            this.kullanici_cins.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kullanici_cins.Name = "kullanici_cins";
            this.kullanici_cins.Size = new System.Drawing.Size(159, 27);
            this.kullanici_cins.TabIndex = 24;
            // 
            // kullanici_adres
            // 
            this.kullanici_adres.Location = new System.Drawing.Point(196, 190);
            this.kullanici_adres.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kullanici_adres.Name = "kullanici_adres";
            this.kullanici_adres.Size = new System.Drawing.Size(162, 26);
            this.kullanici_adres.TabIndex = 23;
            // 
            // kullanici_tel
            // 
            this.kullanici_tel.Location = new System.Drawing.Point(196, 129);
            this.kullanici_tel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kullanici_tel.Name = "kullanici_tel";
            this.kullanici_tel.Size = new System.Drawing.Size(162, 26);
            this.kullanici_tel.TabIndex = 22;
            // 
            // kullanici_pass
            // 
            this.kullanici_pass.Location = new System.Drawing.Point(196, 72);
            this.kullanici_pass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kullanici_pass.Name = "kullanici_pass";
            this.kullanici_pass.Size = new System.Drawing.Size(162, 26);
            this.kullanici_pass.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Parola";
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Location = new System.Drawing.Point(196, 19);
            this.kullanici_adi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(162, 26);
            this.kullanici_adi.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // uye_ara
            // 
            this.uye_ara.Location = new System.Drawing.Point(544, 9);
            this.uye_ara.Name = "uye_ara";
            this.uye_ara.Size = new System.Drawing.Size(100, 26);
            this.uye_ara.TabIndex = 29;
            this.uye_ara.TextChanged += new System.EventHandler(this.uye_ara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Arama";
            // 
            // uye_silme
            // 
            this.uye_silme.Location = new System.Drawing.Point(186, 397);
            this.uye_silme.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uye_silme.Name = "uye_silme";
            this.uye_silme.Size = new System.Drawing.Size(99, 33);
            this.uye_silme.TabIndex = 31;
            this.uye_silme.Text = "SİLME";
            this.uye_silme.UseVisualStyleBackColor = true;
            this.uye_silme.Click += new System.EventHandler(this.uye_silme_Click);
            // 
            // UyeListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1068, 603);
            this.Controls.Add(this.uye_silme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uye_ara);
            this.Controls.Add(this.kullanici_mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ekle_guncel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kullanici_cins);
            this.Controls.Add(this.kullanici_adres);
            this.Controls.Add(this.kullanici_tel);
            this.Controls.Add(this.kullanici_pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UyeListeleme";
            this.Text = "UyeListeleme";
            this.Load += new System.EventHandler(this.UyeListeleme_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UyeListeleme_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kullanici_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ekle_guncel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox kullanici_cins;
        private System.Windows.Forms.TextBox kullanici_adres;
        private System.Windows.Forms.TextBox kullanici_tel;
        private System.Windows.Forms.TextBox kullanici_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.Label label1;
       
       
        private System.Windows.Forms.TextBox uye_ara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button uye_silme;
    }
}
