namespace dStok
{
    partial class Personel
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
            this.cbbYetkiler = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.mskPersonelTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.richPersonelAdres = new System.Windows.Forms.RichTextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.dgwPersoneller = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yetki:";
            // 
            // cbbYetkiler
            // 
            this.cbbYetkiler.FormattingEnabled = true;
            this.cbbYetkiler.Location = new System.Drawing.Point(786, 80);
            this.cbbYetkiler.Name = "cbbYetkiler";
            this.cbbYetkiler.Size = new System.Drawing.Size(226, 21);
            this.cbbYetkiler.TabIndex = 1;
            this.cbbYetkiler.SelectedIndexChanged += new System.EventHandler(this.cbbYetkiler_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwPersoneller);
            this.groupBox1.Controls.Add(this.btnPersonelGuncelle);
            this.groupBox1.Controls.Add(this.btnPersonelSil);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.richPersonelAdres);
            this.groupBox1.Controls.Add(this.mskPersonelTelefon);
            this.groupBox1.Controls.Add(this.txtPersonelKullaniciAd);
            this.groupBox1.Controls.Add(this.txtPersonelSifre);
            this.groupBox1.Controls.Add(this.txtPersonelMail);
            this.groupBox1.Controls.Add(this.txtPersonelSoyad);
            this.groupBox1.Controls.Add(this.txtPersonelAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbYetkiler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 543);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİ GİRİŞİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Adres:";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(113, 24);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelAd.TabIndex = 3;
            // 
            // mskPersonelTelefon
            // 
            this.mskPersonelTelefon.Location = new System.Drawing.Point(113, 55);
            this.mskPersonelTelefon.Mask = "(999) 000-0000";
            this.mskPersonelTelefon.Name = "mskPersonelTelefon";
            this.mskPersonelTelefon.Size = new System.Drawing.Size(145, 20);
            this.mskPersonelTelefon.TabIndex = 4;
            // 
            // txtPersonelKullaniciAd
            // 
            this.txtPersonelKullaniciAd.Location = new System.Drawing.Point(113, 85);
            this.txtPersonelKullaniciAd.Name = "txtPersonelKullaniciAd";
            this.txtPersonelKullaniciAd.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelKullaniciAd.TabIndex = 3;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(481, 24);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelSoyad.TabIndex = 3;
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.Location = new System.Drawing.Point(481, 55);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelMail.TabIndex = 3;
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(481, 81);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelSifre.TabIndex = 3;
            // 
            // richPersonelAdres
            // 
            this.richPersonelAdres.Location = new System.Drawing.Point(786, 24);
            this.richPersonelAdres.Name = "richPersonelAdres";
            this.richPersonelAdres.Size = new System.Drawing.Size(226, 51);
            this.richPersonelAdres.TabIndex = 5;
            this.richPersonelAdres.Text = "";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Image = global::dStok.Properties.Resources.plus;
            this.btnPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelEkle.Location = new System.Drawing.Point(603, 139);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(133, 37);
            this.btnPersonelEkle.TabIndex = 6;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Image = global::dStok.Properties.Resources.del;
            this.btnPersonelSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelSil.Location = new System.Drawing.Point(742, 139);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(133, 37);
            this.btnPersonelSil.TabIndex = 7;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Image = global::dStok.Properties.Resources.update;
            this.btnPersonelGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(876, 139);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(133, 37);
            this.btnPersonelGuncelle.TabIndex = 8;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // dgwPersoneller
            // 
            this.dgwPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersoneller.Location = new System.Drawing.Point(-54, 182);
            this.dgwPersoneller.Name = "dgwPersoneller";
            this.dgwPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPersoneller.Size = new System.Drawing.Size(1142, 343);
            this.dgwPersoneller.TabIndex = 9;
            this.dgwPersoneller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersoneller_CellClick);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 617);
            this.Controls.Add(this.groupBox1);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbYetkiler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richPersonelAdres;
        private System.Windows.Forms.MaskedTextBox mskPersonelTelefon;
        private System.Windows.Forms.TextBox txtPersonelKullaniciAd;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.DataGridView dgwPersoneller;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.Button btnPersonelSil;
    }
}