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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = . ; initial Catalog = Northwind; user = sa; password = 1234");

        public void UrunEkle()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Products", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CustomerID"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Adı = textBox1.Text;
            decimal fiyat = numericUpDown1.Value;
            decimal stok = numericUpDown3.Value;

            SqlCommand komut = new SqlCommand();
            komut.CommandText = String.Format("insert into Products(ProductName,UnitPrice,UnitsInStock) values('{0}', {1}, {2})", Adı, fiyat, stok);

            komut.Connection = baglanti;
            baglanti.Open();

            int eklenti = komut.ExecuteNonQuery();
            baglanti.Close();

            if (eklenti > 0)
            {
                MessageBox.Show("Başarılı");
                UrunEkle();
            }
            else
            {
                MessageBox.Show("Eklenmedi");

            }
            baglanti.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            textBox1.Tag = dataGridView1.CurrentRow.Cells["ProductID"].Value;
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitPrice"].Value);
            numericUpDown3.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Adı = textBox1.Text;
            decimal fiyat = numericUpDown1.Value;
            decimal stok = numericUpDown3.Value;

            SqlCommand komut = new SqlCommand();
            komut.CommandText = String.Format("update Products set ProductName = '{0}',UnitPrice = {1},UnitsInStock = {2} where ProductID={3}",Adı,fiyat,stok,textBox1.Tag);

            //"insert into Products(ProductName,UnitPrice,UnitsInStock) values('{0}', {1}, {2})", Adı, fiyat, stok

            komut.Connection = baglanti;
            baglanti.Open();

            int eklenti3 = komut.ExecuteNonQuery();
            baglanti.Close();

            if (eklenti3 > 0)
            {
                MessageBox.Show("güncellendi");
                UrunEkle();
            }
            else
            {
                MessageBox.Show("olmadı");

            }
            baglanti.Close();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int Id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                SqlCommand komut = new SqlCommand();
                komut.CommandText = String.Format("delete Products where ProductID ={0}",Id);
                komut.Connection = baglanti;
                baglanti.Open();
                int eklenti4 = komut.ExecuteNonQuery();
                baglanti.Close();
                if (eklenti4 > 0)
                {
                    MessageBox.Show("silindi");
                    UrunEkle();
                }
                else
                {
                    MessageBox.Show("olmadı");

                }
                baglanti.Close();
            }
        }
    }
}
