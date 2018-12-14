using System;
using System.Drawing;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormRandevu : Form
    {
        
        public FormRandevu()
        {
            InitializeComponent();
            this.Load += FormRandevu_Load;

            btn.MouseClick += Btn_MouseClick;


        }
        Button btn = new Button();
        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            string tut = btn.Text;
            MessageBox.Show(tut);

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
                    int i = 0;
                    Button btn = new Button();
                    //Button btn = (Button)sender;
                    btn.BackColor = Color.Peru;
                    btn.Size = new Size(65, 60);
                    btn.Text = saat.ToString("00") + ":" + dakika.ToString("00");
                    btn.Name = i.ToString();
                    flwRandevu.Controls.Add(btn);

                }

            }



        }

        private void cmbHastaSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServisSec.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            lblServisSec.Visible = true;
            cmbServisSec.Visible = true;
        }

        private void cmbServisSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Kayıtlı doktorlar Alındı.
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

