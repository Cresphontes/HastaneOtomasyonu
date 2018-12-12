using HastaneOtomasyonu.Class_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.ClassLib
{
    public class Personel : Kisi, IMaasAlabilir
    {

        private string _maas;


        public PersonelBranslari PersonelBrans { get; set; }


        public string Maas
        {
            get => this._maas;
            set
            {
                _maas = value;
            }
           
        }
        public override string ToString()
        {
            return TCKN + " " + Ad + " " + Soyad;
        }
    }
}
