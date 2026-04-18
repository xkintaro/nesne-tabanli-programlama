using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Class_Form__Karenin_cevresi_ve_alani
{
    class kareislem
    {
        private int a;
        public kareislem (int a)
        {
            this.a = a;
        }
        public int cevrehesapla()
        {
            return 4 * a;
        }
        public int alanhesapla()
        {
            return a * a;
        }
    }
}
