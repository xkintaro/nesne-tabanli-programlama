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
            int say;
            int sayac = 0;
            int toplam = 0;
            Console.WriteLine("Sayı Giriniz.");
            do
            {
                say = Convert.ToInt32(Console.ReadLine());

                if (say == 0)
                {
                    break;
                }
                else if (say != 0)
                {
                    sayac++;
                    toplam += say;
                }
                Console.WriteLine("Sayaç = " + sayac);
                Console.WriteLine("Toplam = " + toplam);
                Console.WriteLine("");
                Console.WriteLine("Sayı Giriniz.");
            }
            while (say != 0);
        }
    }
}
