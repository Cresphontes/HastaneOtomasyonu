using HastaneOtomasyonu.Class_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.ClassLib
{
    public class Doktor : Kisi, IMaasAlabilir
    {
        private string _maas;

        public DoktorBranslari DoktorBrans { get; set; }

        public Hemsire HemsireSec { get; set; }
        public string Maas
        {
            get => this._maas;
            set
            {
                if (value.Length<0)
                    throw new Exception(" Maas Boş Geçilemez ");
                if (value.Length>5)
                    throw new Exception("Maas 99.999 TL den fazla olamaz. ");

             this._maas = value;
            }

        }
    



        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }

      
        //public RandevuSaati[] SaatListesi { get; set; }
    }
}
