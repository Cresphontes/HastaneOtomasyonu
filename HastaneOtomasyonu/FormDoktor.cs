using HastaneOtomasyonu.Class_Lib;
using HastaneOtomasyonu.ClassLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }


        List<Hemsire> BransliHemsireler = new List<Hemsire>();

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {

            Doktor doktor = new Doktor();


            doktor.Ad = txtDoktorAd.Text;
            doktor.Soyad = txtDoktorSoyad.Text;
            doktor.Email = txtDoktorEmail.Text;
            doktor.Telefon = txtDoktorTelefon.Text;
            doktor.TCKN = txtDoktorTCKN.Text;
            doktor.Maas = txtDoktorMaas.Text;

            DoktorBranslari doktorBrans = (DoktorBranslari)Enum.Parse(typeof(DoktorBranslari),cmbDoktorBrans.SelectedItem.ToString());



            //doktor.HemsireSec = (this.MdiParent as FormGiris).hemsireler

            switch (doktorBrans)
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

            FormuTemizle();

            lstDoktorlar.Items.AddRange(((this.MdiParent as FormGiris).doktorlar).ToArray());



        }

        public void FormuTemizle()
        {
            BransliHemsireler.Clear();

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

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            BransliHemsireler.Clear();
            cmbDoktorHemsire.Items.Clear();

            if (lstDoktorlar.SelectedItem == null) return;

            Doktor secilikisi = lstDoktorlar.SelectedItem as Doktor;
            txtDoktorAd.Text = secilikisi.Ad;
            txtDoktorSoyad.Text = secilikisi.Soyad;
            txtDoktorEmail.Text = secilikisi.Email;
            txtDoktorTelefon.Text = secilikisi.Telefon;
            txtDoktorTCKN.Text = secilikisi.TCKN;
            txtDoktorMaas.Text = secilikisi.Maas;
            cmbDoktorBrans.Text = secilikisi.DoktorBrans.ToString();

            foreach (Hemsire item in ((this.MdiParent as FormGiris).hemsireler))
            {
                if (item.HemsireBrans == secilikisi.DoktorBrans)
                {
                    BransliHemsireler.Add(item);
                }
            }

            cmbDoktorHemsire.Items.AddRange(BransliHemsireler.ToArray());


            //btnDoktorKaydet.Enabled = false;
        }

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            lstDoktorlar.Items.AddRange((this.MdiParent as FormGiris).doktorlar.ToArray());
            cmbDoktorBrans.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            

        }


        private void içeriAktarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Doktorlar.json"; // string.Empty;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    (this.MdiParent as FormGiris).doktorlar = JsonConvert.DeserializeObject<List<Doktor>>(dosyaIcerigi);
                    //Kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List > Kisi >;
                    //Kisiler = (list<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($"{(this.MdiParent as FormGiris).doktorlar.Count} kişi başarıyala aktarıldı");
                    lstDoktorlar.Items.Clear();
                    lstDoktorlar.Items.AddRange((this.MdiParent as FormGiris).doktorlar.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("bir hata oluştu " + ex.Message);
                }
            }
        }

        private void dışarıAktarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyası) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Doktorlar.json"; // string.Empty;
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject((this.MdiParent as FormGiris).doktorlar));
                writer.Close();
                writer.Dispose();
            }

        }
    }
}




