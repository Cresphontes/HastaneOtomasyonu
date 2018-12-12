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
            ((System.ComponentModel.ISupportInitialize)(this.pbDoktor)).BeginInit();
            this.cmsListe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDoktor
            // 
            this.pbDoktor.Location = new System.Drawing.Point(216, 52);
            this.pbDoktor.Name = "pbDoktor";
            this.pbDoktor.Size = new System.Drawing.Size(139, 124);
            this.pbDoktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoktor.TabIndex = 34;
            this.pbDoktor.TabStop = false;
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(177, 182);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(79, 38);
            this.btnDoktorGuncelle.TabIndex = 33;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtDoktorAra
            // 
            this.txtDoktorAra.Location = new System.Drawing.Point(361, 227);
            this.txtDoktorAra.Name = "txtDoktorAra";
            this.txtDoktorAra.Size = new System.Drawing.Size(196, 20);
            this.txtDoktorAra.TabIndex = 32;
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.ContextMenuStrip = this.cmsListe;
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(361, 52);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(196, 147);
            this.lstDoktorlar.TabIndex = 31;
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
            this.btnDoktorKaydet.Location = new System.Drawing.Point(75, 182);
            this.btnDoktorKaydet.Name = "btnDoktorKaydet";
            this.btnDoktorKaydet.Size = new System.Drawing.Size(79, 38);
            this.btnDoktorKaydet.TabIndex = 30;
            this.btnDoktorKaydet.Text = "Kaydet";
            this.btnDoktorKaydet.UseVisualStyleBackColor = true;
            // 
            // txtDoktorTCKN
            // 
            this.txtDoktorTCKN.Location = new System.Drawing.Point(75, 156);
            this.txtDoktorTCKN.Name = "txtDoktorTCKN";
            this.txtDoktorTCKN.Size = new System.Drawing.Size(135, 20);
            this.txtDoktorTCKN.TabIndex = 29;
            // 
            // txtDoktorEmail
            // 
            this.txtDoktorEmail.Location = new System.Drawing.Point(75, 130);
            this.txtDoktorEmail.Name = "txtDoktorEmail";
            this.txtDoktorEmail.Size = new System.Drawing.Size(135, 20);
            this.txtDoktorEmail.TabIndex = 28;
            // 
            // txtDoktorTelefon
            // 
            this.txtDoktorTelefon.Location = new System.Drawing.Point(75, 104);
            this.txtDoktorTelefon.Name = "txtDoktorTelefon";
            this.txtDoktorTelefon.Size = new System.Drawing.Size(135, 20);
            this.txtDoktorTelefon.TabIndex = 27;
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(75, 78);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(135, 20);
            this.txtDoktorSoyad.TabIndex = 26;
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(75, 52);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(135, 20);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
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
            // 
            // dışarıAktarToolStripMenuItem1
            // 
            this.dışarıAktarToolStripMenuItem1.Name = "dışarıAktarToolStripMenuItem1";
            this.dışarıAktarToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.dışarıAktarToolStripMenuItem1.Text = "&Dışarı Aktar";
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
            this.lblDoktorTCKN.Location = new System.Drawing.Point(19, 156);
            this.lblDoktorTCKN.Name = "lblDoktorTCKN";
            this.lblDoktorTCKN.Size = new System.Drawing.Size(36, 13);
            this.lblDoktorTCKN.TabIndex = 36;
            this.lblDoktorTCKN.Text = "TCKN";
            // 
            // lblDoktorEmail
            // 
            this.lblDoktorEmail.AutoSize = true;
            this.lblDoktorEmail.Location = new System.Drawing.Point(19, 130);
            this.lblDoktorEmail.Name = "lblDoktorEmail";
            this.lblDoktorEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDoktorEmail.TabIndex = 37;
            this.lblDoktorEmail.Text = "Email";
            // 
            // lblDoktorTelefon
            // 
            this.lblDoktorTelefon.AutoSize = true;
            this.lblDoktorTelefon.Location = new System.Drawing.Point(19, 104);
            this.lblDoktorTelefon.Name = "lblDoktorTelefon";
            this.lblDoktorTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblDoktorTelefon.TabIndex = 38;
            this.lblDoktorTelefon.Text = "Telefon";
            // 
            // lblDoktorSoyad
            // 
            this.lblDoktorSoyad.AutoSize = true;
            this.lblDoktorSoyad.Location = new System.Drawing.Point(19, 78);
            this.lblDoktorSoyad.Name = "lblDoktorSoyad";
            this.lblDoktorSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblDoktorSoyad.TabIndex = 39;
            this.lblDoktorSoyad.Text = "Soyad";
            // 
            // lblDoktorAd
            // 
            this.lblDoktorAd.AutoSize = true;
            this.lblDoktorAd.Location = new System.Drawing.Point(19, 52);
            this.lblDoktorAd.Name = "lblDoktorAd";
            this.lblDoktorAd.Size = new System.Drawing.Size(20, 13);
            this.lblDoktorAd.TabIndex = 40;
            this.lblDoktorAd.Text = "Ad";
            // 
            // FormDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormDoktor";
            this.Text = "FormDoktor";
            ((System.ComponentModel.ISupportInitialize)(this.pbDoktor)).EndInit();
            this.cmsListe.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}