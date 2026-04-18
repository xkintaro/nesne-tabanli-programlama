using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Metod_sonlandırma
{
    class ekran
    {
        public void ekranayaz(params int[] sayi)
        {
            if (sayi.Length == 0)
            {
                Console.WriteLine("Parametre Olmadığı İçin Metotdan Çıkılıyor");
                return;
            }
            Console.WriteLine("Parametreden Gelen Değerler");
            foreach (var i in sayi)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ekran e = new ekran();
            e.ekranayaz(5,8,6,4,8,4,5,4,58,85,47,4,4);
            e.ekranayaz(0);
            Console.ReadKey();
        }
    }
}

























































































































