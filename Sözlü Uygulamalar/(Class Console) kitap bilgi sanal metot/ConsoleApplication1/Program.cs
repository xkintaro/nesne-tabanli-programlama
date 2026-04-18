using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class KitapBilgi
    {
        public int sayfaSayisi;
        public string kitapKonusu;

        public int KitapSayfaSayisi = 300;
        public string KitapKitapKonusu = "Tarih";

        public int DergiSayfaSayisi = 250;
        public string DergiKitapKonusu = "Doğal Afetler";

        public int AnsiklopediSayfaSayisi = 700;
        public string AnsiklopediKitapKonusu = "Dünyanın Oluşumu";

        public KitapBilgi()
        {
        }
        public virtual int SayfaSayisiniGöster()
        {
            return sayfaSayisi;
        }
        public virtual string KitapKonusuBilgi()
        {
            return kitapKonusu;
        }
    }
    public class Kitap : KitapBilgi
    {
        public override int SayfaSayisiniGöster()
        {
            return KitapSayfaSayisi;
        }
        public override string KitapKonusuBilgi()
        {
            return KitapKitapKonusu;
        }
    }
    public class Dergi : KitapBilgi
    {
        public override int SayfaSayisiniGöster()
        {
            return DergiSayfaSayisi;
        }
        public override string KitapKonusuBilgi()
        {
            return DergiKitapKonusu;
        }
    }
    public class Ansiklopedi : KitapBilgi
    {
        public override int SayfaSayisiniGöster()
        {
            return AnsiklopediSayfaSayisi;
        }
        public override string KitapKonusuBilgi()
        {
            return AnsiklopediKitapKonusu;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap();
            Dergi d = new Dergi();
            Ansiklopedi a = new Ansiklopedi();
            Console.WriteLine("Kitap Konusu = " + k.KitapKonusuBilgi());
            Console.WriteLine("Kitap Sayfası Sayısı = " + k.SayfaSayisiniGöster());
            Console.WriteLine("");
            Console.WriteLine("Dergi Konusu = " + d.KitapKonusuBilgi());
            Console.WriteLine("Dergi Sayfa sayısı = " + d.SayfaSayisiniGöster());
            Console.WriteLine("");
            Console.WriteLine("Ansiklopedi Konusu = " + a.KitapKonusuBilgi());
            Console.WriteLine("Ansiklopedi Sayfa Sayısı = " + a.SayfaSayisiniGöster());
            Console.ReadKey();
        }
    }
}
