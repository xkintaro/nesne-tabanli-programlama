using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpim_tablosu_code
{
    public class CarpimTablosuMateryal
    {
        public int sifir = 0;
        public int bir = 1;
        public int iki = 2;
        public int uc = 3;
        public int dort = 4;
        public int bes = 5;
        public int alti = 6;
        public int yedi = 7;
        public int sekiz = 8;
        public int dokuz = 9;
        public int on = 10;
    }
    public class Birler : CarpimTablosuMateryal
    {
        public int BirKereBir()
        {
            return bir * bir;
        }
        public int BirKereiki()
        {
            return bir * iki;
        }
        public int BirKereUc()
        {
            return bir * uc;
        }
        public int BirKereDort()
        {
            return bir * dort;
        }
        public int BirKereBes()
        {
            return bir * bes;
        }
        public int BirKereAlti()
        {
            return bir * alti;
        }
        public int BirKereYedi()
        {
            return bir * yedi;
        }
        public int BirKereSekiz()
        {
            return bir * sekiz;
        }
        public int BirKereDokuz()
        {
            return bir * dokuz;
        }
        public int BirKereOn()
        {
            return bir * on;
        }
        public class İkiler : CarpimTablosuMateryal
        {

        }
        public class Ucler : CarpimTablosuMateryal
        {

        }
        public class Dortler : CarpimTablosuMateryal
        {

        }
        public class Besler : CarpimTablosuMateryal
        {

        }
        public class Altilar : CarpimTablosuMateryal
        {

        }
        public class Yediler : CarpimTablosuMateryal
        {

        }
        public class Sekizler : CarpimTablosuMateryal
        {

        }
        public class Dokuzlar : CarpimTablosuMateryal
        {

        }
        public class Onlar : CarpimTablosuMateryal
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Birler birler = new Birler();
            Console.WriteLine("1 x 1 = " + birler.BirKereBir());
            Console.WriteLine("1 x 2 = " + birler.BirKereiki());
            Console.WriteLine("1 x 3 = " + birler.BirKereUc());
            Console.WriteLine("1 x 4 = " + birler.BirKereDort());
            Console.WriteLine("1 x 5 = " + birler.BirKereBes());
            Console.WriteLine("1 x 6 = " + birler.BirKereAlti());
            Console.WriteLine("1 x 7 = " + birler.BirKereYedi());
            Console.WriteLine("1 x 8 = " + birler.BirKereSekiz());
            Console.WriteLine("1 x 9 = " + birler.BirKereDokuz());



            Console.Read();
        }
    }
}
