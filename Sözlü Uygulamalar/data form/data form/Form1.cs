using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            if (textBox1.Text == "mustafa"
               || textBox2.Text == "ta***"
               || textBox3.Text == "119"
               || textBox4.Text == "2006"
               || textBox5.Text == "+90552*******"
               || textBox6.Text == "a****"
               || textBox7.Text == "sa****"
               || textBox8.Text == "lise"
               || textBox9.Text == "konya"
               || textBox10.Text == "selcuklu")
            {
                comboBox1.Items.Add("Ad = Mustafa");
                comboBox1.Items.Add("SoyAd = TAŞAL");
                comboBox1.Items.Add("Tc = 119396*****");
                comboBox1.Items.Add("Doğum Yılı = 2006");
                comboBox1.Items.Add("Telefon Numarası = +90552*******");
                comboBox1.Items.Add("Ana Adı = ay***");
                comboBox1.Items.Add("Baba Adı = sa****");
                comboBox1.Items.Add("Eğitim Düzeyi = Lise");
                comboBox1.Items.Add("Yaşadığı İl = konya");
                comboBox1.Items.Add("Yaşadığı İlçe = Selçuklu");
            }
            */
              if (textBox1.Text == "talha"
                     || textBox2.Text == "turk"
                     || textBox3.Text == "119********"
                     || textBox4.Text == "2006"
                     || textBox5.Text == "+90533*******"
                     || textBox6.Text == "la*****"
                     || textBox7.Text == "su*****"
                     || textBox8.Text == "acık"
                     || textBox9.Text == "konya"
                     || textBox10.Text == "karatay")
               {
                   comboBox1.Items.Add("Ad = Talha");
                   comboBox1.Items.Add("SoyAd = TÜRK");
                   comboBox1.Items.Add("Tc = 119********");
                   comboBox1.Items.Add("Doğum Yılı = 2006");
                   comboBox1.Items.Add("Telefon Numarası = +90533******");
                   comboBox1.Items.Add("Ana Adı = la*****");
                   comboBox1.Items.Add("Baba Adı = su*****");
                   comboBox1.Items.Add("Eğitim Düzeyi = Açık Lise");
                   comboBox1.Items.Add("Yaşadığı İl = konya");
                   comboBox1.Items.Add("Yaşadığı İlçe = Karatay");
               } 
        }
    }
}
