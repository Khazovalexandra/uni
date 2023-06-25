using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string way5;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataSet ds, ds2, ds3, ds4, ds5;

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                try
                {
                    string connect = @"Data Source='" + way5 + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                    string query = "SELECT SUM(Заработная_плата)+SUM(Пассивный_доход) AS Доход_Семьи FROM Доход_Члена_Семьи INNER JOIN Корзина ON  Доход_Члена_Семьи.Номер_записи = Корзина.Номер_записи WHERE Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                    adapterSql = new SqlDataAdapter(query, connect);
                    ds = new DataSet();
                    adapterSql.Fill(ds);
                    DataTable dt = new DataTable();
                    dataGridView1.DataSource = ds.Tables[0];
                    dt.Dispose();
                    ds.Dispose();
                    textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
                    string query2 = "SELECT SUM(Количество * Цена) AS Расходы_Семьи FROM Продукт INNER JOIN Корзина ON Корзина.Номер_записи = Продукт.ID_продукта WHERE Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                    adapterSql = new SqlDataAdapter(query2, connect);
                    ds2 = new DataSet();
                    adapterSql.Fill(ds2);
                    DataTable dt2 = new DataTable();
                    dataGridView2.DataSource = ds2.Tables[0];
                    dt2.Dispose();
                    ds2.Dispose();
                    textBox2.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[dataGridView2.CurrentCell.ColumnIndex].Value.ToString();
                    string te1 = textBox2.Text;
                    double r = Convert.ToDouble(te1);
                    string te2 = textBox1.Text;
                    double d = Convert.ToDouble(te2);
                    if (r > d)
                    {
                        label2.Text = "Дефицитный";
                        label4.Text = "Превышение расходов бюджета над его доходами";
                        textBox6.Text = Convert.ToString(d - r);
                    }
                    else if ((r == d) && (r < (d * 1.11)))
                    {
                        label2.Text = "Равновестный";
                        textBox6.Text = Convert.ToString(d - r);
                        label4.Text = "Количество расходов бюджета равно или приблизительно равно его доходам";
                    }
                    else if (r <= (d * 1.12))
                    {
                        label2.Text = "Профицитный";
                        textBox6.Text = Convert.ToString(d - r);
                        label4.Text = "Превышение доходов бюджета над его расходами";
                    }
                    string query3 = "SELECT COUNT(Категория.Номер_записи) AS Жизненнонеобходимые FROM Категория INNER JOIN Корзина ON Корзина.Номер_записи = Категория.Номер_записи WHERE Категория.Жизненнонеобходимые = 'True' AND Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                    adapterSql = new SqlDataAdapter(query3, connect);
                    ds3 = new DataSet();
                    adapterSql.Fill(ds3);
                    DataTable dt3 = new DataTable();
                    dataGridView3.DataSource = ds3.Tables[0];
                    dt3.Dispose();
                    ds3.Dispose();
                    textBox3.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[dataGridView3.CurrentCell.ColumnIndex].Value.ToString();
                    string query4 = "SELECT COUNT(Категория.Номер_записи) AS Желательные FROM Категория INNER JOIN Корзина ON  Корзина.Номер_записи = Категория.Номер_записи WHERE Категория.Желательные = 'True' AND Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                    adapterSql = new SqlDataAdapter(query4, connect);
                    ds4 = new DataSet();
                    adapterSql.Fill(ds4);
                    DataTable dt4 = new DataTable();
                    dataGridView4.DataSource = ds4.Tables[0];
                    dt4.Dispose();
                    ds4.Dispose();
                    textBox4.Text = dataGridView4.Rows[dataGridView4.CurrentCell.RowIndex].Cells[dataGridView4.CurrentCell.ColumnIndex].Value.ToString();
                    string query5 = "SELECT COUNT(Категория.Номер_записи) AS Развлечения FROM Категория INNER JOIN Корзина ON  Корзина.Номер_записи = Категория.Номер_записи WHERE Категория.Развлечения = 'True' AND Дата_покупки>='" + dateTimePicker1.Value + "' and Дата_покупки<='" + dateTimePicker2.Value + "'";
                    adapterSql = new SqlDataAdapter(query5, connect);
                    ds5 = new DataSet();
                    adapterSql.Fill(ds5);
                    DataTable dt5 = new DataTable();
                    dataGridView5.DataSource = ds5.Tables[0];
                    dt5.Dispose();
                    ds5.Dispose();
                    textBox5.Text = dataGridView5.Rows[dataGridView5.CurrentCell.RowIndex].Cells[dataGridView5.CurrentCell.ColumnIndex].Value.ToString();
                    string k1 = textBox2.Text;
                    double n = Convert.ToDouble(k1);
                    string k2 = textBox2.Text;
                    double g = Convert.ToDouble(k2);
                    string k3 = textBox2.Text;
                    double ras = Convert.ToDouble(k3);
                    string resalt = label2.Text;
                    if ((n > (g + ras)) && (resalt == "Дефицитный"))
                    {
                        label11.Text = "НИЗКИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if (((n + g) < ras) && (resalt == "Дефицитный"))
                    {
                        label11.Text = "СРЕДНИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if (((n + g) >= ras) && (resalt == "Дефицитный"))
                    {
                        label11.Text = "НИЗКИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if (((n + g) >= ras) && (resalt == "Равновестный"))
                    {
                        label11.Text = "СРЕДНИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if ((n > (g + ras)) && (resalt == "Равновестный"))
                    {
                        label11.Text = "НИЗКИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if (((n + g) < ras) && (resalt == "Равновестный"))
                    {
                        label11.Text = "СРЕДНИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if (((n + g) >= ras) && (resalt == "Профицитный"))
                    {
                        label11.Text = "ВЫСОКИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if ((n > (g + ras)) && (resalt == "Профицитный"))
                    {
                        label11.Text = "СРЕДНИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                    else if (((n + g) < ras) && (resalt == "Профицитный"))
                    {
                        label11.Text = "ВЫСОКИЙ УРОВЕНЬ ЖИЗНИ";
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(Convert.ToString(t));
                }
            }
            else
            {
                MessageBox.Show("Даты введены в неверном порядке.", "ОШИБКА");
            }
        }

        SqlDataAdapter adapterSql;
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
