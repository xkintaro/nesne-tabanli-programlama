using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   class kisi
    {
        int yas = 0;
        string ad = "";
        public kisi ()
        {
            yas = 19;
            ad = "Mustafa";
            Console.WriteLine("Yapıcı Metot Çalıştı");
        }
        public kisi (int yas)
        {
            this.yas = yas;
            ad = "Mustafa";
            Console.WriteLine("int parametreli metot çalıştı");
        }
        public kisi (string ad)
        {
            yas = 19;
            this.ad = ad;
            Console.WriteLine("String parametreli metot çalıştı");
        }
        public kisi (int yas,string ad)
        {
            this.yas = yas;
            this.ad = ad;
            Console.WriteLine("İki parametreli metot da çalıştı");
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı");
            kisi k1 = new kisi();
            kisi k2 = new kisi(16);
            kisi k3 = new kisi("Mustafa");
            kisi k4 = new kisi(16, "Mustafa");
            Console.WriteLine("Program Bitti");
            Console.ReadKey();
        }
    }
}
