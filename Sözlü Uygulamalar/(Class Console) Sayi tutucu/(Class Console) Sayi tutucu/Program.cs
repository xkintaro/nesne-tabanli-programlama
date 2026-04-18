using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Sayi_tutucu
{
    class sayitutucu
    {
        public int A
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int say1 = 10;
            int say2 = say1;
            say2 = 50;
            Console.WriteLine("say1 = {0}", say1);
            Console.WriteLine("say2 = {0}", say2);
            sayitutucu st1 = new sayitutucu();
            st1.A = 10;
            sayitutucu st2 = st1;
            st2.A = 50;
            Console.WriteLine("");
            Console.WriteLine("st1.A değeri = {0}", st1.A);
            Console.WriteLine("st2.A değeri = {0}", st2.A);
            Console.ReadKey();
        }
    }
}
