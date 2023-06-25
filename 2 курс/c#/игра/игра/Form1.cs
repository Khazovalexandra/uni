using System;
using System.Drawing;
using System.Windows.Forms;

namespace игра
{
    public partial class Form1 : Form
    {
        int s1, s2;
        public Form1()
        {
            InitializeComponent();
        }
        private Button[,] Cells = new Button[1000,1000];
        public void Game1()
        {
                int m = Convert.ToInt32(txt1.Text);
                int n = Convert.ToInt32(txt2.Text);
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Cells[i, j] = new Button();
                        Cells[i, j].Location = new Point(50 + i * 25, 50 + j * 25);
                        Cells[i, j].Size = new Size(25, 25);
                        this.Controls.Add(Cells[i, j]);
                        Cells[i, j].Show();
                    }
                }
        }
        public int Index()
        {
            switch (cmbBox.Text)
            {
                case "1 сек":
                    return 1000;
                case "2 сек":
                    return 2000;
                case "4 сек":
                    return 4000;
                default:
                    return 0;
            }
        }
        public void Game2(Object myObject, EventArgs eventArgs)
        {
            int m = Convert.ToInt32(txt1.Text);
            int n = Convert.ToInt32(txt2.Text);
            Random rnd = new Random();
            int ran1 = rnd.Next(0, m);
            int ran2 = rnd.Next(0, n);
            for (int t = 0; t < m; t++)
            {
                for(int r = 0; r < n; r++)
                {
                    if ((s1 != ran1) && (s2 != ran2))
                    {
                        Cells[s1, s2].BackColor = Color.Transparent;
                        Cells[ran1, ran2].BackColor = Color.Red;
                        s1 = ran1;
                        s2 = ran2;
                    } 
                }
            }
        }
        private void stop_Click(object sender, EventArgs e)
        {
            stop.Visible = true;
            Game1();
            int cmb;
            cmb = Index();
            timer2.Enabled = true;
            timer2.Start();
            timer2.Interval = cmb;
            timer2.Tick += Game2;
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void stop_Click_1(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(txt1.Text);
            int n = Convert.ToInt32(txt2.Text);
            Label lab = new Label();
            panel1.Controls.Add(lab);
            lab.Text = "Ваш счет:" + "/" + (m*n);
        }
        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
