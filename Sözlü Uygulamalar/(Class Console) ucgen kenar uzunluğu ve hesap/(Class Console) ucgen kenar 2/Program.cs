using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__ucgen_kenar_2
{
    class ucgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı Giriş");
                else if (value > 0)
                    a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı Giriş");
                else if (value > 0)
                    b = value;
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı Giriş");
                else if (value > 0)
                    c = value;
            }
        }
        public int cevre
        {
            get { return A + B + C; }
        }
        public int alan
        {
            get { return (A * B) / 2; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ucgen u = new ucgen();

            Console.WriteLine("Üç Adet Değer Giriniz");
            u.A = Convert.ToInt32(Console.ReadLine());
            u.B = Convert.ToInt32(Console.ReadLine());
            u.C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Birinci Kenar Uzunlıuğu {0}'Cm", u.A);
            Console.WriteLine("İkinci Kenar Uzunluğu {0}'Cm", u.B);
            Console.WriteLine("Üçüncü Kenar Uzunluğu {0}'Cm", u.C);
            Console.WriteLine("");
            Console.WriteLine("Üçgenin Çevresi {0}'Cm", u.cevre);
            Console.WriteLine("Üçgenin Alanı {0}'Cm", u.alan);
            Console.ReadLine();
        }
    }
}
