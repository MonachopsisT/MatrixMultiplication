namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.matrix1 = new System.Windows.Forms.DataGridView();
            this.matrix2 = new System.Windows.Forms.DataGridView();
            this.enter1 = new System.Windows.Forms.Button();
            this.enter2 = new System.Windows.Forms.Button();
            this.row1 = new System.Windows.Forms.TextBox();
            this.column1 = new System.Windows.Forms.TextBox();
            this.row2 = new System.Windows.Forms.TextBox();
            this.column2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix1
            // 
            this.matrix1.AllowUserToAddRows = false;
            this.matrix1.AllowUserToDeleteRows = false;
            this.matrix1.AllowUserToResizeColumns = false;
            this.matrix1.AllowUserToResizeRows = false;
            this.matrix1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix1.ColumnHeadersVisible = false;
            this.matrix1.Location = new System.Drawing.Point(12, 74);
            this.matrix1.Name = "matrix1";
            this.matrix1.RowHeadersVisible = false;
            this.matrix1.Size = new System.Drawing.Size(246, 156);
            this.matrix1.TabIndex = 0;
            // 
            // matrix2
            // 
            this.matrix2.AllowUserToAddRows = false;
            this.matrix2.AllowUserToDeleteRows = false;
            this.matrix2.AllowUserToResizeColumns = false;
            this.matrix2.AllowUserToResizeRows = false;
            this.matrix2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix2.ColumnHeadersVisible = false;
            this.matrix2.Location = new System.Drawing.Point(346, 74);
            this.matrix2.Name = "matrix2";
            this.matrix2.RowHeadersVisible = false;
            this.matrix2.Size = new System.Drawing.Size(246, 156);
            this.matrix2.TabIndex = 1;
            // 
            // enter1
            // 
            this.enter1.Location = new System.Drawing.Point(150, 23);
            this.enter1.Name = "enter1";
            this.enter1.Size = new System.Drawing.Size(75, 23);
            this.enter1.TabIndex = 2;
            this.enter1.Text = "Enter";
            this.enter1.UseVisualStyleBackColor = true;
            this.enter1.Click += new System.EventHandler(this.enter1_Click);
            // 
            // enter2
            // 
            this.enter2.Location = new System.Drawing.Point(458, 29);
            this.enter2.Name = "enter2";
            this.enter2.Size = new System.Drawing.Size(75, 23);
            this.enter2.TabIndex = 3;
            this.enter2.Text = "Enter";
            this.enter2.UseVisualStyleBackColor = true;
            this.enter2.Click += new System.EventHandler(this.enter2_Click);
            // 
            // row1
            // 
            this.row1.Location = new System.Drawing.Point(82, 12);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(62, 20);
            this.row1.TabIndex = 4;
            // 
            // column1
            // 
            this.column1.Location = new System.Drawing.Point(82, 38);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(62, 20);
            this.column1.TabIndex = 5;
            // 
            // row2
            // 
            this.row2.Location = new System.Drawing.Point(390, 19);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(62, 20);
            this.row2.TabIndex = 6;
            // 
            // column2
            // 
            this.column2.Location = new System.Drawing.Point(390, 44);
            this.column2.Name = "column2";
            this.column2.Size = new System.Drawing.Size(62, 20);
            this.column2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Row:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Column:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Row:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Column: ";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(1, 236);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // result
            // 
            this.result.AllowUserToAddRows = false;
            this.result.AllowUserToDeleteRows = false;
            this.result.AllowUserToResizeColumns = false;
            this.result.AllowUserToResizeRows = false;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.ColumnHeadersVisible = false;
            this.result.Location = new System.Drawing.Point(679, 74);
            this.result.Name = "result";
            this.result.RowHeadersVisible = false;
            this.result.Size = new System.Drawing.Size(246, 156);
            this.result.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(281, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 55);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(609, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 55);
            this.label6.TabIndex = 15;
            this.label6.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 522);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.column2);
            this.Controls.Add(this.row2);
            this.Controls.Add(this.column1);
            this.Controls.Add(this.row1);
            this.Controls.Add(this.enter2);
            this.Controls.Add(this.enter1);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.matrix1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrix1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix1;
        private System.Windows.Forms.DataGridView matrix2;
        private System.Windows.Forms.Button enter1;
        private System.Windows.Forms.Button enter2;
        private System.Windows.Forms.TextBox row1;
        private System.Windows.Forms.TextBox column1;
        private System.Windows.Forms.TextBox row2;
        private System.Windows.Forms.TextBox column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

