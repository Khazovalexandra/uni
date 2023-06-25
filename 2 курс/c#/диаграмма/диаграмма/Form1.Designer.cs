
namespace диаграмма
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBarA = new System.Windows.Forms.HScrollBar();
            this.hScrollBarB = new System.Windows.Forms.HScrollBar();
            this.hScrollBarC = new System.Windows.Forms.HScrollBar();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "c=";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(46, 32);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(89, 20);
            this.textA.TabIndex = 3;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(46, 72);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(89, 20);
            this.textB.TabIndex = 4;
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(46, 115);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(89, 20);
            this.textC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "K=";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Начертить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBarA
            // 
            this.hScrollBarA.LargeChange = 1;
            this.hScrollBarA.Location = new System.Drawing.Point(24, 52);
            this.hScrollBarA.Minimum = -100;
            this.hScrollBarA.Name = "hScrollBarA";
            this.hScrollBarA.Size = new System.Drawing.Size(151, 17);
            this.hScrollBarA.TabIndex = 9;
            this.hScrollBarA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBarB
            // 
            this.hScrollBarB.LargeChange = 1;
            this.hScrollBarB.Location = new System.Drawing.Point(24, 95);
            this.hScrollBarB.Minimum = -100;
            this.hScrollBarB.Name = "hScrollBarB";
            this.hScrollBarB.Size = new System.Drawing.Size(151, 17);
            this.hScrollBarB.TabIndex = 10;
            this.hScrollBarB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarB_Scroll);
            // 
            // hScrollBarC
            // 
            this.hScrollBarC.LargeChange = 1;
            this.hScrollBarC.Location = new System.Drawing.Point(24, 138);
            this.hScrollBarC.Minimum = -100;
            this.hScrollBarC.Name = "hScrollBarC";
            this.hScrollBarC.Size = new System.Drawing.Size(150, 17);
            this.hScrollBarC.TabIndex = 11;
            this.hScrollBarC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.LargeChange = 1;
            this.hScrollBar4.Location = new System.Drawing.Point(122, 253);
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(123, 19);
            this.hScrollBar4.TabIndex = 12;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(282, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 358);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 354);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.hScrollBarC);
            this.Controls.Add(this.hScrollBarB);
            this.Controls.Add(this.hScrollBarA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Графики";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBarA;
        private System.Windows.Forms.HScrollBar hScrollBarB;
        private System.Windows.Forms.HScrollBar hScrollBarC;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

