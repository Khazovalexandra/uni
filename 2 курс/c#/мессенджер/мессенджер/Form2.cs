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
    public partial class Form2 : Form
    {
        Form1 f1;
        Form3 f3;

        public string text
        {
            get { return txt2.Text; }
            set { txt2.Text = value; }
        }

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public void Form2_1(Form3 f3)
        {
            this.f3 = f3;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            f1.text += "\r\n" + System.DateTime.Now + " Отправитель " + this.Name + "\r\n" + txt1.Text;
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
