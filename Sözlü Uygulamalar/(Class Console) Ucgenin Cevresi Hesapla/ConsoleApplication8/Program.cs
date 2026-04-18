using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Ucgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0) Console.WriteLine("Hatalı Bilgi");
                else a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0) Console.WriteLine("Hatalı Bilgi");
                else b = value;
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0) Console.WriteLine("Hatalı Bilgi");
                else c = value;
            }
        }

        public int cevre
        {
            get { return a + b + c; }
        }

    }
    class Program
    {


        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 50;
            ucgen.B = 20;
            ucgen.C = 30;
            Console.WriteLine("Ucgenin cevresi= {0}", ucgen.cevre);
           
            Console.Read();
        }
    }
}
