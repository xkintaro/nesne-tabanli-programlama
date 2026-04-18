using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sinifim
    {      
        public void Selamla(string ad)
        {
            Console.WriteLine("Merhaba " + ad);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sinifim s = new Sinifim();
            Console.WriteLine("İsminizi Giriniz");
            s.Selamla(ad);          
            Console.ReadLine();
        }
    }
}



