﻿using HastaneOtomasyonu.ClassLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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




            DoktorBranslari hemsireBrans = (DoktorBranslari)Enum.Parse(typeof(DoktorBranslari), cmbHemsireBrans.SelectedItem.ToString());



            //doktor.HemsireSec = (this.MdiParent as FormGiris).hemsireler

            switch (hemsireBrans)
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

            //lstHemsireKisiler.Items.Clear();
            FormuTemizle();

            lstHemsireKisiler.Items.AddRange((this.MdiParent as FormGiris).hemsireler.ToArray());



        }

        public void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtHemsirAra")
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
                    pbox.Image = null;
                }
                else if (control is ComboBox cb)
                {
                    
                        if (control.Name == "HastaAramaResim")
                    {
                        continue;
                    }
                    cb.Text = string.Empty; ;
                }
            }
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
            cmbHemsireBrans.Text = secilikisi.HemsireBrans.ToString();
        }

      

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Hemsireler.json"; // string.Empty;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    (this.MdiParent as FormGiris).hemsireler = JsonConvert.DeserializeObject<List<Hemsire>>(dosyaIcerigi);
                    //Kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List > Kisi >;
                    //Kisiler = (list<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($"{(this.MdiParent as FormGiris).hemsireler.Count} kişi başarıyala aktarıldı");
                    lstHemsireKisiler.Items.Clear();
                    lstHemsireKisiler.Items.AddRange((this.MdiParent as FormGiris).hemsireler.ToArray());
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
            dosyaKaydet.FileName = "Hemsireler.json"; // string.Empty;
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject((this.MdiParent as FormGiris).hemsireler));
                writer.Close();
                writer.Dispose();
            }
        }
    }
}
