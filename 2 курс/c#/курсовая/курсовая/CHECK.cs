using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace курсовая
{
    public partial class CHECK : Form
    {//HOME-PC\SQLEXPRESS01
        public CHECK()
        {
            InitializeComponent();
        }
        DataSet ds, ds2;
        SqlDataAdapter adapterSql, adapterSql2;
        private void CHECK_Load(object sender, EventArgs e)
        {

        }
        //HOME-PC\SQLEXPRESS01
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string way = textBox3.Text;
                string connect = @"Data Source= '" + way + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
                string query = "SELECT Логин FROM ВХОД WHERE Логин = '" + textBox1.Text + "'";
                string query2 = "SELECT Пароль FROM ВХОД WHERE Пароль = '" + textBox2.Text + "'";
                adapterSql = new SqlDataAdapter(query, connect);
                adapterSql2 = new SqlDataAdapter(query2, connect);
                ds = new DataSet();
                ds2 = new DataSet();
                adapterSql.Fill(ds);
                adapterSql2.Fill(ds2);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = ds.Tables[0];
                DataTable dt2 = new DataTable();
                dataGridView2.DataSource = ds2.Tables[0];
                ds.Dispose();
                ds2.Dispose();
                dt.Dispose();
                dt2.Dispose();
            }
            else 
            {
                MessageBox.Show("Введите путь в базе данных.", "ОШИБКА");
            }
            if((textBox1.Text!="")&&(textBox2.Text!=""))
            {
                if((dataGridView1[0,0].Value!=null)&&(dataGridView2[0,0].Value!=null))
                {
                    if(textBox3.Text!="")
                    {
                        Main v = new Main();
                        v.Show();
                        v.way1 = textBox3.Text;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Введите путь в базе данных.", "ОШИБКА");
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя не найдено. Повторите попытку или нажмите добавить нового пользователя", "ОШИБКА");
                }
            }
            else
            {
                MessageBox.Show("В ячейки не введены данные для проверки. Попробуйте снова.", "ОШИБКА");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string way = textBox3.Text;
            string connect = @"Data Source= '" + way + "';Initial Catalog= Потребитеьская корзина ;Integrated Security=True";
            string query = "SELECT Логин FROM ВХОД WHERE Логин = '"+ textBox1.Text +"'";
            string query2 = "SELECT Пароль FROM ВХОД WHERE Пароль = '"+ textBox2.Text +"'";
            adapterSql = new SqlDataAdapter(query, connect);
            adapterSql2 = new SqlDataAdapter(query2, connect);
            ds = new DataSet();
            ds2 = new DataSet();
            adapterSql.Fill(ds);
            adapterSql2.Fill(ds2);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = ds.Tables[0];
            DataTable dt2 = new DataTable();
            dataGridView2.DataSource = ds2.Tables[0];
            ds.Dispose();
            ds2.Dispose();
            dt.Dispose();
            dt2.Dispose();
            if((textBox1.Text!="")&&(textBox2.Text!=""))
            {
                if ((textBox1.Text.Length >= 4)||(textBox1.Text.Length >= 4))
                {
                    if ((dataGridView1[0, 0].Value == null) && (dataGridView2[0, 0].Value == null))
                    {
                        string query3 = " INSERT INTO Вход(Логин, Пароль) VALUES('"+textBox1.Text+"','"+textBox2.Text+"')";
                        adapterSql = new SqlDataAdapter(query3, connect);
                        ds = new DataSet();
                        adapterSql.Fill(ds);
                        DataTable dt3 = new DataTable();
                        dt3.Dispose();
                        ds.Dispose();
                        textBox1.Text = "Повторите ввод";
                        textBox2.Text = "и нажмите Зайти";
                    }
                    else
                    {
                        MessageBox.Show("Такой пользователь уже зарегистрирован", "ОШИБКА");
                    }
                }
                else
                {
                    MessageBox.Show("Логин и пароль не могут быть короче 4 символов. Повторите попытку.", "ОШИБКА");
                } 
            }
            else 
            {
                MessageBox.Show("В ячейки не введены данные для сохранения. Попробуйте снова.", "ОШИБКА");
            }
        }
    }
}
