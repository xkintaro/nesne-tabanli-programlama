using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Daire_Yapıcı_metot
{
    class daire
    {
        double yaricap;
        public daire()
        {
            yaricap = 5;
            Console.WriteLine("yarıcap metotu çalıştı");
        }
        public double cap
        {
            get
            {
                return yaricap;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program başladı.");
            daire d = new daire();
            Console.WriteLine("Yaricap = {0}", d.cap);
            Console.WriteLine("program bitti");
            Console.ReadKey();
        }
    }
}
