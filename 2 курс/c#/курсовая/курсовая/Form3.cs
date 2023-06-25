using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter adapterSql;
        public string way3;
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {

                string connect = @"Data Source= '" + way3 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "SELECT * FROM Члены_Семьи";
                adapterSql = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapterSql.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].ReadOnly = true;
                dt.Dispose();
                ds.Dispose();
            }
            catch (Exception t)
            {
                MessageBox.Show(Convert.ToString(t));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapterSql);
            adapterSql.Fill(ds);
            adapterSql.Update(ds);
            ds.Clear();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
