namespace DBMS.SQL.EmployeeSales
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
            dgvEmployeeList = new DataGridView();
            dgvOrderList = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Location = new Point(26, 85);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.Size = new Size(323, 353);
            dgvEmployeeList.TabIndex = 0;
            dgvEmployeeList.CellMouseUp += dgvEmployeeList_CellMouseUp;
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(457, 85);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.Size = new Size(320, 353);
            dgvOrderList.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Employee";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(457, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "OrderList";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dgvOrderList);
            Controls.Add(dgvEmployeeList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployeeList;
        private DataGridView dgvOrderList;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
