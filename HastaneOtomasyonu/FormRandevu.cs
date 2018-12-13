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
    public partial class FormRandevu : Form
    {
        Button btn = new Button();
        public FormRandevu()
        {
            InitializeComponent();
            this.Load += FormRandevu_Load;
            
            btn.MouseClick += Btn_MouseClick;
            
            
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
          
            
        }

        private void FormRandevu_Load(object sender, EventArgs e)
        {

            for (int saat = 9; saat <= 16; saat++)
            {

                if (saat == 12)
                {
                    continue;
                }
                for (int dakika = 0; dakika <= 45; dakika += 15)
                {
                    int i = 0;
                    Button btn = new Button();
                    //Button btn = (Button)sender;
                    btn.BackColor = Color.Peru;
                    btn.Size = new Size(65, 60);
                    btn.Text = saat.ToString("00") + ":" + dakika.ToString("00");
                    btn.Name = i.ToString();
                    flwRandevu.Controls.Add(btn);
                  
                }

            }



        }

      
    }
}
