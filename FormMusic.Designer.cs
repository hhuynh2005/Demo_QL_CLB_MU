﻿namespace Mancher
{
    partial class FormMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxNhac = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxNhac
            // 
            this.checkBoxNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNhac.ForeColor = System.Drawing.Color.Black;
            this.checkBoxNhac.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxNhac.Image")));
            this.checkBoxNhac.Location = new System.Drawing.Point(765, 41);
            this.checkBoxNhac.Name = "checkBoxNhac";
            this.checkBoxNhac.Size = new System.Drawing.Size(141, 67);
            this.checkBoxNhac.TabIndex = 2;
            this.checkBoxNhac.Text = "Music";
            this.checkBoxNhac.UseVisualStyleBackColor = true;
            this.checkBoxNhac.CheckedChanged += new System.EventHandler(this.checkBoxNhac_CheckedChanged);
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 556);
            this.Controls.Add(this.checkBoxNhac);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMusic";
            this.Text = "FormMusic";
            this.Load += new System.EventHandler(this.FormMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxNhac;
    }
}