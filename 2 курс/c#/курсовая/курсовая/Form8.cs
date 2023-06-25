using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public string way8;
        private void Form8_Load(object sender, EventArgs e)
        {

        }
        DataSet ds;
        SqlDataAdapter adapterSql;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value<=dateTimePicker2.Value)
            {
                string connect = @"Data Source= '" + way8 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "SELECT Название, Цена, Количество FROM Корзина INNER JOIN Продукт ON Продукт.ID_Продукта = Корзина.Номер_записи WHERE Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                adapterSql = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapterSql.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                dt.Dispose();
                ds.Dispose();
            }
            else 
            {
                MessageBox.Show("Даты введены в неверном порядке.", "ОШИБКА");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить данные?", "ПОДТВЕРЖДЕНИЕ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connect = @"Data Source= '" + way8 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "DELETE FROM Категория, Корзина, Продукт WHERE Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                adapterSql = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapterSql.Fill(ds);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                dt.Dispose();
                ds.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
