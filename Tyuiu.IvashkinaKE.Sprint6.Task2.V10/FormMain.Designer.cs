
namespace Tyuiu.IvashkinaKE.Sprint6.Task2.V10
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
            this.groupBoxTask_IKE = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_IKE = new System.Windows.Forms.GroupBox();
            this.labelStopStep_IKE = new System.Windows.Forms.Label();
            this.labelStartStep_IKE = new System.Windows.Forms.Label();
            this.textBoxStopStep_IKE = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_IKE = new System.Windows.Forms.TextBox();
            this.groupBoxResult_IKE = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_IKE = new System.Windows.Forms.Label();
            this.buttonHelp_IKE = new System.Windows.Forms.Button();
            this.buttonDone_IKE = new System.Windows.Forms.Button();
            this.groupBoxTask_IKE.SuspendLayout();
            this.groupBoxInputData_IKE.SuspendLayout();
            this.groupBoxResult_IKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_IKE
            // 
            this.groupBoxTask_IKE.Controls.Add(this.textBox1);
            this.groupBoxTask_IKE.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask_IKE.Name = "groupBoxTask_IKE";
            this.groupBoxTask_IKE.Size = new System.Drawing.Size(490, 304);
            this.groupBoxTask_IKE.TabIndex = 0;
            this.groupBoxTask_IKE.TabStop = false;
            this.groupBoxTask_IKE.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(438, 188);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию f(x) на заданном диапазоне. Результат вывести в DataGridV" +
    "iew и построить график функции.";
            // 
            // groupBoxInputData_IKE
            // 
            this.groupBoxInputData_IKE.Controls.Add(this.labelStopStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.labelStartStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.textBoxStopStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.textBoxStartStep_IKE);
            this.groupBoxInputData_IKE.Location = new System.Drawing.Point(14, 323);
            this.groupBoxInputData_IKE.Name = "groupBoxInputData_IKE";
            this.groupBoxInputData_IKE.Size = new System.Drawing.Size(275, 70);
            this.groupBoxInputData_IKE.TabIndex = 1;
            this.groupBoxInputData_IKE.TabStop = false;
            this.groupBoxInputData_IKE.Text = "Ввод данных";
            // 
            // labelStopStep_IKE
            // 
            this.labelStopStep_IKE.AutoSize = true;
            this.labelStopStep_IKE.Location = new System.Drawing.Point(138, 22);
            this.labelStopStep_IKE.Name = "labelStopStep_IKE";
            this.labelStopStep_IKE.Size = new System.Drawing.Size(85, 17);
            this.labelStopStep_IKE.TabIndex = 3;
            this.labelStopStep_IKE.Text = "Конец шага";
            // 
            // labelStartStep_IKE
            // 
            this.labelStartStep_IKE.AutoSize = true;
            this.labelStartStep_IKE.Location = new System.Drawing.Point(6, 22);
            this.labelStartStep_IKE.Name = "labelStartStep_IKE";
            this.labelStartStep_IKE.Size = new System.Drawing.Size(83, 17);
            this.labelStartStep_IKE.TabIndex = 2;
            this.labelStartStep_IKE.Text = "Старт шага";
            // 
            // textBoxStopStep_IKE
            // 
            this.textBoxStopStep_IKE.Location = new System.Drawing.Point(138, 42);
            this.textBoxStopStep_IKE.Name = "textBoxStopStep_IKE";
            this.textBoxStopStep_IKE.Size = new System.Drawing.Size(127, 22);
            this.textBoxStopStep_IKE.TabIndex = 1;
            this.textBoxStopStep_IKE.Text = "5";
            // 
            // textBoxStartStep_IKE
            // 
            this.textBoxStartStep_IKE.Location = new System.Drawing.Point(5, 42);
            this.textBoxStartStep_IKE.Name = "textBoxStartStep_IKE";
            this.textBoxStartStep_IKE.Size = new System.Drawing.Size(127, 22);
            this.textBoxStartStep_IKE.TabIndex = 0;
            this.textBoxStartStep_IKE.Text = "-5";
            // 
            // groupBoxResult_IKE
            // 
            this.groupBoxResult_IKE.Controls.Add(this.chartFunction);
            this.groupBoxResult_IKE.Controls.Add(this.dataGridViewFunction);
            this.groupBoxResult_IKE.Controls.Add(this.labelResult_IKE);
            this.groupBoxResult_IKE.Location = new System.Drawing.Point(509, 13);
            this.groupBoxResult_IKE.Name = "groupBoxResult_IKE";
            this.groupBoxResult_IKE.Size = new System.Drawing.Size(648, 372);
            this.groupBoxResult_IKE.TabIndex = 2;
            this.groupBoxResult_IKE.TabStop = false;
            this.groupBoxResult_IKE.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(167, 44);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(481, 306);
            this.chartFunction.TabIndex = 6;
            this.chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction.Location = new System.Drawing.Point(8, 44);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.RowHeadersWidth = 51;
            this.dataGridViewFunction.RowTemplate.Height = 24;
            this.dataGridViewFunction.Size = new System.Drawing.Size(153, 306);
            this.dataGridViewFunction.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(x)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // labelResult_IKE
            // 
            this.labelResult_IKE.AutoSize = true;
            this.labelResult_IKE.Location = new System.Drawing.Point(7, 22);
            this.labelResult_IKE.Name = "labelResult_IKE";
            this.labelResult_IKE.Size = new System.Drawing.Size(76, 17);
            this.labelResult_IKE.TabIndex = 0;
            this.labelResult_IKE.Text = "Результат";
            // 
            // buttonHelp_IKE
            // 
            this.buttonHelp_IKE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_IKE.Location = new System.Drawing.Point(303, 331);
            this.buttonHelp_IKE.Name = "buttonHelp_IKE";
            this.buttonHelp_IKE.Size = new System.Drawing.Size(84, 54);
            this.buttonHelp_IKE.TabIndex = 4;
            this.buttonHelp_IKE.Text = "Справка";
            this.buttonHelp_IKE.UseVisualStyleBackColor = false;
            this.buttonHelp_IKE.Click += new System.EventHandler(this.buttonHelp_IKE_Click);
            // 
            // buttonDone_IKE
            // 
            this.buttonDone_IKE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_IKE.Location = new System.Drawing.Point(393, 331);
            this.buttonDone_IKE.Name = "buttonDone_IKE";
            this.buttonDone_IKE.Size = new System.Drawing.Size(110, 54);
            this.buttonDone_IKE.TabIndex = 3;
            this.buttonDone_IKE.Text = "Выполнить";
            this.buttonDone_IKE.UseVisualStyleBackColor = false;
            this.buttonDone_IKE.Click += new System.EventHandler(this.buttonDone_IKE_Click);
            this.buttonDone_IKE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_IKE_MouseDown);
            this.buttonDone_IKE.MouseEnter += new System.EventHandler(this.buttonDone_IKE_MouseEnter);
            this.buttonDone_IKE.MouseLeave += new System.EventHandler(this.buttonDone_IKE_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 405);
            this.Controls.Add(this.buttonDone_IKE);
            this.Controls.Add(this.buttonHelp_IKE);
            this.Controls.Add(this.groupBoxResult_IKE);
            this.Controls.Add(this.groupBoxInputData_IKE);
            this.Controls.Add(this.groupBoxTask_IKE);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант10 | Ивашкина К. Э.";
            this.groupBoxTask_IKE.ResumeLayout(false);
            this.groupBoxTask_IKE.PerformLayout();
            this.groupBoxInputData_IKE.ResumeLayout(false);
            this.groupBoxInputData_IKE.PerformLayout();
            this.groupBoxResult_IKE.ResumeLayout(false);
            this.groupBoxResult_IKE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IKE;
        private System.Windows.Forms.GroupBox groupBoxInputData_IKE;
        private System.Windows.Forms.GroupBox groupBoxResult_IKE;
        private System.Windows.Forms.Button buttonHelp_IKE;
        private System.Windows.Forms.Button buttonDone_IKE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStopStep_IKE;
        private System.Windows.Forms.Label labelStartStep_IKE;
        private System.Windows.Forms.TextBox textBoxStopStep_IKE;
        private System.Windows.Forms.TextBox textBoxStartStep_IKE;
        private System.Windows.Forms.Label labelResult_IKE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

