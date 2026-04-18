using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Dikdortgen_alan_cevre
{
    class dikdortgen
    {
        public int a, b;
        public dikdortgen (int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public int alanhesapla()
        {
            return a * b;
        }
        public int cevrehesapla()
        {
            return 2 * (a + b);
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            dikdortgen d = new dikdortgen(5, 8);
            Console.WriteLine("Dikdortgenin alanı {0}", d.alanhesapla());
            Console.WriteLine("Dikdortgenin cevresi {0}", d.cevrehesapla());
            Console.ReadKey();
            Console.Read();
        }
    }
}
