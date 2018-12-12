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

        public List<Hemsire> hemsireler = new List<Hemsire>();

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
                case DoktorBranslari.GözHastaliklaari:
                    hemsire.HemsireBrans = DoktorBranslari.GözHastaliklaari;
                    break;
                default:
                    break;
            }

            hemsireler.Add(hemsire);
            lstHemsireKisiler.Items.Clear();

            foreach (var item in hemsireler)
            {
                lstHemsireKisiler.Items.Add(item);
            }

        }

        private void FormHemsire_Load(object sender, EventArgs e)
        {
            cmbHemsireBrans.Items.AddRange(Enum.GetNames((typeof(DoktorBranslari))));
        }
    }
}
