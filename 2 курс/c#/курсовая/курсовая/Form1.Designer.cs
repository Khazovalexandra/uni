
namespace курсовая
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.потребитеьскаякорзинаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.потребитеьская_корзинаDataSet = new курсовая.Потребитеьская_корзинаDataSet();
            this.доходЧленаСемьиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доход_Члена_СемьиTableAdapter = new курсовая.Потребитеьская_корзинаDataSetTableAdapters.Доход_Члена_СемьиTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.продуктTableAdapter1 = new курсовая.Потребитеьская_корзинаDataSetTableAdapters.ПродуктTableAdapter();
            this.доходЧленаСемьиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категорияTableAdapter = new курсовая.Потребитеьская_корзинаDataSetTableAdapters.КатегорияTableAdapter();
            this.корзинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.корзинаTableAdapter = new курсовая.Потребитеьская_корзинаDataSetTableAdapters.КорзинаTableAdapter();
            this.продуктBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.членыСемьиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.члены_СемьиTableAdapter = new курсовая.Потребитеьская_корзинаDataSetTableAdapters.Члены_СемьиTableAdapter();
            this.потребитеьская_корзинаDataSet1 = new курсовая.Потребитеьская_корзинаDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребитеьскаякорзинаDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребитеьская_корзинаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доходЧленаСемьиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доходЧленаСемьиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.членыСемьиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребитеьская_корзинаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 228);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // потребитеьскаякорзинаDataSetBindingSource
            // 
            this.потребитеьскаякорзинаDataSetBindingSource.DataSource = this.потребитеьская_корзинаDataSet;
            this.потребитеьскаякорзинаDataSetBindingSource.Position = 0;
            // 
            // потребитеьская_корзинаDataSet
            // 
            this.потребитеьская_корзинаDataSet.DataSetName = "Потребитеьская_корзинаDataSet";
            this.потребитеьская_корзинаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // доходЧленаСемьиBindingSource
            // 
            this.доходЧленаСемьиBindingSource.DataMember = "Доход_Члена_Семьи";
            this.доходЧленаСемьиBindingSource.DataSource = this.потребитеьскаякорзинаDataSetBindingSource;
            // 
            // доход_Члена_СемьиTableAdapter
            // 
            this.доход_Члена_СемьиTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "сохранить изменения в Продукт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // продуктTableAdapter1
            // 
            this.продуктTableAdapter1.ClearBeforeFill = true;
            // 
            // доходЧленаСемьиBindingSource1
            // 
            this.доходЧленаСемьиBindingSource1.DataMember = "Доход_Члена_Семьи";
            this.доходЧленаСемьиBindingSource1.DataSource = this.потребитеьскаякорзинаDataSetBindingSource;
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.потребитеьскаякорзинаDataSetBindingSource;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // корзинаBindingSource
            // 
            this.корзинаBindingSource.DataMember = "Корзина";
            this.корзинаBindingSource.DataSource = this.потребитеьскаякорзинаDataSetBindingSource;
            // 
            // корзинаTableAdapter
            // 
            this.корзинаTableAdapter.ClearBeforeFill = true;
            // 
            // продуктBindingSource
            // 
            this.продуктBindingSource.DataMember = "Продукт";
            this.продуктBindingSource.DataSource = this.потребитеьскаякорзинаDataSetBindingSource;
            // 
            // членыСемьиBindingSource
            // 
            this.членыСемьиBindingSource.DataMember = "Члены_Семьи";
            this.членыСемьиBindingSource.DataSource = this.потребитеьскаякорзинаDataSetBindingSource;
            // 
            // члены_СемьиTableAdapter
            // 
            this.члены_СемьиTableAdapter.ClearBeforeFill = true;
            // 
            // потребитеьская_корзинаDataSet1
            // 
            this.потребитеьская_корзинаDataSet1.DataSetName = "Потребитеьская_корзинаDataSet";
            this.потребитеьская_корзинаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавление расхода";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(368, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(450, 228);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "сохранить изменения в Категорию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Расходы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребитеьскаякорзинаDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребитеьская_корзинаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доходЧленаСемьиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доходЧленаСемьиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.членыСемьиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.потребитеьская_корзинаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource потребитеьскаякорзинаDataSetBindingSource;
        private Потребитеьская_корзинаDataSet потребитеьская_корзинаDataSet;
        private System.Windows.Forms.BindingSource доходЧленаСемьиBindingSource;
        private Потребитеьская_корзинаDataSetTableAdapters.Доход_Члена_СемьиTableAdapter доход_Члена_СемьиTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource доходЧленаСемьиBindingSource1;
        private Потребитеьская_корзинаDataSetTableAdapters.ПродуктTableAdapter продуктTableAdapter1;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private Потребитеьская_корзинаDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.BindingSource корзинаBindingSource;
        private Потребитеьская_корзинаDataSetTableAdapters.КорзинаTableAdapter корзинаTableAdapter;
        private System.Windows.Forms.BindingSource продуктBindingSource;
        private System.Windows.Forms.BindingSource членыСемьиBindingSource;
        private Потребитеьская_корзинаDataSetTableAdapters.Члены_СемьиTableAdapter члены_СемьиTableAdapter;
        private Потребитеьская_корзинаDataSet потребитеьская_корзинаDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}

