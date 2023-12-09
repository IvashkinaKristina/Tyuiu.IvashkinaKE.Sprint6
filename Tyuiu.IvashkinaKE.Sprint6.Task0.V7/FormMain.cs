﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.IvashkinaKE.Sprint6.Task0.V7.Lib;


namespace Tyuiu.IvashkinaKE.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_IKE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_IKE.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_IKE.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_IKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студент группы АСОиУб-23-1 Ивашкина Кристина Эдуардовна", "Сообщение");  
        }

        private void groupBoxResult_IKE_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_IKE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
