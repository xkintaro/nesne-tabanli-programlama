using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__kalıtım_Bilgisayar
{
    public class Bilgisayar
    {
        public string marka { get; set; }
        public string renk { get; set; }
        public string surum { get; set; }
    }
    public class bilgisayarRam : Bilgisayar
    {
        public string ram { get; set; }
    }
    public class bilgisayarİslemci : Bilgisayar
    {
        public string islemci { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar ozellik = new Bilgisayar
            {
                marka = "Asus",
                renk = "Siyah",
                surum = "windows 10"
            };
            bilgisayarRam pcRam = new bilgisayarRam
            {
                ram = "8 gb"
            };
            bilgisayarİslemci pcislemci = new bilgisayarİslemci
            {
                islemci = "intel"
            };
            Bilgisayar pc = ozellik;
            bilgisayarRam pcramm = pcRam;
            bilgisayarİslemci pcislemciii = pcislemci;

            Console.WriteLine("Bilgisayar Markası = " + pc.marka);
            Console.WriteLine("Bigisayar Rengi = " + pc.renk);
            Console.WriteLine("Bilgisayar Sürümü = " + pc.surum);

            Console.WriteLine("Bilgisayar Ram = " + pcramm.ram);

            Console.WriteLine("Bilgisayar İslemcisi = " + pcislemciii.islemci);

            Console.ReadKey();
        }
    }
}
