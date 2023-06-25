using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public string way7;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataSet ds, ds1;
        SqlDataAdapter adapterSql;
        private void Form7_Load(object sender, EventArgs e)
        {
            string connect1 = @"Data Source= '" + way7 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
            string query1 = "SELECT ФИО FROM Члены_Семьи";
            SqlConnection connection = new SqlConnection(connect1);
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            DataTable dt1 = new DataTable();
            adapterSql = new SqlDataAdapter(cmd1);
            adapterSql.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "ФИО";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                string connect = @"Data Source= '" + way7 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "SELECT CASE ID_члена_семьи WHEN '" + (comboBox1.SelectedIndex + 1) + "' THEN (SUM(Заработная_плата)+SUM(Пассивный_доход)) END AS Общий_доход, SUM(Заработная_плата) AS Общая_зарплата, SUM(Пассивный_доход) AS Общай_пассивный_доход FROM Доход_Члена_Семьи WHERE ID_члена_семьи ='" + (comboBox1.SelectedIndex + 1) + "' GROUP BY ID_члена_семьи";
                adapterSql = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapterSql.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                dt.Dispose();
                ds.Dispose();
            }
            catch (Exception t)
            {
                MessageBox.Show(Convert.ToString(t));
            }
        }
    }
}
