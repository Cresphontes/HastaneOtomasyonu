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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }


        List<Kisi> aramalar = new List<Kisi>();

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
                    if (control.Name == "txtPersonelAra")
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
                    if (control.Name == "PersonelAramaResim")
                    {
                        continue;
                    }
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
            btnPersonelKaydet.Enabled = false;

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstPersonelKisiler.SelectedItem == null) return;
            Personel seciliKisi = (Personel)lstPersonelKisiler.SelectedItem;
            (this.MdiParent as FormGiris).personeller.Remove(seciliKisi);
            FormuTemizle();
            lstPersonelKisiler.Items.AddRange((this.MdiParent as FormGiris).personeller.ToArray());
        }

        private void txtPersonelAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtPersonelAra.Text.ToLower();
            aramalar = new List<Kisi>();
            (this.MdiParent as FormGiris).doktorlar.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstPersonelKisiler.Items.AddRange(aramalar.ToArray());
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Personeller.json"; // string.Empty;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    (this.MdiParent as FormGiris).personeller = JsonConvert.DeserializeObject<List<Personel>>(dosyaIcerigi);
                    //Kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List > Kisi >;
                    //Kisiler = (list<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($"{(this.MdiParent as FormGiris).personeller.Count} kişi başarıyala aktarıldı");
                    lstPersonelKisiler.Items.Clear();
                    lstPersonelKisiler.Items.AddRange((this.MdiParent as FormGiris).personeller.ToArray());
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
            dosyaKaydet.FileName = "Personeller.json"; // string.Empty;
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject((this.MdiParent as FormGiris).personeller));
                writer.Close();
                writer.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            lstPersonelKisiler.Items.AddRange(((this.MdiParent as FormGiris).personeller).ToArray());
        }
    }
}
