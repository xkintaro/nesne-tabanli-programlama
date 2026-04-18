using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Class_Form__Daire_alan_ve_cevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {                  
           double  yaricap = Convert.ToDouble(textBox1.Text);

            daire d = new daire();

            label1.Text = d.cevre(yaricap).ToString();
            label2.Text = d.alan(yaricap).ToString();
        }
    }
}
