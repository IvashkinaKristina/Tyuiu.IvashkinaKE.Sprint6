using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.IvashkinaKE.Sprint6.Task2.V10.Lib;

namespace Tyuiu.IvashkinaKE.Sprint6.Task2.V10
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

                this.chartFunction.Titles.Add("График функции f(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDone_IKE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_IKE.BackColor = Color.Blue;
        }

        private void buttonDone_IKE_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_IKE.BackColor = Color.Red;
        }

        private void buttonDone_IKE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_IKE.BackColor = Color.Blue;
        }

        private void buttonHelp_IKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы АСОиУб-23-1 Ивашкина Кристина Эдуардовна");
        }
    }
}
