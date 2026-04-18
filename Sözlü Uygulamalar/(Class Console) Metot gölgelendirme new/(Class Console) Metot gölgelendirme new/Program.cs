using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Metot_gölgelendirme_new
{
    public class okulPersoneli
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public void AdSoyAdYazdir()
        {
            Console.WriteLine("Benim ismim = " + Ad + " " + SoyAd);
        }
    }
    public class ogretmen : okulPersoneli
    {
        public string brans { get; set; }
        public void AdSoyAdYazdir()
        {
            Console.WriteLine("Benim ismim = " + Ad + " " + SoyAd);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            okulPersoneli okulper = new okulPersoneli
            {
                Ad = "Mustafa",
                SoyAd = "TAŞAL",

            };
            ogretmen ogpersonel = new ogretmen
            {
                brans = "Ogrencı"
            };
            okulPersoneli okulpersonel = okulper;
            ogretmen ogretmenper = ogpersonel;
            Console.WriteLine("Personel Adı = " + okulper.Ad);
            Console.WriteLine("Personel SoyAdi = " + okulper.SoyAd);
            Console.WriteLine("Personel Branşı = " + ogpersonel.brans);

            Console.ReadKey();
        }
    }
}