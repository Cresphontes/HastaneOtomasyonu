namespace HastaneOtomasyonu
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.cmsPersonel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbPersonelBrans = new System.Windows.Forms.ComboBox();
            this.lblPersonelMaas = new System.Windows.Forms.Label();
            this.lblPersonelBrans = new System.Windows.Forms.Label();
            this.txtPersonelMaas = new System.Windows.Forms.TextBox();
            this.lblPersonelTCKN = new System.Windows.Forms.Label();
            this.lblPersonelEmail = new System.Windows.Forms.Label();
            this.lblPersonelTelefon = new System.Windows.Forms.Label();
            this.lblPersonelSoyad = new System.Windows.Forms.Label();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.pbPersonel = new System.Windows.Forms.PictureBox();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.lstPersonelKisiler = new System.Windows.Forms.ListBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.txtPersonelTCKN = new System.Windows.Forms.TextBox();
            this.txtPersonelEmail = new System.Windows.Forms.TextBox();
            this.txtPersonelTelefon = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelAramaResim = new System.Windows.Forms.PictureBox();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.btnPersonelTemizle = new System.Windows.Forms.Button();
            this.cmsPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelAramaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsPersonel
            // 
            this.cmsPersonel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsPersonel.Name = "cmsListe";
            this.cmsPersonel.Size = new System.Drawing.Size(129, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // cmbPersonelBrans
            // 
            this.cmbPersonelBrans.FormattingEnabled = true;
            this.cmbPersonelBrans.Location = new System.Drawing.Point(62, 158);
            this.cmbPersonelBrans.Name = "cmbPersonelBrans";
            this.cmbPersonelBrans.Size = new System.Drawing.Size(135, 21);
            this.cmbPersonelBrans.TabIndex = 65;
            // 
            // lblPersonelMaas
            // 
            this.lblPersonelMaas.AutoSize = true;
            this.lblPersonelMaas.Location = new System.Drawing.Point(16, 187);
            this.lblPersonelMaas.Name = "lblPersonelMaas";
            this.lblPersonelMaas.Size = new System.Drawing.Size(33, 13);
            this.lblPersonelMaas.TabIndex = 63;
            this.lblPersonelMaas.Text = "Maaş";
            // 
            // lblPersonelBrans
            // 
            this.lblPersonelBrans.AutoSize = true;
            this.lblPersonelBrans.Location = new System.Drawing.Point(16, 161);
            this.lblPersonelBrans.Name = "lblPersonelBrans";
            this.lblPersonelBrans.Size = new System.Drawing.Size(34, 13);
            this.lblPersonelBrans.TabIndex = 64;
            this.lblPersonelBrans.Text = "Branş";
            // 
            // txtPersonelMaas
            // 
            this.txtPersonelMaas.Location = new System.Drawing.Point(62, 184);
            this.txtPersonelMaas.Name = "txtPersonelMaas";
            this.txtPersonelMaas.Size = new System.Drawing.Size(135, 20);
            this.txtPersonelMaas.TabIndex = 62;
            // 
            // lblPersonelTCKN
            // 
            this.lblPersonelTCKN.AutoSize = true;
            this.lblPersonelTCKN.Location = new System.Drawing.Point(16, 136);
            this.lblPersonelTCKN.Name = "lblPersonelTCKN";
            this.lblPersonelTCKN.Size = new System.Drawing.Size(36, 13);
            this.lblPersonelTCKN.TabIndex = 57;
            this.lblPersonelTCKN.Text = "TCKN";
            // 
            // lblPersonelEmail
            // 
            this.lblPersonelEmail.AutoSize = true;
            this.lblPersonelEmail.Location = new System.Drawing.Point(16, 111);
            this.lblPersonelEmail.Name = "lblPersonelEmail";
            this.lblPersonelEmail.Size = new System.Drawing.Size(32, 13);
            this.lblPersonelEmail.TabIndex = 58;
            this.lblPersonelEmail.Text = "Email";
            // 
            // lblPersonelTelefon
            // 
            this.lblPersonelTelefon.AutoSize = true;
            this.lblPersonelTelefon.Location = new System.Drawing.Point(16, 86);
            this.lblPersonelTelefon.Name = "lblPersonelTelefon";
            this.lblPersonelTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblPersonelTelefon.TabIndex = 59;
            this.lblPersonelTelefon.Text = "Telefon";
            // 
            // lblPersonelSoyad
            // 
            this.lblPersonelSoyad.AutoSize = true;
            this.lblPersonelSoyad.Location = new System.Drawing.Point(16, 61);
            this.lblPersonelSoyad.Name = "lblPersonelSoyad";
            this.lblPersonelSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblPersonelSoyad.TabIndex = 60;
            this.lblPersonelSoyad.Text = "Soyad";
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.Location = new System.Drawing.Point(16, 36);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(20, 13);
            this.lblPersonelAd.TabIndex = 61;
            this.lblPersonelAd.Text = "Ad";
            // 
            // pbPersonel
            // 
            this.pbPersonel.Location = new System.Drawing.Point(203, 33);
            this.pbPersonel.Name = "pbPersonel";
            this.pbPersonel.Size = new System.Drawing.Size(139, 124);
            this.pbPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonel.TabIndex = 55;
            this.pbPersonel.TabStop = false;
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(118, 210);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(79, 38);
            this.btnPersonelGuncelle.TabIndex = 54;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // txtPersonelAra
            // 
            this.txtPersonelAra.Location = new System.Drawing.Point(376, 33);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(168, 20);
            this.txtPersonelAra.TabIndex = 53;
            this.txtPersonelAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPersonelAra_KeyUp);
            // 
            // lstPersonelKisiler
            // 
            this.lstPersonelKisiler.ContextMenuStrip = this.cmsPersonel;
            this.lstPersonelKisiler.FormattingEnabled = true;
            this.lstPersonelKisiler.Location = new System.Drawing.Point(348, 57);
            this.lstPersonelKisiler.Name = "lstPersonelKisiler";
            this.lstPersonelKisiler.Size = new System.Drawing.Size(196, 147);
            this.lstPersonelKisiler.TabIndex = 52;
            this.lstPersonelKisiler.SelectedIndexChanged += new System.EventHandler(this.lstPersonelKisiler_SelectedIndexChanged);
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(16, 210);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(79, 38);
            this.btnPersonelKaydet.TabIndex = 51;
            this.btnPersonelKaydet.Text = "Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // txtPersonelTCKN
            // 
            this.txtPersonelTCKN.Location = new System.Drawing.Point(62, 133);
            this.txtPersonelTCKN.Name = "txtPersonelTCKN";
            this.txtPersonelTCKN.Size = new System.Drawing.Size(135, 20);
            this.txtPersonelTCKN.TabIndex = 50;
            // 
            // txtPersonelEmail
            // 
            this.txtPersonelEmail.Location = new System.Drawing.Point(62, 108);
            this.txtPersonelEmail.Name = "txtPersonelEmail";
            this.txtPersonelEmail.Size = new System.Drawing.Size(135, 20);
            this.txtPersonelEmail.TabIndex = 49;
            // 
            // txtPersonelTelefon
            // 
            this.txtPersonelTelefon.Location = new System.Drawing.Point(62, 83);
            this.txtPersonelTelefon.Name = "txtPersonelTelefon";
            this.txtPersonelTelefon.Size = new System.Drawing.Size(135, 20);
            this.txtPersonelTelefon.TabIndex = 48;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(62, 58);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(135, 20);
            this.txtPersonelSoyad.TabIndex = 47;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(62, 33);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(135, 20);
            this.txtPersonelAd.TabIndex = 46;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.dosyaToolStripMenuItem.Text = "&Kaydet";
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
            this.içeriAktarToolStripMenuItem1.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem1_Click);
            // 
            // dışarıAktarToolStripMenuItem1
            // 
            this.dışarıAktarToolStripMenuItem1.Name = "dışarıAktarToolStripMenuItem1";
            this.dışarıAktarToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.dışarıAktarToolStripMenuItem1.Text = "&Dışarı Aktar";
            this.dışarıAktarToolStripMenuItem1.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem1_Click);
            // 
            // PersonelAramaResim
            // 
            this.PersonelAramaResim.Image = ((System.Drawing.Image)(resources.GetObject("PersonelAramaResim.Image")));
            this.PersonelAramaResim.Location = new System.Drawing.Point(348, 33);
            this.PersonelAramaResim.Name = "PersonelAramaResim";
            this.PersonelAramaResim.Size = new System.Drawing.Size(22, 20);
            this.PersonelAramaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonelAramaResim.TabIndex = 66;
            this.PersonelAramaResim.TabStop = false;
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // btnPersonelTemizle
            // 
            this.btnPersonelTemizle.Location = new System.Drawing.Point(71, 254);
            this.btnPersonelTemizle.Name = "btnPersonelTemizle";
            this.btnPersonelTemizle.Size = new System.Drawing.Size(79, 38);
            this.btnPersonelTemizle.TabIndex = 67;
            this.btnPersonelTemizle.Text = "Temizle";
            this.btnPersonelTemizle.UseVisualStyleBackColor = true;
            this.btnPersonelTemizle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersonelTemizle);
            this.Controls.Add(this.PersonelAramaResim);
            this.Controls.Add(this.cmbPersonelBrans);
            this.Controls.Add(this.lblPersonelMaas);
            this.Controls.Add(this.lblPersonelBrans);
            this.Controls.Add(this.txtPersonelMaas);
            this.Controls.Add(this.lblPersonelTCKN);
            this.Controls.Add(this.lblPersonelEmail);
            this.Controls.Add(this.lblPersonelTelefon);
            this.Controls.Add(this.lblPersonelSoyad);
            this.Controls.Add(this.lblPersonelAd);
            this.Controls.Add(this.pbPersonel);
            this.Controls.Add(this.btnPersonelGuncelle);
            this.Controls.Add(this.txtPersonelAra);
            this.Controls.Add(this.lstPersonelKisiler);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.txtPersonelTCKN);
            this.Controls.Add(this.txtPersonelEmail);
            this.Controls.Add(this.txtPersonelTelefon);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            this.Click += new System.EventHandler(this.FormPersonel_Click);
            this.cmsPersonel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelAramaResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsPersonel;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbPersonelBrans;
        private System.Windows.Forms.Label lblPersonelMaas;
        private System.Windows.Forms.Label lblPersonelBrans;
        private System.Windows.Forms.TextBox txtPersonelMaas;
        private System.Windows.Forms.Label lblPersonelTCKN;
        private System.Windows.Forms.Label lblPersonelEmail;
        private System.Windows.Forms.Label lblPersonelTelefon;
        private System.Windows.Forms.Label lblPersonelSoyad;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.PictureBox pbPersonel;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.ListBox lstPersonelKisiler;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.TextBox txtPersonelTCKN;
        private System.Windows.Forms.TextBox txtPersonelEmail;
        private System.Windows.Forms.TextBox txtPersonelTelefon;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem1;
        private System.Windows.Forms.PictureBox PersonelAramaResim;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.Button btnPersonelTemizle;
    }
}