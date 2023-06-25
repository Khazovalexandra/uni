using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public string way1;
        public string way2;
        public string way3;
        public string way4;
        public string way5;
        public string way6;
        public string way7;
        public string way8;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 finance = new Form1();
            finance.way1 = way1;
            finance.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            Form2 finance2 = new Form2();
            finance2.way2 = way1;
            finance2.Show();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            Form3 family = new Form3();
            family.way3 = way1;
            family.Show();
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            Form4 product = new Form4();
            product.way4 = way1;
            product.Show();
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            Form5 result = new Form5();
            result.way5 = way1;
            result.Show();
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            Form6 result2 = new Form6();
            result2.way6 = way1;
            result2.Show();
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            Form7 result3 = new Form7();
            result3.way7 = way1;
            result3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form8 result4 = new Form8();
            result4.way8 = way1;
            result4.Show();
        }
    }
}
