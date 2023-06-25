namespace БД
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bttn1 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.bttn3 = new System.Windows.Forms.Button();
            this.самолетDataSet = new БД.СамолетDataSet();
            this.билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.билетTableAdapter = new БД.СамолетDataSetTableAdapters.БилетTableAdapter();
            this.билетТалонBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.талонTableAdapter = new БД.СамолетDataSetTableAdapters.ТалонTableAdapter();
            this.рейсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсTableAdapter = new БД.СамолетDataSetTableAdapters.РейсTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.местоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.самолетDataSet1 = new БД.СамолетDataSet1();
            this.самолетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.талонBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.билетBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.билетTableAdapter1 = new БД.СамолетDataSet1TableAdapters.БилетTableAdapter();
            this.билетТалонBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.билетТалонBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.рейсBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.рейсTableAdapter1 = new БД.СамолетDataSet1TableAdapters.РейсTableAdapter();
            this.пассажирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пассажирTableAdapter = new БД.СамолетDataSet1TableAdapters.ПассажирTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.самолетTableAdapter = new БД.СамолетDataSet1TableAdapters.СамолетTableAdapter();
            this.рейсBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.классBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.классTableAdapter = new БД.СамолетDataSet1TableAdapters.КлассTableAdapter();
            this.талонTableAdapter1 = new БД.СамолетDataSet1TableAdapters.ТалонTableAdapter();
            this.билетBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.местоTableAdapter = new БД.СамолетDataSet1TableAdapters.МестоTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.самолетDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетТалонBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.талонBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетТалонBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетТалонBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn1
            // 
            this.bttn1.Location = new System.Drawing.Point(195, 12);
            this.bttn1.Name = "bttn1";
            this.bttn1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttn1.Size = new System.Drawing.Size(149, 24);
            this.bttn1.TabIndex = 0;
            this.bttn1.Text = "загрузить";
            this.bttn1.UseVisualStyleBackColor = true;
            this.bttn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn2
            // 
            this.bttn2.Location = new System.Drawing.Point(360, 12);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(151, 23);
            this.bttn2.TabIndex = 1;
            this.bttn2.Text = "сохранить";
            this.bttn2.UseVisualStyleBackColor = true;
            this.bttn2.Click += new System.EventHandler(this.bttn2_Click);
            // 
            // bttn3
            // 
            this.bttn3.Location = new System.Drawing.Point(517, 355);
            this.bttn3.Name = "bttn3";
            this.bttn3.Size = new System.Drawing.Size(70, 59);
            this.bttn3.TabIndex = 2;
            this.bttn3.Text = "выполнить запрос";
            this.bttn3.UseVisualStyleBackColor = true;
            this.bttn3.Click += new System.EventHandler(this.bttn3_Click);
            // 
            // самолетDataSet
            // 
            this.самолетDataSet.DataSetName = "СамолетDataSet";
            this.самолетDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // билетBindingSource
            // 
            this.билетBindingSource.DataMember = "Билет";
            this.билетBindingSource.DataSource = this.самолетDataSet;
            // 
            // билетTableAdapter
            // 
            this.билетTableAdapter.ClearBeforeFill = true;
            // 
            // билетТалонBindingSource
            // 
            this.билетТалонBindingSource.DataMember = "БилетТалон";
            this.билетТалонBindingSource.DataSource = this.билетBindingSource;
            // 
            // талонTableAdapter
            // 
            this.талонTableAdapter.ClearBeforeFill = true;
            // 
            // рейсBindingSource
            // 
            this.рейсBindingSource.DataMember = "Рейс";
            this.рейсBindingSource.DataSource = this.самолетDataSet;
            // 
            // рейсTableAdapter
            // 
            this.рейсTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(483, 212);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // местоBindingSource
            // 
            this.местоBindingSource.DataMember = "Место";
            this.местоBindingSource.DataSource = this.самолетDataSet1;
            // 
            // самолетDataSet1
            // 
            this.самолетDataSet1.DataSetName = "СамолетDataSet1";
            this.самолетDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // самолетBindingSource
            // 
            this.самолетBindingSource.DataMember = "Самолет";
            this.самолетBindingSource.DataSource = this.самолетDataSet1;
            this.самолетBindingSource.CurrentChanged += new System.EventHandler(this.самолетBindingSource_CurrentChanged);
            // 
            // талонBindingSource
            // 
            this.талонBindingSource.DataMember = "Талон";
            this.талонBindingSource.DataSource = this.самолетDataSet1;
            // 
            // билетBindingSource1
            // 
            this.билетBindingSource1.DataMember = "Билет";
            this.билетBindingSource1.DataSource = this.самолетDataSet1;
            // 
            // билетTableAdapter1
            // 
            this.билетTableAdapter1.ClearBeforeFill = true;
            // 
            // билетТалонBindingSource1
            // 
            this.билетТалонBindingSource1.DataMember = "БилетТалон";
            this.билетТалонBindingSource1.DataSource = this.билетBindingSource;
            // 
            // билетТалонBindingSource2
            // 
            this.билетТалонBindingSource2.DataMember = "БилетТалон";
            this.билетТалонBindingSource2.DataSource = this.билетBindingSource;
            // 
            // рейсBindingSource1
            // 
            this.рейсBindingSource1.DataMember = "Рейс";
            this.рейсBindingSource1.DataSource = this.самолетDataSet1;
            // 
            // рейсTableAdapter1
            // 
            this.рейсTableAdapter1.ClearBeforeFill = true;
            // 
            // пассажирBindingSource
            // 
            this.пассажирBindingSource.DataMember = "Пассажир";
            this.пассажирBindingSource.DataSource = this.самолетDataSet1;
            // 
            // пассажирTableAdapter
            // 
            this.пассажирTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Самолет",
            "Пассажир",
            "Рейс",
            "Талон",
            "Билет",
            "Класс",
            "Место"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Самолет ",
            "Пассажир",
            "Рейс",
            "Талон",
            "Билет",
            "Место",
            "Класс"});
            this.comboBox1.Location = new System.Drawing.Point(27, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // самолетTableAdapter
            // 
            this.самолетTableAdapter.ClearBeforeFill = true;
            // 
            // рейсBindingSource2
            // 
            this.рейсBindingSource2.DataMember = "Рейс";
            this.рейсBindingSource2.DataSource = this.самолетDataSet1;
            // 
            // классBindingSource
            // 
            this.классBindingSource.DataMember = "Класс";
            this.классBindingSource.DataSource = this.самолетDataSet1;
            // 
            // классTableAdapter
            // 
            this.классTableAdapter.ClearBeforeFill = true;
            // 
            // талонTableAdapter1
            // 
            this.талонTableAdapter1.ClearBeforeFill = true;
            // 
            // билетBindingSource2
            // 
            this.билетBindingSource2.DataMember = "Билет";
            this.билетBindingSource2.DataSource = this.самолетDataSet1;
            // 
            // местоTableAdapter
            // 
            this.местоTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 108);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя сервера";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя БД";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "строка подключения";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(361, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 355);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(484, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(517, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MS Access";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(517, 272);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SQL Server";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttn3);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.bttn1);
            this.Name = "Form1";
            this.Text = "Базы данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.самолетDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетТалонBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.талонBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетТалонBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетТалонBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button bttn3;
        private СамолетDataSet самолетDataSet;
        private System.Windows.Forms.BindingSource билетBindingSource;
        private СамолетDataSetTableAdapters.БилетTableAdapter билетTableAdapter;
        private System.Windows.Forms.BindingSource билетТалонBindingSource;
        private СамолетDataSetTableAdapters.ТалонTableAdapter талонTableAdapter;
        private System.Windows.Forms.BindingSource рейсBindingSource;
        private СамолетDataSetTableAdapters.РейсTableAdapter рейсTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private СамолетDataSet1 самолетDataSet1;
        private System.Windows.Forms.BindingSource билетBindingSource1;
        private СамолетDataSet1TableAdapters.БилетTableAdapter билетTableAdapter1;
        private System.Windows.Forms.BindingSource билетТалонBindingSource1;
        private System.Windows.Forms.BindingSource билетТалонBindingSource2;
        private System.Windows.Forms.BindingSource рейсBindingSource1;
        private СамолетDataSet1TableAdapters.РейсTableAdapter рейсTableAdapter1;
        private System.Windows.Forms.BindingSource пассажирBindingSource;
        private СамолетDataSet1TableAdapters.ПассажирTableAdapter пассажирTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource самолетBindingSource;
        private СамолетDataSet1TableAdapters.СамолетTableAdapter самолетTableAdapter;
        private System.Windows.Forms.BindingSource рейсBindingSource2;
        private System.Windows.Forms.BindingSource классBindingSource;
        private СамолетDataSet1TableAdapters.КлассTableAdapter классTableAdapter;
        private System.Windows.Forms.BindingSource талонBindingSource;
        private СамолетDataSet1TableAdapters.ТалонTableAdapter талонTableAdapter1;
        private System.Windows.Forms.BindingSource билетBindingSource2;
        private System.Windows.Forms.BindingSource местоBindingSource;
        private СамолетDataSet1TableAdapters.МестоTableAdapter местоTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
    }
}

