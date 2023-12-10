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

using Tyuiu.IvashkinaKE.Sprint6.Task6.V26.Lib;

namespace Tyuiu.IvashkinaKE.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
private void buttonOpenFile_IKE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IKE.ShowDialog();
            openFilePath = openFileDialogTask_IKE.FileName;
            textBoxInput_IKE.Text = File.ReadAllText(openFilePath);
            buttonDone_IKE.Enabled = true;            
            groupBoxInput_IKE.Text = groupBoxInput_IKE.Text + " " + openFileDialogTask_IKE.FileName;

        }
        private void buttonDone_IKE_Click(object sender, EventArgs e)
        {
            //string path = @"C:\DataSprint6\InPutFileTask6V26.txt";
            textBoxResult_IKE.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_IKE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        

        
    }
}
