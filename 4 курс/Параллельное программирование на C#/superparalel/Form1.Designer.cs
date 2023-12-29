namespace superparalel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbMin = new TextBox();
            tbMax = new TextBox();
            label2 = new Label();
            tbShag = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            prbPosled = new ProgressBar();
            prbParalelPul = new ProgressBar();
            prbParalelTPL = new ProgressBar();
            lbPosled = new Label();
            lbParalelPul = new Label();
            lbParalelTPL = new Label();
            lbShetTPL = new Label();
            lbShetPul = new Label();
            lbShetPosled = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 66);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "minrectangle";
            // 
            // tbMin
            // 
            tbMin.Location = new Point(142, 59);
            tbMin.Name = "tbMin";
            tbMin.Size = new Size(125, 27);
            tbMin.TabIndex = 1;
            // 
            // tbMax
            // 
            tbMax.Location = new Point(389, 59);
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(125, 27);
            tbMax.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 66);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "maxrectangle";
            // 
            // tbShag
            // 
            tbShag.Location = new Point(593, 63);
            tbShag.Name = "tbShag";
            tbShag.Size = new Size(125, 27);
            tbShag.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 66);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "shag";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 196);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 6;
            label4.Text = "Последовательно";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 196);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 7;
            label5.Text = "Паралельно Пулы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 196);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 8;
            label6.Text = "Паралельно tpl";
            // 
            // button1
            // 
            button1.Location = new Point(324, 126);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // prbPosled
            // 
            prbPosled.Location = new Point(57, 253);
            prbPosled.Name = "prbPosled";
            prbPosled.Size = new Size(185, 29);
            prbPosled.TabIndex = 10;
            // 
            // prbParalelPul
            // 
            prbParalelPul.Location = new Point(287, 253);
            prbParalelPul.Name = "prbParalelPul";
            prbParalelPul.Size = new Size(185, 29);
            prbParalelPul.TabIndex = 11;
            // 
            // prbParalelTPL
            // 
            prbParalelTPL.Location = new Point(547, 253);
            prbParalelTPL.Name = "prbParalelTPL";
            prbParalelTPL.Size = new Size(185, 29);
            prbParalelTPL.TabIndex = 12;
            // 
            // lbPosled
            // 
            lbPosled.AutoSize = true;
            lbPosled.Location = new Point(57, 292);
            lbPosled.Name = "lbPosled";
            lbPosled.Size = new Size(0, 20);
            lbPosled.TabIndex = 13;
            // 
            // lbParalelPul
            // 
            lbParalelPul.AutoSize = true;
            lbParalelPul.Location = new Point(287, 292);
            lbParalelPul.Name = "lbParalelPul";
            lbParalelPul.Size = new Size(0, 20);
            lbParalelPul.TabIndex = 14;
            // 
            // lbParalelTPL
            // 
            lbParalelTPL.AutoSize = true;
            lbParalelTPL.Location = new Point(547, 291);
            lbParalelTPL.Name = "lbParalelTPL";
            lbParalelTPL.Size = new Size(0, 20);
            lbParalelTPL.TabIndex = 15;
            // 
            // lbShetTPL
            // 
            this.lbShetTPL.AutoSize = true;
            this.lbShetTPL.Location = new Point(548, 340);
            this.lbShetTPL.Name = "lbShetTPL";
            this.lbShetTPL.Size = new Size(0, 20);
            this.lbShetTPL.TabIndex = 19;
            // 
            // lbShetPul
            // 
            this.lbShetPul.AutoSize = true;
            this.lbShetPul.Location = new Point(288, 341);
            this.lbShetPul.Name = "lbShetPul";
            this.lbShetPul.Size = new Size(0, 20);
            this.lbShetPul.TabIndex = 18;
            // 
            // lbShetPosled
            // 
            lbShetPosled.AutoSize = true;
            lbShetPosled.Location = new Point(58, 341);
            lbShetPosled.Name = "lbShetPosled";
            lbShetPosled.Size = new Size(0, 20);
            lbShetPosled.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.lbShetTPL);
            Controls.Add(this.lbShetPul);
            Controls.Add(lbShetPosled);
            Controls.Add(lbParalelTPL);
            Controls.Add(lbParalelPul);
            Controls.Add(lbPosled);
            Controls.Add(prbPosled);
            Controls.Add(prbParalelPul);
            Controls.Add(prbParalelTPL);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbShag);
            Controls.Add(label3);
            Controls.Add(tbMax);
            Controls.Add(label2);
            Controls.Add(tbMin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbMin;
        private TextBox tbMax;
        private Label label2;
        private TextBox tbShag;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ProgressBar prbPosled;
        private ProgressBar prbParalelPul;
        private ProgressBar prbParalelTPL;
        private Label lbPosled;
        private Label lbParalelPul;
        private Label lbParalelTPL;
        private Label label7;
        private Label lbShetPul;
        private Label lbShetTPL;
        private Label lbShetPosled;
    }
}