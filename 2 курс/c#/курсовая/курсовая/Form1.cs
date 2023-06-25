using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds, ds2;
        SqlDataAdapter adapterSql, adapterSql1;
        public string way1;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string connect = @"Data Source= '" + way1 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "SELECT ID_Продукта, Цена, Название FROM Продукт";
                string query2 = "SELECT ID_Продукта, Жизненнонеобходимые, Желательные, Развлечения FROM Категория";
                adapterSql = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapterSql.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                adapterSql1 = new SqlDataAdapter(query2, connect);
                ds2 = new DataSet();
                adapterSql1.Fill(ds2);
                DataTable dt2 = new DataTable();
                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView1.Columns[0].ReadOnly = true;
                dt.Dispose();
                ds.Dispose();
                ds2.Dispose();
                dt2.Dispose();
            }
            catch(Exception t)
            {
                MessageBox.Show(Convert.ToString(t));
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapterSql);
            adapterSql.Fill(ds);
            adapterSql.Update(ds);
            ds.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapterSql1);
            adapterSql1.Fill(ds2);
            adapterSql1.Update(ds2);
            ds2.Clear();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
