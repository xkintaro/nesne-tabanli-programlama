using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte ortalama;
            ortalama = Convert.ToByte(textBox1.Text);
            if (ortalama >= 50)
            {
                if (ortalama >= 85)
                {
                    MessageBox.Show("Takdir Belgesi Almaya Hak Kazandınız.");
                }
                else if (ortalama >= 70)
                {
                    MessageBox.Show("Teşekkür Belgesi Almaya Hak Kazandınız.");
                }
                else
                {
                    MessageBox.Show("Belge Almadan Sınıf Geçtiniz.");
                }
            }
            else
            {
                MessageBox.Show("Sınıf Geçmek İçin Yeterli Not Alamadınız.");
            }

        }
    }
}
