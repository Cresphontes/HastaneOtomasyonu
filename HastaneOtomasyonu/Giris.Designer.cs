namespace HastaneOtomasyonu
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.menuGirisler = new System.Windows.Forms.MenuStrip();
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGirisler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGirisler
            // 
            this.menuGirisler.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuGirisler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.doktorKayıtToolStripMenuItem,
            this.personelKayıtToolStripMenuItem,
            this.hemşireKayıtToolStripMenuItem});
            this.menuGirisler.Location = new System.Drawing.Point(0, 0);
            this.menuGirisler.Name = "menuGirisler";
            this.menuGirisler.Size = new System.Drawing.Size(484, 24);
            this.menuGirisler.TabIndex = 6;
            this.menuGirisler.Text = "MenuKayıtlar";
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.hastaKayıtToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayıtToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtToolStripMenuItem_Click);
            // 
            // doktorKayıtToolStripMenuItem
            // 
            this.doktorKayıtToolStripMenuItem.Name = "doktorKayıtToolStripMenuItem";
            this.doktorKayıtToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.doktorKayıtToolStripMenuItem.Text = "Doktor Kayıt";
            this.doktorKayıtToolStripMenuItem.Click += new System.EventHandler(this.doktorKayıtToolStripMenuItem_Click);
            // 
            // personelKayıtToolStripMenuItem
            // 
            this.personelKayıtToolStripMenuItem.Name = "personelKayıtToolStripMenuItem";
            this.personelKayıtToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.personelKayıtToolStripMenuItem.Text = "Personel Kayıt";
            this.personelKayıtToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtToolStripMenuItem_Click);
            // 
            // hemşireKayıtToolStripMenuItem
            // 
            this.hemşireKayıtToolStripMenuItem.Name = "hemşireKayıtToolStripMenuItem";
            this.hemşireKayıtToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.hemşireKayıtToolStripMenuItem.Text = "Hemşire Kayıt";
            this.hemşireKayıtToolStripMenuItem.Click += new System.EventHandler(this.hemşireKayıtToolStripMenuItem_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.menuGirisler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGirisler;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGiris";
            this.Text = "Hastane Giris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.menuGirisler.ResumeLayout(false);
            this.menuGirisler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuGirisler;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireKayıtToolStripMenuItem;
    }
}

