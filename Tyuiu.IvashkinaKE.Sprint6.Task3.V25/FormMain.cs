using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.IvashkinaKE.Sprint6.Task3.V25.Lib;

namespace Tyuiu.IvashkinaKE.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = {
                {  14,   5,  -9,  18,  21 },
                {  -5, -12, -12,   4,  28 },
                {  27,  -2, -14,  23,  27 },
                { -19, -15,  17,  15,   1 },
                {  33,   2,   6,  24,  24 }
            };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewTaskMatrix_IKE.ColumnCount = columns;
            dataGridViewTaskMatrix_IKE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTaskMatrix_IKE.Columns[i].Width = 35;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewTaskMatrix_IKE.Rows[i].Height = 35;

                for (int j = 0; j < rows; j++)
                {
                    dataGridViewTaskMatrix_IKE.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_IKE_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewMatrixResult_IKE.ColumnCount = columns;
            dataGridViewMatrixResult_IKE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_IKE.Columns[i].Width = 35;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrixResult_IKE.Rows[i].Height = 35;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_IKE.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }

            
        }

        private void buttonHelp_IKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы АСОиУб-23-1 Ивашкина Кристина Эдуардовна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
