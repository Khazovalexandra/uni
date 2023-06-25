using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace текстовый_редактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
        }

        private void создаьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                TabPage newp = new TabPage();
                newp.Name = saveFileDialog1.FileName;
                string name = newp.Name;
                tabControl1.TabPages.Add(newp);
                newp.Text = name;
                RichTextBox newr = new RichTextBox();
                newr.Parent = tabControl1.TabPages[newp.Name];
                textBox1.Text = saveFileDialog1.FileName;
                newp.Controls.Add(newr);
                newr.Size += new System.Drawing.Size(1000, 400);
                int count = newr.   
                File.WriteAllText(saveFileDialog1.FileName, newr.Text);
            }
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                MessageBox.Show("Файл успешно сохранен");
            }
            textBox1.Text = saveFileDialog1.FileName;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void открытьФайлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string openfile = openFileDialog1.FileName;
            string readfile = File.ReadAllText(openfile);
            richTextBox1.Text = readfile;
            textBox1.Text = openfile;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void количествоСтрочекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void количествоСимволовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = richTextBox1.TextLength;
            label1.Text = "Количество символов: " + Convert.ToString(k);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
