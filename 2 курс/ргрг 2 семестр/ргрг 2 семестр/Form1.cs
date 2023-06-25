using System;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace ргрг_2_семестр
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Word Files (*docx)|*.docx";//выбираем расширение файлов, которые мы будем открывать
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Text1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)//открытие диалогового окна для выбора файла
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)//если пользователь хочет выйти
                {
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    openFileDialog1.ShowDialog();
                }
            }
            string openfile = openFileDialog1.FileName; //сохраняем путь файла
            try
            { 
                Word.Application w = new Word.Application();
                w.Visible = false;
                Word.Document doc = w.Documents.Open(openfile, ReadOnly:false);//открываем файл
                textBox1.Text = openfile;//выводим путь файла
                w.Selection.TypeText(Text1.Text);
                doc.ActiveWindow.Selection.WholeStory();
                doc.ActiveWindow.Selection.Copy();//копируем текст из файла
                Text1.Paste();//метод вставки изображений
                doc.Close();//закрываем документ
                w.Quit();//закрывает поток Application
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text1.Clear();
            textBox1.Clear();
        }
    }
}
