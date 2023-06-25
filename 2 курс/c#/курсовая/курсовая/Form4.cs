using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string way4;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataSet ds, ds2, ds3;
        SqlDataAdapter adapterSql, adapterSql2, adapterSql3;
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                string connect = @"Data Source= '" + way4 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "SELECT ID_продукта, ID_члена_семьи, Дата_покупки, Количество FROM Корзина";
                adapterSql = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapterSql.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                dt.Dispose();
                ds.Dispose();
                string query2 = "Select ID_продукта, Название FROM Продукт";
                adapterSql2 = new SqlDataAdapter(query2, connect);
                ds2 = new DataSet();
                adapterSql2.Fill(ds2);
                DataTable dt2 = new DataTable();
                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView2.ReadOnly = true;
                dt2.Dispose();
                ds2.Dispose();
                string query3 = "Select ID_члена_семьи, ФИО FROM Члены_Семьи";
                adapterSql3 = new SqlDataAdapter(query3, connect);
                ds3 = new DataSet();
                adapterSql3.Fill(ds3);
                DataTable dt3 = new DataTable();
                dataGridView3.DataSource = ds3.Tables[0];
                dataGridView3.ReadOnly = true;
                dt2.Dispose();
                ds2.Dispose();
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    if (DateTime.Now < Convert.ToDateTime(dataGridView1.CurrentCell.Value))
                    {
                        MessageBox.Show("Невозможная дата.", "ОШИБКА");
                        dataGridView1.CurrentCell.Value = "01.05.2022";
                    }
                }
                catch(Exception t)
                {
                    MessageBox.Show(Convert.ToString(t));
                    dataGridView1.CurrentCell.Value = "01.05.2022";
                }
            }
        }
    }
}
