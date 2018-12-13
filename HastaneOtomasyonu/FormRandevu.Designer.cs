namespace HastaneOtomasyonu
{
    partial class FormRandevu
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
            this.flwRandevu = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.lblServisSec = new System.Windows.Forms.Label();
            this.lblDoktorSec = new System.Windows.Forms.Label();
            this.cmbServisSec = new System.Windows.Forms.ComboBox();
            this.cmbDoktorSec = new System.Windows.Forms.ComboBox();
            this.cmbHastaSec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flwRandevu
            // 
            this.flwRandevu.AutoScroll = true;
            this.flwRandevu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flwRandevu.Location = new System.Drawing.Point(347, 20);
            this.flwRandevu.Name = "flwRandevu";
            this.flwRandevu.Size = new System.Drawing.Size(347, 271);
            this.flwRandevu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Seçiniz :";
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRandevuKaydet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandevuKaydet.Location = new System.Drawing.Point(347, 333);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(347, 56);
            this.btnRandevuKaydet.TabIndex = 5;
            this.btnRandevuKaydet.Text = "Randevu Kaydet";
            this.btnRandevuKaydet.UseVisualStyleBackColor = false;
            // 
            // lblServisSec
            // 
            this.lblServisSec.AutoSize = true;
            this.lblServisSec.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblServisSec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServisSec.Location = new System.Drawing.Point(7, 57);
            this.lblServisSec.Name = "lblServisSec";
            this.lblServisSec.Size = new System.Drawing.Size(109, 16);
            this.lblServisSec.TabIndex = 6;
            this.lblServisSec.Text = "Servis Seciniz : ";
            // 
            // lblDoktorSec
            // 
            this.lblDoktorSec.AutoSize = true;
            this.lblDoktorSec.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblDoktorSec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoktorSec.Location = new System.Drawing.Point(7, 84);
            this.lblDoktorSec.Name = "lblDoktorSec";
            this.lblDoktorSec.Size = new System.Drawing.Size(109, 16);
            this.lblDoktorSec.TabIndex = 7;
            this.lblDoktorSec.Text = "Doktor Seçiniz :";
            // 
            // cmbServisSec
            // 
            this.cmbServisSec.FormattingEnabled = true;
            this.cmbServisSec.Location = new System.Drawing.Point(137, 52);
            this.cmbServisSec.Name = "cmbServisSec";
            this.cmbServisSec.Size = new System.Drawing.Size(191, 21);
            this.cmbServisSec.TabIndex = 8;
            this.cmbServisSec.SelectedIndexChanged += new System.EventHandler(this.cmbServisSec_SelectedIndexChanged);
            // 
            // cmbDoktorSec
            // 
            this.cmbDoktorSec.FormattingEnabled = true;
            this.cmbDoktorSec.Location = new System.Drawing.Point(137, 79);
            this.cmbDoktorSec.Name = "cmbDoktorSec";
            this.cmbDoktorSec.Size = new System.Drawing.Size(191, 21);
            this.cmbDoktorSec.TabIndex = 9;
            this.cmbDoktorSec.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorSec_SelectedIndexChanged);
            // 
            // cmbHastaSec
            // 
            this.cmbHastaSec.FormattingEnabled = true;
            this.cmbHastaSec.Location = new System.Drawing.Point(137, 25);
            this.cmbHastaSec.Name = "cmbHastaSec";
            this.cmbHastaSec.Size = new System.Drawing.Size(191, 21);
            this.cmbHastaSec.TabIndex = 10;
            this.cmbHastaSec.SelectedIndexChanged += new System.EventHandler(this.cmbHastaSec_SelectedIndexChanged);
            // 
            // FormRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.cmbHastaSec);
            this.Controls.Add(this.cmbDoktorSec);
            this.Controls.Add(this.cmbServisSec);
            this.Controls.Add(this.lblDoktorSec);
            this.Controls.Add(this.lblServisSec);
            this.Controls.Add(this.btnRandevuKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flwRandevu);
            this.Name = "FormRandevu";
            this.Text = "RANDEVU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwRandevu;
        private System.Windows.Forms.Label label1;
       
        private System.Windows.Forms.Button btnRandevuKaydet;
        private System.Windows.Forms.Label lblServisSec;
        private System.Windows.Forms.Label lblDoktorSec;
        private System.Windows.Forms.ComboBox cmbServisSec;
        private System.Windows.Forms.ComboBox cmbDoktorSec;
        private System.Windows.Forms.ComboBox cmbHastaSec;
    }
}