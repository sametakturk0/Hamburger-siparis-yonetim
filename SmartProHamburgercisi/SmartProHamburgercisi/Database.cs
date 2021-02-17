using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartProHamburgercisi
{
    public class Database
    {
        public static List<Hamburger> Hamburgerler { get; set; }
        public static List<EkstraMalzemeler> EkstraMalzemeler { get; set; }
        public static List<Siparis> Siparisler { get; set; }

        public static void Olustur()
        {
            Hamburgerler = new List<Hamburger>();
            EkstraMalzemeler = new List<EkstraMalzemeler>();
            Siparisler = new List<Siparis>();

            EkstraMalzemeleriEkle();
            HamburgerEKle();
        }

        static void EkstraMalzemeleriEkle() 
        {
            EkstraMalzemeler em = new EkstraMalzemeler() { Adi = "Sogan", Fiyat = 1 };
            EkstraMalzemeler.Add(em);

            EkstraMalzemeler.Add(new EkstraMalzemeler() { Adi = "Tursu", Fiyat = 1 });
            EkstraMalzemeler.Add(new EkstraMalzemeler() { Adi = "Marul", Fiyat = 1 });
            EkstraMalzemeler.Add(new EkstraMalzemeler() { Adi = "Domates", Fiyat = 1 });
            EkstraMalzemeler.Add(new EkstraMalzemeler() { Adi = "Ketcap", Fiyat = 1 });
            EkstraMalzemeler.Add(new EkstraMalzemeler() { Adi = "Mayonez", Fiyat = 1 });

        }

        static void HamburgerEKle()
        {
            Database.Hamburgerler.Add(new Hamburger { Ad = "KofteBurger", Fiyat = 20 });
            Database.Hamburgerler.Add(new Hamburger { Ad = "BinKing", Fiyat = 25 });
        }
    }
}
