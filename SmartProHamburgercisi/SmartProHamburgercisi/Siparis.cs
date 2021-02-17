using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartProHamburgercisi
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzemeler>();
        }
        public Hamburger Hamburger{ get; set; }

        public List<EkstraMalzemeler> EkstraMalzemeler{ get; set; }

        public int Adet { get; set; }

        public MenuBoy menuBoy { get; set; }

        public decimal FiyatHesapla()
        {
            decimal tutar = 0;

            tutar += Hamburger.Fiyat;

            foreach (var item in EkstraMalzemeler)
            {
                tutar += item.Fiyat;
            }

            switch (menuBoy)
            {               
                case MenuBoy.Orta:
                    tutar += 1.5m;
                    break;
                case MenuBoy.Buyuk:
                    tutar += 3.0m;
                    break;               
                    
            }

            return tutar * Adet;
        }

        public decimal EkstraMalzeFiyatHesapla()
        {
            decimal tutar = 0;

            foreach (var item in EkstraMalzemeler)
            {
                tutar += item.Fiyat;
            }
            return tutar;
        }

        public override string ToString()
        {
            return $" Hamburger : {this.Hamburger.Ad} | Menu Boy : { menuBoy.ToString() }| Adet : {Adet} | Tutar : { FiyatHesapla().ToString("C2") }";
        }
    }
}