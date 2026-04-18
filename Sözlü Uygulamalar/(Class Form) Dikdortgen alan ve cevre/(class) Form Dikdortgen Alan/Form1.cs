using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _class__Form_Dikdortgen_Alan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisakenar = Convert.ToInt32(textBox1.Text);
            int uzunkenar = Convert.ToInt32(textBox2.Text);

            dikdorgen d = new dikdorgen(kisakenar, uzunkenar);

            label1.Text = d.cevrehesapla().ToString();
            label2.Text = d.alanhesapla().ToString();
        }
    }
}
