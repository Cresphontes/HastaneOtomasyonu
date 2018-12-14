namespace HastaneOtomasyonu
{
    partial class FormHemsire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHemsire));
            this.pbHemsire = new System.Windows.Forms.PictureBox();
            this.btnHemsireGuncelle = new System.Windows.Forms.Button();
            this.txtHemsirAra = new System.Windows.Forms.TextBox();
            this.lstHemsireKisiler = new System.Windows.Forms.ListBox();
            this.cmsHemsire = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHemsireKaydet = new System.Windows.Forms.Button();
            this.txtHemsireTCKN = new System.Windows.Forms.TextBox();
            this.txtHemsireEmail = new System.Windows.Forms.TextBox();
            this.txtHemsireTelefon = new System.Windows.Forms.TextBox();
            this.txtHemsireSoyad = new System.Windows.Forms.TextBox();
            this.txtHemsireAd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHemsireTCKN = new System.Windows.Forms.Label();
            this.lblHemsireEmail = new System.Windows.Forms.Label();
            this.lblHemsireTelefon = new System.Windows.Forms.Label();
            this.lblHemsireSoyad = new System.Windows.Forms.Label();
            this.lblHemsireAd = new System.Windows.Forms.Label();
            this.lblHemsireMaas = new System.Windows.Forms.Label();
            this.lblHemsireBrans = new System.Windows.Forms.Label();
            this.txtHemsireMaas = new System.Windows.Forms.TextBox();
            this.cmbHemsireBrans = new System.Windows.Forms.ComboBox();
            this.HastaAramaResim = new System.Windows.Forms.PictureBox();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.btnHemsireTemizle = new System.Windows.Forms.Button();
            this.btnFotografHemsire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHemsire)).BeginInit();
            this.cmsHemsire.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaAramaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHemsire
            // 
            this.pbHemsire.Location = new System.Drawing.Point(619, 43);
            this.pbHemsire.Name = "pbHemsire";
            this.pbHemsire.Size = new System.Drawing.Size(139, 124);
            this.pbHemsire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHemsire.TabIndex = 34;
            this.pbHemsire.TabStop = false;
            // 
            // btnHemsireGuncelle
            // 
            this.btnHemsireGuncelle.Location = new System.Drawing.Point(114, 217);
            this.btnHemsireGuncelle.Name = "btnHemsireGuncelle";
            this.btnHemsireGuncelle.Size = new System.Drawing.Size(79, 38);
            this.btnHemsireGuncelle.TabIndex = 33;
            this.btnHemsireGuncelle.Text = "Güncelle";
            this.btnHemsireGuncelle.UseVisualStyleBackColor = true;
            this.btnHemsireGuncelle.Click += new System.EventHandler(this.btnHemsireGuncelle_Click);
            // 
            // txtHemsirAra
            // 
            this.txtHemsirAra.Location = new System.Drawing.Point(372, 40);
            this.txtHemsirAra.Name = "txtHemsirAra";
            this.txtHemsirAra.Size = new System.Drawing.Size(171, 20);
            this.txtHemsirAra.TabIndex = 32;
            this.txtHemsirAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHemsirAra_KeyUp);
            // 
            // lstHemsireKisiler
            // 
            this.lstHemsireKisiler.ContextMenuStrip = this.cmsHemsire;
            this.lstHemsireKisiler.FormattingEnabled = true;
            this.lstHemsireKisiler.Location = new System.Drawing.Point(347, 65);
            this.lstHemsireKisiler.Name = "lstHemsireKisiler";
            this.lstHemsireKisiler.Size = new System.Drawing.Size(196, 160);
            this.lstHemsireKisiler.TabIndex = 31;
            this.lstHemsireKisiler.SelectedIndexChanged += new System.EventHandler(this.lstHemsireKisiler_SelectedIndexChanged);
            // 
            // cmsHemsire
            // 
            this.cmsHemsire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsHemsire.Name = "cmsListe";
            this.cmsHemsire.Size = new System.Drawing.Size(129, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnHemsireKaydet
            // 
            this.btnHemsireKaydet.Location = new System.Drawing.Point(12, 217);
            this.btnHemsireKaydet.Name = "btnHemsireKaydet";
            this.btnHemsireKaydet.Size = new System.Drawing.Size(79, 38);
            this.btnHemsireKaydet.TabIndex = 30;
            this.btnHemsireKaydet.Text = "Kaydet";
            this.btnHemsireKaydet.UseVisualStyleBackColor = true;
            this.btnHemsireKaydet.Click += new System.EventHandler(this.btnHemsireKaydet_Click);
            // 
            // txtHemsireTCKN
            // 
            this.txtHemsireTCKN.Location = new System.Drawing.Point(58, 140);
            this.txtHemsireTCKN.Name = "txtHemsireTCKN";
            this.txtHemsireTCKN.Size = new System.Drawing.Size(135, 20);
            this.txtHemsireTCKN.TabIndex = 29;
            // 
            // txtHemsireEmail
            // 
            this.txtHemsireEmail.Location = new System.Drawing.Point(58, 115);
            this.txtHemsireEmail.Name = "txtHemsireEmail";
            this.txtHemsireEmail.Size = new System.Drawing.Size(135, 20);
            this.txtHemsireEmail.TabIndex = 28;
            // 
            // txtHemsireTelefon
            // 
            this.txtHemsireTelefon.Location = new System.Drawing.Point(58, 90);
            this.txtHemsireTelefon.Name = "txtHemsireTelefon";
            this.txtHemsireTelefon.Size = new System.Drawing.Size(135, 20);
            this.txtHemsireTelefon.TabIndex = 27;
            // 
            // txtHemsireSoyad
            // 
            this.txtHemsireSoyad.Location = new System.Drawing.Point(58, 65);
            this.txtHemsireSoyad.Name = "txtHemsireSoyad";
            this.txtHemsireSoyad.Size = new System.Drawing.Size(135, 20);
            this.txtHemsireSoyad.TabIndex = 26;
            // 
            // txtHemsireAd
            // 
            this.txtHemsireAd.Location = new System.Drawing.Point(58, 40);
            this.txtHemsireAd.Name = "txtHemsireAd";
            this.txtHemsireAd.Size = new System.Drawing.Size(135, 20);
            this.txtHemsireAd.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 35;
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
            // lblHemsireTCKN
            // 
            this.lblHemsireTCKN.AutoSize = true;
            this.lblHemsireTCKN.Location = new System.Drawing.Point(12, 143);
            this.lblHemsireTCKN.Name = "lblHemsireTCKN";
            this.lblHemsireTCKN.Size = new System.Drawing.Size(36, 13);
            this.lblHemsireTCKN.TabIndex = 36;
            this.lblHemsireTCKN.Text = "TCKN";
            // 
            // lblHemsireEmail
            // 
            this.lblHemsireEmail.AutoSize = true;
            this.lblHemsireEmail.Location = new System.Drawing.Point(12, 118);
            this.lblHemsireEmail.Name = "lblHemsireEmail";
            this.lblHemsireEmail.Size = new System.Drawing.Size(32, 13);
            this.lblHemsireEmail.TabIndex = 37;
            this.lblHemsireEmail.Text = "Email";
            // 
            // lblHemsireTelefon
            // 
            this.lblHemsireTelefon.AutoSize = true;
            this.lblHemsireTelefon.Location = new System.Drawing.Point(12, 93);
            this.lblHemsireTelefon.Name = "lblHemsireTelefon";
            this.lblHemsireTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblHemsireTelefon.TabIndex = 38;
            this.lblHemsireTelefon.Text = "Telefon";
            // 
            // lblHemsireSoyad
            // 
            this.lblHemsireSoyad.AutoSize = true;
            this.lblHemsireSoyad.Location = new System.Drawing.Point(12, 68);
            this.lblHemsireSoyad.Name = "lblHemsireSoyad";
            this.lblHemsireSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblHemsireSoyad.TabIndex = 39;
            this.lblHemsireSoyad.Text = "Soyad";
            // 
            // lblHemsireAd
            // 
            this.lblHemsireAd.AutoSize = true;
            this.lblHemsireAd.Location = new System.Drawing.Point(12, 43);
            this.lblHemsireAd.Name = "lblHemsireAd";
            this.lblHemsireAd.Size = new System.Drawing.Size(20, 13);
            this.lblHemsireAd.TabIndex = 40;
            this.lblHemsireAd.Text = "Ad";
            // 
            // lblHemsireMaas
            // 
            this.lblHemsireMaas.AutoSize = true;
            this.lblHemsireMaas.Location = new System.Drawing.Point(12, 194);
            this.lblHemsireMaas.Name = "lblHemsireMaas";
            this.lblHemsireMaas.Size = new System.Drawing.Size(33, 13);
            this.lblHemsireMaas.TabIndex = 43;
            this.lblHemsireMaas.Text = "Maaş";
            // 
            // lblHemsireBrans
            // 
            this.lblHemsireBrans.AutoSize = true;
            this.lblHemsireBrans.Location = new System.Drawing.Point(12, 168);
            this.lblHemsireBrans.Name = "lblHemsireBrans";
            this.lblHemsireBrans.Size = new System.Drawing.Size(34, 13);
            this.lblHemsireBrans.TabIndex = 44;
            this.lblHemsireBrans.Text = "Branş";
            // 
            // txtHemsireMaas
            // 
            this.txtHemsireMaas.Location = new System.Drawing.Point(58, 191);
            this.txtHemsireMaas.Name = "txtHemsireMaas";
            this.txtHemsireMaas.Size = new System.Drawing.Size(135, 20);
            this.txtHemsireMaas.TabIndex = 42;
            // 
            // cmbHemsireBrans
            // 
            this.cmbHemsireBrans.FormattingEnabled = true;
            this.cmbHemsireBrans.Location = new System.Drawing.Point(58, 165);
            this.cmbHemsireBrans.Name = "cmbHemsireBrans";
            this.cmbHemsireBrans.Size = new System.Drawing.Size(135, 21);
            this.cmbHemsireBrans.TabIndex = 45;
            // 
            // HastaAramaResim
            // 
            this.HastaAramaResim.Image = ((System.Drawing.Image)(resources.GetObject("HastaAramaResim.Image")));
            this.HastaAramaResim.Location = new System.Drawing.Point(347, 41);
            this.HastaAramaResim.Name = "HastaAramaResim";
            this.HastaAramaResim.Size = new System.Drawing.Size(22, 20);
            this.HastaAramaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HastaAramaResim.TabIndex = 46;
            this.HastaAramaResim.TabStop = false;
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // btnHemsireTemizle
            // 
            this.btnHemsireTemizle.Location = new System.Drawing.Point(58, 261);
            this.btnHemsireTemizle.Name = "btnHemsireTemizle";
            this.btnHemsireTemizle.Size = new System.Drawing.Size(79, 38);
            this.btnHemsireTemizle.TabIndex = 68;
            this.btnHemsireTemizle.Text = "Temizle";
            this.btnHemsireTemizle.UseVisualStyleBackColor = true;
            this.btnHemsireTemizle.Click += new System.EventHandler(this.btnHemsireTemizle_Click);
            // 
            // btnFotografHemsire
            // 
            this.btnFotografHemsire.Location = new System.Drawing.Point(645, 191);
            this.btnFotografHemsire.Name = "btnFotografHemsire";
            this.btnFotografHemsire.Size = new System.Drawing.Size(79, 23);
            this.btnFotografHemsire.TabIndex = 69;
            this.btnFotografHemsire.Text = "Fotoğraf Ekle";
            this.btnFotografHemsire.UseVisualStyleBackColor = true;
            this.btnFotografHemsire.Click += new System.EventHandler(this.btnFotografHemsire_Click);
            // 
            // FormHemsire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(813, 461);
            this.Controls.Add(this.btnFotografHemsire);
            this.Controls.Add(this.btnHemsireTemizle);
            this.Controls.Add(this.HastaAramaResim);
            this.Controls.Add(this.cmbHemsireBrans);
            this.Controls.Add(this.lblHemsireMaas);
            this.Controls.Add(this.lblHemsireBrans);
            this.Controls.Add(this.txtHemsireMaas);
            this.Controls.Add(this.lblHemsireTCKN);
            this.Controls.Add(this.lblHemsireEmail);
            this.Controls.Add(this.lblHemsireTelefon);
            this.Controls.Add(this.lblHemsireSoyad);
            this.Controls.Add(this.lblHemsireAd);
            this.Controls.Add(this.pbHemsire);
            this.Controls.Add(this.btnHemsireGuncelle);
            this.Controls.Add(this.txtHemsirAra);
            this.Controls.Add(this.lstHemsireKisiler);
            this.Controls.Add(this.btnHemsireKaydet);
            this.Controls.Add(this.txtHemsireTCKN);
            this.Controls.Add(this.txtHemsireEmail);
            this.Controls.Add(this.txtHemsireTelefon);
            this.Controls.Add(this.txtHemsireSoyad);
            this.Controls.Add(this.txtHemsireAd);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormHemsire";
            this.Text = "FormHemsire";
            this.Load += new System.EventHandler(this.FormHemsire_Load);
            this.Click += new System.EventHandler(this.FormHemsire_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbHemsire)).EndInit();
            this.cmsHemsire.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaAramaResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHemsire;
        private System.Windows.Forms.Button btnHemsireGuncelle;
        private System.Windows.Forms.TextBox txtHemsirAra;
        private System.Windows.Forms.ListBox lstHemsireKisiler;
        private System.Windows.Forms.ContextMenuStrip cmsHemsire;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnHemsireKaydet;
        private System.Windows.Forms.TextBox txtHemsireTCKN;
        private System.Windows.Forms.TextBox txtHemsireEmail;
        private System.Windows.Forms.TextBox txtHemsireTelefon;
        private System.Windows.Forms.TextBox txtHemsireSoyad;
        private System.Windows.Forms.TextBox txtHemsireAd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem1;
        private System.Windows.Forms.Label lblHemsireTCKN;
        private System.Windows.Forms.Label lblHemsireEmail;
        private System.Windows.Forms.Label lblHemsireTelefon;
        private System.Windows.Forms.Label lblHemsireSoyad;
        private System.Windows.Forms.Label lblHemsireAd;
        private System.Windows.Forms.Label lblHemsireMaas;
        private System.Windows.Forms.Label lblHemsireBrans;
        private System.Windows.Forms.TextBox txtHemsireMaas;
        private System.Windows.Forms.ComboBox cmbHemsireBrans;
        private System.Windows.Forms.PictureBox HastaAramaResim;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.Button btnHemsireTemizle;
        private System.Windows.Forms.Button btnFotografHemsire;
    }
}