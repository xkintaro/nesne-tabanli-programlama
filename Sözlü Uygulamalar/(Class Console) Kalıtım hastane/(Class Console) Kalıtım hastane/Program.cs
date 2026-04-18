using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Kalıtım_hastane
{
    public class HastanePersoneli
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
    }
    public class Doktor : HastanePersoneli
    {
        public string brans { get; set; }
    }
    public class Hizmetli : HastanePersoneli
    {
        public string cinsiyet { get; set; }
    }
    public class Hasta : HastanePersoneli
    {
        public string hastalıkAdi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Doktor dktr = new Doktor
            {
                Ad = "Mustafa",
                SoyAd = "TAŞAL",
                brans = "Cerrah"
            };
            Hizmetli hzmtli = new Hizmetli
            {
                Ad = "Mehmet",
                SoyAd = "AYDIN",
                cinsiyet = "Erkek"
            };
            Hasta hsta = new Hasta
            {
                Ad = "Muhammet",
                SoyAd = "TEVFİk",
                hastalıkAdi = "Grip"
            };
            HastanePersoneli personelDoktor = dktr;
            Doktor personelDoktorBrans = dktr;

            HastanePersoneli personelHizmetli = hzmtli;
            Hizmetli personelHizmetliCinsiyet = hzmtli;

            HastanePersoneli personelHasta = hsta;
            Hasta personelHastaSaglıkDurumu = hsta;


            Console.WriteLine("Doktor Adı = " + personelDoktor.Ad);
            Console.WriteLine("Doktor SoyAdı = " + personelDoktor.SoyAd);
            Console.WriteLine("Doktor Branşı = " + personelDoktorBrans.brans);

            Console.WriteLine("");

            Console.WriteLine("Hizmetli Adı = " + personelHizmetli.Ad);
            Console.WriteLine("Hizmetli Soyadı = " + personelHizmetli.SoyAd);
            Console.WriteLine("Hizmetli Cinsiyeti = " + personelHizmetliCinsiyet.cinsiyet);

            Console.WriteLine("");

            Console.WriteLine("Hasta Adı = " + personelHasta.Ad);
            Console.WriteLine("Hasta SoyAdı = " + personelHasta.SoyAd);
            Console.WriteLine("Hasta Sağlık Sorunu = " + personelHastaSaglıkDurumu.hastalıkAdi);

            Console.ReadKey();
        }
    }
}
