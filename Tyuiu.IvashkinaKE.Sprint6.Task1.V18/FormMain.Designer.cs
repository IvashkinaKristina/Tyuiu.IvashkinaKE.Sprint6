
namespace Tyuiu.IvashkinaKE.Sprint6.Task1.V18
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
            this.groupBoxTask_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IKE = new System.Windows.Forms.TextBox();
            this.groupBoxResult_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_IKE = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_IKE = new System.Windows.Forms.GroupBox();
            this.labelStopStep_IKE = new System.Windows.Forms.Label();
            this.labelStartStep_IKE = new System.Windows.Forms.Label();
            this.textBoxStopStep_IKE = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_IKE = new System.Windows.Forms.TextBox();
            this.buttonHelp_IKE = new System.Windows.Forms.Button();
            this.buttonDone_IKE = new System.Windows.Forms.Button();
            this.labelResult_IKE = new System.Windows.Forms.Label();
            this.groupBoxTask_IKE.SuspendLayout();
            this.groupBoxResult_IKE.SuspendLayout();
            this.groupBoxInputData_IKE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_IKE
            // 
            this.groupBoxTask_IKE.Controls.Add(this.textBoxTask_IKE);
            this.groupBoxTask_IKE.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask_IKE.Name = "groupBoxTask_IKE";
            this.groupBoxTask_IKE.Size = new System.Drawing.Size(542, 340);
            this.groupBoxTask_IKE.TabIndex = 0;
            this.groupBoxTask_IKE.TabStop = false;
            this.groupBoxTask_IKE.Text = "Условие";
            // 
            // textBoxTask_IKE
            // 
            this.textBoxTask_IKE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IKE.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_IKE.Multiline = true;
            this.textBoxTask_IKE.Name = "textBoxTask_IKE";
            this.textBoxTask_IKE.ReadOnly = true;
            this.textBoxTask_IKE.Size = new System.Drawing.Size(404, 286);
            this.textBoxTask_IKE.TabIndex = 0;
            this.textBoxTask_IKE.Text = "Протабулировать функцию f(x) на заданном диапазоне. Результат вывести в виде табл" +
    "ице. ";
            // 
            // groupBoxResult_IKE
            // 
            this.groupBoxResult_IKE.Controls.Add(this.labelResult_IKE);
            this.groupBoxResult_IKE.Controls.Add(this.textBoxResult_IKE);
            this.groupBoxResult_IKE.Location = new System.Drawing.Point(571, 12);
            this.groupBoxResult_IKE.Name = "groupBoxResult_IKE";
            this.groupBoxResult_IKE.Size = new System.Drawing.Size(274, 420);
            this.groupBoxResult_IKE.TabIndex = 1;
            this.groupBoxResult_IKE.TabStop = false;
            this.groupBoxResult_IKE.Text = "Вывод данных";
            // 
            // textBoxResult_IKE
            // 
            this.textBoxResult_IKE.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_IKE.Location = new System.Drawing.Point(8, 41);
            this.textBoxResult_IKE.Multiline = true;
            this.textBoxResult_IKE.Name = "textBoxResult_IKE";
            this.textBoxResult_IKE.ReadOnly = true;
            this.textBoxResult_IKE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_IKE.Size = new System.Drawing.Size(261, 371);
            this.textBoxResult_IKE.TabIndex = 3;
            // 
            // groupBoxInputData_IKE
            // 
            this.groupBoxInputData_IKE.Controls.Add(this.labelStopStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.labelStartStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.textBoxStopStep_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.textBoxStartStep_IKE);
            this.groupBoxInputData_IKE.Location = new System.Drawing.Point(12, 358);
            this.groupBoxInputData_IKE.Name = "groupBoxInputData_IKE";
            this.groupBoxInputData_IKE.Size = new System.Drawing.Size(323, 80);
            this.groupBoxInputData_IKE.TabIndex = 2;
            this.groupBoxInputData_IKE.TabStop = false;
            this.groupBoxInputData_IKE.Text = "Ввод данных";
            // 
            // labelStopStep_IKE
            // 
            this.labelStopStep_IKE.AutoSize = true;
            this.labelStopStep_IKE.Location = new System.Drawing.Point(164, 29);
            this.labelStopStep_IKE.Name = "labelStopStep_IKE";
            this.labelStopStep_IKE.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_IKE.TabIndex = 3;
            this.labelStopStep_IKE.Text = "Конец шага:";
            // 
            // labelStartStep_IKE
            // 
            this.labelStartStep_IKE.AutoSize = true;
            this.labelStartStep_IKE.Location = new System.Drawing.Point(8, 29);
            this.labelStartStep_IKE.Name = "labelStartStep_IKE";
            this.labelStartStep_IKE.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_IKE.TabIndex = 2;
            this.labelStartStep_IKE.Text = "Старт шага:";
            // 
            // textBoxStopStep_IKE
            // 
            this.textBoxStopStep_IKE.Location = new System.Drawing.Point(164, 52);
            this.textBoxStopStep_IKE.Name = "textBoxStopStep_IKE";
            this.textBoxStopStep_IKE.Size = new System.Drawing.Size(153, 22);
            this.textBoxStopStep_IKE.TabIndex = 1;
            this.textBoxStopStep_IKE.Text = "5";
            // 
            // textBoxStartStep_IKE
            // 
            this.textBoxStartStep_IKE.Location = new System.Drawing.Point(8, 53);
            this.textBoxStartStep_IKE.Name = "textBoxStartStep_IKE";
            this.textBoxStartStep_IKE.Size = new System.Drawing.Size(151, 22);
            this.textBoxStartStep_IKE.TabIndex = 0;
            this.textBoxStartStep_IKE.Text = "-5";
            // 
            // buttonHelp_IKE
            // 
            this.buttonHelp_IKE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_IKE.Location = new System.Drawing.Point(341, 368);
            this.buttonHelp_IKE.Name = "buttonHelp_IKE";
            this.buttonHelp_IKE.Size = new System.Drawing.Size(83, 64);
            this.buttonHelp_IKE.TabIndex = 4;
            this.buttonHelp_IKE.Text = "Справка";
            this.buttonHelp_IKE.UseVisualStyleBackColor = false;
            this.buttonHelp_IKE.Click += new System.EventHandler(this.buttonHelp_IKE_Click);
            // 
            // buttonDone_IKE
            // 
            this.buttonDone_IKE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_IKE.Location = new System.Drawing.Point(430, 368);
            this.buttonDone_IKE.Name = "buttonDone_IKE";
            this.buttonDone_IKE.Size = new System.Drawing.Size(125, 64);
            this.buttonDone_IKE.TabIndex = 3;
            this.buttonDone_IKE.Text = "Выполнить";
            this.buttonDone_IKE.UseVisualStyleBackColor = false;
            this.buttonDone_IKE.Click += new System.EventHandler(this.buttonDone_IKE_Click);
            // 
            // labelResult_IKE
            // 
            this.labelResult_IKE.AutoSize = true;
            this.labelResult_IKE.Location = new System.Drawing.Point(8, 22);
            this.labelResult_IKE.Name = "labelResult_IKE";
            this.labelResult_IKE.Size = new System.Drawing.Size(76, 17);
            this.labelResult_IKE.TabIndex = 4;
            this.labelResult_IKE.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 451);
            this.Controls.Add(this.buttonDone_IKE);
            this.Controls.Add(this.buttonHelp_IKE);
            this.Controls.Add(this.groupBoxInputData_IKE);
            this.Controls.Add(this.groupBoxResult_IKE);
            this.Controls.Add(this.groupBoxTask_IKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант18 | Ивашкина К. Э.";
            this.groupBoxTask_IKE.ResumeLayout(false);
            this.groupBoxTask_IKE.PerformLayout();
            this.groupBoxResult_IKE.ResumeLayout(false);
            this.groupBoxResult_IKE.PerformLayout();
            this.groupBoxInputData_IKE.ResumeLayout(false);
            this.groupBoxInputData_IKE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IKE;
        private System.Windows.Forms.GroupBox groupBoxResult_IKE;
        private System.Windows.Forms.GroupBox groupBoxInputData_IKE;
        private System.Windows.Forms.TextBox textBoxStopStep_IKE;
        private System.Windows.Forms.TextBox textBoxStartStep_IKE;
        private System.Windows.Forms.TextBox textBoxTask_IKE;
        private System.Windows.Forms.TextBox textBoxResult_IKE;
        private System.Windows.Forms.Label labelStopStep_IKE;
        private System.Windows.Forms.Label labelStartStep_IKE;
        private System.Windows.Forms.Button buttonHelp_IKE;
        private System.Windows.Forms.Button buttonDone_IKE;
        private System.Windows.Forms.Label labelResult_IKE;
    }
}

