using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class saybulucu
    {
        public bool sayibul(int say1)
        {
            bool sonuc;
            if (say1 % 2 == 0)
            {
                sonuc = true;               
                Console.WriteLine("Bu sayı çifttir");
            }
           else 
            {
                sonuc = false;
                Console.WriteLine("Bu sayı tektir");
            }
            return sonuc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            saybulucu sb = new saybulucu();
            Console.WriteLine("Bir Adet Sayı Giriniz");
            int say1 = Convert.ToInt32 (Console.ReadLine());
            bool sonuc = sb.sayibul(say1);
            Console.WriteLine("{0}", sonuc);
            Console.ReadLine();
        }
    }
}
