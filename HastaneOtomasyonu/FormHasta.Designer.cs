namespace HastaneOtomasyonu
{
    partial class FormHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHasta));
            this.pbHasta = new System.Windows.Forms.PictureBox();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.txtHastaAra = new System.Windows.Forms.TextBox();
            this.lstHastaList = new System.Windows.Forms.ListBox();
            this.cmsHastaListe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.txtHastaTCKN = new System.Windows.Forms.TextBox();
            this.txtHastaEmail = new System.Windows.Forms.TextBox();
            this.txtHastaTelefon = new System.Windows.Forms.TextBox();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HastaAramaResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHasta)).BeginInit();
            this.cmsHastaListe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaAramaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHasta
            // 
            this.pbHasta.Location = new System.Drawing.Point(208, 60);
            this.pbHasta.Name = "pbHasta";
            this.pbHasta.Size = new System.Drawing.Size(139, 124);
            this.pbHasta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHasta.TabIndex = 34;
            this.pbHasta.TabStop = false;
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.Location = new System.Drawing.Point(123, 195);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(79, 38);
            this.btnHastaGuncelle.TabIndex = 33;
            this.btnHastaGuncelle.Text = "Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = true;
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // txtHastaAra
            // 
            this.txtHastaAra.Location = new System.Drawing.Point(378, 60);
            this.txtHastaAra.Name = "txtHastaAra";
            this.txtHastaAra.Size = new System.Drawing.Size(175, 20);
            this.txtHastaAra.TabIndex = 32;
            this.txtHastaAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHastaAra_KeyUp);
            // 
            // lstHastaList
            // 
            this.lstHastaList.ContextMenuStrip = this.cmsHastaListe;
            this.lstHastaList.FormattingEnabled = true;
            this.lstHastaList.Location = new System.Drawing.Point(357, 81);
            this.lstHastaList.Name = "lstHastaList";
            this.lstHastaList.Size = new System.Drawing.Size(196, 147);
            this.lstHastaList.TabIndex = 31;
            this.lstHastaList.SelectedIndexChanged += new System.EventHandler(this.lstHastaList_SelectedIndexChanged);
            // 
            // cmsHastaListe
            // 
            this.cmsHastaListe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsHastaListe.Name = "cmsListe";
            this.cmsHastaListe.Size = new System.Drawing.Size(129, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.Location = new System.Drawing.Point(24, 195);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(79, 38);
            this.btnHastaKaydet.TabIndex = 30;
            this.btnHastaKaydet.Text = "Kaydet";
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // txtHastaTCKN
            // 
            this.txtHastaTCKN.Location = new System.Drawing.Point(67, 164);
            this.txtHastaTCKN.Name = "txtHastaTCKN";
            this.txtHastaTCKN.Size = new System.Drawing.Size(135, 20);
            this.txtHastaTCKN.TabIndex = 29;
            // 
            // txtHastaEmail
            // 
            this.txtHastaEmail.Location = new System.Drawing.Point(67, 138);
            this.txtHastaEmail.Name = "txtHastaEmail";
            this.txtHastaEmail.Size = new System.Drawing.Size(135, 20);
            this.txtHastaEmail.TabIndex = 28;
            // 
            // txtHastaTelefon
            // 
            this.txtHastaTelefon.Location = new System.Drawing.Point(67, 112);
            this.txtHastaTelefon.Name = "txtHastaTelefon";
            this.txtHastaTelefon.Size = new System.Drawing.Size(135, 20);
            this.txtHastaTelefon.TabIndex = 27;
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(67, 86);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(135, 20);
            this.txtHastaSoyad.TabIndex = 26;
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(67, 60);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(135, 20);
            this.txtHastaAd.TabIndex = 25;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "TCKN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ad";
            // 
            // HastaAramaResim
            // 
            this.HastaAramaResim.Image = ((System.Drawing.Image)(resources.GetObject("HastaAramaResim.Image")));
            this.HastaAramaResim.Location = new System.Drawing.Point(357, 60);
            this.HastaAramaResim.Name = "HastaAramaResim";
            this.HastaAramaResim.Size = new System.Drawing.Size(22, 20);
            this.HastaAramaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HastaAramaResim.TabIndex = 42;
            this.HastaAramaResim.TabStop = false;
            // 
            // FormHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HastaAramaResim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHasta);
            this.Controls.Add(this.btnHastaGuncelle);
            this.Controls.Add(this.txtHastaAra);
            this.Controls.Add(this.lstHastaList);
            this.Controls.Add(this.btnHastaKaydet);
            this.Controls.Add(this.txtHastaTCKN);
            this.Controls.Add(this.txtHastaEmail);
            this.Controls.Add(this.txtHastaTelefon);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.txtHastaAd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHasta";
            this.Text = "FormHasta";
            this.Load += new System.EventHandler(this.FormHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHasta)).EndInit();
            this.cmsHastaListe.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaAramaResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHasta;
        private System.Windows.Forms.Button btnHastaGuncelle;
        private System.Windows.Forms.TextBox txtHastaAra;
        private System.Windows.Forms.ListBox lstHastaList;
        private System.Windows.Forms.ContextMenuStrip cmsHastaListe;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.TextBox txtHastaTCKN;
        private System.Windows.Forms.TextBox txtHastaEmail;
        private System.Windows.Forms.TextBox txtHastaTelefon;
        private System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.TextBox txtHastaAd;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HastaAramaResim;
    }
}