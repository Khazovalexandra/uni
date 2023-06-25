using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string way6;
        private void Form6_Load(object sender, EventArgs e)
        {
            string connect1 = @"Data Source= '" + way6 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
            string query1 = "SELECT Название FROM Продукт";
            SqlConnection connection = new SqlConnection(connect1);
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            DataTable dt1 = new DataTable();
            adapterSql = new SqlDataAdapter(cmd1);
            adapterSql.Fill(dt1);
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Название";
            comboBox2.SelectedIndex = -1;
        }
        DataSet ds, ds2;
        SqlDataAdapter adapterSql, adapterSql2;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    try
                    {
                        string connect = @"Data Source= '" + way6 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                        string query = "SELECT Жизненнонеобходимые, Название, SUM(Количество*Цена) AS Сумма FROM Продукт INNER JOIN Корзина ON Продукт.ID_продукта = Корзина.ID_продукта JOIN Категория ON Продукт.ID_продукта = Категория.Номер_записи WHERE Категория.Жизненнонеобходимые = 'True' and Корзина.ID_продукта = Продукт.ID_продукта and Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "' GROUP BY Жизненнонеобходимые, Название";
                        string query2 = "SELECT SUM(Количество*Цена) AS Сумма FROM Продукт INNER JOIN Корзина ON Продукт.ID_продукта = Корзина.ID_продукта JOIN Категория ON Продукт.ID_продукта = Категория.Номер_записи WHERE Категория.Жизненнонеобходимые = 'True' and Корзина.ID_продукта = Продукт.ID_продукта and Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "' GROUP BY Жизненнонеобходимые";
                        adapterSql = new SqlDataAdapter(query, connect);
                        ds = new DataSet();
                        adapterSql.Fill(ds);
                        DataTable dt = new DataTable();
                        dataGridView1.DataSource = ds.Tables[0];
                        adapterSql2 = new SqlDataAdapter(query2, connect);
                        ds2 = new DataSet();
                        adapterSql2.Fill(ds2);
                        DataTable dt2 = new DataTable();
                        dataGridView2.DataSource = ds2.Tables[0];
                        textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[dataGridView2.CurrentCell.ColumnIndex].Value.ToString();
                        dt.Dispose();
                        ds.Dispose();
                        dt2.Dispose();
                        ds2.Dispose();
                    }
                    catch (Exception t)
                    {
                        MessageBox.Show(Convert.ToString(t));
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    try
                    {
                        string connect = @"Data Source= '" + way6 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                        string query = "SELECT Желательные, Название, SUM(Количество*Цена) AS Сумма FROM Продукт INNER JOIN Корзина ON Продукт.ID_продукта = Корзина.ID_продукта JOIN Категория ON Продукт.ID_продукта = Категория.Номер_записи WHERE Категория.Желательные = 'True' and Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "' GROUP BY Желательные, Название";
                        string query2 = "SELECT SUM(Количество*Цена) AS Сумма FROM Продукт INNER JOIN Корзина ON Продукт.ID_продукта = Корзина.ID_продукта JOIN Категория ON Продукт.ID_продукта = Категория.Номер_записи WHERE Категория.Желательные = 'True' and Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "' GROUP BY Желательные";
                        adapterSql = new SqlDataAdapter(query, connect);
                        ds = new DataSet();
                        adapterSql.Fill(ds);
                        DataTable dt = new DataTable();
                        dataGridView1.DataSource = ds.Tables[0];
                        adapterSql2 = new SqlDataAdapter(query2, connect);
                        ds2 = new DataSet();
                        adapterSql2.Fill(ds2);
                        DataTable dt2 = new DataTable();
                        dataGridView2.DataSource = ds2.Tables[0];
                        textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[dataGridView2.CurrentCell.ColumnIndex].Value.ToString();
                        dt.Dispose();
                        ds.Dispose();
                        dt2.Dispose();
                        ds2.Dispose();
                    }
                    catch (Exception t)
                    {
                        MessageBox.Show(Convert.ToString(t));
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    try 
                    { 
                        string connect = @"Data Source= '" + way6 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                        string query = "SELECT Развлечения, Название, SUM(Количество*Цена) AS Сумма FROM Продукт INNER JOIN Корзина ON Продукт.ID_продукта = Корзина.ID_продукта JOIN Категория ON Продукт.ID_продукта = Категория.Номер_записи WHERE Категория.Развлечения = 'True' and Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "' GROUP BY Развлечения, Название";
                        string query2 = "SELECT SUM(Количество*Цена) AS Сумма FROM Продукт INNER JOIN Корзина ON Продукт.ID_продукта = Корзина.ID_продукта JOIN Категория ON Продукт.ID_продукта = Категория.Номер_записи WHERE Категория.Развлечения = 'True' and Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "' GROUP BY Развлечения";
                        adapterSql = new SqlDataAdapter(query, connect);
                        ds = new DataSet();
                        adapterSql.Fill(ds);
                        DataTable dt = new DataTable();
                        dataGridView1.DataSource = ds.Tables[0];
                        adapterSql2 = new SqlDataAdapter(query2, connect);
                        ds2 = new DataSet();
                        adapterSql2.Fill(ds2);
                        DataTable dt2 = new DataTable();
                        dataGridView2.DataSource = ds2.Tables[0];
                        textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[dataGridView2.CurrentCell.ColumnIndex].Value.ToString();
                        dt.Dispose();
                        ds.Dispose();
                        dt2.Dispose();
                        ds2.Dispose();
                    }
                    catch (Exception t)
                    {
                        MessageBox.Show(Convert.ToString(t));
                    }
                }
                else if (comboBox2.SelectedIndex != -1)
                {
                    try
                    {
                        string connect = @"Data Source= '" + way6 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                        string query = "SELECT Название, SUM(Количество*Цена) AS Cумма FROM Продукт INNER JOIN Корзина ON Корзина.ID_продукта = Продукт.ID_продукта WHERE Продукт.Название = '" + comboBox2.Text + "' AND Дата_покупки>='01.05.2022' and Дата_покупки<='01.06.2022' GROUP BY Название";
                        string query2 = "SELECT SUM(Количество*Цена) AS Сумма FROM Продукт INNER JOIN Корзина ON Продукт.ID_продукта = Корзина.ID_продукта WHERE Продукт.Название = '" + comboBox2.Text + "' and Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                        adapterSql = new SqlDataAdapter(query, connect);
                        ds = new DataSet();
                        adapterSql.Fill(ds);
                        DataTable dt = new DataTable();
                        dataGridView1.DataSource = ds.Tables[0];
                        adapterSql2 = new SqlDataAdapter(query2, connect);
                        ds2 = new DataSet();
                        adapterSql2.Fill(ds2);
                        DataTable dt2 = new DataTable();
                        dataGridView2.DataSource = ds2.Tables[0];
                        textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[dataGridView2.CurrentCell.ColumnIndex].Value.ToString();
                        dt.Dispose();
                        ds.Dispose();
                        dt2.Dispose();
                        ds2.Dispose();
                    }
                    catch (Exception t)
                    {
                        MessageBox.Show(Convert.ToString(t));
                    }
                }
            }
            else
            {
                MessageBox.Show("Даты введены в неверном порядке.", "ОШИБКА");
            }
        }
    }
}
