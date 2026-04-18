using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carpim_tablosu_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
        }
        public class İkiler : CarpimTablosuMateryal
        {
            public int İkiKereBir()
            {
                return iki * bir;
            }
            public int İkiKereİki()
            {
                return iki * iki;
            }
            public int İkiKereUc()
            {
                return iki * uc;
            }
            public int İkiKereDort()
            {
                return iki * dort;
            }
            public int İkiKereBes()
            {
                return iki * bes;
            }
            public int İkiKereAlti()
            {
                return iki * alti;
            }
            public int İkikereYedi()
            {
                return iki * yedi;
            }
            public int İkiKereSekiz()
            {
                return iki * sekiz;
            }
            public int İkiKereDokuz()
            {
                return iki * dokuz;
            }
            public int İkiKereOn()
            {
                return iki * on;
            }
        }
        public class Ucler : CarpimTablosuMateryal
        {
            public int UcKereBir()
            {
                return uc * bir;
            }
            public int UcKereİki()
            {
                return uc * iki;
            }
            public int UcKereUc()
            {
                return uc * uc;
            }
            public int UcKereDort()
            {
                return uc * dort;
            }
            public int UckereBes()
            {
                return uc * bes;
            }
            public int UcKereAlti()
            {
                return uc * alti;
            }
            public int UcKereYedi()
            {
                return uc * yedi;
            }
            public int UckereSekiz()
            {
                return uc * sekiz;
            }
            public int UcKereDokuz()
            {
                return uc * dokuz;
            }
            public int UcKereOn()
            {
                return uc * on;
            }
        }
        public class Dortler : CarpimTablosuMateryal
        {
            public int DortKereBir()
            {
                return dort * bir;
            }
            public int DortKereİki()
            {
                return dort * iki;
            }
            public int DortKereUc()
            {
                return dort * uc;
            }
            public int DortKereDort()
            {
                return dort * dort;
            }
            public int DortKereBes()
            {
                return dort * bes;
            }
            public int DortKereAlti()
            {
                return dort * alti;
            }
            public int DortKereYedi()
            {
                return dort * yedi;
            }
            public int DortKereSekiz()
            {
                return dort * sekiz;
            }
            public int DortKereDokuz()
            {
                return dort * dokuz;
            }
            public int DortKereOn()
            {
                return dort * on;
            }
        }
        public class Besler : CarpimTablosuMateryal
        {
            public int BesKereBir()
            {
                return bes * bir;
            }
            public int BesKereİki()
            {
                return bes * iki;
            }
            public int BesKereUc()
            {
                return bes * uc;
            }
            public int BesKereDort()
            {
                return bes * dort;
            }
            public int BesKereBes()
            {
                return bes * bes;
            }
            public int BesKereAlti()
            {
                return bes * alti;
            }
            public int BesKereYedi()
            {
                return bes * yedi;
            }
            public int BesKereSekiz()
            {
                return bes * sekiz;
            }
            public int BesKereDokuz()
            {
                return bes * dokuz;
            }
            public int BesKereOn()
            {
                return bes * on;
            }
        }
        public class Altilar : CarpimTablosuMateryal
        {
            public int AltiKereBir()
            {
                return alti * bir;
            }
            public int AltiKereİki()
            {
                return alti * iki;
            }
            public int AltiKereUc()
            {
                return alti * uc;
            }
            public int AltiKereDort()
            {
                return alti * dort;
            }
            public int AltiKereBes()
            {
                return alti * bes;
            }
            public int AltiKereAlti()
            {
                return alti * alti;
            }
            public int AltiKereYedi()
            {
                return alti * yedi;
            }
            public int AltiKereSekiz()
            {
                return alti * sekiz;
            }
            public int AltiKereDokuz()
            {
                return alti * dokuz;
            }
            public int AltiKereOn()
            {
                return alti * on;
            }
        }
        public class Yediler : CarpimTablosuMateryal
        {
            public int YediKereBir()
            {
                return yedi * bir;
            }
            public int YediKereİki()
            {
                return yedi * iki;
            }
            public int YediKereUc()
            {
                return yedi * uc;
            }
            public int YediKereDort()
            {
                return yedi * dort;
            }
            public int YediKereBes()
            {
                return yedi * bes;
            }
            public int YediKereAlti()
            {
                return yedi * alti;
            }
            public int YediKereYedi()
            {
                return yedi * yedi;
            }
            public int YediKereSekiz()
            {
                return yedi * sekiz;
            }
            public int YediKereDokuz()
            {
                return yedi * dokuz;
            }
            public int YediKereOn()
            {
                return yedi * on;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Birler birler = new Birler();
            listBox1.Items.Add("Birler");
            listBox1.Items.Add("1 x 1 = " + birler.BirKereBir());
            listBox1.Items.Add("1 x 2 = " + birler.BirKereiki());
            listBox1.Items.Add("1 x 3 = " + birler.BirKereUc());
            listBox1.Items.Add("1 x 4 = " + birler.BirKereDort());
            listBox1.Items.Add("1 x 5 = " + birler.BirKereBes());
            listBox1.Items.Add("1 x 6 = " + birler.BirKereAlti());
            listBox1.Items.Add("1 x 7 = " + birler.BirKereYedi());
            listBox1.Items.Add("1 x 8 = " + birler.BirKereSekiz());
            listBox1.Items.Add("1 x 9 = " + birler.BirKereDokuz());
            listBox1.Items.Add("1 x 10 = " + birler.BirKereOn());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İkiler ikiler = new İkiler();
            listBox2.Items.Add("İkiler");
            listBox2.Items.Add("2 x 1 = " + ikiler.İkiKereBir());
            listBox2.Items.Add("2 x 2 = " + ikiler.İkiKereİki());
            listBox2.Items.Add("2 x 3 = " + ikiler.İkiKereUc());
            listBox2.Items.Add("2 x 4 = " + ikiler.İkiKereDort());
            listBox2.Items.Add("2 x 5 = " + ikiler.İkiKereBes());
            listBox2.Items.Add("2 x 6 = " + ikiler.İkiKereAlti());
            listBox2.Items.Add("2 x 7 = " + ikiler.İkikereYedi());
            listBox2.Items.Add("2 x 8 = " + ikiler.İkiKereSekiz());
            listBox2.Items.Add("2 x 9 = " + ikiler.İkiKereDokuz());
            listBox2.Items.Add("2 x 10 = " + ikiler.İkiKereOn());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ucler ucler = new Ucler();
            listBox3.Items.Add("Üçler");
            listBox3.Items.Add("3 x 1 = " + ucler.UcKereBir());
            listBox3.Items.Add("3 x 2 = " + ucler.UcKereİki());
            listBox3.Items.Add("3 x 3 = " + ucler.UcKereUc());
            listBox3.Items.Add("3 x 4 = " + ucler.UcKereDort());
            listBox3.Items.Add("3 x 5 = " + ucler.UckereBes());
            listBox3.Items.Add("3 x 6 = " + ucler.UcKereAlti());
            listBox3.Items.Add("3 x 7 = " + ucler.UcKereYedi());
            listBox3.Items.Add("3 x 8 = " + ucler.UckereSekiz());
            listBox3.Items.Add("3 x 9 = " + ucler.UcKereDokuz());
            listBox3.Items.Add("3 x 10 = " + ucler.UcKereOn());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dortler dortler = new Dortler();
            listBox4.Items.Add("Dörtler");
            listBox4.Items.Add("4 x 1 = " + dortler.DortKereBir());
            listBox4.Items.Add("4 x 2 = " + dortler.DortKereİki());
            listBox4.Items.Add("4 x 3 = " + dortler.DortKereUc());
            listBox4.Items.Add("4 x 4 = " + dortler.DortKereDort());
            listBox4.Items.Add("4 x 5 = " + dortler.DortKereBes());
            listBox4.Items.Add("4 x 6 = " + dortler.DortKereAlti());
            listBox4.Items.Add("4 x 7 = " + dortler.DortKereYedi());
            listBox4.Items.Add("4 x 8 = " + dortler.DortKereSekiz());
            listBox4.Items.Add("4 x 9 = " + dortler.DortKereDokuz());
            listBox4.Items.Add("4 x 10 = " + dortler.DortKereOn());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Besler besler = new Besler();

            listBox5.Items.Add("5 x 1 = " + besler.BesKereBir());
            listBox5.Items.Add("5 x 2 = " + besler.BesKereİki());
            listBox5.Items.Add("5 x 3 = " + besler.BesKereUc());
            listBox5.Items.Add("5 x 4 = " + besler.BesKereDort());
            listBox5.Items.Add("5 x 5 = " + besler.BesKereBes());
            listBox5.Items.Add("5 x 6 = " + besler.BesKereAlti());
            listBox5.Items.Add("5 x 7 = " + besler.BesKereYedi());
            listBox5.Items.Add("5 x 8 = " + besler.BesKereSekiz());
            listBox5.Items.Add("5 x 9 = " + besler.BesKereDokuz());
            listBox5.Items.Add("5 x 10 = " + besler.BesKereOn());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e) //tümü
        {
            Birler birler = new Birler();
            //   listBox1.Items.Add("Birler");
            listBox1.Items.Add("1 x 1 = " + birler.BirKereBir());
            listBox1.Items.Add("1 x 2 = " + birler.BirKereiki());
            listBox1.Items.Add("1 x 3 = " + birler.BirKereUc());
            listBox1.Items.Add("1 x 4 = " + birler.BirKereDort());
            listBox1.Items.Add("1 x 5 = " + birler.BirKereBes());
            listBox1.Items.Add("1 x 6 = " + birler.BirKereAlti());
            listBox1.Items.Add("1 x 7 = " + birler.BirKereYedi());
            listBox1.Items.Add("1 x 8 = " + birler.BirKereSekiz());
            listBox1.Items.Add("1 x 9 = " + birler.BirKereDokuz());
            listBox1.Items.Add("1 x 10 = " + birler.BirKereOn());
            İkiler ikiler = new İkiler();
            //  listBox2.Items.Add("İkiler");
            listBox2.Items.Add("2 x 1 = " + ikiler.İkiKereBir());
            listBox2.Items.Add("2 x 2 = " + ikiler.İkiKereİki());
            listBox2.Items.Add("2 x 3 = " + ikiler.İkiKereUc());
            listBox2.Items.Add("2 x 4 = " + ikiler.İkiKereDort());
            listBox2.Items.Add("2 x 5 = " + ikiler.İkiKereBes());
            listBox2.Items.Add("2 x 6 = " + ikiler.İkiKereAlti());
            listBox2.Items.Add("2 x 7 = " + ikiler.İkikereYedi());
            listBox2.Items.Add("2 x 8 = " + ikiler.İkiKereSekiz());
            listBox2.Items.Add("2 x 9 = " + ikiler.İkiKereDokuz());
            listBox2.Items.Add("2 x 10 = " + ikiler.İkiKereOn());
            Ucler ucler = new Ucler();
            //     listBox3.Items.Add("Üçler");
            listBox3.Items.Add("3 x 1 = " + ucler.UcKereBir());
            listBox3.Items.Add("3 x 2 = " + ucler.UcKereİki());
            listBox3.Items.Add("3 x 3 = " + ucler.UcKereUc());
            listBox3.Items.Add("3 x 4 = " + ucler.UcKereDort());
            listBox3.Items.Add("3 x 5 = " + ucler.UckereBes());
            listBox3.Items.Add("3 x 6 = " + ucler.UcKereAlti());
            listBox3.Items.Add("3 x 7 = " + ucler.UcKereYedi());
            listBox3.Items.Add("3 x 8 = " + ucler.UckereSekiz());
            listBox3.Items.Add("3 x 9 = " + ucler.UcKereDokuz());
            listBox3.Items.Add("3 x 10 = " + ucler.UcKereOn());
            Dortler dortler = new Dortler();
            //   listBox4.Items.Add("Dörtler");
            listBox4.Items.Add("4 x 1 = " + dortler.DortKereBir());
            listBox4.Items.Add("4 x 2 = " + dortler.DortKereİki());
            listBox4.Items.Add("4 x 3 = " + dortler.DortKereUc());
            listBox4.Items.Add("4 x 4 = " + dortler.DortKereDort());
            listBox4.Items.Add("4 x 5 = " + dortler.DortKereBes());
            listBox4.Items.Add("4 x 6 = " + dortler.DortKereAlti());
            listBox4.Items.Add("4 x 7 = " + dortler.DortKereYedi());
            listBox4.Items.Add("4 x 8 = " + dortler.DortKereSekiz());
            listBox4.Items.Add("4 x 9 = " + dortler.DortKereDokuz());
            listBox4.Items.Add("4 x 10 = " + dortler.DortKereOn());
            Besler besler = new Besler();
            //listBox5.Items.Add("Beşler");
            listBox5.Items.Add("5 x 1 = " + besler.BesKereBir());
            listBox5.Items.Add("5 x 2 = " + besler.BesKereİki());
            listBox5.Items.Add("5 x 3 = " + besler.BesKereUc());
            listBox5.Items.Add("5 x 4 = " + besler.BesKereDort());
            listBox5.Items.Add("5 x 5 = " + besler.BesKereBes());
            listBox5.Items.Add("5 x 6 = " + besler.BesKereAlti());
            listBox5.Items.Add("5 x 7 = " + besler.BesKereYedi());
            listBox5.Items.Add("5 x 8 = " + besler.BesKereSekiz());
            listBox5.Items.Add("5 x 9 = " + besler.BesKereDokuz());
            listBox5.Items.Add("5 x 10 = " + besler.BesKereOn());
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            //  listBox1.Items.Add("Birler");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.Items.Clear();
            //   listBox2.Items.Add("İkiler");
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            listBox3.Items.Clear();
            //      listBox3.Items.Add("Üçler");
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            listBox4.Items.Clear();
            //    listBox4.Items.Add("Dörtler");
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            listBox5.Items.Clear();
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            listBox6.Items.Clear();
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            listBox7.Items.Clear();
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            listBox8.Items.Clear();
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            listBox9.Items.Clear();
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            listBox10.Items.Clear();
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            listBox1.Items.Add("Birler");
            listBox2.Items.Add("İkiler");
            listBox3.Items.Add("Üçler");
            listBox4.Items.Add("Dörtler");
        }
    }
}
