using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _class__Form_ucgen_cevre_ve_alan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int birincikenar = Convert.ToInt32(textBox1.Text);
            int ikincikenar = Convert.ToInt32(textBox2.Text);
            int ucuncukenar = Convert.ToInt32(textBox3.Text);

            ucgen uckn = new ucgen(birincikenar, ikincikenar, ucuncukenar);

            label1.Text = uckn.cevrehesapla().ToString();
            label7.Text = uckn.alanhesapla().ToString();
        }
    }
}
