
namespace Tyuiu.IvashkinaKE.Sprint6.Task7.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_IKE = new System.Windows.Forms.PictureBox();
            this.labelInfo_IKE = new System.Windows.Forms.Label();
            this.buttonOk_IKE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_IKE
            // 
            this.pictureBoxAvatar_IKE.Image = global::Tyuiu.IvashkinaKE.Sprint6.Task7.V18.Properties.Resources.dfcsd;
            this.pictureBoxAvatar_IKE.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_IKE.Name = "pictureBoxAvatar_IKE";
            this.pictureBoxAvatar_IKE.Size = new System.Drawing.Size(180, 184);
            this.pictureBoxAvatar_IKE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_IKE.TabIndex = 0;
            this.pictureBoxAvatar_IKE.TabStop = false;
            // 
            // labelInfo_IKE
            // 
            this.labelInfo_IKE.AutoSize = true;
            this.labelInfo_IKE.Location = new System.Drawing.Point(199, 13);
            this.labelInfo_IKE.Name = "labelInfo_IKE";
            this.labelInfo_IKE.Size = new System.Drawing.Size(363, 170);
            this.labelInfo_IKE.TabIndex = 1;
            this.labelInfo_IKE.Text = resources.GetString("labelInfo_IKE.Text");
            // 
            // buttonOk_IKE
            // 
            this.buttonOk_IKE.Location = new System.Drawing.Point(481, 170);
            this.buttonOk_IKE.Name = "buttonOk_IKE";
            this.buttonOk_IKE.Size = new System.Drawing.Size(75, 27);
            this.buttonOk_IKE.TabIndex = 2;
            this.buttonOk_IKE.Text = "Ок";
            this.buttonOk_IKE.UseVisualStyleBackColor = true;
            this.buttonOk_IKE.Click += new System.EventHandler(this.buttonOk_IKE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 201);
            this.Controls.Add(this.buttonOk_IKE);
            this.Controls.Add(this.labelInfo_IKE);
            this.Controls.Add(this.pictureBoxAvatar_IKE);
            this.MaximumSize = new System.Drawing.Size(586, 248);
            this.MinimumSize = new System.Drawing.Size(586, 248);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IKE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_IKE;
        private System.Windows.Forms.Label labelInfo_IKE;
        private System.Windows.Forms.Button buttonOk_IKE;
    }
}