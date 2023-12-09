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

using Tyuiu.IvashkinaKE.Sprint6.Task4.V14.Lib;

namespace Tyuiu.IvashkinaKE.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        private void buttonDone_IKE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_IKE.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_IKE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray; 
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_IKE.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_IKE.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_IKE.Text = "";
                chartFunction_IKE.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_IKE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_IKE.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_IKE_Click(object sender, EventArgs e)
        {
            try
            {

                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFile.Task4V14";
                File.WriteAllText(path, textBoxResult_IKE.Text);

                DialogResult dialogResult = MessageBox.Show(" Файл " + path + " сохранен успешно!\n Открыть его в блакноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_IKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы АСОиУб-23-1 Ивашкина Кристина Эдуардовна", "Сообщение");
        }
    }
}
