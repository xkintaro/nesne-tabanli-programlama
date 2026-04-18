using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Params_toplam
{
    class sayiislem
    {
        public int toplam (params int []sayilar)
        {
            int toplam = 0;
            foreach (var a in sayilar)
            {
                toplam += a;
            }
                return toplam;         
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sayiislem s = new sayiislem();
            Console.WriteLine("Topam = {0}", s.toplam(5, 6));
        //  Console.WriteLine("Toplam = {0}", s.toplam(3, 4, 5));
        //  Console.WriteLine("Toplam = {0}", s.toplam(5,5));
            Console.ReadLine();
        }
    }
}
