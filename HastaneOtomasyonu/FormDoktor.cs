using HastaneOtomasyonu.Class_Lib;
using HastaneOtomasyonu.ClassLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }
        

        public List<Doktor> doktorlar = new List<Doktor>();

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {

            Doktor doktor = new Doktor();

            try
            {
                doktor.Ad = txtDoktorAd.Text;
                doktor.Soyad = txtDoktorSoyad.Text;
                doktor.Email = txtDoktorEmail.Text;
                doktor.Telefon = txtDoktorTelefon.Text;
                doktor.TCKN = txtDoktorTCKN.Text;
                doktor.Maas = txtDoktorMaas.Text;

                switch (cmbDoktorBrans.SelectedItem)
                {

                    case DoktorBranslari.GenelCerrahi:
                        doktor.DoktorBrans = DoktorBranslari.GenelCerrahi;
                        break;
                    case DoktorBranslari.Ortopedi:
                        doktor.DoktorBrans = DoktorBranslari.Ortopedi;
                        break;
                    case DoktorBranslari.Uroloji:
                        doktor.DoktorBrans = DoktorBranslari.Uroloji;
                        break;
                    case DoktorBranslari.KBB:
                        doktor.DoktorBrans = DoktorBranslari.KBB;
                        break;
                    case DoktorBranslari.CocukSagligi:
                        doktor.DoktorBrans = DoktorBranslari.CocukSagligi;
                        break;
                    case DoktorBranslari.Kardiyoloji:
                        doktor.DoktorBrans = DoktorBranslari.Kardiyoloji;
                        break;
                    case DoktorBranslari.GozHastaliklari:
                        doktor.DoktorBrans = DoktorBranslari.GozHastaliklari;
                        break;
                    default:
                        break;
                }


                doktorlar.Add(doktor);

                FormuTemizle();

                foreach (var item in doktorlar)
                {

                    lstDoktorlar.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        public void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    //if (control.Name == "txtSearch")
                    //{
                    //    continue;
                    //}
                    control.Text = string.Empty;
                }
                else if (control is ListBox lst)
                {
                    lst.Items.Clear();
                }
                else if (control is PictureBox pbox)
                {
                    pbox.Image = null;
                }
                else if (control is ComboBox cb)
                {
                    cb.Text = string.Empty; ;
                }
            }
        }

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            cmbDoktorBrans.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            
            
        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            Personel secilikisi = lstDoktorlar.SelectedItem as Personel;
            txtDoktorAd.Text = secilikisi.Ad;
            txtDoktorSoyad.Text = secilikisi.Soyad;
            txtDoktorEmail.Text = secilikisi.Email;
            txtDoktorTelefon.Text = secilikisi.Telefon;
            txtDoktorTCKN.Text = secilikisi.TCKN;
            txtDoktorMaas.Text = secilikisi.Maas;
            btnDoktorKaydet.Enabled = false;
        }
    }
}
