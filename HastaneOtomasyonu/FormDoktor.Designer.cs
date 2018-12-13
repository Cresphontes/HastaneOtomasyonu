namespace HastaneOtomasyonu
{
    partial class FormDoktor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktor));
            this.pbDoktor = new System.Windows.Forms.PictureBox();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.txtDoktorAra = new System.Windows.Forms.TextBox();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.cmsListe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDoktorKaydet = new System.Windows.Forms.Button();
            this.txtDoktorTCKN = new System.Windows.Forms.TextBox();
            this.txtDoktorEmail = new System.Windows.Forms.TextBox();
            this.txtDoktorTelefon = new System.Windows.Forms.TextBox();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.denetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.lblDoktorTCKN = new System.Windows.Forms.Label();
            this.lblDoktorEmail = new System.Windows.Forms.Label();
            this.lblDoktorTelefon = new System.Windows.Forms.Label();
            this.lblDoktorSoyad = new System.Windows.Forms.Label();
            this.lblDoktorAd = new System.Windows.Forms.Label();
            this.cmbDoktorBrans = new System.Windows.Forms.ComboBox();
            this.lblDoktorMaas = new System.Windows.Forms.Label();
            this.lblDoktorBrans = new System.Windows.Forms.Label();
            this.txtDoktorMaas = new System.Windows.Forms.TextBox();
            this.cmbDoktorHemsire = new System.Windows.Forms.ComboBox();
            this.lblDoktorHemsire = new System.Windows.Forms.Label();
            this.DoktorAramaResim = new System.Windows.Forms.PictureBox();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoktor)).BeginInit();
            this.cmsListe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorAramaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDoktor
            // 
            this.pbDoktor.Location = new System.Drawing.Point(283, 59);
            this.pbDoktor.Name = "pbDoktor";
            this.pbDoktor.Size = new System.Drawing.Size(139, 124);
            this.pbDoktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoktor.TabIndex = 34;
            this.pbDoktor.TabStop = false;
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(195, 283);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(79, 38);
            this.btnDoktorGuncelle.TabIndex = 33;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtDoktorAra
            // 
            this.txtDoktorAra.Location = new System.Drawing.Point(456, 59);
            this.txtDoktorAra.Name = "txtDoktorAra";
            this.txtDoktorAra.Size = new System.Drawing.Size(170, 20);
            this.txtDoktorAra.TabIndex = 32;
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.ContextMenuStrip = this.cmsListe;
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(430, 81);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(196, 186);
            this.lstDoktorlar.TabIndex = 31;
            this.lstDoktorlar.SelectedIndexChanged += new System.EventHandler(this.lstDoktorlar_SelectedIndexChanged);
            // 
            // cmsListe
            // 
            this.cmsListe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsListe.Name = "cmsListe";
            this.cmsListe.Size = new System.Drawing.Size(129, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // btnDoktorKaydet
            // 
            this.btnDoktorKaydet.Location = new System.Drawing.Point(75, 283);
            this.btnDoktorKaydet.Name = "btnDoktorKaydet";
            this.btnDoktorKaydet.Size = new System.Drawing.Size(79, 38);
            this.btnDoktorKaydet.TabIndex = 30;
            this.btnDoktorKaydet.Text = "Kaydet";
            this.btnDoktorKaydet.UseVisualStyleBackColor = true;
            this.btnDoktorKaydet.Click += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // txtDoktorTCKN
            // 
            this.txtDoktorTCKN.Location = new System.Drawing.Point(75, 156);
            this.txtDoktorTCKN.Name = "txtDoktorTCKN";
            this.txtDoktorTCKN.Size = new System.Drawing.Size(199, 20);
            this.txtDoktorTCKN.TabIndex = 29;
            // 
            // txtDoktorEmail
            // 
            this.txtDoktorEmail.Location = new System.Drawing.Point(75, 130);
            this.txtDoktorEmail.Name = "txtDoktorEmail";
            this.txtDoktorEmail.Size = new System.Drawing.Size(199, 20);
            this.txtDoktorEmail.TabIndex = 28;
            // 
            // txtDoktorTelefon
            // 
            this.txtDoktorTelefon.Location = new System.Drawing.Point(75, 104);
            this.txtDoktorTelefon.Name = "txtDoktorTelefon";
            this.txtDoktorTelefon.Size = new System.Drawing.Size(199, 20);
            this.txtDoktorTelefon.TabIndex = 27;
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(75, 78);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(199, 20);
            this.txtDoktorSoyad.TabIndex = 26;
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(75, 52);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(199, 20);
            this.txtDoktorAd.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.denetimToolStripMenuItem,
            this.toolStripTextBox1,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 27);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeriAktarToolStripMenuItem,
            this.dışarıAktarToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem.Text = "&XML";
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.içeriAktarToolStripMenuItem.Text = "&İçeri Aktar";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dışarıAktarToolStripMenuItem.Text = "&Dışarı Aktar";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeriAktarToolStripMenuItem1,
            this.dışarıAktarToolStripMenuItem1});
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "&JSON";
            // 
            // içeriAktarToolStripMenuItem1
            // 
            this.içeriAktarToolStripMenuItem1.Name = "içeriAktarToolStripMenuItem1";
            this.içeriAktarToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.içeriAktarToolStripMenuItem1.Text = "&İçeri Aktar";
            this.içeriAktarToolStripMenuItem1.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem1_Click_1);
            // 
            // dışarıAktarToolStripMenuItem1
            // 
            this.dışarıAktarToolStripMenuItem1.Name = "dışarıAktarToolStripMenuItem1";
            this.dışarıAktarToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.dışarıAktarToolStripMenuItem1.Text = "&Dışarı Aktar";
            this.dışarıAktarToolStripMenuItem1.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem1_Click_1);
            // 
            // denetimToolStripMenuItem
            // 
            this.denetimToolStripMenuItem.Name = "denetimToolStripMenuItem";
            this.denetimToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.denetimToolStripMenuItem.Text = "Dene&tim";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 23);
            this.toolStripTextBox1.ToolTipText = "Kisi Ara";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // lblDoktorTCKN
            // 
            this.lblDoktorTCKN.AutoSize = true;
            this.lblDoktorTCKN.Location = new System.Drawing.Point(19, 159);
            this.lblDoktorTCKN.Name = "lblDoktorTCKN";
            this.lblDoktorTCKN.Size = new System.Drawing.Size(36, 13);
            this.lblDoktorTCKN.TabIndex = 36;
            this.lblDoktorTCKN.Text = "TCKN";
            // 
            // lblDoktorEmail
            // 
            this.lblDoktorEmail.AutoSize = true;
            this.lblDoktorEmail.Location = new System.Drawing.Point(19, 133);
            this.lblDoktorEmail.Name = "lblDoktorEmail";
            this.lblDoktorEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDoktorEmail.TabIndex = 37;
            this.lblDoktorEmail.Text = "Email";
            // 
            // lblDoktorTelefon
            // 
            this.lblDoktorTelefon.AutoSize = true;
            this.lblDoktorTelefon.Location = new System.Drawing.Point(19, 107);
            this.lblDoktorTelefon.Name = "lblDoktorTelefon";
            this.lblDoktorTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblDoktorTelefon.TabIndex = 38;
            this.lblDoktorTelefon.Text = "Telefon";
            // 
            // lblDoktorSoyad
            // 
            this.lblDoktorSoyad.AutoSize = true;
            this.lblDoktorSoyad.Location = new System.Drawing.Point(19, 81);
            this.lblDoktorSoyad.Name = "lblDoktorSoyad";
            this.lblDoktorSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblDoktorSoyad.TabIndex = 39;
            this.lblDoktorSoyad.Text = "Soyad";
            // 
            // lblDoktorAd
            // 
            this.lblDoktorAd.AutoSize = true;
            this.lblDoktorAd.Location = new System.Drawing.Point(19, 55);
            this.lblDoktorAd.Name = "lblDoktorAd";
            this.lblDoktorAd.Size = new System.Drawing.Size(20, 13);
            this.lblDoktorAd.TabIndex = 40;
            this.lblDoktorAd.Text = "Ad";
            // 
            // cmbDoktorBrans
            // 
            this.cmbDoktorBrans.FormattingEnabled = true;
            this.cmbDoktorBrans.Location = new System.Drawing.Point(75, 186);
            this.cmbDoktorBrans.Name = "cmbDoktorBrans";
            this.cmbDoktorBrans.Size = new System.Drawing.Size(199, 21);
            this.cmbDoktorBrans.TabIndex = 49;
            this.cmbDoktorBrans.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorBrans_SelectedIndexChanged);
            // 
            // lblDoktorMaas
            // 
            this.lblDoktorMaas.AutoSize = true;
            this.lblDoktorMaas.Location = new System.Drawing.Point(19, 251);
            this.lblDoktorMaas.Name = "lblDoktorMaas";
            this.lblDoktorMaas.Size = new System.Drawing.Size(33, 13);
            this.lblDoktorMaas.TabIndex = 47;
            this.lblDoktorMaas.Text = "Maaş";
            // 
            // lblDoktorBrans
            // 
            this.lblDoktorBrans.AutoSize = true;
            this.lblDoktorBrans.Location = new System.Drawing.Point(19, 189);
            this.lblDoktorBrans.Name = "lblDoktorBrans";
            this.lblDoktorBrans.Size = new System.Drawing.Size(34, 13);
            this.lblDoktorBrans.TabIndex = 48;
            this.lblDoktorBrans.Text = "Branş";
            // 
            // txtDoktorMaas
            // 
            this.txtDoktorMaas.Location = new System.Drawing.Point(75, 248);
            this.txtDoktorMaas.Name = "txtDoktorMaas";
            this.txtDoktorMaas.Size = new System.Drawing.Size(199, 20);
            this.txtDoktorMaas.TabIndex = 46;
            // 
            // cmbDoktorHemsire
            // 
            this.cmbDoktorHemsire.FormattingEnabled = true;
            this.cmbDoktorHemsire.Location = new System.Drawing.Point(75, 218);
            this.cmbDoktorHemsire.Name = "cmbDoktorHemsire";
            this.cmbDoktorHemsire.Size = new System.Drawing.Size(199, 21);
            this.cmbDoktorHemsire.TabIndex = 50;
            // 
            // lblDoktorHemsire
            // 
            this.lblDoktorHemsire.AutoSize = true;
            this.lblDoktorHemsire.Location = new System.Drawing.Point(19, 221);
            this.lblDoktorHemsire.Name = "lblDoktorHemsire";
            this.lblDoktorHemsire.Size = new System.Drawing.Size(45, 13);
            this.lblDoktorHemsire.TabIndex = 51;
            this.lblDoktorHemsire.Text = "Hemşire";
            // 
            // DoktorAramaResim
            // 
            this.DoktorAramaResim.Image = ((System.Drawing.Image)(resources.GetObject("DoktorAramaResim.Image")));
            this.DoktorAramaResim.Location = new System.Drawing.Point(430, 59);
            this.DoktorAramaResim.Name = "DoktorAramaResim";
            this.DoktorAramaResim.Size = new System.Drawing.Size(22, 20);
            this.DoktorAramaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoktorAramaResim.TabIndex = 52;
            this.DoktorAramaResim.TabStop = false;
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // FormDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(785, 461);
            this.Controls.Add(this.DoktorAramaResim);
            this.Controls.Add(this.lblDoktorHemsire);
            this.Controls.Add(this.cmbDoktorHemsire);
            this.Controls.Add(this.cmbDoktorBrans);
            this.Controls.Add(this.lblDoktorMaas);
            this.Controls.Add(this.lblDoktorBrans);
            this.Controls.Add(this.txtDoktorMaas);
            this.Controls.Add(this.lblDoktorTCKN);
            this.Controls.Add(this.lblDoktorEmail);
            this.Controls.Add(this.lblDoktorTelefon);
            this.Controls.Add(this.lblDoktorSoyad);
            this.Controls.Add(this.lblDoktorAd);
            this.Controls.Add(this.pbDoktor);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.txtDoktorAra);
            this.Controls.Add(this.lstDoktorlar);
            this.Controls.Add(this.btnDoktorKaydet);
            this.Controls.Add(this.txtDoktorTCKN);
            this.Controls.Add(this.txtDoktorEmail);
            this.Controls.Add(this.txtDoktorTelefon);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoktor";
            this.Text = "FormDoktor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDoktor)).EndInit();
            this.cmsListe.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorAramaResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDoktor;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.TextBox txtDoktorAra;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.ContextMenuStrip cmsListe;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnDoktorKaydet;
        private System.Windows.Forms.TextBox txtDoktorTCKN;
        private System.Windows.Forms.TextBox txtDoktorEmail;
        private System.Windows.Forms.TextBox txtDoktorTelefon;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem denetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label lblDoktorTCKN;
        private System.Windows.Forms.Label lblDoktorEmail;
        private System.Windows.Forms.Label lblDoktorTelefon;
        private System.Windows.Forms.Label lblDoktorSoyad;
        private System.Windows.Forms.Label lblDoktorAd;
        private System.Windows.Forms.ComboBox cmbDoktorBrans;
        private System.Windows.Forms.Label lblDoktorMaas;
        private System.Windows.Forms.Label lblDoktorBrans;
        private System.Windows.Forms.TextBox txtDoktorMaas;
        private System.Windows.Forms.ComboBox cmbDoktorHemsire;
        private System.Windows.Forms.Label lblDoktorHemsire;
        private System.Windows.Forms.PictureBox DoktorAramaResim;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
    }
}