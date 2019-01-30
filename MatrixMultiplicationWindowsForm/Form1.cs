using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int kolona1;
        static int red1;
        static int kolona2;
        static int red2;
        static double[,] CalcMatrix(double[,] a, double[,] b)
        {
            double[,] MatrixResult = new double[a.GetLength(0), b.GetLength(1)];
            if (a.GetLength(1) == b.GetLength(0))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        MatrixResult[i, j] = 0;
                        for (int k = 0; k < b.GetLength(0); k++)
                        {
                            MatrixResult[i, j] += a[i, k] * b[k, j];
                        }
                    }
            }
            else
            {
                MatrixResult = null;
                MessageBox.Show("Error");
            }
            return MatrixResult;
        }


        private void enter1_Click(object sender, EventArgs e)
        {
            red1 = int.Parse(row1.Text);
            kolona1 = int.Parse(column1.Text);

            for (int i = 0; i < kolona1; i++)
            {
                matrix1.Columns.Add("", "");
                DataGridViewColumn column = matrix1.Columns[i];
                column.Width = 50;
            }
            matrix1.Rows.Add(red1);
            enter1.Enabled = false;
            column1.Enabled = false;
            row1.Enabled = false;
        }

        private void enter2_Click(object sender, EventArgs e)
        {
            red2 = int.Parse(row2.Text);
            kolona2 = int.Parse(column2.Text);
            for (int i = 0; i < kolona2; i++)
            {
                matrix2.Columns.Add("", "");
                DataGridViewColumn column = matrix2.Columns[i];
                column.Width = 50;
            }
            matrix2.Rows.Add(red2);
            enter2.Enabled = false;
            column2.Enabled = false;
            row2.Enabled = false;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            if (enter1.Enabled == false && enter2.Enabled == false)
                if (kolona1 != red2)
                {
                    MessageBox.Show("Error");
                }

                else
                {
                    
                    for (int i = 0; i < kolona2; i++)
                    {
                        result.Columns.Add("", "");
                        DataGridViewColumn column = result.Columns[i];
                        column.Width = 50;
                    }
                    result.Rows.Add(red1);

                    double[,] matrix_1; 
                    matrix_1 = new double[red1, kolona1];
                    double[,] matrix_2;
                    matrix_2 = new double[red2, kolona2];

                    for (int i = 0; i < red1; i++)
                    {
                        for (int j = 0; j < kolona1; j++)
                        {
                            matrix_1[i, j] = double.Parse(matrix1[j, i].Value.ToString());
                        }
                    }
                    for (int i = 0; i < red2; i++)
                    {
                        for (int j = 0; j < kolona2; j++)
                        {
                            matrix_2[i, j] = double.Parse(matrix2[j, i].Value.ToString());
                        }
                    }
                    double[,] result_matrix = new double[red1, kolona2];

                    result_matrix = CalcMatrix(matrix_1,matrix_2);
                    for (int i = 0; i < red1; i++)
                    {
                        for (int k = 0; k < kolona2; k++)
                        {
                            result[k, i].Value = result_matrix[i, k];
                        }
                    }
                }

        }



    }
}
