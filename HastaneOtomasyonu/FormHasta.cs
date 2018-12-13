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
    public partial class FormHasta : Form
    {
        public FormHasta()
        {
            InitializeComponent();
        }
        //Gerekirse
        //List<Hasta> Hastas = new List<Hasta>();
        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            Hasta yeniKisi = new Hasta();
            try
            {
                yeniKisi.Ad = txtHastaAd.Text;
                yeniKisi.Soyad = txtHastaSoyad.Text;
                yeniKisi.Email = txtHastaEmail.Text;
                yeniKisi.Telefon = txtHastaTelefon.Text;
                yeniKisi.TCKN = txtHastaTCKN.Text;
                //Gerekirse Diye
                // Hastas.Add(yeniKisi);
                (this.MdiParent as FormGiris).Hastalarx.Add(yeniKisi);

                //if (memoryStream.Length > 0)
                //{
                //    yeniKisi.Fotograf = memoryStream.ToArray();
                //}
                //memoryStream = new MemoryStream();
                //kisiler.Add(yeniKisi);
                ////MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
                lstHastaList.Items.AddRange((this.MdiParent as FormGiris).Hastalarx.ToArray());
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
        private void FormHasta_Load(object sender, EventArgs e)
        {
            lstHastaList.Items.AddRange((this.MdiParent as FormGiris).Hastalarx.ToArray());
        }

        

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstHastaList.SelectedItem == null) return;
            Hasta seciliKisi = (Hasta)lstHastaList.SelectedItem;
            (this.MdiParent as FormGiris).Hastalarx.Remove(seciliKisi);
            FormuTemizle();
            lstHastaList.Items.AddRange((this.MdiParent as FormGiris).Hastalarx.ToArray());
        }

        private void lstHastaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHastaList.SelectedItem == null) return;

            Hasta secilikisi = lstHastaList.SelectedItem as Hasta;
            txtHastaAd.Text = secilikisi.Ad;
            txtHastaSoyad.Text = secilikisi.Soyad;
            txtHastaEmail.Text = secilikisi.Email;
            txtHastaTelefon.Text = secilikisi.Telefon;
            txtHastaTCKN.Text = secilikisi.TCKN;
            btnHastaKaydet.Enabled = false;
        }
    }
}
