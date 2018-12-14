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

                PersonelBranslari personelBrans = (PersonelBranslari)Enum.Parse(typeof(PersonelBranslari), cmbPersonelBrans.SelectedItem.ToString());

                switch (personelBrans)
                {

                    case PersonelBranslari.Muhasebe:
                        personel.PersonelBrans = PersonelBranslari.Muhasebe;
                        break;
                    case PersonelBranslari.Temizlik:
                        personel.PersonelBrans = PersonelBranslari.Temizlik;
                        break;
                    case PersonelBranslari.HastaBakici:
                        personel.PersonelBrans = PersonelBranslari.HastaBakici;
                        break;
                    case PersonelBranslari.Rontgenci:
                        personel.PersonelBrans = PersonelBranslari.Rontgenci;
                        break;
                    case PersonelBranslari.Kantin:
                        personel.PersonelBrans = PersonelBranslari.Kantin;
                        break;
                    case PersonelBranslari.Sofor:
                        personel.PersonelBrans = PersonelBranslari.Sofor;
                        break;
                    case PersonelBranslari.HastaKayitci:
                        personel.PersonelBrans = PersonelBranslari.HastaKayitci;
                        break;
                    default:
                        break;
                }

                (this.MdiParent as FormGiris).personeller.Add(personel);

                //if (memoryStream.Length > 0)
                //{
                //    yeniKisi.Fotograf = memoryStream.ToArray();
                //}
                //memoryStream = new MemoryStream();
                //kisiler.Add(yeniKisi);
                ////MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
                lstPersonelKisiler.Items.AddRange((this.MdiParent as FormGiris).personeller.ToArray());
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
            cmbPersonelBrans.Text = (lstPersonelKisiler.SelectedItem as Personel).PersonelBrans.ToString();
            btnPersonelKaydet.Enabled = false;

        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (lstPersonelKisiler.SelectedItem == null) return;

            Personel seciliKisi = (Personel)lstPersonelKisiler.SelectedItem;// referans tip değişkenler !

            //static metod yap orda ara varsa varde yoksa yokdersin.
            try
            {
                seciliKisi.Ad = txtPersonelAd.Text;
                seciliKisi.Soyad = txtPersonelSoyad.Text;
                seciliKisi.Email = txtPersonelEmail.Text;
                seciliKisi.Telefon = txtPersonelTelefon.Text;
                seciliKisi.TCKN = txtPersonelTCKN.Text;
                seciliKisi.Maas = txtPersonelMaas.Text;


                PersonelBranslari personelBrans = (PersonelBranslari)Enum.Parse(typeof(PersonelBranslari), cmbPersonelBrans.SelectedItem.ToString());

                switch (personelBrans)
                {

                    case PersonelBranslari.Muhasebe:
                        seciliKisi.PersonelBrans = PersonelBranslari.Muhasebe;
                        break;
                    case PersonelBranslari.Temizlik:
                        seciliKisi.PersonelBrans = PersonelBranslari.Temizlik;
                        break;
                    case PersonelBranslari.HastaBakici:
                        seciliKisi.PersonelBrans = PersonelBranslari.HastaBakici;
                        break;
                    case PersonelBranslari.Rontgenci:
                        seciliKisi.PersonelBrans = PersonelBranslari.Rontgenci;
                        break;
                    case PersonelBranslari.Kantin:
                        seciliKisi.PersonelBrans = PersonelBranslari.Kantin;
                        break;
                    case PersonelBranslari.Sofor:
                        seciliKisi.PersonelBrans = PersonelBranslari.Sofor;
                        break;
                    case PersonelBranslari.HastaKayitci:
                        seciliKisi.PersonelBrans = PersonelBranslari.HastaKayitci;
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            lstPersonelKisiler.Items.AddRange((this.MdiParent as FormGiris).personeller.ToArray());
            btnPersonelKaydet.Enabled = true;
        }

        private void FormPersonel_Click(object sender, EventArgs e)
        {
            lstPersonelKisiler.SelectedItem = null;
            btnPersonelKaydet.Enabled = true;
        }
    }
}
