using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartProHamburgercisi
{
    public class Hamburger
    {
        public Hamburger()
        {
            ekstraMalzemeler = new List<EkstraMalzemeler>();
        }

        public string Ad { get; set; }

        public decimal Fiyat { get; set; }

        public List<EkstraMalzemeler> ekstraMalzemeler { get; set; }

        public override string ToString()
        {
            return Ad + " | " + Fiyat.ToString();
        }
    }
}
