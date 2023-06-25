using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataSet ds, ds2;
        SqlDataAdapter adapterSql;
        public string way2;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string connect = @"Data Source= '" + way2 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "SELECT ID_члена_семьи, Заработная_плата, Пассивный_доход FROM Доход_Члена_Семьи";
                adapterSql = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapterSql.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                dt.Dispose();
                ds.Dispose();
            }
            catch(Exception t)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = @"Data Source= HOME-PC\SQLEXPRESS01;Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query2 = "SELECT CASE Номер_записи WHEN 0 THEN 0 ELSE Заработная_плата+Пассивный_доход END AS Размер FROM Доход_Члена_Семьи";
                adapterSql = new SqlDataAdapter(query2, connect);
                ds2 = new DataSet();
                adapterSql.Fill(ds2);
                DataTable dt1 = new DataTable();
                dataGridView2.DataSource = ds2.Tables[0];
                ds2.Dispose();
                dt1.Dispose();
            }
            catch (Exception t)
            {
                MessageBox.Show(Convert.ToString(t));
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
