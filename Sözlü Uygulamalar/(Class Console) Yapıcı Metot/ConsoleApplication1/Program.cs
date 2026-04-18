using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kisi
    {
        int yas;
        string ad;
        public Kisi()
        {
            yas = 19;
            ad = "Mustafa";
            Console.WriteLine("Yapıcı Metot Çalıstı");
        }
        public int Yas
        {
            get
            {
                return yas;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Basladı");
            Kisi k = new Kisi();
            Console.WriteLine("Adı = {0}", k.Ad);
            Console.WriteLine("Yası = {0}", k.Yas);
            Console.WriteLine("Program Bitti");
            Console.ReadKey();
        }
    }
}
