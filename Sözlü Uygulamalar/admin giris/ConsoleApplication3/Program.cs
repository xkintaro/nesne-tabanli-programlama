using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    class data
    {
        public string kullanıcı(string hesap, int sifre)
        {
            if (hesap == "mustafa" && sifre == 123)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Yanlış.");
            }
            return hesap;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            data d = new data();
            Console.WriteLine("Kullanıcı Adı Giriniz:");
            string hesap = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Şifrenizi Giriniz:");
            int sifre = Convert.ToInt32(Console.ReadLine());
            d.kullanıcı(hesap, sifre);
            Console.ReadKey();
        }
    }

}
