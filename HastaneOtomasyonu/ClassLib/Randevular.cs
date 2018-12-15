using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.ClassLib
{
  public  class Randevular
    {
        public Doktor RandevuDoktor { get; set; }
        public Hasta RandevuHasta { get; set; }
        public DoktorBranslari RandevuBrans { get; set; }
        public string RandevuSaat { get; set; }

        public override string ToString()
        {
            return $"{this.RandevuHasta}  {this.RandevuBrans}  {this.RandevuDoktor}  {this.RandevuSaat}";
        }

    }
}
