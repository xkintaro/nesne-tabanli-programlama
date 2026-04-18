using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Class_Form__Karenin_cevresi_ve_alani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kareninkenari = Convert.ToInt32(textBox1.Text);

            kareislem kare = new kareislem(kareninkenari);

            label1.Text = kare.cevrehesapla().ToString();
            label2.Text = kare.alanhesapla().ToString();
        }
    }
}
