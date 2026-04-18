using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Kalıtım_Askeriye
{
    public class AskeriPersonel
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
    }
    public class KomutanPersonel
    {
        public string Rutbe { get; set; }
    }
    public class CalısanPersonel
    {
        public string ascı { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AskeriPersonel askriPer = new AskeriPersonel
            {
                Ad = "Mustafa",
                SoyAd = "TAŞAL"
            };
            KomutanPersonel kmtanPer = new KomutanPersonel
            {
                Rutbe = "YüzBaşı"
            };
            CalısanPersonel clsnPer = new CalısanPersonel
            {
                ascı = "Mehmet Bey"
            };

            AskeriPersonel askeripersonel = askriPer;
            KomutanPersonel kmtanpersonel = kmtanPer;
            CalısanPersonel clasnpersonel = clsnPer;

            Console.WriteLine("Ad = " + askriPer.Ad);
            Console.WriteLine("SoyAd = " + askriPer.SoyAd);
            Console.WriteLine("Rütbe = " + kmtanPer.Rutbe);
            Console.WriteLine("YemekHane Görevlisi = " + clsnPer.ascı);
            Console.ReadKey();

        }
    }
}
