using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace диаграмма_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            // графическая поверхность
            Graphics g = e.Graphics;
            // диаметр диаграммы
            int d = ClientSize.Height - 70;
            int x0 = 30;
            int y0 = (ClientSize.Height - d) / 2 + 10;
            // длина дуги сектора
            int swe;
            // кисть для заливки сектора диаграммы
            Brush fBrush = Brushes.White;
            // начальная точка дуги сектора
            int sta = 0;
            string secondLine = File.ReadLines("text.txt").Skip(1).First();
            int n = Convert.ToInt32(secondLine);
            // рисуем диаграмму
            for (int i = 0; i < n; i++)
            {
                // длина дуги
                swe = (int)(360 * 0.2);
                // задать цвет сектора
                switch (i)
                {
                    case 0:
                        fBrush = Brushes.YellowGreen;
                        break;
                    case 1:
                        fBrush = Brushes.Gold;
                        break;
                    case 2:
                        fBrush = Brushes.Pink;
                        break;
                    case 3:
                        fBrush = Brushes.Violet;
                        break;
                    case 4:
                        fBrush = Brushes.SkyBlue;
                        break;
                }
                if (i == n - 1)
                {
                    // последний сектор
                    swe = 360 - sta;
                }
                // рисуем сектор
                g.FillPie(fBrush, x0, y0, d, d, sta, swe);
                // рисуем границу сектора
                g.DrawPie(System.Drawing.Pens.Black, x0, y0, d, d, sta, swe);
                // начальная точка дуги для следующего сектора
                sta += swe;
                g.FillRectangle(fBrush, 2 * x0, 2 * y0, d, d);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string firstLine = File.ReadLines("text.txt").Skip(0).First();
            label1.Text = firstLine;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
