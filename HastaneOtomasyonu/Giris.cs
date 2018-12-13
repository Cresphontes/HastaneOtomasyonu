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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }


        public List<Personel> Personellerx { get; set; }
        private FormHasta _frmHasta;
        private FormHemsire _frmHemsire;
        private FormDoktor _frmDoktor;
        private FormPersonel _frmPersonel;
        
        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
              
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            Personellerx = new List<Personel>();
            Hastalarx = new List<Hasta>();
        }

        public List<Hasta> Hastalarx { get; set; }
        #region HastaKayıtForm
        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmHasta == null || _frmHasta.IsDisposed)
            {
                _frmHasta = new FormHasta();
                _frmHasta.MdiParent = this;
                _frmHasta.Show();

                if (_frmPersonel != null)
                {
                    _frmPersonel.Dispose();
                }
                if (_frmHemsire != null)
                {
                    _frmHemsire.Dispose();
                }
                if (_frmDoktor != null)
                {
                    _frmDoktor.Dispose();
                }
            }
           

        } 
        #endregion

        #region DoktorForm
        private void doktorKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmDoktor == null || _frmDoktor.IsDisposed)
            {
                _frmDoktor = new FormDoktor();
                _frmDoktor.MdiParent = this;
                _frmDoktor.Show();

                if (_frmHasta != null)
                {
                    _frmHasta.Dispose();
                }
                if (_frmHemsire != null)
                {
                    _frmHemsire.Dispose();
                }
                if (_frmPersonel != null)
                {
                    _frmPersonel.Dispose();
                }
            }
           

        }
        #endregion

        #region PersonelForm
        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (_frmPersonel == null || _frmPersonel.IsDisposed)
            {
                _frmPersonel = new FormPersonel();
                _frmPersonel.MdiParent = this;
                _frmPersonel.Show();

                if (_frmHasta != null)
                {
                    _frmHasta.Dispose();
                }
                if (_frmHemsire != null)
                {
                    _frmHemsire.Dispose();
                }
                if (_frmDoktor != null)
                {
                    _frmDoktor.Dispose();
                }
            }

        } 
        #endregion

        #region Hemşire Form
        private void hemşireKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (_frmHemsire == null || _frmHemsire.IsDisposed)
            {
                _frmHemsire = new FormHemsire();
                _frmHemsire.MdiParent = this;
                _frmHemsire.Show();

                if(_frmHasta != null)
                {
                    _frmHasta.Dispose();
                }
                if (_frmPersonel != null)
                {
                    _frmPersonel.Dispose();
                }
                if (_frmDoktor != null)
                {
                    _frmDoktor.Dispose();
                }
             
            }
           

        }
        #endregion

       
    }
}
