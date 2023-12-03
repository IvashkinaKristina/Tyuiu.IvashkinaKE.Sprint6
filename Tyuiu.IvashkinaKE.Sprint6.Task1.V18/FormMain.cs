using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.IvashkinaKE.Sprint6.Task1.V18.Lib;

namespace Tyuiu.IvashkinaKE.Sprint6.Task1.V18
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
                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_IKE.Text = "";
                textBoxResult_IKE.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_IKE.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_IKE.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |{1, 6:f2}    |", startStep, valueArray[i]);
                    textBoxResult_IKE.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_IKE.AppendText("+----------+----------+" + Environment.NewLine);

            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonHelp_IKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУб-23-1 Ивашкина Кристина Эдуардовна");
        }
    }
}
