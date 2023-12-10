
namespace Tyuiu.IvashkinaKE.Sprint6.Task6.V26
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
            this.buttonOk_IKE = new System.Windows.Forms.Button();
            this.labelInfo_IKE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_IKE
            // 
            this.pictureBoxAvatar_IKE.Image = global::Tyuiu.IvashkinaKE.Sprint6.Task6.V26.Properties.Resources.dfcsd;
            this.pictureBoxAvatar_IKE.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_IKE.Name = "pictureBoxAvatar_IKE";
            this.pictureBoxAvatar_IKE.Size = new System.Drawing.Size(178, 184);
            this.pictureBoxAvatar_IKE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_IKE.TabIndex = 1;
            this.pictureBoxAvatar_IKE.TabStop = false;
            // 
            // buttonOk_IKE
            // 
            this.buttonOk_IKE.Location = new System.Drawing.Point(484, 178);
            this.buttonOk_IKE.Name = "buttonOk_IKE";
            this.buttonOk_IKE.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_IKE.TabIndex = 2;
            this.buttonOk_IKE.Text = "Ок";
            this.buttonOk_IKE.UseVisualStyleBackColor = true;
            this.buttonOk_IKE.Click += new System.EventHandler(this.buttonOk_IKE_Click);
            // 
            // labelInfo_IKE
            // 
            this.labelInfo_IKE.AutoSize = true;
            this.labelInfo_IKE.Location = new System.Drawing.Point(196, 22);
            this.labelInfo_IKE.Name = "labelInfo_IKE";
            this.labelInfo_IKE.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_IKE.TabIndex = 3;
            this.labelInfo_IKE.Text = resources.GetString("labelInfo_IKE.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 208);
            this.Controls.Add(this.labelInfo_IKE);
            this.Controls.Add(this.buttonOk_IKE);
            this.Controls.Add(this.pictureBoxAvatar_IKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IKE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAvatar_IKE;
        private System.Windows.Forms.Button buttonOk_IKE;
        private System.Windows.Forms.Label labelInfo_IKE;
    }
}