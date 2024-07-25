namespace Mancher
{
    partial class FormLegend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLegend));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "7",
            "C.Ronaldo",
            "5/2/1985",
            "Portugal",
            "CM",
            "6"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "11",
            "Ryan Giggs",
            "29/11/1973",
            "Anh",
            "CDM",
            "18"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "18",
            "Paul Scholes",
            "16/11/1974",
            "Anh",
            "CDM",
            "20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "16",
            "Roy Keane",
            "10/8/1971",
            "Ireland",
            "CDM",
            "12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "07",
            "David Beckham",
            "2/5/1975",
            "Anh",
            "CDM",
            "9"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "Rio Ferdinand",
            "7/11/1978",
            "Anh",
            "CB",
            "12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Nemanja Vidic",
            "21/10/1981",
            "Serbia",
            "CB",
            "8"}, -1);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPlaypos = new System.Windows.Forms.ComboBox();
            this.labelPos = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSTT = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.textboxso = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxdate = new System.Windows.Forms.TextBox();
            this.textBoxnationality = new System.Windows.Forms.TextBox();
            this.textBoxyear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemove = new System.Windows.Forms.Button();
            this.pictureBoxRonaldo = new System.Windows.Forms.PictureBox();
            this.pictureBoxGiggs = new System.Windows.Forms.PictureBox();
            this.pictureBoxScholes = new System.Windows.Forms.PictureBox();
            this.pictureBoxKeane = new System.Windows.Forms.PictureBox();
            this.pictureBoxBeckham = new System.Windows.Forms.PictureBox();
            this.pictureBoxRio = new System.Windows.Forms.PictureBox();
            this.pictureBoxVidic = new System.Windows.Forms.PictureBox();
            this.pictureBoxMU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRonaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiggs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScholes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeckham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVidic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMU)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxPlaypos
            // 
            this.comboBoxPlaypos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlaypos.FormattingEnabled = true;
            this.comboBoxPlaypos.Items.AddRange(new object[] {
            "GK",
            "CB",
            "RB",
            "LB",
            "CDM",
            "RWB",
            "LWB",
            "CM",
            "RM",
            "LM",
            "ST"});
            this.comboBoxPlaypos.Location = new System.Drawing.Point(800, 23);
            this.comboBoxPlaypos.Name = "comboBoxPlaypos";
            this.comboBoxPlaypos.Size = new System.Drawing.Size(132, 33);
            this.comboBoxPlaypos.TabIndex = 5;
            // 
            // labelPos
            // 
            this.labelPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPos.Location = new System.Drawing.Point(594, 22);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(200, 33);
            this.labelPos.TabIndex = 6;
            this.labelPos.Text = "Playing Position";
            this.labelPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPos.Click += new System.EventHandler(this.labelPos_Click);
            // 
            // labelYear
            // 
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelYear.Image = ((System.Drawing.Image)(resources.GetObject("labelYear.Image")));
            this.labelYear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelYear.Location = new System.Drawing.Point(594, 73);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(205, 35);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "Number of Years Competing";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelYear.Click += new System.EventHandler(this.labelYear_Click);
            // 
            // labelSTT
            // 
            this.labelSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSTT.Image = ((System.Drawing.Image)(resources.GetObject("labelSTT.Image")));
            this.labelSTT.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelSTT.Location = new System.Drawing.Point(-5, 22);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(129, 33);
            this.labelSTT.TabIndex = 8;
            this.labelSTT.Text = "Number";
            this.labelSTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSTT.Click += new System.EventHandler(this.labelSTT_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Image = ((System.Drawing.Image)(resources.GetObject("labelName.Image")));
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelName.Location = new System.Drawing.Point(-5, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 35);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDate.Image = ((System.Drawing.Image)(resources.GetObject("labelDate.Image")));
            this.labelDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelDate.Location = new System.Drawing.Point(310, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(136, 34);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date of Birth";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelNationality
            // 
            this.labelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNationality.Image = ((System.Drawing.Image)(resources.GetObject("labelNationality.Image")));
            this.labelNationality.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelNationality.Location = new System.Drawing.Point(310, 74);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(136, 34);
            this.labelNationality.TabIndex = 11;
            this.labelNationality.Text = "Nationality";
            this.labelNationality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNationality.Click += new System.EventHandler(this.labelNationality_Click);
            // 
            // textboxso
            // 
            this.textboxso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxso.Location = new System.Drawing.Point(145, 25);
            this.textboxso.Name = "textboxso";
            this.textboxso.Size = new System.Drawing.Size(159, 30);
            this.textboxso.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(145, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 30);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxdate
            // 
            this.textBoxdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdate.Location = new System.Drawing.Point(463, 24);
            this.textBoxdate.Name = "textBoxdate";
            this.textBoxdate.Size = new System.Drawing.Size(120, 30);
            this.textBoxdate.TabIndex = 14;
            this.textBoxdate.TextChanged += new System.EventHandler(this.textBoxdate_TextChanged);
            // 
            // textBoxnationality
            // 
            this.textBoxnationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnationality.Location = new System.Drawing.Point(463, 76);
            this.textBoxnationality.Name = "textBoxnationality";
            this.textBoxnationality.Size = new System.Drawing.Size(120, 30);
            this.textBoxnationality.TabIndex = 15;
            // 
            // textBoxyear
            // 
            this.textBoxyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxyear.Location = new System.Drawing.Point(805, 73);
            this.textBoxyear.Name = "textBoxyear";
            this.textBoxyear.Size = new System.Drawing.Size(132, 30);
            this.textBoxyear.TabIndex = 16;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdd.Location = new System.Drawing.Point(807, 568);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 49);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listView1.Location = new System.Drawing.Point(0, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1141, 451);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Day of Birth";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nationality";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PlayingPosition";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Number og Years";
            this.columnHeader6.Width = 200;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRemove.Location = new System.Drawing.Point(569, 568);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(133, 49);
            this.buttonRemove.TabIndex = 19;
            this.buttonRemove.Text = "RemoveAt";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // pictureBoxRonaldo
            // 
            this.pictureBoxRonaldo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRonaldo.Image")));
            this.pictureBoxRonaldo.Location = new System.Drawing.Point(938, 315);
            this.pictureBoxRonaldo.Name = "pictureBoxRonaldo";
            this.pictureBoxRonaldo.Size = new System.Drawing.Size(202, 247);
            this.pictureBoxRonaldo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRonaldo.TabIndex = 20;
            this.pictureBoxRonaldo.TabStop = false;
            // 
            // pictureBoxGiggs
            // 
            this.pictureBoxGiggs.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGiggs.Image")));
            this.pictureBoxGiggs.Location = new System.Drawing.Point(939, 315);
            this.pictureBoxGiggs.Name = "pictureBoxGiggs";
            this.pictureBoxGiggs.Size = new System.Drawing.Size(202, 247);
            this.pictureBoxGiggs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGiggs.TabIndex = 21;
            this.pictureBoxGiggs.TabStop = false;
            // 
            // pictureBoxScholes
            // 
            this.pictureBoxScholes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScholes.Image")));
            this.pictureBoxScholes.Location = new System.Drawing.Point(938, 315);
            this.pictureBoxScholes.Name = "pictureBoxScholes";
            this.pictureBoxScholes.Size = new System.Drawing.Size(202, 247);
            this.pictureBoxScholes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScholes.TabIndex = 22;
            this.pictureBoxScholes.TabStop = false;
            // 
            // pictureBoxKeane
            // 
            this.pictureBoxKeane.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKeane.Image")));
            this.pictureBoxKeane.Location = new System.Drawing.Point(939, 315);
            this.pictureBoxKeane.Name = "pictureBoxKeane";
            this.pictureBoxKeane.Size = new System.Drawing.Size(202, 247);
            this.pictureBoxKeane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKeane.TabIndex = 23;
            this.pictureBoxKeane.TabStop = false;
            // 
            // pictureBoxBeckham
            // 
            this.pictureBoxBeckham.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBeckham.Image")));
            this.pictureBoxBeckham.Location = new System.Drawing.Point(939, 315);
            this.pictureBoxBeckham.Name = "pictureBoxBeckham";
            this.pictureBoxBeckham.Size = new System.Drawing.Size(202, 247);
            this.pictureBoxBeckham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBeckham.TabIndex = 24;
            this.pictureBoxBeckham.TabStop = false;
            // 
            // pictureBoxRio
            // 
            this.pictureBoxRio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRio.Image")));
            this.pictureBoxRio.Location = new System.Drawing.Point(939, 315);
            this.pictureBoxRio.Name = "pictureBoxRio";
            this.pictureBoxRio.Size = new System.Drawing.Size(202, 247);
            this.pictureBoxRio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRio.TabIndex = 25;
            this.pictureBoxRio.TabStop = false;
            // 
            // pictureBoxVidic
            // 
            this.pictureBoxVidic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVidic.Image")));
            this.pictureBoxVidic.Location = new System.Drawing.Point(938, 315);
            this.pictureBoxVidic.Name = "pictureBoxVidic";
            this.pictureBoxVidic.Size = new System.Drawing.Size(202, 247);
            this.pictureBoxVidic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVidic.TabIndex = 26;
            this.pictureBoxVidic.TabStop = false;
            // 
            // pictureBoxMU
            // 
            this.pictureBoxMU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMU.Image")));
            this.pictureBoxMU.Location = new System.Drawing.Point(939, 315);
            this.pictureBoxMU.Name = "pictureBoxMU";
            this.pictureBoxMU.Size = new System.Drawing.Size(219, 247);
            this.pictureBoxMU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMU.TabIndex = 28;
            this.pictureBoxMU.TabStop = false;
            // 
            // FormLegend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 617);
            this.Controls.Add(this.pictureBoxMU);
            this.Controls.Add(this.pictureBoxVidic);
            this.Controls.Add(this.pictureBoxRio);
            this.Controls.Add(this.pictureBoxBeckham);
            this.Controls.Add(this.pictureBoxKeane);
            this.Controls.Add(this.pictureBoxScholes);
            this.Controls.Add(this.pictureBoxGiggs);
            this.Controls.Add(this.pictureBoxRonaldo);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxyear);
            this.Controls.Add(this.textBoxnationality);
            this.Controls.Add(this.textBoxdate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textboxso);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSTT);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelPos);
            this.Controls.Add(this.comboBoxPlaypos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLegend";
            this.Text = "FormLegend";
            this.Load += new System.EventHandler(this.FormLegend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRonaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiggs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScholes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeckham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVidic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxPlaypos;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSTT;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.TextBox textboxso;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxdate;
        private System.Windows.Forms.TextBox textBoxnationality;
        private System.Windows.Forms.TextBox textBoxyear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.PictureBox pictureBoxRonaldo;
        private System.Windows.Forms.PictureBox pictureBoxGiggs;
        private System.Windows.Forms.PictureBox pictureBoxScholes;
        private System.Windows.Forms.PictureBox pictureBoxKeane;
        private System.Windows.Forms.PictureBox pictureBoxBeckham;
        private System.Windows.Forms.PictureBox pictureBoxRio;
        private System.Windows.Forms.PictureBox pictureBoxVidic;
        private System.Windows.Forms.PictureBox pictureBoxMU;
    }
}