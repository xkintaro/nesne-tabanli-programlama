using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class sayibul
    {
        public int buyukbul(int say1, int say2)
        {
            int sonuc;
            if (say1 < say2)
            {
                sonuc = say2;        
            }
            else
                sonuc = say1 ;
            return sonuc;
        }
        public int kucukbul(int say1, int say2)
        {
            int karar;
            if (say1 < say2)
            {
                karar = say1; 
            }
            else
                karar = say2;
            return karar;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sayibul sb = new sayibul();
            sayibul kb = new sayibul();
            Console.WriteLine("İki adet sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sonuc = sb.buyukbul(a, b);
            int karar = kb.kucukbul(a, b);
            Console.WriteLine("Büyük OLan Sayı {0}", sonuc);
            Console.WriteLine("Küçük Olan Sayı {0}", karar);
            Console.ReadLine();
        }
    }
}
