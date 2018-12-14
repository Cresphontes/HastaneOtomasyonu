using HastaneOtomasyonu.Class_Lib;
using System;

namespace HastaneOtomasyonu.ClassLib
{
    public class Hemsire : Kisi, IMaasAlabilir
    {
        string _maas;
        public DoktorBranslari HemsireBrans { get; set; }
        public string Maas
        { get => this._maas;
            set
            {
                if (value.Length < 0)
                    throw new Exception(" Maas Boş Geçilemez ");
                if (value.Length > 5)
                    throw new Exception("Maas 99.999 TL den fazla olamaz. ");              
                _maas = value;
            }
        }

        public override string ToString()
        {
            return $" {this.TCKN} {this.Ad} {this.Soyad} {this.HemsireBrans} ";
        }
    }
}
