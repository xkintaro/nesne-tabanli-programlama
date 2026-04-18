using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Otomobil
    {
      
        public Otomobil()
        {
         string    marka = "TOGG";
        string     renk = "Kırmızı";
            Console.WriteLine("Yapıcı Metot Çalıştı.");
            Console.WriteLine("");
            Console.WriteLine("Otomobilin Markası = "+ marka);
            Console.WriteLine("Otomobilin Rengi = "+ renk);
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Başladı.");
            Otomobil o = new Otomobil();
            Console.WriteLine("");
            Console.WriteLine("Program Bitti.");
            Console.ReadKey();
        }
    }
}

