using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Daire_alan_ve_cevre
{
    class daire
    {
        public double alan(double r)
        {
            return 3.14 * r * r;
        }
        public double cevre(double r)
        {
            return (2 * Math.PI * r);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            daire d = new daire();
            daire f = new daire();

            double   r;
            Console.Write("Yarıçap giriniz=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Dairenin Alanı {0}", d.alan(r));
            Console.WriteLine("Dairenin Cevresi {0}", d.cevre(r));
            Console.ReadLine();
        }
    }
}
