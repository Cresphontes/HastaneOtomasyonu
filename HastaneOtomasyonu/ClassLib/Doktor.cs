using HastaneOtomasyonu.Class_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.ClassLib
{
    public class Doktor : Kisi, IMaasAlabilir, IHemsireSecebilir
    {
        private string _maas;

        public string Maas
        {
            get => this._maas;
            set
            {
                if (value.Length<0)
                    throw new Exception(" Maas Boş Geçilemez ");
                if (value.Length>5)
                    throw new Exception("Maas 99.999 TL den fazla olamaz. ");

             this._maas = Maas;
            }

        }

        public string HemsireSec()
        {
            throw new NotImplementedException();
        }
    }
}
