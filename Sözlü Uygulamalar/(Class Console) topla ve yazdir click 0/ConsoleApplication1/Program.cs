using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int toplam = 0;
            int ustAl;
            Console.WriteLine("Sayı Giriniz");
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {

                }
                else if (a == 0)
                {
                    break;
                }
                toplam += a;
                ustAl = a * a;
                Console.WriteLine("Girilen Sayı = " + a);
                Console.WriteLine("Girilen Tüm Sayıların Toplamı = " + toplam);
                Console.WriteLine("Girilen Sayının Üssü = " + ustAl);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Sayı Giriniz");
            }
            while (a != 0);
        }
    }
}
