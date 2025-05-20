namespace WindowsFormsApp5
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kvartirsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vladelecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozrastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vladelecDataGridViewTextBoxColumn,
            this.размерDataGridViewTextBoxColumn,
            this.vozrastDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kvartirsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kvartirsBindingSource
            // 
            this.kvartirsBindingSource.DataSource = typeof(WindowsFormsApp5.EF.Kvartirs);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vladelecDataGridViewTextBoxColumn
            // 
            this.vladelecDataGridViewTextBoxColumn.DataPropertyName = "Vladelec";
            this.vladelecDataGridViewTextBoxColumn.HeaderText = "Vladelec";
            this.vladelecDataGridViewTextBoxColumn.Name = "vladelecDataGridViewTextBoxColumn";
            // 
            // размерDataGridViewTextBoxColumn
            // 
            this.размерDataGridViewTextBoxColumn.DataPropertyName = "Размер";
            this.размерDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.размерDataGridViewTextBoxColumn.Name = "размерDataGridViewTextBoxColumn";
            // 
            // vozrastDataGridViewTextBoxColumn
            // 
            this.vozrastDataGridViewTextBoxColumn.DataPropertyName = "Vozrast";
            this.vozrastDataGridViewTextBoxColumn.HeaderText = "Vozrast";
            this.vozrastDataGridViewTextBoxColumn.Name = "vozrastDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vladelecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozrastDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kvartirsBindingSource;
    }
}

