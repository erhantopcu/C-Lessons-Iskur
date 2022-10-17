using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotOrtalamasıMF
{
    public partial class Form1 : Form
    {
        double not1, not2, ort;
        string ogr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            double a = 5;
           
            for (int i = 0; i < a; i++)
            {
                //start1:
                //try
                //{
                    not1 = Convert.ToDouble(textBox1.Text);
                    not2 = Convert.ToDouble(textBox2.Text);
                    //if (not1 >= 0 && not2 >= 0)
                    //{
                        ort = (not1 + not2) / 2;
                        
                        ogr = ($"{i + 1} . Ogrenci notu = ");
                        listBox1.Items.Add(ogr + ort);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("hata");
                    //    goto start1;

                    //}


                //}
                //catch (Exception)
                //{

                //    //MessageBox.Show("hata");
                //    //goto start1;
                //    throw;
                //}

                textBox1.Clear();
                textBox2.Clear();
            }  
            

        }
    }
}
