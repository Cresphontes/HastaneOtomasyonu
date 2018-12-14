using HastaneOtomasyonu.Class_Lib;
using HastaneOtomasyonu.ClassLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<Kisi> aramalar = new List<Kisi>();
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
                (this.MdiParent as FormGiris).hastalar.Add(yeniKisi);

                //if (memoryStream.Length > 0)
                //{
                //    yeniKisi.Fotograf = memoryStream.ToArray();
                //}
                //memoryStream = new MemoryStream();
                //kisiler.Add(yeniKisi);
                ////MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
                lstHastaList.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
                btnHastaKaydet.Enabled = false;
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
                    if (control.Name == "txtHastaAra")
                    {
                        continue;
                    }
                    control.Text = string.Empty;
                }
                else if (control is ListBox lst)
                {
                    lst.Items.Clear();
                }
                else if (control is PictureBox pbox)
                {
                    if (control.Name == "HastaAramaResim")
                    {
                        continue;
                    }
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
            this.WindowState = FormWindowState.Maximized;
            btnHastaGuncelle.Enabled = false;
            lstHastaList.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
        }



        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstHastaList.SelectedItem == null) return;
            Hasta seciliKisi = (Hasta)lstHastaList.SelectedItem;
            (this.MdiParent as FormGiris).hastalar.Remove(seciliKisi);
            FormuTemizle();
            lstHastaList.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
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

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHastaList.SelectedItem == null) return;

            Hasta seciliKisi = (Hasta)lstHastaList.SelectedItem;// referans tip değişkenler !

            //static metod yap orda ara varsa varde yoksa yokdersin.
            try
            {
                seciliKisi.Ad = txtHastaAd.Text;
                seciliKisi.Soyad = txtHastaSoyad.Text;
                seciliKisi.Email = txtHastaEmail.Text;
                 seciliKisi.Telefon= txtHastaTelefon.Text;
                 seciliKisi.TCKN= txtHastaTCKN.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            lstHastaList.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
            btnHastaKaydet.Enabled = true;
            btnHastaGuncelle.Enabled = false;
        }

        private void txtHastaAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtHastaAra.Text.ToLower();
            aramalar = new List<Kisi>();
            (this.MdiParent as FormGiris).hastalar.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara)
            || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstHastaList.Items.AddRange(aramalar.ToArray());
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Hastalar.json"; // string.Empty;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    (this.MdiParent as FormGiris).hastalar = JsonConvert.DeserializeObject<List<Hasta>>(dosyaIcerigi);
                    //Kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List > Kisi >;
                    //Kisiler = (list<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($"{(this.MdiParent as FormGiris).hastalar.Count} kişi başarıyala aktarıldı");
                    lstHastaList.Items.Clear();
                    lstHastaList.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("bir hata oluştu " + ex.Message);
                }
            }
        }

        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyası) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Hastalar.json"; // string.Empty;
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject((this.MdiParent as FormGiris).hastalar));
                writer.Close();
                writer.Dispose();
            }
        }

        private void btnHastaTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            lstHastaList.Items.AddRange(((this.MdiParent as FormGiris).hastalar).ToArray());
            btnHastaKaydet.Enabled = true;
            btnHastaGuncelle.Enabled = false;
        }

        private void FormHasta_Click(object sender, EventArgs e)
        {
            lstHastaList.SelectedItem = null;
        }
    }
}
