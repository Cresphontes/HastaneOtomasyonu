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

        Hasta hasta = new Hasta();
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
            hasta.RandevuSaati = (sender as MyButton).Text;
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

