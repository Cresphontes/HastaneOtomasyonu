using HastaneOtomasyonu.Class_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.ClassLib
{
    public class Hasta : Kisi, IRandevuAl
    {
        public void RandevuAl()
        {
           
        }
        
        public override string ToString()
        {
            return  Ad + " " + Soyad;
        }
    }
}
