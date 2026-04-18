using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    public class ogrenci
    {
        public string Ders;
        public string adı_Soyadı;
        public int No;

    }

    public class YazılımAlanları
    {
        public string Alan;

    }



    class Program
    {
        static void Main(string[] args)
        {
            YazılımAlanları yazılım1 = new YazılımAlanları();
            yazılım1.Alan = "Oyun Geliştirme";

            YazılımAlanları yazılım2 = new YazılımAlanları();
            yazılım2.Alan = "Uygulama Geliştirme";

            YazılımAlanları yazılım3 = new YazılımAlanları();
            yazılım3.Alan = "Web Sitesi Geliştirme";

            YazılımAlanları yazılım4 = new YazılımAlanları();
            yazılım4.Alan = "Siber Güvenlik";

            ogrenci ogr1 = new ogrenci();
            ogr1.Ders = "Matematik";
            ogr1.adı_Soyadı = "Mustafa TAŞAL";
            ogr1.No = 2706;

            ogrenci ogr2 = new ogrenci();
            ogr2.Ders = "Matematik";
            ogr2.adı_Soyadı = "Mustafa Miraç";
            ogr2.No = 2707;

            Console.WriteLine("Ders= {0}", ogr1.Ders);
            Console.WriteLine("Ad/Soyad= {0}", ogr1.adı_Soyadı);
            Console.WriteLine("No= {0}", ogr1.No);

            Console.WriteLine("Ders= {0}", ogr2.Ders);
            Console.WriteLine("Ad/Soyad= {0}", ogr2.adı_Soyadı);
            Console.WriteLine("No= {0}", ogr2.No);

            Console.WriteLine("Yazılım Alanları_1: {0}", yazılım1.Alan);
            Console.WriteLine("Yazılım Alanları_2: {0}", yazılım2.Alan);
            Console.WriteLine("Yazılım Alanları_3: {0}", yazılım3.Alan);
            Console.WriteLine("Yazılım Alanları_4: {0}", yazılım4.Alan);


            Console.Read();
        }
    }
}
