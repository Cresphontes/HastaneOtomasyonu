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
    public partial class FormHemsire : Form
    {
        public FormHemsire()
        {
            InitializeComponent();
        }

        

        private void btnHemsireKaydet_Click(object sender, EventArgs e)
        {
            Hemsire hemsire = new Hemsire();

            hemsire.Ad = txtHemsireAd.Text;
            hemsire.Soyad = txtHemsireSoyad.Text;
            hemsire.Email = txtHemsireEmail.Text;
            hemsire.Telefon = txtHemsireTelefon.Text;
            hemsire.TCKN = txtHemsireTCKN.Text;
            hemsire.Maas = txtHemsireMaas.Text;

           


            switch (cmbHemsireBrans.SelectedItem)
            {

                case DoktorBranslari.GenelCerrahi:
                    hemsire.HemsireBrans = DoktorBranslari.GenelCerrahi;
                    break;
                case DoktorBranslari.Ortopedi:
                    hemsire.HemsireBrans = DoktorBranslari.Ortopedi;
                    break;
                case DoktorBranslari.Uroloji:
                    hemsire.HemsireBrans = DoktorBranslari.Uroloji;
                    break;
                case DoktorBranslari.KBB:
                    hemsire.HemsireBrans = DoktorBranslari.KBB;
                    break;
                case DoktorBranslari.CocukSagligi:
                    hemsire.HemsireBrans = DoktorBranslari.CocukSagligi;
                    break;
                case DoktorBranslari.Kardiyoloji:
                    hemsire.HemsireBrans = DoktorBranslari.Kardiyoloji;
                    break;
                case DoktorBranslari.GozHastaliklari:
                    hemsire.HemsireBrans = DoktorBranslari.GozHastaliklari;
                    break;
                default:
                    break;
            }

            (this.MdiParent as FormGiris).hemsireler.Add(hemsire);

            lstHemsireKisiler.Items.Clear();

            lstHemsireKisiler.Items.AddRange((this.MdiParent as FormGiris).hemsireler.ToArray());



        }

        private void FormHemsire_Load(object sender, EventArgs e)
        {
            cmbHemsireBrans.Items.AddRange(Enum.GetNames((typeof(DoktorBranslari))));
            lstHemsireKisiler.Items.AddRange((this.MdiParent as FormGiris).hemsireler.ToArray());
        }

        private void lstHemsireKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHemsireKisiler.SelectedItem == null) return;

            Hemsire secilikisi = lstHemsireKisiler.SelectedItem as Hemsire;

            txtHemsireAd.Text = secilikisi.Ad;
            txtHemsireSoyad.Text = secilikisi.Soyad;
            txtHemsireEmail.Text = secilikisi.Email;
            txtHemsireTelefon.Text = secilikisi.Telefon;
            txtHemsireTCKN.Text = secilikisi.TCKN;
            txtHemsireMaas.Text = secilikisi.Maas;
        }
    }
}
