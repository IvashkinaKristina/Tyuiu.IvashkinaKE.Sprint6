
namespace Tyuiu.IvashkinaKE.Sprint6.Task4.V14
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTop_IKE = new System.Windows.Forms.Panel();
            this.groupBoxInputData_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_IKE = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_IKE = new System.Windows.Forms.TextBox();
            this.labelStopStep_IKE = new System.Windows.Forms.Label();
            this.labelStartStep_IKE = new System.Windows.Forms.Label();
            this.buttonDone_IKE = new System.Windows.Forms.Button();
            this.buttonSave_IKE = new System.Windows.Forms.Button();
            this.buttonHelp_IKE = new System.Windows.Forms.Button();
            this.groupBoxTask_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IKE = new System.Windows.Forms.TextBox();
            this.panelLeft_IKE = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_IKE = new System.Windows.Forms.TextBox();
            this.panelRigth_IKE = new System.Windows.Forms.Panel();
            this.chartFunction_IKE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterPanel_IKE = new System.Windows.Forms.Splitter();
            this.panelTop_IKE.SuspendLayout();
            this.groupBoxInputData_IKE.SuspendLayout();
            this.groupBoxTask_IKE.SuspendLayout();
            this.panelLeft_IKE.SuspendLayout();
            this.groupBoxOutPutData_IKE.SuspendLayout();
            this.panelRigth_IKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_IKE
            // 
            this.panelTop_IKE.Controls.Add(this.groupBoxInputData_IKE);
            this.panelTop_IKE.Controls.Add(this.buttonDone_IKE);
            this.panelTop_IKE.Controls.Add(this.buttonSave_IKE);
            this.panelTop_IKE.Controls.Add(this.buttonHelp_IKE);
            this.panelTop_IKE.Controls.Add(this.groupBoxTask_IKE);
            this.panelTop_IKE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_IKE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_IKE.Name = "panelTop_IKE";
            this.panelTop_IKE.Size = new System.Drawing.Size(1041, 100);
            this.panelTop_IKE.TabIndex = 0;
            // 
            // groupBoxInputData_IKE
            // 
            this.groupBoxInputData_IKE.Controls.Add(this.textBoxStopStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.textBoxStartStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.labelStopStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.labelStartStep_IKE);
            this.groupBoxInputData_IKE.Location = new System.Drawing.Point(492, 4);
            this.groupBoxInputData_IKE.Name = "groupBoxInputData_IKE";
            this.groupBoxInputData_IKE.Size = new System.Drawing.Size(237, 90);
            this.groupBoxInputData_IKE.TabIndex = 4;
            this.groupBoxInputData_IKE.TabStop = false;
            this.groupBoxInputData_IKE.Text = "Ввод данных:";
            // 
            // textBoxStopStep_IKE
            // 
            this.textBoxStopStep_IKE.Location = new System.Drawing.Point(129, 62);
            this.textBoxStopStep_IKE.Name = "textBoxStopStep_IKE";
            this.textBoxStopStep_IKE.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_IKE.TabIndex = 3;
            this.textBoxStopStep_IKE.Text = "5";
            // 
            // textBoxStartStep_IKE
            // 
            this.textBoxStartStep_IKE.Location = new System.Drawing.Point(6, 62);
            this.textBoxStartStep_IKE.Name = "textBoxStartStep_IKE";
            this.textBoxStartStep_IKE.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_IKE.TabIndex = 2;
            this.textBoxStartStep_IKE.Text = "-5";
            // 
            // labelStopStep_IKE
            // 
            this.labelStopStep_IKE.AutoSize = true;
            this.labelStopStep_IKE.Location = new System.Drawing.Point(126, 38);
            this.labelStopStep_IKE.Name = "labelStopStep_IKE";
            this.labelStopStep_IKE.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_IKE.TabIndex = 1;
            this.labelStopStep_IKE.Text = "Конец шага:";
            // 
            // labelStartStep_IKE
            // 
            this.labelStartStep_IKE.AutoSize = true;
            this.labelStartStep_IKE.Location = new System.Drawing.Point(6, 38);
            this.labelStartStep_IKE.Name = "labelStartStep_IKE";
            this.labelStartStep_IKE.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_IKE.TabIndex = 0;
            this.labelStartStep_IKE.Text = "Старт шага:";
            // 
            // buttonDone_IKE
            // 
            this.buttonDone_IKE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_IKE.Location = new System.Drawing.Point(735, 22);
            this.buttonDone_IKE.Name = "buttonDone_IKE";
            this.buttonDone_IKE.Size = new System.Drawing.Size(100, 57);
            this.buttonDone_IKE.TabIndex = 3;
            this.buttonDone_IKE.Text = "Выполнить";
            this.buttonDone_IKE.UseVisualStyleBackColor = false;
            this.buttonDone_IKE.Click += new System.EventHandler(this.buttonDone_IKE_Click);
            // 
            // buttonSave_IKE
            // 
            this.buttonSave_IKE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_IKE.Location = new System.Drawing.Point(841, 22);
            this.buttonSave_IKE.Name = "buttonSave_IKE";
            this.buttonSave_IKE.Size = new System.Drawing.Size(96, 57);
            this.buttonSave_IKE.TabIndex = 2;
            this.buttonSave_IKE.Text = "Сохранить";
            this.buttonSave_IKE.UseVisualStyleBackColor = false;
            this.buttonSave_IKE.Click += new System.EventHandler(this.buttonSave_IKE_Click);
            // 
            // buttonHelp_IKE
            // 
            this.buttonHelp_IKE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_IKE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_IKE.Location = new System.Drawing.Point(956, 22);
            this.buttonHelp_IKE.Name = "buttonHelp_IKE";
            this.buttonHelp_IKE.Size = new System.Drawing.Size(82, 57);
            this.buttonHelp_IKE.TabIndex = 1;
            this.buttonHelp_IKE.Text = "Справка";
            this.buttonHelp_IKE.UseVisualStyleBackColor = false;
            this.buttonHelp_IKE.Click += new System.EventHandler(this.buttonHelp_IKE_Click);
            // 
            // groupBoxTask_IKE
            // 
            this.groupBoxTask_IKE.Controls.Add(this.textBoxTask_IKE);
            this.groupBoxTask_IKE.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_IKE.Name = "groupBoxTask_IKE";
            this.groupBoxTask_IKE.Size = new System.Drawing.Size(485, 91);
            this.groupBoxTask_IKE.TabIndex = 0;
            this.groupBoxTask_IKE.TabStop = false;
            this.groupBoxTask_IKE.Text = "Условие:";
            // 
            // textBoxTask_IKE
            // 
            this.textBoxTask_IKE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IKE.Location = new System.Drawing.Point(7, 19);
            this.textBoxTask_IKE.Multiline = true;
            this.textBoxTask_IKE.Name = "textBoxTask_IKE";
            this.textBoxTask_IKE.ReadOnly = true;
            this.textBoxTask_IKE.Size = new System.Drawing.Size(475, 66);
            this.textBoxTask_IKE.TabIndex = 0;
            this.textBoxTask_IKE.Text = "Протабулировать функцию f(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести" +
    " в textBox, построить график функции и сохранить в файл OutPutFileTask4V14.txt п" +
    "о нажатию кнопки.";
            // 
            // panelLeft_IKE
            // 
            this.panelLeft_IKE.Controls.Add(this.groupBoxOutPutData_IKE);
            this.panelLeft_IKE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_IKE.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_IKE.Name = "panelLeft_IKE";
            this.panelLeft_IKE.Size = new System.Drawing.Size(228, 303);
            this.panelLeft_IKE.TabIndex = 0;
            // 
            // groupBoxOutPutData_IKE
            // 
            this.groupBoxOutPutData_IKE.Controls.Add(this.textBoxResult_IKE);
            this.groupBoxOutPutData_IKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_IKE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_IKE.Name = "groupBoxOutPutData_IKE";
            this.groupBoxOutPutData_IKE.Size = new System.Drawing.Size(228, 303);
            this.groupBoxOutPutData_IKE.TabIndex = 0;
            this.groupBoxOutPutData_IKE.TabStop = false;
            this.groupBoxOutPutData_IKE.Text = "Вывод:";
            this.groupBoxOutPutData_IKE.Enter += new System.EventHandler(this.groupBoxOutPutData_IKE_Enter);
            // 
            // textBoxResult_IKE
            // 
            this.textBoxResult_IKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_IKE.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_IKE.Multiline = true;
            this.textBoxResult_IKE.Name = "textBoxResult_IKE";
            this.textBoxResult_IKE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_IKE.Size = new System.Drawing.Size(222, 282);
            this.textBoxResult_IKE.TabIndex = 0;
            // 
            // panelRigth_IKE
            // 
            this.panelRigth_IKE.Controls.Add(this.chartFunction_IKE);
            this.panelRigth_IKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRigth_IKE.Location = new System.Drawing.Point(228, 100);
            this.panelRigth_IKE.Name = "panelRigth_IKE";
            this.panelRigth_IKE.Size = new System.Drawing.Size(813, 303);
            this.panelRigth_IKE.TabIndex = 0;
            // 
            // chartFunction_IKE
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_IKE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_IKE.Legends.Add(legend1);
            this.chartFunction_IKE.Location = new System.Drawing.Point(7, 4);
            this.chartFunction_IKE.Name = "chartFunction_IKE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_IKE.Series.Add(series1);
            this.chartFunction_IKE.Size = new System.Drawing.Size(803, 296);
            this.chartFunction_IKE.TabIndex = 0;
            this.chartFunction_IKE.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции f(x)";
            this.chartFunction_IKE.Titles.Add(title1);
            // 
            // splitterPanel_IKE
            // 
            this.splitterPanel_IKE.Location = new System.Drawing.Point(228, 100);
            this.splitterPanel_IKE.Name = "splitterPanel_IKE";
            this.splitterPanel_IKE.Size = new System.Drawing.Size(3, 303);
            this.splitterPanel_IKE.TabIndex = 1;
            this.splitterPanel_IKE.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 403);
            this.Controls.Add(this.splitterPanel_IKE);
            this.Controls.Add(this.panelRigth_IKE);
            this.Controls.Add(this.panelLeft_IKE);
            this.Controls.Add(this.panelTop_IKE);
            this.MinimumSize = new System.Drawing.Size(1059, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 14 | Ивашкина К. Э.";
            this.panelTop_IKE.ResumeLayout(false);
            this.groupBoxInputData_IKE.ResumeLayout(false);
            this.groupBoxInputData_IKE.PerformLayout();
            this.groupBoxTask_IKE.ResumeLayout(false);
            this.groupBoxTask_IKE.PerformLayout();
            this.panelLeft_IKE.ResumeLayout(false);
            this.groupBoxOutPutData_IKE.ResumeLayout(false);
            this.groupBoxOutPutData_IKE.PerformLayout();
            this.panelRigth_IKE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_IKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_IKE;
        private System.Windows.Forms.Panel panelLeft_IKE;
        private System.Windows.Forms.Panel panelRigth_IKE;
        private System.Windows.Forms.Splitter splitterPanel_IKE;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_IKE;
        private System.Windows.Forms.TextBox textBoxResult_IKE;
        private System.Windows.Forms.Button buttonHelp_IKE;
        private System.Windows.Forms.GroupBox groupBoxTask_IKE;
        private System.Windows.Forms.TextBox textBoxTask_IKE;
        private System.Windows.Forms.Button buttonDone_IKE;
        private System.Windows.Forms.Button buttonSave_IKE;
        private System.Windows.Forms.GroupBox groupBoxInputData_IKE;
        private System.Windows.Forms.Label labelStopStep_IKE;
        private System.Windows.Forms.Label labelStartStep_IKE;
        private System.Windows.Forms.TextBox textBoxStopStep_IKE;
        private System.Windows.Forms.TextBox textBoxStartStep_IKE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_IKE;
    }
}

