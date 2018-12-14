using HastaneOtomasyonu.ClassLib;
using System;
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

       
        Randevular Randevu = new Randevular();
        MyButton button;
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
            lblServisSec.Visible = false;
            cmbServisSec.Visible = false;
            lblDoktorSec.Visible = false;
            cmbDoktorSec.Visible = false;
            flwRandevu.Visible = false;
            btnRandevuKaydet.Visible = false;

            //Butonların üstlerine saatleri yazıyoruz.

            for (int saat = 9; saat <= 16; saat++)
            {

                if (saat == 12)
                {
                    continue;
                }
                for (int dakika = 0; dakika <= 45; dakika += 15)
                {

                    button = new MyButton();
                    button.Text = saat.ToString("00") + ":" + dakika.ToString("00");
                    flwRandevu.Controls.Add(button);
                    button.Click += Button_Click;
                }

            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Randevu.RandevuSaat = (sender as MyButton).Text;
        }

        private void cmbHastaSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHastaSec.SelectedItem == null) return;
            cmbServisSec.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            Randevu.RandevuHasta = cmbHastaSec.SelectedItem as Hasta; 
            lblServisSec.Visible = true;
            cmbServisSec.Visible = true;
        }

        private void cmbServisSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServisSec.SelectedItem == null) return;
            //Kayıtlı doktorlar Alındı.
            cmbDoktorSec.Items.AddRange((this.MdiParent as FormGiris).doktorlar.ToArray());
            //enum doktor bransları eklendi
            DoktorBranslari doktorBrans = (DoktorBranslari)Enum.Parse(typeof(DoktorBranslari),cmbServisSec.SelectedItem.ToString());
            //secilen doktor bransını randevu hastaya kaydetti
            Randevu.RandevuBrans = doktorBrans;
         
            lblDoktorSec.Visible = true;
            cmbDoktorSec.Visible = true;
        }

        private void cmbDoktorSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktorSec.SelectedItem == null) return;
            //secilen doktoru randevulu doktor'a kaydetti.
            Randevu.RandevuDoktor = cmbDoktorSec.SelectedItem as Doktor;
            flwRandevu.Visible = true;
            btnRandevuKaydet.Visible = true;
        }
    }
}

