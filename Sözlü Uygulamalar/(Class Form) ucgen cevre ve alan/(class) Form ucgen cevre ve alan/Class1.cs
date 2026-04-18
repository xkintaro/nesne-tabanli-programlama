using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _class__Form_ucgen_cevre_ve_alan
{
    class ucgen
    {
        private int a, b, c;
        public ucgen(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }          
        public int cevrehesapla()
        {
            return a + b + c;
        }
        public int alanhesapla()
        {
            return (a * b) / 2;
        }
    }
}
