using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartProHamburgercisi
{
    public class EkstraMalzemeler
    {
        public string Adi { get; set; }

        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Adi + " | " + Fiyat.ToString();
        }
    }
}
