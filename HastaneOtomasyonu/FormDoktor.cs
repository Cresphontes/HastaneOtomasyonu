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

            lstDoktorlar.Items.Clear();
            
            foreach (var item in doktorlar)
            {
               
                lstDoktorlar.Items.Add(item);
            }
            

        }
        

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            cmbDoktorBrans.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            
            
        }
    }
}
