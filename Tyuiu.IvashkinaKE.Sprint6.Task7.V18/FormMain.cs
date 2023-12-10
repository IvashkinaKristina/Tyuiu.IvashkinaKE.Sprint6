using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.IvashkinaKE.Sprint6.Task7.V18.Lib;

namespace Tyuiu.IvashkinaKE.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_IKE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_IKE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        string openPathFile;
        static int rows, colums;
        static int[,] mtrx;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonDone_IKE_Click(object sender, EventArgs e)
        {
            int[,] valueArray = new int[rows, colums];
            valueArray = ds.GetMatrix(openPathFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewResult_IKE.Rows[r].Cells[c].Value = valueArray[r, c];
                }
            }

            buttonSaveFile_IKE.Enabled = true;
        }

        private void buttonSaveFile_IKE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_IKE.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_IKE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_IKE.ShowDialog();

            string path = saveFileDialogMatrix_IKE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_IKE.RowCount;
            int columns = dataGridViewResult_IKE.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewResult_IKE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewResult_IKE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_IKE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_IKE_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_IKE.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_IKE_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_IKE.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_IKE_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_IKE.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_IKE_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_IKE.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_IKE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IKE.ShowDialog();
            openPathFile = openFileDialogTask_IKE.FileName;


            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openPathFile);


            dataGridViewInput_IKE.ColumnCount = colums;
            dataGridViewInput_IKE.RowCount = rows;
            dataGridViewResult_IKE.ColumnCount = colums;
            dataGridViewResult_IKE.RowCount = rows;


            for (int i = 0; i < colums; i++)
            {
                dataGridViewResult_IKE.Columns[i].Width = 25;
                dataGridViewInput_IKE.Columns[i].Width = 25;
            }


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInput_IKE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openPathFile);
            buttonDone_IKE.Enabled = true;
        }
    }
}
