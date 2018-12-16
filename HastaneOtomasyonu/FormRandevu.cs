using HastaneOtomasyonu.ClassLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormRandevu : Form
    {


        public FormRandevu()
        {
            InitializeComponent();
            this.Load += FormRandevu_Load;

        }


        Randevular Randevu = new Randevular();
        MyButton button;
        MyButton butonTut;
        string saatTut;
        bool basildiMi = false;
        public class MyButton : Button
        {
            protected override Size DefaultSize => Size = new Size(65, 60);
            public override Color BackColor { get; set; } // => Color.Peru           

        }
        private void FormRandevu_Load(object sender, EventArgs e)
        {
            //Kayıtlı hastalar combobox'a eklendi.
            cmbHastaSec.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
            //checkedListBox1.Items.AddRange((this.MdiParent as FormGiris).hastalar.ToArray());
            lblServisSec.Visible = false;
            cmbServisSec.Visible = false;
            lblDoktorSec.Visible = false;
            cmbDoktorSec.Visible = false;
            flwRandevu.Visible = false;
            btnRandevuKaydet.Visible = false;


        }
        public void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {

                if (control is ComboBox cb)
                {
                    cb.Text = string.Empty; ;
                }

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            butonTut = (sender as MyButton);
            basildiMi = !basildiMi;
            if (basildiMi)
            {
                saatTut = (sender as MyButton).Text;
                (sender as MyButton).BackColor = Color.Green;

                for (int i = 0; i < flwRandevu.Controls.Count; i++)
                {
                    if (!(((Button)flwRandevu.Controls[i]).Text == (sender as MyButton).Text))
                    {
                        ((Button)flwRandevu.Controls[i]).Enabled = false;
                    }
                }

            }
            if (!basildiMi)
            {
                (sender as MyButton).BackColor = Color.Peru;
                saatTut = string.Empty;
                for (int i = 0; i < flwRandevu.Controls.Count; i++)
                {
                    ((Button)flwRandevu.Controls[i]).Enabled = true;
                }
            }


        }

        private void cmbHastaSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHastaSec.SelectedItem == null) return;
            cmbServisSec.Items.Clear();
            cmbServisSec.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            cmbServisSec.Text = string.Empty;
            lblServisSec.Visible = true;
            cmbServisSec.Visible = true;
        }

        private void cmbServisSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServisSec.SelectedItem == null) return;
            cmbDoktorSec.Items.Clear();
            cmbDoktorSec.Text = string.Empty;

            foreach (Doktor item in (this.MdiParent as FormGiris).doktorlar)
            {
                if (item == null)
                {
                    break;
                }
                if (item.DoktorBrans.ToString() == cmbServisSec.Text)
                {
                    cmbDoktorSec.Items.Add(item);
                }
            }


            lblDoktorSec.Visible = true;
            cmbDoktorSec.Visible = true;
        }

        private void cmbDoktorSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktorSec.SelectedItem == null) return;

            //Butonların üstlerine saatleri yazıyoruz.Ve butonları olusturuyoruz.
            //formunloadından buraya taşındı . 2.kez seçim yapıldıgında gelmiyordu butonlar.
            //doktorun randevu saati dolumu bosmu bos ise null atıyorum degilse kontrol ediyoruz.
            flwRandevu.Controls.Clear();

            List<string> doluSaatler = new List<string>();
            foreach (Randevular item in (this.MdiParent as FormGiris).RandevuBilgileri.Where(x => x.RandevuDoktor.Ad + " " + x.RandevuDoktor.Soyad == cmbDoktorSec.SelectedItem.ToString()))
            {                
                    doluSaatler.Add(item.RandevuSaat);
            }

            for (int saat = 9; saat <= 16; saat++)
            {

                if (saat == 12)
                {
                    continue;
                }
                for (int dakika = 0; dakika <= 45; dakika += 15)
                {

                    button = new MyButton();
                    button.BackColor = Color.Peru;
                    button.Text = saat.ToString("00") + ":" + dakika.ToString("00");

                    foreach (Randevular item in (this.MdiParent as FormGiris).RandevuBilgileri.Where(x => x.RandevuDoktor.Ad + " " + x.RandevuDoktor.Soyad == cmbDoktorSec.SelectedItem.ToString()))
                    {

                        if (item.RandevuSaat.ToString() == button.Text)
                        {
                            button.Enabled = false;
                            button.BackColor = Color.Green;

                            continue;
                        }
                    }
                    if (doluSaatler.Contains(saat.ToString("00") + ":" + dakika.ToString("00")))
                    {
                        button.BackColor = Color.Blue;
                        button.Enabled = false;
                    }


                    flwRandevu.Controls.Add(button);
                    button.Click += Button_Click;

                }

            }
            flwRandevu.Visible = true;
            btnRandevuKaydet.Visible = true;


        }
        

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            DoktorBranslari doktorBrans = (DoktorBranslari)Enum.Parse(typeof(DoktorBranslari), cmbServisSec.SelectedItem.ToString());

            Randevular yeniRandevu = new Randevular
            {
                RandevuHasta = cmbHastaSec.SelectedItem as Hasta,
                RandevuBrans = doktorBrans,
                RandevuDoktor = cmbDoktorSec.SelectedItem as Doktor,
                RandevuSaat = saatTut
            };


            if (basildiMi == false)
            {
                MessageBox.Show("Lütfen Uygun Bir Randevu Saati Seçiniz.");
                return;
            }

            if ((this.MdiParent as FormGiris).RandevuBilgileri.Count == 0)
            {
                lstKayitliHastalar.Items.Add(yeniRandevu);
                (this.MdiParent as FormGiris).RandevuBilgileri.Add(yeniRandevu);
            }
            else
            {
                foreach (Randevular item in (this.MdiParent as FormGiris).RandevuBilgileri)
                {

                    if (item.RandevuBrans.ToString() == cmbServisSec.SelectedItem.ToString() && item.RandevuHasta.Ad + " " + item.RandevuHasta.Soyad == cmbHastaSec.SelectedItem.ToString())
                    {
                        DialogResult secenek = MessageBox.Show("Bu Serviste Kaydınız Vardır.\nGüncellemek istermisiniz", "Kayıt Hatası", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (secenek == DialogResult.No)
                        {

                            MessageBox.Show("Saglıklı Günler Dileriz");
                            break;
                        }
                        else if (secenek == DialogResult.Yes)
                        {
                            (this.MdiParent as FormGiris).RandevuBilgileri.Remove(item);
                            lstKayitliHastalar.Items.Remove(item);
                            (this.MdiParent as FormGiris).RandevuBilgileri.Add(yeniRandevu);
                            lstKayitliHastalar.Items.Add(yeniRandevu);
                            MessageBox.Show("Tebrikler Güncellemeniz Yapıldı.\nSaglıklı Günler Dileriz.");
                            break;
                        }
                    }
                    else
                    {
                        lstKayitliHastalar.Items.Add(yeniRandevu);
                        (this.MdiParent as FormGiris).RandevuBilgileri.Add(yeniRandevu);
                        MessageBox.Show("Tebrikler Kaydınız Oluşturuldu.\nSaglıklı Günler Dileriz.");
                        break;
                    }

                }
            }

            butonTut.Enabled = false;
            FormuTemizle();
            btnRandevuKaydet.Visible = false;
            flwRandevu.Visible = false;
            lblServisSec.Visible = false;
            cmbServisSec.Visible = false;
            lblDoktorSec.Visible = false;
            cmbDoktorSec.Visible = false;
            basildiMi = false;
            saatTut = string.Empty;

        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "RandevuluHastalar.json"; // string.Empty;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    (this.MdiParent as FormGiris).RandevuBilgileri = JsonConvert.DeserializeObject<List<Randevular>>(dosyaIcerigi);
                    //Kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List > Kisi >;
                    //Kisiler = (list<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($"{(this.MdiParent as FormGiris).RandevuBilgileri.Count} kişi başarıyala aktarıldı");
                    lstKayitliHastalar.Items.Clear();
                    lstKayitliHastalar.Items.AddRange((this.MdiParent as FormGiris).RandevuBilgileri.ToArray());
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
            dosyaKaydet.FileName = "RandevuluHastalar.json"; // string.Empty;
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject((this.MdiParent as FormGiris).RandevuBilgileri));
                writer.Close();
                writer.Dispose();
            }
            lstKayitliHastalar.Items.Clear();
        }
    }
}

