using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerstenCumleMF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string metin, gg;
        private void button1_Click(object sender, EventArgs e)
        {
            metin = Convert.ToString(textBox1.Text);
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                gg = gg + metin[i].ToString();
            }
            label1.Text = Convert.ToString(gg);
        }
    }
}
