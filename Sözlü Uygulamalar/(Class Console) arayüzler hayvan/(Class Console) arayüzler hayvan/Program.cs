using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__arayüzler_hayvan
{
    interface IHayvan
    {
        void sesCikar();
    }
    interface IBeslen
    {
        void Beslen();
    }
    public class Kedi : IHayvan, IBeslen
    {
        public void sesCikar()
        {
            Console.WriteLine("Kedi: Miyavv Miyavv");
        }
        public void Beslen()
        {
            Console.WriteLine("Kedi Süt İçiyor.");
        }
    }
    public class Kopek : IHayvan, IBeslen
    {
        public void sesCikar()
        {
            Console.WriteLine("Köpek: Havv Havv");
        }
        public void Beslen()
        {
            Console.WriteLine("Köpek Mama Yiyor.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kedi cat = new Kedi();
            Kopek dog = new Kopek();
            cat.sesCikar();
            cat.Beslen();        
            dog.sesCikar();
            dog.Beslen();
            Console.WriteLine("--------------------------------------------");
       /*     IHayvan hayvankedi = cat;
            IHayvan hayvankopek = dog;
            IBeslen beslenkedi = cat;
            IBeslen beslenkopek = dog;
            hayvankedi.sesCikar();
            hayvankopek.sesCikar();
            7 */
            Console.Read();
        }
    }
}
