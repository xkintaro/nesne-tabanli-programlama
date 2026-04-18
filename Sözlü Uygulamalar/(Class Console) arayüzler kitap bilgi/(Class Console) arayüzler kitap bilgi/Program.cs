using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__arayüzler_kitap_bilgi
{
    interface IkitapOku
    {
        void Oku();
    }
   public class Kitap : IkitapOku
    {
        public void Oku()
        {
            Console.WriteLine("Kitap Okunuyor.");
        }
    }
    public class Dergi : IkitapOku
    {
        public void Oku()
        {
            Console.WriteLine("Dergi Okunuyor.");
        }
    }
    public class Ansiklopedi :IkitapOku
    {
        public void Oku()
        {
            Console.WriteLine("Ansiklopedi Okunuyor.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap();
            Dergi d = new Dergi();
            Ansiklopedi a = new Ansiklopedi();
            IkitapOku ktp = k;
            IkitapOku drgi = d;
            IkitapOku ansklpdi = a;
            ktp.Oku();
            drgi.Oku();
            ansklpdi.Oku();
            Console.Read();  
        }
    }
}
