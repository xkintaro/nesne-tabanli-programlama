using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class toplamİslem
    {
        public int toplaint(int a, int b)
        {
            Console.WriteLine("int parametresinden gelen değerler");
            return a + b;
        }
        public int toplaparamsint(params int[] sayilar)
        {
            Console.WriteLine("Params int  Parametreden gelen değerler");
            int toplam = 0;
            foreach (var s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }
        public double topladouble(double a, double b)
        {
            Console.WriteLine("Double Parametreden gelen değerler");
            return a + b;
        }
        public double toplaparamsdouble(params double[] sayilar)
        {
            Console.WriteLine("Params Double Parametreden gelen değerler");
            double toplam = 0;
            foreach (var s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }
        public string toplastring(string a, string b)
        {
            Console.WriteLine("String Parametreden gelen değerler");
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            toplamİslem ti = new toplamİslem();
            Console.WriteLine(ti.toplaint (5,8));
            Console.WriteLine(ti.toplaparamsint (5,8,9,7,1));
            Console.WriteLine(ti.topladouble(5.8,7.9));
            Console.WriteLine(ti.toplaparamsdouble(5.8,7.4,9.5,2.7));
            Console.WriteLine(ti.toplastring ("Merhaba" + " Mustafa"));
            Console.ReadKey();
        }
    }
}
