namespace BANK
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
            this.DB = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANKDataSet = new BANK.BANKDataSet();
            this.bankDBTableAdapter = new BANK.BANKDataSetTableAdapters.BankDBTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DB
            // 
            this.DB.AutoGenerateColumns = false;
            this.DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMERDataGridViewTextBoxColumn,
            this.pASSDataGridViewTextBoxColumn,
            this.mONEYDataGridViewTextBoxColumn});
            this.DB.DataSource = this.bankDBBindingSource;
            this.DB.Location = new System.Drawing.Point(12, 12);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(776, 185);
            this.DB.TabIndex = 0;
            this.DB.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nOMERDataGridViewTextBoxColumn
            // 
            this.nOMERDataGridViewTextBoxColumn.DataPropertyName = "NOMER";
            this.nOMERDataGridViewTextBoxColumn.HeaderText = "NOMER";
            this.nOMERDataGridViewTextBoxColumn.Name = "nOMERDataGridViewTextBoxColumn";
            this.nOMERDataGridViewTextBoxColumn.Width = 200;
            // 
            // pASSDataGridViewTextBoxColumn
            // 
            this.pASSDataGridViewTextBoxColumn.DataPropertyName = "PASS";
            this.pASSDataGridViewTextBoxColumn.HeaderText = "PASS";
            this.pASSDataGridViewTextBoxColumn.Name = "pASSDataGridViewTextBoxColumn";
            this.pASSDataGridViewTextBoxColumn.Width = 200;
            // 
            // mONEYDataGridViewTextBoxColumn
            // 
            this.mONEYDataGridViewTextBoxColumn.DataPropertyName = "MONEY";
            this.mONEYDataGridViewTextBoxColumn.HeaderText = "MONEY";
            this.mONEYDataGridViewTextBoxColumn.Name = "mONEYDataGridViewTextBoxColumn";
            this.mONEYDataGridViewTextBoxColumn.Width = 200;
            // 
            // bankDBBindingSource
            // 
            this.bankDBBindingSource.DataMember = "BankDB";
            this.bankDBBindingSource.DataSource = this.bANKDataSet;
            // 
            // bANKDataSet
            // 
            this.bANKDataSet.DataSetName = "BANKDataSet";
            this.bANKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDBTableAdapter
            // 
            this.bankDBTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SAVE DATAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public BANKDataSet bANKDataSet;
        public System.Windows.Forms.BindingSource bankDBBindingSource;
        public BANKDataSetTableAdapters.BankDBTableAdapter bankDBTableAdapter;
        public System.Windows.Forms.DataGridView DB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONEYDataGridViewTextBoxColumn;
    }
}

