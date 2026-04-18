using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class sayiislem
    {
        public int topla ( int say1 ,int say2 , int say3)
        {
            return say1 + say2 + say3;
        }
        public int carp(int say1, int say2, int say3)
        {
            return say1 * say2 * say3;
        }
        public int fark (int say1,int say2,int say3)
        {
            return say1 - say2 - say3;
        }
        public double   bolum(double  say1, double  say2, double  say3)
        {
            return say1 / say2 / say3;
        }
        public double  ort(double  say1, double  say2, double  say3)
        {
            return (say1 + say2 + say3) / 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sayiislem si = new sayiislem();
            Console.WriteLine("Üç Adet Sayı Giriniz");
            int say1 = Convert.ToInt32(Console.ReadLine());
            int say2 = Convert.ToInt32(Console.ReadLine());
            int say3 = Convert.ToInt32(Console.ReadLine());
            int toplam = si.topla(say1, say2, say3);
            int carpım = si.carp(say1, say2, say3);
            int farkl = si.fark(say1, say2, say3);
            double  bolme = si.bolum(say1, say2, say3);
            double ortalama = si.ort(say1, say2, say3);
            Console.WriteLine("Sayıların toplamı {0}", toplam);
            Console.WriteLine("Sayıların çarpımı {0}", carpım);
            Console.WriteLine("Sayıların farkı {0}",farkl);
            Console.WriteLine("Sayıların Bölümü {0}",bolme );
            Console.WriteLine("Sayıların Ortalaması {0}",ortalama );
            Console.ReadLine();        
        }
    }
}
