using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace диаграмма
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, k, x1, x2;

        private void hScrollBarB_Scroll(object sender, ScrollEventArgs e)
        {
            b = hScrollBarB.Value / 10.0;
            textB.Text = b.ToString(); ;
            pictureBox1.Refresh();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            c = hScrollBarC.Value / 10.0;
            textC.Text = c.ToString(); ;
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class Drow
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(a) + "x*x" + Convert.ToString(b) + 'x' + Convert.ToString(c)+"=0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int W = pictureBox1.Width, H = pictureBox1.Height;
            int halfW = W / 2, halfH = H / 2;
            e.Graphics.DrawLine(Pens.Black, halfW, 0, halfW, H);
            e.Graphics.DrawLine(Pens.Black, 0, halfH, W, halfH);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            a = hScrollBarA.Value / 10.0;
            textA.Text = a.ToString(); ;
            pictureBox1.Refresh();
        }
    }
}
