using HastaneOtomasyonu.Class_Lib;
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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        
       
        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            
            Personel personel = new Personel();
            try
            {
                personel.Ad = txtPersonelAd.Text;
                personel.Soyad = txtPersonelSoyad.Text;
                personel.Email = txtPersonelEmail.Text;
                personel.Telefon = txtPersonelTelefon.Text;
                personel.TCKN = txtPersonelTCKN.Text;
                personel.Maas = txtPersonelMaas.Text;

                switch (cmbPersonelBrans.SelectedItem)
                {

                    case PersonelBranslari.HastaBakici:
                        personel.PersonelBrans = PersonelBranslari.HastaBakici;
                        break;
                    case PersonelBranslari.HastaKayitci:
                        personel.PersonelBrans = PersonelBranslari.HastaKayitci;
                        break;
                    case PersonelBranslari.Kantin:
                        personel.PersonelBrans = PersonelBranslari.Kantin;
                        break;
                    case PersonelBranslari.Muhasebe:
                        personel.PersonelBrans = PersonelBranslari.Muhasebe;
                        break;
                    case PersonelBranslari.Rontgenci:
                        personel.PersonelBrans = PersonelBranslari.Rontgenci;
                        break;
                    case PersonelBranslari.Sofor:
                        personel.PersonelBrans = PersonelBranslari.Sofor;
                        break;
                    case PersonelBranslari.Temizlik:
                        personel.PersonelBrans = PersonelBranslari.Temizlik;
                        break;
                    default:
                        break;
                }

                (this.MdiParent as FormGiris).personeller.Add(personel);

                lstPersonelKisiler.Items.Clear();

                lstPersonelKisiler.Items.AddRange(((this.MdiParent as FormGiris).personeller).ToArray());

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void FormPersonel_Load(object sender, EventArgs e)
        {
         
            lstPersonelKisiler.Items.AddRange(((this.MdiParent as FormGiris).personeller).ToArray());
            cmbPersonelBrans.Items.AddRange(Enum.GetNames(typeof(PersonelBranslari)));          
        }

        private void lstPersonelKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonelKisiler.SelectedItem ==null) return;

            Personel secilikisi = lstPersonelKisiler.SelectedItem as Personel;

            txtPersonelAd.Text = secilikisi.Ad;
            txtPersonelSoyad.Text = secilikisi.Soyad;
            txtPersonelEmail.Text = secilikisi.Email;
            txtPersonelTelefon.Text = secilikisi.Telefon;
            txtPersonelTCKN.Text = secilikisi.TCKN;
            txtPersonelMaas.Text = secilikisi.Maas;

        }
    }
}
