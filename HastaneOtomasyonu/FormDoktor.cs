using HastaneOtomasyonu.ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }


      

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


            (this.MdiParent as FormGiris).doktorlar.Add(doktor);

            lstDoktorlar.Items.Clear();

            lstDoktorlar.Items.AddRange(((this.MdiParent as FormGiris).doktorlar).ToArray());


        }

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            lstDoktorlar.Items.AddRange((this.MdiParent as FormGiris).doktorlar.ToArray());
            cmbDoktorBrans.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            
            
        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            Doktor secilikisi = lstDoktorlar.SelectedItem as Doktor;

            txtDoktorAd.Text = secilikisi.Ad;
            txtDoktorSoyad.Text = secilikisi.Soyad;
            txtDoktorEmail.Text = secilikisi.Email;
            txtDoktorTelefon.Text = secilikisi.Telefon;
            txtDoktorTCKN.Text = secilikisi.TCKN;
            txtDoktorMaas.Text = secilikisi.Maas;
           

        }
    }
}
