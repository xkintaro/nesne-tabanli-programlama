using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__soyut_sınıf_kitap_bilgi
{
    public abstract class KitapBilgi
    {
        public string Kitap { get; set; }
        public string Dergi { get; set; }
        public string Ansiklopedi { get; set; }
        public abstract void Oku();
    }
    public class kitap : KitapBilgi
    {
        public override void Oku()
        {
            Console.WriteLine("Kitap Okunuyor.");
        }
    }
    public class Dergi : KitapBilgi
    {
        public override void Oku()
        {
            Console.WriteLine("Dergi okunuyor.");
        }
    }
    public class Ansiklopedi : KitapBilgi
    {
        public override void Oku()
        {
            Console.WriteLine("Ansiklopedi Okunuyor.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            kitap k = new kitap
            {
                Kitap = "Tarih"
            };
            Dergi d = new Dergi
            {
                Dergi = "Magazin"
            };
            Ansiklopedi a = new Ansiklopedi
            {
                Ansiklopedi = "Dinazorlar"
            };

            kitap ktp = k;
            Dergi drgi = d;
            Ansiklopedi ansklpdi = a;

            k.Oku();
            Console.WriteLine("Kitap Türü = " + ktp.Kitap);
            Console.WriteLine("");
            d.Oku();
            Console.WriteLine("Dergi Türü = " + drgi.Dergi);
            Console.WriteLine("");
            a.Oku();
            Console.WriteLine("Ansiklopedi türü = " + ansklpdi.Ansiklopedi);

            Console.Read();
        }
    }
}
