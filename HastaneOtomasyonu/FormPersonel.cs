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
            
            Personel yeniKisi = new Personel();
            try
            {
                yeniKisi.Ad = txtPersonelAd.Text;
                yeniKisi.Soyad = txtPersonelSoyad.Text;
                yeniKisi.Email = txtPersonelEmail.Text;
                yeniKisi.Telefon = txtPersonelTelefon.Text;
                yeniKisi.TCKN = txtPersonelTCKN.Text;
                yeniKisi.Maas = txtPersonelMaas.Text;
                (this.MdiParent as FormGiris).Personellerx.Add(yeniKisi);

                //if (memoryStream.Length > 0)
                //{
                //    yeniKisi.Fotograf = memoryStream.ToArray();
                //}
                //memoryStream = new MemoryStream();
                //kisiler.Add(yeniKisi);
                ////MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                (this.MdiParent as FormGiris).FormuTemizle();
                lstPersonelKisiler.Items.AddRange((this.MdiParent as FormGiris).Personellerx.ToArray());
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
         
            lstPersonelKisiler.Items.AddRange(((this.MdiParent as FormGiris).Personellerx).ToArray());
          
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
