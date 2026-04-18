using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Console__soyut_sınıflar_otomobil
{
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int MotorYili { get; set; }

        public abstract void calis();
        public abstract void dur();
    }
    public class Otomobil : MotorluArac
    {
        public bool Otomatilvites { get; set; }
        public override void calis()
        {
            Console.WriteLine("Otomobil Çalıştı");
        }
        public override void dur()
        {
            Console.WriteLine("Otomobil durdu");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil
            {
                MotorYili = 2018,
                MotorHacmi = 1600,
                Otomatilvites = true
            };
            MotorluArac mo = oto;
            oto.calis();
            Console.WriteLine("");
            Console.WriteLine("Model Yılı = " + oto.MotorYili);
            Console.WriteLine("Motor Hacmi = " + oto.MotorHacmi);
            Console.WriteLine("Otomatik Vites = " + oto.Otomatilvites);
            Console.WriteLine("");
            oto.dur();
            Console.Read();
        }
    }
}
