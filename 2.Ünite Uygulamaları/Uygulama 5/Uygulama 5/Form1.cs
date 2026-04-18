using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_Adi;
            kullanici_Adi = textBox1.Text;
            if (kullanici_Adi == "kintaro") 
            {
                MessageBox.Show("Kullanıcı Sisteme Kayıtlıdır");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
        }
    }
}
