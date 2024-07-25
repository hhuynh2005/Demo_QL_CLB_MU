namespace Mancher
{
    partial class FormCompetitionShirt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompetitionShirt));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.radioButtonAway = new System.Windows.Forms.RadioButton();
            this.radioButtonHome = new System.Windows.Forms.RadioButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureInsertHome1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelhomecourt = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBoxInsertAway1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelAway = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelTop.SuspendLayout();
            this.groupBoxInsert.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInsertHome1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsertAway1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Red;
            this.panelTop.Controls.Add(this.buttonOpen);
            this.panelTop.Controls.Add(this.groupBoxInsert);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(825, 90);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonOpen.Location = new System.Drawing.Point(528, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(216, 72);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "OpenFile";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.radioButtonAway);
            this.groupBoxInsert.Controls.Add(this.radioButtonHome);
            this.groupBoxInsert.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(494, 90);
            this.groupBoxInsert.TabIndex = 0;
            this.groupBoxInsert.TabStop = false;
            // 
            // radioButtonAway
            // 
            this.radioButtonAway.AutoSize = true;
            this.radioButtonAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAway.Location = new System.Drawing.Point(217, 32);
            this.radioButtonAway.Name = "radioButtonAway";
            this.radioButtonAway.Size = new System.Drawing.Size(135, 29);
            this.radioButtonAway.TabIndex = 1;
            this.radioButtonAway.TabStop = true;
            this.radioButtonAway.Text = "Away Court";
            this.radioButtonAway.UseVisualStyleBackColor = true;
            this.radioButtonAway.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonHome
            // 
            this.radioButtonHome.AutoSize = true;
            this.radioButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHome.Location = new System.Drawing.Point(6, 32);
            this.radioButtonHome.Name = "radioButtonHome";
            this.radioButtonHome.Size = new System.Drawing.Size(138, 29);
            this.radioButtonHome.TabIndex = 0;
            this.radioButtonHome.TabStop = true;
            this.radioButtonHome.Text = "Home Court";
            this.radioButtonHome.UseVisualStyleBackColor = true;
            this.radioButtonHome.CheckedChanged += new System.EventHandler(this.radioButtonHome_CheckedChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pictureInsertHome1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.labelhomecourt);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 90);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(384, 430);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // pictureInsertHome1
            // 
            this.pictureInsertHome1.Location = new System.Drawing.Point(9, 218);
            this.pictureInsertHome1.Name = "pictureInsertHome1";
            this.pictureInsertHome1.Size = new System.Drawing.Size(190, 176);
            this.pictureInsertHome1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInsertHome1.TabIndex = 2;
            this.pictureInsertHome1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelhomecourt
            // 
            this.labelhomecourt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhomecourt.Location = new System.Drawing.Point(117, 3);
            this.labelhomecourt.Name = "labelhomecourt";
            this.labelhomecourt.Size = new System.Drawing.Size(185, 43);
            this.labelhomecourt.TabIndex = 0;
            this.labelhomecourt.Text = "Home Court";
            this.labelhomecourt.Click += new System.EventHandler(this.labelhomecourt_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.pictureBoxInsertAway1);
            this.panelRight.Controls.Add(this.pictureBox3);
            this.panelRight.Controls.Add(this.pictureBox2);
            this.panelRight.Controls.Add(this.labelAway);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(390, 90);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(435, 430);
            this.panelRight.TabIndex = 0;
            // 
            // pictureBoxInsertAway1
            // 
            this.pictureBoxInsertAway1.Location = new System.Drawing.Point(17, 218);
            this.pictureBoxInsertAway1.Name = "pictureBoxInsertAway1";
            this.pictureBoxInsertAway1.Size = new System.Drawing.Size(202, 176);
            this.pictureBoxInsertAway1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInsertAway1.TabIndex = 3;
            this.pictureBoxInsertAway1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(240, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelAway
            // 
            this.labelAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAway.Location = new System.Drawing.Point(173, 7);
            this.labelAway.Name = "labelAway";
            this.labelAway.Size = new System.Drawing.Size(148, 54);
            this.labelAway.TabIndex = 0;
            this.labelAway.Text = "Away Court";
            this.labelAway.Click += new System.EventHandler(this.labelAway_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCompetitionShirt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 520);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "FormCompetitionShirt";
            this.Text = "FormCompetitionShirt";
            this.Load += new System.EventHandler(this.FormCompetitionShirt_Load);
            this.panelTop.ResumeLayout(false);
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxInsert.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInsertHome1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsertAway1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelhomecourt;
        private System.Windows.Forms.Label labelAway;
        private System.Windows.Forms.PictureBox pictureInsertHome1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxInsertAway1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.RadioButton radioButtonAway;
        private System.Windows.Forms.RadioButton radioButtonHome;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}