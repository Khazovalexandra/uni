using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace БД
{
    public partial class Form1 : Form
    {
        List<BindingSource> bs = new List<BindingSource>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bs.Add(самолетBindingSource);
            bs.Add(пассажирBindingSource);
            bs.Add(рейсBindingSource1);
            bs.Add(талонBindingSource);
            bs.Add(билетBindingSource1);
            bs.Add(местоBindingSource);
            bs.Add(классBindingSource);
            int index = comboBox1.SelectedIndex;
            dataGridView2.DataSource = bs[index];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet1.Место". При необходимости она может быть перемещена или удалена.
            this.местоTableAdapter.Fill(this.самолетDataSet1.Место);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet1.Талон". При необходимости она может быть перемещена или удалена.
            this.талонTableAdapter1.Fill(this.самолетDataSet1.Талон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet1.Класс". При необходимости она может быть перемещена или удалена.
            this.классTableAdapter.Fill(this.самолетDataSet1.Класс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet1.Самолет". При необходимости она может быть перемещена или удалена.
           this.самолетTableAdapter.Fill(this.самолетDataSet1.Самолет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet1.Пассажир". При необходимости она может быть перемещена или удалена.
            this.пассажирTableAdapter.Fill(this.самолетDataSet1.Пассажир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet1.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter1.Fill(this.самолетDataSet1.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet1.Билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter1.Fill(this.самолетDataSet1.Билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолетDataSet.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.самолетDataSet.Рейс);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            пассажирTableAdapter.Update(самолетDataSet1);
            рейсTableAdapter1.Update(самолетDataSet1);
            билетTableAdapter1.Update(самолетDataSet1);
            классTableAdapter.Update(самолетDataSet1);
            талонTableAdapter1.Update(самолетDataSet1);
            самолетTableAdapter.Update(самолетDataSet1);
        }

        SqlDataAdapter sql;
        DataSet ds;

        private void самолетBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            string connect= "Data Source= PC-CLASSSE\\SQLEXPRESS;Initial Catalog= Самолет ;Integrated Security=True";
            string query = "SELECT * FROM Рейс";
            SqlDataAdapter adapterSql = new SqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            adapterSql.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dt.Dispose();
            ds.Dispose();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
