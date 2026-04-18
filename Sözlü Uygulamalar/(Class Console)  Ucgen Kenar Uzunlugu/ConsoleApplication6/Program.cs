using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Ucgen
    {
        public int a;
        public int b;
        public int c;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen uck = new Ucgen();
            uck.a = Convert.ToInt32(Console.ReadLine());
            uck.b = 350;
            uck.c = 270;

            Console.WriteLine(" Ücgenin a kenarı uzunluğu {0} cm", uck.a);
            Console.WriteLine("Ücgenin b kenarı uzunluğu {0} cm", uck.b);
            Console.WriteLine("Ücgenin c kenarı uzunluğu {0} cm", uck.c);
            Console.ReadLine();
        }
    }
}
