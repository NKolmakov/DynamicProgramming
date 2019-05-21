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
            this.dgUserData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericOrganizations = new System.Windows.Forms.NumericUpDown();
            this.numericYears = new System.Windows.Forms.NumericUpDown();
            this.numericColumns = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrganizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUserData
            // 
            this.dgUserData.AllowUserToAddRows = false;
            this.dgUserData.AllowUserToDeleteRows = false;
            this.dgUserData.AllowUserToResizeColumns = false;
            this.dgUserData.AllowUserToResizeRows = false;
            this.dgUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserData.ColumnHeadersVisible = false;
            this.dgUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX});
            this.dgUserData.Location = new System.Drawing.Point(27, 210);
            this.dgUserData.Name = "dgUserData";
            this.dgUserData.RowHeadersVisible = false;
            this.dgUserData.Size = new System.Drawing.Size(180, 90);
            this.dgUserData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество предприятий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество лет плана";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество столбцов(выделяемые суммы)";
            // 
            // numericOrganizations
            // 
            this.numericOrganizations.Location = new System.Drawing.Point(421, 15);
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
            this.numericYears.Location = new System.Drawing.Point(421, 44);
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
            this.numericColumns.Location = new System.Drawing.Point(466, 109);
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(237, 143);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 39);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "Xi";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnX.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericColumns);
            this.Controls.Add(this.numericYears);
            this.Controls.Add(this.numericOrganizations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUserData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrganizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUserData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericOrganizations;
        private System.Windows.Forms.NumericUpDown numericYears;
        private System.Windows.Forms.NumericUpDown numericColumns;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
    }
}

