using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, topla;
            ad = "Zeynep";
            soyad = "Sare";
            topla = ad + " " + soyad;
            MessageBox.Show(topla);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "25";
            textBox2.Text = "2";
            textBox3.Text = textBox1.Text + textBox2.Text;
        }
    }
}
        
    

