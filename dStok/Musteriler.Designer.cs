namespace dStok
{
    partial class Musteriler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.rtxMusteriAdres = new System.Windows.Forms.RichTextBox();
            this.mskMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMusteriMail = new System.Windows.Forms.TextBox();
            this.txtMusteriFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwMusteriler);
            this.groupBox1.Controls.Add(this.btnMusteriGuncelle);
            this.groupBox1.Controls.Add(this.btnMusteriSil);
            this.groupBox1.Controls.Add(this.btnMusteriEkle);
            this.groupBox1.Controls.Add(this.btnYeniKayit);
            this.groupBox1.Controls.Add(this.rtxMusteriAdres);
            this.groupBox1.Controls.Add(this.mskMusteriTelefon);
            this.groupBox1.Controls.Add(this.txtMusteriMail);
            this.groupBox1.Controls.Add(this.txtMusteriFirmaAdi);
            this.groupBox1.Controls.Add(this.txtMusteriAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Girişi";
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.Location = new System.Drawing.Point(26, 180);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.Size = new System.Drawing.Size(751, 305);
            this.dgwMusteriler.TabIndex = 5;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(687, 141);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(90, 33);
            this.btnMusteriGuncelle.TabIndex = 4;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSil.Location = new System.Drawing.Point(585, 141);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(78, 33);
            this.btnMusteriSil.TabIndex = 4;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriEkle.Location = new System.Drawing.Point(472, 141);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(93, 33);
            this.btnMusteriEkle.TabIndex = 4;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(26, 127);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(78, 33);
            this.btnYeniKayit.TabIndex = 4;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            // 
            // rtxMusteriAdres
            // 
            this.rtxMusteriAdres.Location = new System.Drawing.Point(527, 25);
            this.rtxMusteriAdres.Name = "rtxMusteriAdres";
            this.rtxMusteriAdres.Size = new System.Drawing.Size(250, 63);
            this.rtxMusteriAdres.TabIndex = 3;
            this.rtxMusteriAdres.Text = "";
            // 
            // mskMusteriTelefon
            // 
            this.mskMusteriTelefon.Location = new System.Drawing.Point(89, 63);
            this.mskMusteriTelefon.Mask = "(999) 000-0000";
            this.mskMusteriTelefon.Name = "mskMusteriTelefon";
            this.mskMusteriTelefon.Size = new System.Drawing.Size(150, 20);
            this.mskMusteriTelefon.TabIndex = 2;
            // 
            // txtMusteriMail
            // 
            this.txtMusteriMail.Location = new System.Drawing.Point(304, 63);
            this.txtMusteriMail.Name = "txtMusteriMail";
            this.txtMusteriMail.Size = new System.Drawing.Size(150, 20);
            this.txtMusteriMail.TabIndex = 1;
            // 
            // txtMusteriFirmaAdi
            // 
            this.txtMusteriFirmaAdi.Location = new System.Drawing.Point(304, 25);
            this.txtMusteriFirmaAdi.Name = "txtMusteriFirmaAdi";
            this.txtMusteriFirmaAdi.Size = new System.Drawing.Size(150, 20);
            this.txtMusteriFirmaAdi.TabIndex = 1;
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(89, 25);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtMusteriAdSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Firma Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox mskMusteriTelefon;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.RichTextBox rtxMusteriAdres;
        private System.Windows.Forms.TextBox txtMusteriMail;
        private System.Windows.Forms.TextBox txtMusteriFirmaAdi;
        private System.Windows.Forms.DataGridView dgwMusteriler;
    }
}