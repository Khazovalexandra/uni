using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace мессенджер
{
    public partial class Form1 : Form
    {
        Form2 f2;
        Form3 f3;
        public Form1()
        {
            InitializeComponent();
        }

        public string text
        {
            get { return txt2.Text; }
            set { txt2.Text = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.Show();
            f2.Location = new Point(400, 50);
            f3 = new Form3(this);
            f3.Show();
            f3.Location = new Point(800, 50);
            f2.Form2_1(f3);
            f3.Form3_1(f2);
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            f2.text += "\r\n" + System.DateTime.Now + " Отправитель " + this.Name + "\r\n" + txt1.Text;
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            f3.text += "\r\n" + System.DateTime.Now + " Отправитель " + this.Name + "\r\n" + txt1.Text;
        }
    }
}
