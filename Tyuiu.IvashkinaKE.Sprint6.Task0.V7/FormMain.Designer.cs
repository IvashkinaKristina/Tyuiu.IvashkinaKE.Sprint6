
namespace Tyuiu.IvashkinaKE.Sprint6.Task0.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_IKE = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_IKE = new System.Windows.Forms.TextBox();
            this.labelVarX_IKE = new System.Windows.Forms.Label();
            this.groupBoxResult_IKE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_IKE = new System.Windows.Forms.TextBox();
            this.labelResult_IKE = new System.Windows.Forms.Label();
            this.buttonDone_IKE = new System.Windows.Forms.Button();
            this.buttonHelp_IKE = new System.Windows.Forms.Button();
            this.groupBoxTask_IKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_IKE)).BeginInit();
            this.groupBoxInputData_IKE.SuspendLayout();
            this.groupBoxResult_IKE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_IKE
            // 
            this.groupBoxTask_IKE.Controls.Add(this.textBoxTask);
            this.groupBoxTask_IKE.Controls.Add(this.pictureBoxFormula_IKE);
            this.groupBoxTask_IKE.Location = new System.Drawing.Point(12, 35);
            this.groupBoxTask_IKE.Name = "groupBoxTask_IKE";
            this.groupBoxTask_IKE.Size = new System.Drawing.Size(565, 238);
            this.groupBoxTask_IKE.TabIndex = 0;
            this.groupBoxTask_IKE.TabStop = false;
            this.groupBoxTask_IKE.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Location = new System.Drawing.Point(9, 18);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(400, 211);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_IKE
            // 
            this.pictureBoxFormula_IKE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_IKE.Image")));
            this.pictureBoxFormula_IKE.Location = new System.Drawing.Point(415, 18);
            this.pictureBoxFormula_IKE.Name = "pictureBoxFormula_IKE";
            this.pictureBoxFormula_IKE.Size = new System.Drawing.Size(144, 83);
            this.pictureBoxFormula_IKE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_IKE.TabIndex = 1;
            this.pictureBoxFormula_IKE.TabStop = false;
            // 
            // groupBoxInputData_IKE
            // 
            this.groupBoxInputData_IKE.Controls.Add(this.textBoxVarX_IKE);
            this.groupBoxInputData_IKE.Controls.Add(this.labelVarX_IKE);
            this.groupBoxInputData_IKE.Location = new System.Drawing.Point(12, 279);
            this.groupBoxInputData_IKE.Name = "groupBoxInputData_IKE";
            this.groupBoxInputData_IKE.Size = new System.Drawing.Size(271, 109);
            this.groupBoxInputData_IKE.TabIndex = 1;
            this.groupBoxInputData_IKE.TabStop = false;
            this.groupBoxInputData_IKE.Text = "Ввод данных";
            // 
            // textBoxVarX_IKE
            // 
            this.textBoxVarX_IKE.Location = new System.Drawing.Point(7, 49);
            this.textBoxVarX_IKE.Name = "textBoxVarX_IKE";
            this.textBoxVarX_IKE.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_IKE.TabIndex = 1;
            this.textBoxVarX_IKE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // labelVarX_IKE
            // 
            this.labelVarX_IKE.AutoSize = true;
            this.labelVarX_IKE.Location = new System.Drawing.Point(6, 28);
            this.labelVarX_IKE.Name = "labelVarX_IKE";
            this.labelVarX_IKE.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_IKE.TabIndex = 0;
            this.labelVarX_IKE.Text = "Переменная X:";
            // 
            // groupBoxResult_IKE
            // 
            this.groupBoxResult_IKE.Controls.Add(this.textBoxResult_IKE);
            this.groupBoxResult_IKE.Controls.Add(this.labelResult_IKE);
            this.groupBoxResult_IKE.Location = new System.Drawing.Point(289, 279);
            this.groupBoxResult_IKE.Name = "groupBoxResult_IKE";
            this.groupBoxResult_IKE.Size = new System.Drawing.Size(288, 109);
            this.groupBoxResult_IKE.TabIndex = 2;
            this.groupBoxResult_IKE.TabStop = false;
            this.groupBoxResult_IKE.Text = "Вывод данных";
            this.groupBoxResult_IKE.Enter += new System.EventHandler(this.groupBoxResult_IKE_Enter);
            // 
            // textBoxResult_IKE
            // 
            this.textBoxResult_IKE.Location = new System.Drawing.Point(6, 49);
            this.textBoxResult_IKE.Name = "textBoxResult_IKE";
            this.textBoxResult_IKE.ReadOnly = true;
            this.textBoxResult_IKE.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult_IKE.TabIndex = 1;
            // 
            // labelResult_IKE
            // 
            this.labelResult_IKE.AutoSize = true;
            this.labelResult_IKE.Location = new System.Drawing.Point(6, 29);
            this.labelResult_IKE.Name = "labelResult_IKE";
            this.labelResult_IKE.Size = new System.Drawing.Size(80, 17);
            this.labelResult_IKE.TabIndex = 0;
            this.labelResult_IKE.Text = "Результат:";
            // 
            // buttonDone_IKE
            // 
            this.buttonDone_IKE.Location = new System.Drawing.Point(456, 394);
            this.buttonDone_IKE.Name = "buttonDone_IKE";
            this.buttonDone_IKE.Size = new System.Drawing.Size(118, 42);
            this.buttonDone_IKE.TabIndex = 3;
            this.buttonDone_IKE.Text = "Выполнить";
            this.buttonDone_IKE.UseVisualStyleBackColor = true;
            this.buttonDone_IKE.Click += new System.EventHandler(this.buttonDone_IKE_Click);
            // 
            // buttonHelp_IKE
            // 
            this.buttonHelp_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_IKE.Location = new System.Drawing.Point(403, 394);
            this.buttonHelp_IKE.Name = "buttonHelp_IKE";
            this.buttonHelp_IKE.Size = new System.Drawing.Size(47, 42);
            this.buttonHelp_IKE.TabIndex = 4;
            this.buttonHelp_IKE.Text = "?";
            this.buttonHelp_IKE.UseVisualStyleBackColor = true;
            this.buttonHelp_IKE.Click += new System.EventHandler(this.buttonHelp_IKE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 454);
            this.Controls.Add(this.buttonHelp_IKE);
            this.Controls.Add(this.buttonDone_IKE);
            this.Controls.Add(this.groupBoxResult_IKE);
            this.Controls.Add(this.groupBoxInputData_IKE);
            this.Controls.Add(this.groupBoxTask_IKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 7 | Ивашкина К. Э.";
            this.groupBoxTask_IKE.ResumeLayout(false);
            this.groupBoxTask_IKE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_IKE)).EndInit();
            this.groupBoxInputData_IKE.ResumeLayout(false);
            this.groupBoxInputData_IKE.PerformLayout();
            this.groupBoxResult_IKE.ResumeLayout(false);
            this.groupBoxResult_IKE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IKE;
        private System.Windows.Forms.GroupBox groupBoxInputData_IKE;
        private System.Windows.Forms.TextBox textBoxVarX_IKE;
        private System.Windows.Forms.Label labelVarX_IKE;
        private System.Windows.Forms.GroupBox groupBoxResult_IKE;
        private System.Windows.Forms.TextBox textBoxResult_IKE;
        private System.Windows.Forms.Label labelResult_IKE;
        private System.Windows.Forms.PictureBox pictureBoxFormula_IKE;
        private System.Windows.Forms.Button buttonDone_IKE;
        private System.Windows.Forms.Button buttonHelp_IKE;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}

