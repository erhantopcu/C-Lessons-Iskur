using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukemmelSayi
{
    public partial class Form1 : Form
    {
        int sayi, toplam;
        string cevap1 = "Sayı mükemmel bir sayıdır.", cevap2 = "Sayı mükemmel değil.";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt16(textBox1.Text);
            toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)
            {
                label1.Text = Convert.ToString(cevap1);
            }
            else
            {
                label1.Text = Convert.ToString(cevap2);
            }
        }
    }
}
