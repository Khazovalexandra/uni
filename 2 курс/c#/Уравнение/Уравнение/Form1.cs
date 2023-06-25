using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Уравнение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void reset()
        {
            lbD.Visible = true;
            lbD.Text = "D";
            lbx1.Visible = true;
            lbx1.Text = "x1 =";
            lbx2.Visible = true;
            lbx2.Text = "x2 =";
            lblx1.Visible = true;
            lblx1.Text = " ";
            lblx2.Visible = true;
            lblx1.Text = " ";
        }
        private void РЕШЕНИЕ_Click(object sender, EventArgs e)
        {
            reset();
            double a = 0, b = 0, c = 0;
            bool a1, b1, c1;
            a1 = double.TryParse(txta.Text, out a);
            b1 = double.TryParse(txtb.Text, out b);
            c1 = double.TryParse(txtc.Text, out c);
            if (!b1 || !c1)
            {
                MessageBox.Show("Неверные данные!");
                return;
            }
            Yrav kv = new Yrav(a, b, c);
            double d = kv.D(a, b, c); 
            lblD.Text = Convert.ToString(d);
            if ((a == 0) && (b == 0))
            {
                lblvid.Text = " ";
                lblD.Text = " ";
                lbD.Visible = false;
                lbx1.Visible = false;
                lbx2.Visible = false;
                lblx1.Visible = false;
                lblx2.Visible = false;
                MessageBox.Show("Нет такого уравнения");
                return;
            }
            if (a != 0)
            {
                if (d > 0)
                {
                    lblvid.Text = "Квадратное уравнение";
                    lblD.Text = "= " + Convert.ToString(d);
                    lblx1.Text = Convert.ToString(kv.first(a, b, c));
                    lblx2.Text = Convert.ToString(kv.second(a, b, c));
                }
                else if (d == 0)
                {
                    lblvid.Text = "Квадратное уравнение";
                    lblD.Text = "= 0";
                    lblx1.Text = Convert.ToString(kv.first(a, b, c));
                    lbx2.Visible = false;
                }
                else
                {
                    lblvid.Text = "Квадратное уравнение";
                    lblD.Text = "<0";
                    lbx1.Visible = false;
                    lbx2.Visible = false;
                    lblx1.Visible = false;
                    lblx2.Visible = false;
                    MessageBox.Show("Корней нет");
                }
            }
            else
            {
                lblvid.Text = "Линейное уравнение";
                lblx1.Text = Convert.ToString(kv.first(a, b, c));
                lbD.Visible = false;
                lbx2.Visible = false;
            }
        }

        private void выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
