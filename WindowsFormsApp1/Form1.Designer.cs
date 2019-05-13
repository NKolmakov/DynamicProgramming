namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericOrganizations = new System.Windows.Forms.NumericUpDown();
            this.numericYears = new System.Windows.Forms.NumericUpDown();
            this.numericColumns = new System.Windows.Forms.NumericUpDown();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrganizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX});
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(300, 66);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество предприятий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество лет плана";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество столбцов(выделяемые суммы)";
            // 
            // numericOrganizations
            // 
            this.numericOrganizations.Location = new System.Drawing.Point(211, 27);
            this.numericOrganizations.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericOrganizations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericOrganizations.Name = "numericOrganizations";
            this.numericOrganizations.Size = new System.Drawing.Size(60, 20);
            this.numericOrganizations.TabIndex = 4;
            this.numericOrganizations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericYears
            // 
            this.numericYears.Location = new System.Drawing.Point(211, 56);
            this.numericYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericYears.Name = "numericYears";
            this.numericYears.Size = new System.Drawing.Size(60, 20);
            this.numericYears.TabIndex = 5;
            this.numericYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericColumns
            // 
            this.numericColumns.Location = new System.Drawing.Point(256, 121);
            this.numericColumns.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericColumns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericColumns.Name = "numericColumns";
            this.numericColumns.Size = new System.Drawing.Size(57, 20);
            this.numericColumns.TabIndex = 6;
            this.numericColumns.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "Xi";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericColumns);
            this.Controls.Add(this.numericYears);
            this.Controls.Add(this.numericOrganizations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrganizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericOrganizations;
        private System.Windows.Forms.NumericUpDown numericYears;
        private System.Windows.Forms.NumericUpDown numericColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
    }
}

