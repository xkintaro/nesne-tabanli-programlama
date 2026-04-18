using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__sanal_metot_daire
{
    public class Sekil
    {
        public const double pi = 3.14;
        protected double y, x, z;
        public Sekil()
        {

        }
        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double AlanHesapla()
        {
            return x * y;
        }
        public virtual void BilgiYazdir()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
    public class Daire : Sekil
    {
        public Daire(double r) : base(r, 0)
        {

        }
        public override double AlanHesapla()
        {
            return pi * x * x;
        }
        public override void BilgiYazdir()
        {
            Console.WriteLine("x = " + x);
        }
    }
    public class Kare : Sekil
    {
        public Kare(double x)
        {
            this.x = x;

        }
        public override double AlanHesapla()
        {
            return x * x;
        }
        public override void BilgiYazdir()
        {
            Console.WriteLine("x = " + x);
        }
    }
    public class Ucgen : Sekil
    {
        public Ucgen(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override double AlanHesapla()
        {
            return (x * y) / 2;
        }
        public override void BilgiYazdir()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sekil s = new Sekil(5, 6);
            Daire d = new Daire(4);
            Kare k = new Kare(5);
            Ucgen u = new Ucgen(5, 3);
            s.BilgiYazdir();
            Console.WriteLine("Sekil Alanı = " + s.AlanHesapla());

            Console.WriteLine("");

            d.BilgiYazdir();
            Console.WriteLine("Dairenin Alanı = " + d.AlanHesapla());

            Console.WriteLine(" ");

            k.BilgiYazdir();
            Console.WriteLine("Karenin Alanı = " + k.AlanHesapla());

            Console.WriteLine(" ");

            u.BilgiYazdir();
            Console.WriteLine("Üçgenin Alanı = " + u.AlanHesapla());
            Console.ReadKey();
        }
    }
}


