using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = . ; initial Catalog = Northwind; user = sa; password = 1234");

        public void KatEkle()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Categories", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            KatEkle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text;
            

            SqlCommand komut = new SqlCommand();
            komut.CommandText = String.Format("insert into Categories(CategoryName,Description)values('{0}','{1}')", name,description);

            komut.Connection = baglanti;
            baglanti.Open();

            int eklenti2 = komut.ExecuteNonQuery();
            baglanti.Close();

            if (eklenti2 > 0)
            {
                MessageBox.Show("Başarılı");
                KatEkle();
            }
            else
            {
                MessageBox.Show("Eklenmedi");

            }
            baglanti.Close();
        }

      
    }
}
