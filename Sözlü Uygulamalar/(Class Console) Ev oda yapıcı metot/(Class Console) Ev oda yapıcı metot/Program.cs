using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__Ev_oda_yapıcı_metot
{
    class evclass
    {
        int metrekare;
        int odasayisi;
        public evclass()
        {
            metrekare = 100;
            odasayisi = 5;
            Console.WriteLine("Yapıcı Metot çalıştı.");
        }
        public int metrekareee
        {
            get
            {
                return metrekare;
            }
        }
        public int odasayisiii
        {
            get
            {
                return odasayisi;
            }
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program basladı");
            evclass ec = new evclass();
            Console.WriteLine("Oda Sayısı = " + ec.odasayisiii);
            Console.WriteLine("Metre Kare = " + ec.metrekareee);
            Console.ReadKey();
        }
    }
}
