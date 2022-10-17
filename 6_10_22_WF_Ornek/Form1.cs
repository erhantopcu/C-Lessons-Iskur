using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_10_22_WF_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam = 0, cikarma = 0, bolme = 0, carpma = 0;
            

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox5.Text);
            

            switch (comboBox1.Text)
            {
                case "+":

                    toplam = sayi1 + sayi2;
                    Sonuc.Text = Convert.ToString(toplam);
                    textBox1.Clear();
                    textBox5.Clear();
                    comboBox1.Text = " ";
                    break;
                case "-":
                    cikarma = sayi1 - sayi2;
                    Sonuc.Text = Convert.ToString(cikarma);
                    textBox1.Clear();
                    textBox5.Clear();
                    comboBox1.Text = " ";

                    break;
                case "/":
                    bolme = sayi1 / sayi2;
                    Sonuc.Text = Convert.ToString(bolme);
                    textBox1.Clear();
                    textBox5.Clear();
                    comboBox1.Text = " ";
                    break;
                case "*":
                    carpma = sayi1 * sayi2;
                    Sonuc.Text = Convert.ToString(carpma);
                    textBox1.Clear();
                    textBox5.Clear();
                    comboBox1.Text = " ";
                    break;
      
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
