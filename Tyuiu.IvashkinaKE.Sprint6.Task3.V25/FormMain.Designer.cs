
namespace Tyuiu.IvashkinaKE.Sprint6.Task3.V25
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
            this.groupBoxResult_IKE = new System.Windows.Forms.GroupBox();
            this.buttonHelp_IKE = new System.Windows.Forms.Button();
            this.buttonDone_IKE = new System.Windows.Forms.Button();
            this.textBoxTask_IKE = new System.Windows.Forms.TextBox();
            this.dataGridViewTaskMatrix_IKE = new System.Windows.Forms.DataGridView();
            this.labelResult_IKE = new System.Windows.Forms.Label();
            this.dataGridViewMatrixResult_IKE = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_IKE.SuspendLayout();
            this.groupBoxResult_IKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_IKE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_IKE
            // 
            this.groupBoxTask_IKE.Controls.Add(this.dataGridViewTaskMatrix_IKE);
            this.groupBoxTask_IKE.Controls.Add(this.textBoxTask_IKE);
            this.groupBoxTask_IKE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_IKE.Name = "groupBoxTask_IKE";
            this.groupBoxTask_IKE.Size = new System.Drawing.Size(590, 337);
            this.groupBoxTask_IKE.TabIndex = 0;
            this.groupBoxTask_IKE.TabStop = false;
            this.groupBoxTask_IKE.Text = "Условие";
            // 
            // groupBoxResult_IKE
            // 
            this.groupBoxResult_IKE.Controls.Add(this.dataGridViewMatrixResult_IKE);
            this.groupBoxResult_IKE.Controls.Add(this.labelResult_IKE);
            this.groupBoxResult_IKE.Location = new System.Drawing.Point(623, 12);
            this.groupBoxResult_IKE.Name = "groupBoxResult_IKE";
            this.groupBoxResult_IKE.Size = new System.Drawing.Size(389, 303);
            this.groupBoxResult_IKE.TabIndex = 1;
            this.groupBoxResult_IKE.TabStop = false;
            this.groupBoxResult_IKE.Text = "Вывод данных";
            // 
            // buttonHelp_IKE
            // 
            this.buttonHelp_IKE.Location = new System.Drawing.Point(623, 321);
            this.buttonHelp_IKE.Name = "buttonHelp_IKE";
            this.buttonHelp_IKE.Size = new System.Drawing.Size(31, 28);
            this.buttonHelp_IKE.TabIndex = 2;
            this.buttonHelp_IKE.Text = "?";
            this.buttonHelp_IKE.UseVisualStyleBackColor = true;
            this.buttonHelp_IKE.Click += new System.EventHandler(this.buttonHelp_IKE_Click);
            // 
            // buttonDone_IKE
            // 
            this.buttonDone_IKE.Location = new System.Drawing.Point(669, 323);
            this.buttonDone_IKE.Name = "buttonDone_IKE";
            this.buttonDone_IKE.Size = new System.Drawing.Size(98, 26);
            this.buttonDone_IKE.TabIndex = 3;
            this.buttonDone_IKE.Text = "Выполнить";
            this.buttonDone_IKE.UseVisualStyleBackColor = true;
            this.buttonDone_IKE.Click += new System.EventHandler(this.buttonDone_IKE_Click);
            // 
            // textBoxTask_IKE
            // 
            this.textBoxTask_IKE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IKE.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_IKE.Multiline = true;
            this.textBoxTask_IKE.Name = "textBoxTask_IKE";
            this.textBoxTask_IKE.ReadOnly = true;
            this.textBoxTask_IKE.Size = new System.Drawing.Size(230, 154);
            this.textBoxTask_IKE.TabIndex = 0;
            this.textBoxTask_IKE.Text = resources.GetString("textBoxTask_IKE.Text");
            // 
            // dataGridViewTaskMatrix_IKE
            // 
            this.dataGridViewTaskMatrix_IKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskMatrix_IKE.Location = new System.Drawing.Point(254, 21);
            this.dataGridViewTaskMatrix_IKE.Name = "dataGridViewTaskMatrix_IKE";
            this.dataGridViewTaskMatrix_IKE.RowHeadersWidth = 51;
            this.dataGridViewTaskMatrix_IKE.RowTemplate.Height = 24;
            this.dataGridViewTaskMatrix_IKE.Size = new System.Drawing.Size(330, 253);
            this.dataGridViewTaskMatrix_IKE.TabIndex = 1;
            // 
            // labelResult_IKE
            // 
            this.labelResult_IKE.AutoSize = true;
            this.labelResult_IKE.Location = new System.Drawing.Point(7, 21);
            this.labelResult_IKE.Name = "labelResult_IKE";
            this.labelResult_IKE.Size = new System.Drawing.Size(76, 17);
            this.labelResult_IKE.TabIndex = 0;
            this.labelResult_IKE.Text = "Результат";
            // 
            // dataGridViewMatrixResult_IKE
            // 
            this.dataGridViewMatrixResult_IKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_IKE.Location = new System.Drawing.Point(10, 41);
            this.dataGridViewMatrixResult_IKE.Name = "dataGridViewMatrixResult_IKE";
            this.dataGridViewMatrixResult_IKE.RowHeadersWidth = 51;
            this.dataGridViewMatrixResult_IKE.RowTemplate.Height = 24;
            this.dataGridViewMatrixResult_IKE.Size = new System.Drawing.Size(334, 256);
            this.dataGridViewMatrixResult_IKE.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 356);
            this.Controls.Add(this.buttonDone_IKE);
            this.Controls.Add(this.buttonHelp_IKE);
            this.Controls.Add(this.groupBoxResult_IKE);
            this.Controls.Add(this.groupBoxTask_IKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 25 | Ивашкина К. Э.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_IKE.ResumeLayout(false);
            this.groupBoxTask_IKE.PerformLayout();
            this.groupBoxResult_IKE.ResumeLayout(false);
            this.groupBoxResult_IKE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_IKE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_IKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_IKE;
        private System.Windows.Forms.DataGridView dataGridViewTaskMatrix_IKE;
        private System.Windows.Forms.TextBox textBoxTask_IKE;
        private System.Windows.Forms.GroupBox groupBoxResult_IKE;
        private System.Windows.Forms.Label labelResult_IKE;
        private System.Windows.Forms.Button buttonHelp_IKE;
        private System.Windows.Forms.Button buttonDone_IKE;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_IKE;
    }
}

