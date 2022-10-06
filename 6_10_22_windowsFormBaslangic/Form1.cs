using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_10_22_windowsFormBaslangic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            int sayi1 = 5;
            int sayi2 = 10;
            int toplam = 0;
            toplam = sayi1 + sayi2;
            MessageBox.Show("Toplam = " + toplam);

            textBox1.Text = Convert.ToString(textBox3.Text);
        }

        private void ad1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
