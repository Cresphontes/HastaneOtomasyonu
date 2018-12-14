using HastaneOtomasyonu.ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormRandevu : Form
    {
      

        public FormRandevu()
        {
            InitializeComponent();
            this.Load += FormRandevu_Load;

        }

        Hasta h = new Hasta();
        MyButton b;
        public class MyButton : Button
        {
            protected override Size DefaultSize => Size = new Size(65, 60);
            public override Color BackColor { get => Color.Peru; }

        }
        private void FormRandevu_Load(object sender, EventArgs e)
        {
            //Kayıtlı hastalar combobox'a eklendi.
            cmbHastaSec.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
            //checkedListBox1.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
            //lblServisSec.Visible = false;
            //cmbServisSec.Visible = false;
            //lblDoktorSec.Visible = false;
            //cmbDoktorSec.Visible = false;
            //flwRandevu.Visible = false;
            //btnRandevuKaydet.Visible = false;

            //Butonların üstlerine saatleri yazıyoruz.

            for (int saat = 9; saat <= 16; saat++)
            {

                if (saat == 12)
                {
                    continue;
                }
                for (int dakika = 0; dakika <= 45; dakika += 15)
                {

                    b = new MyButton();
                    b.Text = saat.ToString("00") + ":" + dakika.ToString("00");
                    flwRandevu.Controls.Add(b);
                    b.Click += B_Click;
             }

            }



        }

        private void B_Click(object sender, EventArgs e)
        {

            h.RandevuSaati = (sender as MyButton).Text;
           
            //Her Gorgune inanma-- MesutHocaya İnan :)
           // if ((sender as MyButton).Text == "09:00")
           //     h.RandevuSaati = "09:00";
           // else if ((sender as MyButton).Text == "09:15")
           //     h.RandevuSaati = "09:15";
           //else  if ((sender as MyButton).Text == "09:30")
           //     h.RandevuSaati = "09:30";
           // else if ((sender as MyButton).Text == "09:45")
           //     h.RandevuSaati = "09:45";
           // else if ((sender as MyButton).Text == "10:00")
           //     h.RandevuSaati = "10:00";
           // else if ((sender as MyButton).Text == "10:15")
           //     h.RandevuSaati = "10:15";
           // else if ((sender as MyButton).Text == "10:30")
           //     h.RandevuSaati = "10:30";
           // else if ((sender as MyButton).Text == "10:45")
           //     h.RandevuSaati = "10:45";
           // else if ((sender as MyButton).Text == "11:00")
           //     h.RandevuSaati = "11:00";
           // else if ((sender as MyButton).Text == "11:15")
           //     h.RandevuSaati = "11:15";
           // else if ((sender as MyButton).Text == "11:30")
           //     h.RandevuSaati = "11:30";
           // else if ((sender as MyButton).Text == "11:45")
           //     h.RandevuSaati = "11:45";
           // else if ((sender as MyButton).Text == "13:00")
           //     h.RandevuSaati = "13:00";
           // else if ((sender as MyButton).Text == "13:15")
           //     h.RandevuSaati = "13:15";
           // else if ((sender as MyButton).Text == "13:30")
           //     h.RandevuSaati = "13:30";
           // else if ((sender as MyButton).Text == "13:45")
           //     h.RandevuSaati = "13:45";
           // else if ((sender as MyButton).Text == "14:00")
           //     h.RandevuSaati = "14:00";
           // else if ((sender as MyButton).Text == "14:15")
           //     h.RandevuSaati = "14:15";
           // else if ((sender as MyButton).Text == "14:30")
           //     h.RandevuSaati = "14:30";
           // else if ((sender as MyButton).Text == "14:45")
           //     h.RandevuSaati = "14:45";
           // else if ((sender as MyButton).Text == "15:00")
           //     h.RandevuSaati = "15:00";
           // else if ((sender as MyButton).Text == "15:15")
           //     h.RandevuSaati = "15:15";
           // else if ((sender as MyButton).Text == "15:30")
           //     h.RandevuSaati = "15:30";
           // else if ((sender as MyButton).Text == "15:45")
           //     h.RandevuSaati = "15:45";
           // else if ((sender as MyButton).Text == "15:00")
           //     h.RandevuSaati = "16:00";
           // else if ((sender as MyButton).Text == "16:15")
           //     h.RandevuSaati = "16:15";
           // else if ((sender as MyButton).Text == "16:30")
           //     h.RandevuSaati = "16:30";
           // else if ((sender as MyButton).Text == "16:45")
           //     h.RandevuSaati = "16:45";





        }

        private void cmbHastaSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServisSec.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            lblServisSec.Visible = true;
            cmbServisSec.Visible = true;
        }

        private void cmbServisSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kayıtlı doktorlar Alındı.
            cmbDoktorSec.Items.AddRange((this.MdiParent as FormGiris).doktorlar.ToArray());
            lblDoktorSec.Visible = true;
            cmbDoktorSec.Visible = true;
        }

        private void cmbDoktorSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            flwRandevu.Visible = true;
            btnRandevuKaydet.Visible = true;
        }
    }
}

