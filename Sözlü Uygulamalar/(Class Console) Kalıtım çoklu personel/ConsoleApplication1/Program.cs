using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class OkulePersoneli
    {
        public string Ad { get; set; }
        public string soyAd { get; set; }
    }
    public class OgretmenBrans : OkulePersoneli 
    {
        public string brans { get; set; }
    }
    public class OgretmenCinsiyet : OgretmenBrans
    {
        public string cinsiyet { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OkulePersoneli per = new OkulePersoneli
            {
                Ad = "Mustafa",
                soyAd = "TAŞAL"
            };
            OgretmenBrans ogBrans = new OgretmenBrans
            {
                brans = "Ogrenci"
            };
            OgretmenCinsiyet ogCins = new OgretmenCinsiyet
            {
                cinsiyet = "Erkek"
            };

            OkulePersoneli personel = per;
            OgretmenBrans ogbransss = ogBrans;
            OgretmenCinsiyet ogcinsiyet = ogCins;

            Console.WriteLine("Personel Adı = " + per .Ad );
            Console.WriteLine("Personel SoyAdı = " +per .soyAd );

            Console.WriteLine("Personel Branşı = "+ogBrans .brans );

            Console.WriteLine("Personel Cinsiyeti = "+ogCins .cinsiyet );

            Console.ReadKey();
        }
    }
}
