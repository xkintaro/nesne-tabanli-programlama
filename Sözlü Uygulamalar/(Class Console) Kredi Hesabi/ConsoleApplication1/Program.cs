using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class program
    {
        class KrediHesabi
        {
            public long HesapNo;
            public double Limit;
            public string KartSahibi , KartSonKullanmaTarihi;
            
        }
        static void Main(string[] args)
        {

            KrediHesabi hesap = new KrediHesabi();
            hesap.HesapNo = 123456789;
            hesap.Limit = 1000000;
            hesap.KartSahibi = "Mustafa TAŞAL";
            hesap.KartSonKullanmaTarihi = "01 01 2025";

            Console.WriteLine(hesap.HesapNo);
            Console.WriteLine(hesap.Limit);
            Console.WriteLine(hesap.KartSahibi);
            Console.WriteLine(hesap.KartSonKullanmaTarihi);

            Console.ReadKey();
        }
    }
}
