namespace Mancher
{
    partial class CoachingStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachingStaff));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "Erik ten Hag",
            "2/2/1970",
            "Coach",
            "Ha Lan"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "02",
            "Ruud van Nistelrooy",
            "1/7/1976",
            "Assistant",
            "Ha Lan"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "03",
            "Van der Gaag",
            "22/10/1971",
            "Assistant",
            "Ha Lan"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "04",
            "Steve McClaren",
            "3/5/1961",
            "Assistant",
            "Anh"}, -1);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeadSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNationality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSTT = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.textBoxSTT = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.comboBoxPos = new System.Windows.Forms.ComboBox();
            this.textBoxNationality = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemoveAt = new System.Windows.Forms.Button();
            this.pictureBoxTen = new System.Windows.Forms.PictureBox();
            this.pictureBoxRuud = new System.Windows.Forms.PictureBox();
            this.pictureBoxGaag = new System.Windows.Forms.PictureBox();
            this.pictureBoxSteve = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteve)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadSTT,
            this.columnHeaderName,
            this.columnHeaderDate,
            this.columnHeaderposition,
            this.columnHeaderNationality,
            this.anh});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(0, 285);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(989, 389);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeadSTT
            // 
            this.columnHeadSTT.Text = "";
            this.columnHeadSTT.Width = 150;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date of Birth";
            this.columnHeaderDate.Width = 150;
            // 
            // columnHeaderposition
            // 
            this.columnHeaderposition.Text = "Position";
            this.columnHeaderposition.Width = 150;
            // 
            // columnHeaderNationality
            // 
            this.columnHeaderNationality.Text = "Nationality";
            this.columnHeaderNationality.Width = 120;
            // 
            // anh
            // 
            this.anh.Text = "";
            this.anh.Width = 90;
            // 
            // labelSTT
            // 
            this.labelSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSTT.Image = ((System.Drawing.Image)(resources.GetObject("labelSTT.Image")));
            this.labelSTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSTT.Location = new System.Drawing.Point(23, 13);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(104, 46);
            this.labelSTT.TabIndex = 2;
            this.labelSTT.Text = "STT";
            this.labelSTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Image = ((System.Drawing.Image)(resources.GetObject("labelName.Image")));
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelName.Location = new System.Drawing.Point(23, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 48);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDate.Image = ((System.Drawing.Image)(resources.GetObject("labelDate.Image")));
            this.labelDate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDate.Location = new System.Drawing.Point(27, 143);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 48);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date of Birth";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPosition.Image = ((System.Drawing.Image)(resources.GetObject("labelPosition.Image")));
            this.labelPosition.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelPosition.Location = new System.Drawing.Point(353, 13);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(116, 46);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Position";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNationality
            // 
            this.labelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNationality.Image = ((System.Drawing.Image)(resources.GetObject("labelNationality.Image")));
            this.labelNationality.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelNationality.Location = new System.Drawing.Point(353, 80);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(116, 52);
            this.labelNationality.TabIndex = 6;
            this.labelNationality.Text = "Nationality";
            this.labelNationality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSTT
            // 
            this.textBoxSTT.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSTT.Location = new System.Drawing.Point(133, 20);
            this.textBoxSTT.Name = "textBoxSTT";
            this.textBoxSTT.Size = new System.Drawing.Size(193, 34);
            this.textBoxSTT.TabIndex = 7;
            this.textBoxSTT.TextChanged += new System.EventHandler(this.textBoxSTT_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(133, 85);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(193, 34);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.Location = new System.Drawing.Point(133, 157);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(193, 34);
            this.textBoxDate.TabIndex = 9;
            // 
            // comboBoxPos
            // 
            this.comboBoxPos.BackColor = System.Drawing.Color.LightCoral;
            this.comboBoxPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPos.FormattingEnabled = true;
            this.comboBoxPos.Items.AddRange(new object[] {
            "Coach",
            "Assistant"});
            this.comboBoxPos.Location = new System.Drawing.Point(475, 17);
            this.comboBoxPos.Name = "comboBoxPos";
            this.comboBoxPos.Size = new System.Drawing.Size(154, 37);
            this.comboBoxPos.TabIndex = 10;
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNationality.Location = new System.Drawing.Point(475, 87);
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(154, 34);
            this.textBoxNationality.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(357, 157);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 50);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemoveAt
            // 
            this.buttonRemoveAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveAt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemoveAt.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveAt.Image")));
            this.buttonRemoveAt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRemoveAt.Location = new System.Drawing.Point(475, 157);
            this.buttonRemoveAt.Name = "buttonRemoveAt";
            this.buttonRemoveAt.Size = new System.Drawing.Size(154, 50);
            this.buttonRemoveAt.TabIndex = 13;
            this.buttonRemoveAt.Text = "RemoveAt";
            this.buttonRemoveAt.UseVisualStyleBackColor = true;
            this.buttonRemoveAt.Click += new System.EventHandler(this.buttonRemoveAt_Click);
            // 
            // pictureBoxTen
            // 
            this.pictureBoxTen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTen.Image")));
            this.pictureBoxTen.Location = new System.Drawing.Point(635, 19);
            this.pictureBoxTen.Name = "pictureBoxTen";
            this.pictureBoxTen.Size = new System.Drawing.Size(227, 188);
            this.pictureBoxTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTen.TabIndex = 14;
            this.pictureBoxTen.TabStop = false;
            // 
            // pictureBoxRuud
            // 
            this.pictureBoxRuud.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRuud.Image")));
            this.pictureBoxRuud.Location = new System.Drawing.Point(635, 19);
            this.pictureBoxRuud.Name = "pictureBoxRuud";
            this.pictureBoxRuud.Size = new System.Drawing.Size(227, 188);
            this.pictureBoxRuud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRuud.TabIndex = 15;
            this.pictureBoxRuud.TabStop = false;
            // 
            // pictureBoxGaag
            // 
            this.pictureBoxGaag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGaag.Image")));
            this.pictureBoxGaag.Location = new System.Drawing.Point(635, 19);
            this.pictureBoxGaag.Name = "pictureBoxGaag";
            this.pictureBoxGaag.Size = new System.Drawing.Size(227, 188);
            this.pictureBoxGaag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGaag.TabIndex = 16;
            this.pictureBoxGaag.TabStop = false;
            // 
            // pictureBoxSteve
            // 
            this.pictureBoxSteve.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSteve.Image")));
            this.pictureBoxSteve.Location = new System.Drawing.Point(635, 0);
            this.pictureBoxSteve.Name = "pictureBoxSteve";
            this.pictureBoxSteve.Size = new System.Drawing.Size(256, 207);
            this.pictureBoxSteve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSteve.TabIndex = 17;
            this.pictureBoxSteve.TabStop = false;
            // 
            // CoachingStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 674);
            this.Controls.Add(this.pictureBoxSteve);
            this.Controls.Add(this.pictureBoxGaag);
            this.Controls.Add(this.pictureBoxRuud);
            this.Controls.Add(this.pictureBoxTen);
            this.Controls.Add(this.buttonRemoveAt);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNationality);
            this.Controls.Add(this.comboBoxPos);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSTT);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSTT);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CoachingStaff";
            this.Text = "CoachingStaff";
            this.Load += new System.EventHandler(this.CoachingStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeadSTT;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderposition;
        private System.Windows.Forms.ColumnHeader columnHeaderNationality;
        private System.Windows.Forms.Label labelSTT;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ColumnHeader anh;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.TextBox textBoxSTT;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ComboBox comboBoxPos;
        private System.Windows.Forms.TextBox textBoxNationality;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemoveAt;
        private System.Windows.Forms.PictureBox pictureBoxTen;
        private System.Windows.Forms.PictureBox pictureBoxRuud;
        private System.Windows.Forms.PictureBox pictureBoxGaag;
        private System.Windows.Forms.PictureBox pictureBoxSteve;
    }
}