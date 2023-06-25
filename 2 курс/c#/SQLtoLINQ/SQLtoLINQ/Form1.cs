using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Data.SqlClient;

namespace SQLtoLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataContext db;
        static string connectionString = @"Data Source=HOME-PC\SQLEXPRESS01;Initial Catalog=Потребитеьская корзина;Integrated Security=True";
        [Table(Name = "Продукт")]
        public class Product
        {
            [Column(Name = "ID_продукта", IsPrimaryKey = true, IsDbGenerated = false)]
            public int ID { get; set; }
            [Column(Name = "Цена")]
            public decimal price { get; set; }
            [Column(Name = "Название")]
            public string Name { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = textBox1.Text;
            try 
            {
                if ((query[0] == 'S')||(query[0] == 's'))
                {
                    dataGridView1.DataSource = db.ExecuteQuery<Product>(query).ToList();
                }
                else
                {
                    db.ExecuteCommand(query);
                }
            }
            catch(Exception q)
            {
                MessageBox.Show(Convert.ToString(q), "Ошибка");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DataContext(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = db.GetTable<Product>().Where(u => u.price > 1000);
            dataGridView1.DataSource = query;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Table<Product> product = db.GetTable<Product>();
                dataGridView1.DataSource = product;
            }
            catch (Exception q)
            {
                MessageBox.Show(Convert.ToString(q), "Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try 
            {
                db.SubmitChanges();
            }
            catch (Exception q)
            {
                MessageBox.Show(Convert.ToString(q), "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query = db.GetTable<Product>().GroupBy(u => u.Name);
            dataGridView1.DataSource = query;
        }
    }
}
