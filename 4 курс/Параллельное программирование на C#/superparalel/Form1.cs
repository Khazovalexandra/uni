using System.Diagnostics;
using System.Numerics;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace superparalel
{
    public partial class Form1 : Form
    {
        static CountdownEvent countDownEvent;
        static double globalPulPI = 0;
        int countCore = Environment.ProcessorCount;
        int minCountCore = 2;
        int countColumns = 2;
        static Excel.Application ex = new Excel.Application();
        static Excel.Workbook wb = ex.Workbooks.Open(@"c:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\superparalel\test4.xlsx");
        Worksheet list1 = wb.Worksheets[1];

        public Form1()
        {
            InitializeComponent();

            tbMin.Text = "1000000000";
            tbMax.Text = "10000000000";
            tbShag.Text = "1000000000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countCore = Environment.ProcessorCount;
            minCountCore = 2;
            countColumns = 2;
            writerRows();
            wb.Save();
            posledMethod();
            wb.Save();
            paralelPullMethod();
            wb.Save();
            paralelTPLlMethod();
            wb.Save();
            wb.Close(true);
            ex.Quit();
        }

        static double posled_PI(BigInteger writer)
        {
            double res, x, Fx, s = 0;
            double interval = 1 / (double)writer;
            for (double i = 1; i <= (double)writer; i++)
            {
                x = interval * (i - 0.5);
                Fx = 4 / (1 + x * x);
                s = s + Fx;
            }
            res = interval * s;
            return res;
        }

        void posledMethod()
        {
            lbPosled.Text = "";
            BigInteger posledMin = Convert.ToInt64(tbMin.Text);
            BigInteger posledMax = Convert.ToInt64(tbMax.Text);
            BigInteger posledShag = Convert.ToInt64(tbShag.Text);
            BigInteger posledind = posledMin;
            int copyMinCountCore = minCountCore;
            prbPosled.Minimum = 0;
            var ttttttt = (int)((posledMax - posledMin) / posledShag);
            prbPosled.Maximum = ttttttt;
            while (copyMinCountCore <= countCore)
            {
                list1.Cells[1, countColumns] = $"Последовательно на {copyMinCountCore} ядер";
                int k = countColumns;
                int j = 2;
                int shet = 1;

                while (posledind <= posledMax)
                {
                    TimeSpan posledResult = new TimeSpan();
                    for (int i = 0; i < 3; i++)
                    {
                        Stopwatch posledStopWatch = new Stopwatch();
                        posledStopWatch.Start();
                        posled_PI(posledind);
                        posledStopWatch.Stop();
                        posledResult += posledStopWatch.Elapsed;
                    }
                    var posledResult2 = posledResult.TotalSeconds / 3;
                    list1.Cells[j, k] = posledResult2;
                    if (shet < prbPosled.Maximum)
                        prbPosled.Value = shet;
                    else prbPosled.Value = prbPosled.Maximum;
                    shet++;

                    lbPosled.Text = $"{posledind} из {posledMax}";
                    lbPosled.Refresh();
                    prbPosled.Refresh();
                    posledind += posledShag;
                    j += 1;
                }
                lbShetPosled.Text = $"Эсперемент на {copyMinCountCore} ядер \n\r завершен";
                copyMinCountCore++;
                countColumns++;
                posledind = posledMin;
            }
            lbPosled.Text = "Сохраняем";
            lbPosled.Text = "Comleted";
        }
        static Array ArrCopy(Array arr)
        {
            object[] copy = new object[arr.Length];
            arr.CopyTo(copy, 0);
            return copy;
        }

        static double paralelTPL(object arr)
        {
            double x, Fx, s = 0;
            var left = (BigInteger)(((object[])arr)[0]);
            var right = (BigInteger)(((object[])arr)[1]);
            var interval_ = (BigInteger)(((object[])arr)[2]);
            Console.WriteLine("�����=" + left + " ������=" + right + " ��������=" + interval_);
            double interval = 1 / (double)interval_;
            for (double i = (double)left; i <= (double)right; i++)
            {
                x = interval * (i - 0.5);
                Fx = 4 / (1 + x * x);
                s = s + Fx;
            }
            return s;
        }
        void paralelTPLlMethod()
        {
            lbPosled.Text = "";
            BigInteger paralelTPLMin = Convert.ToInt64(tbMin.Text);
            BigInteger paralelTPLMax = Convert.ToInt64(tbMax.Text);
            BigInteger paralelTPLShag = Convert.ToInt64(tbShag.Text);
            BigInteger paralelTPLind = paralelTPLMin;
            int copyMinCountCore = minCountCore;
            prbParalelTPL.Minimum = 0;
            var ttttttt = (int)((paralelTPLMax - paralelTPLMin) / paralelTPLShag);
            prbParalelTPL.Maximum = ttttttt;

            while (copyMinCountCore <= countCore)
            {
                list1.Cells[1, countColumns] = $"TPL на {copyMinCountCore} ядер";
                int k = countColumns;
                int j = 2;
                int shet = 0;
                while (paralelTPLind <= paralelTPLMax)
                {
                    TimeSpan posledResult = new TimeSpan();
                    for (int i = 0; i < 3; i++)
                    {
                        Stopwatch posledStopWatch = new Stopwatch();
                        double globalPI = 0;
                        BigInteger step = paralelTPLind / copyMinCountCore;
                        object[] borders = new object[3];
                        posledStopWatch.Start(); 
                        Task<double>[] taskss = new Task<double>[copyMinCountCore];
                        for (int q = 0; q < copyMinCountCore; q++)
                        {
                            if (q == copyMinCountCore - 1)
                            {
                                borders[0] = (step * q) + 1;
                                borders[1] = paralelTPLind;
                            }
                            else
                            {
                                borders[0] = (step * q) + 1;
                                borders[1] = step * (q + 1);
                            }
                            borders[2] = paralelTPLind;
                            var borders2 = ArrCopy(borders);
                            taskss[q] = Task.Run(() => paralelTPL(borders2));
                        }
                        Task.WaitAll(taskss);

                        foreach (var task in taskss)
                        {
                            globalPI = globalPI + task.Result;
                        }

                        double interval = 1.0 / (double)paralelTPLind;
                        globalPI = globalPI * interval;
                        posledStopWatch.Stop();

                        posledResult += posledStopWatch.Elapsed;
                    }
                    var posledResult2 = posledResult.TotalSeconds / 3;
                    string r = posledResult.ToString();
                    list1.Cells[j, k] = posledResult2;
                    if (shet < prbParalelTPL.Maximum)
                        prbParalelTPL.Value = shet;
                    else prbParalelTPL.Value = prbParalelTPL.Maximum;
                    shet++;
                    lbParalelTPL.Text = $"{paralelTPLind} из {paralelTPLMax}";
                    lbParalelTPL.Refresh();
                    prbParalelTPL.Refresh();
                    paralelTPLind += paralelTPLShag;
                    j += 1;
                }
                lbShetTPL.Text = $"Эксперемент на {copyMinCountCore} ядер";
                copyMinCountCore++;
                countColumns++;
                paralelTPLind = paralelTPLMin;
            }
            lbParalelTPL.Text = "Сохранено";
            wb.Save();
            lbParalelTPL.Text = "Comleted";
        }

        static void paralelPul(object iThread)
        {
            object locker = new object();
            double x, Fx, s = 0;
            var left = (BigInteger)(((object[])iThread)[0]);
            var right = (BigInteger)(((object[])iThread)[1]);
            var interval_ = (BigInteger)(((object[])iThread)[2]);
            double interval = 1 / (double)interval_;
            for (double i = (double)left; i <= (double)right; i++)
            {
                x = interval * (i - 0.5);
                Fx = 4 / (1 + x * x);
                s = s + Fx;
            }
            lock (locker)
            {
                globalPulPI += s;
            }
            countDownEvent.Signal();
        }

        void paralelPullMethod()
        {
            lbPosled.Text = "";
            BigInteger paralelPulMin = Convert.ToInt64(tbMin.Text);
            BigInteger paralelPulMax = Convert.ToInt64(tbMax.Text);
            BigInteger paralelPulShag = Convert.ToInt64(tbShag.Text);
            BigInteger paralelPulind = paralelPulMin;
            int copyMinCountCore = minCountCore;
            prbParalelPul.Minimum = 0;
            var ttttttt = (int)((paralelPulMax - paralelPulMin) / paralelPulShag);
            prbParalelPul.Maximum = ttttttt;

            while (copyMinCountCore <= countCore)
            {
                list1.Cells[1, countColumns] = $"Pool для {copyMinCountCore} ядер завершен";
                int k = countColumns;
                int j = 2;
                int shet = 0;
                while (paralelPulind <= paralelPulMax)
                {
                    TimeSpan posledResult = new TimeSpan();
                    for (int i = 0; i < 3; i++)
                    {
                        Stopwatch posledStopWatch = new Stopwatch();
                        double globalPI = 0;
                        BigInteger step = paralelPulind / copyMinCountCore;
                        object[] borders = new object[3];
                        posledStopWatch.Start(); 
                        countDownEvent = new CountdownEvent(copyMinCountCore);
                        for (int q = 0; q < copyMinCountCore; q++)
                        {

                            if (q == copyMinCountCore - 1)
                            {
                                borders[0] = (step * q) + 1;
                                borders[1] = paralelPulind;
                            }
                            else
                            {
                                borders[0] = (step * q) + 1;
                                borders[1] = step * (q + 1);
                            }
                            borders[2] = paralelPulind;
                            ThreadPool.QueueUserWorkItem(paralelPul, ArrCopy(borders));
                        }
                        countDownEvent.Wait();

                        double interval = 1.0 / (double)(paralelPulind);
                        globalPulPI = globalPulPI * interval;
                        posledStopWatch.Stop();
                        posledResult += posledStopWatch.Elapsed;
                    }
                    var posledResult2 = posledResult.TotalSeconds / 3;
                    string r = posledResult.ToString();
                    list1.Cells[j, k] = posledResult2;
                    if (shet < prbParalelPul.Maximum)
                        prbParalelPul.Value = shet;
                    else prbParalelPul.Value = prbParalelPul.Maximum;
                    shet++;
                    lbParalelPul.Text = $"{paralelPulind} из {paralelPulMax}";
                    lbParalelPul.Refresh();
                    prbParalelPul.Refresh();
                    paralelPulind += paralelPulShag;
                    j += 1;
                }
                lbShetPul.Text = $"Эксперемент для {copyMinCountCore} ядер завершен";
                copyMinCountCore++;
                countColumns++;
                paralelPulind = paralelPulMin;
            }
            lbParalelPul.Text = "Сохраняем";
            lbParalelPul.Text = "Comleted";
        }

        void writerRows()
        {
            BigInteger rowsMin = Convert.ToInt64(tbMin.Text);
            BigInteger rowsMax = Convert.ToInt64(tbMax.Text);
            BigInteger rowsShag = Convert.ToInt64(tbShag.Text);
            BigInteger rowsind = rowsMin;
            int i = 2;
            while (rowsind <= rowsMax)
            {
                list1.Cells[i, 1] = $"{rowsind}";
                i++;
                rowsind += rowsShag;
            }
        }
    }
}