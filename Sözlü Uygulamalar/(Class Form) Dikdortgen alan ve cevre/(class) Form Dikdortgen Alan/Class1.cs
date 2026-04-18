using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _class__Form_Dikdortgen_Alan
{
    class dikdorgen
    {
        public int a, b;
        public dikdorgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int alanhesapla()
        {
            return a * b;
        }
        public int cevrehesapla()
        {
            return 2 * (a + b);
        }
    }

}
