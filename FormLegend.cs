using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Mancher
{
    public partial class FormLegend : Form
    {
        public FormLegend()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelNationality_Click(object sender, EventArgs e)
        {

        }

        private void labelSTT_Click(object sender, EventArgs e)
        {

        }

        private void labelYear_Click(object sender, EventArgs e)
        {

        }

        private void labelPos_Click(object sender, EventArgs e)
        {

        }
        HuyenThoai[] huyenTh = new HuyenThoai[50];
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(textboxso.Text);
            lv1.SubItems.Add(textBoxName.Text);
            lv1.SubItems.Add(textBoxdate.Text);
            lv1.SubItems.Add(textBoxnationality.Text);
            lv1.SubItems.Add(comboBoxPlaypos.Text);
            lv1.SubItems.Add(textBoxyear.Text);
            if (textboxso.Text == "" || textBoxName.Text == "" || textBoxdate.Text== "" || textBoxnationality.Text == "" || textBoxyear.Text == ""||comboBoxPlaypos.Text=="")
            {
                MessageBox.Show("Please fill in complete information",
                    "Comfirm",
                                 MessageBoxButtons.OK);
            }
            else
            {
                listView1.Items.Add(lv1);
            }
            pictureBoxRonaldo.Visible = false;
            pictureBoxRio.Visible = false;
            pictureBoxKeane.Visible = false;
            pictureBoxBeckham.Visible = false;
            pictureBoxGiggs.Visible = false;
            pictureBoxScholes.Visible = false;
            pictureBoxVidic.Visible = false;
            pictureBoxMU.Visible = true;

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = listView1.SelectedItems[0];

                textboxso.Text = lv1.SubItems[0].Text;
                textBoxName.Text = lv1.SubItems[1].Text;
                textBoxdate.Text = lv1.SubItems[2].Text;
                textBoxnationality.Text=lv1.SubItems[3].Text;
                comboBoxPlaypos.Text=lv1.SubItems[4].Text;
                textBoxyear.Text=lv1.SubItems[5].Text;

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            

        }

        private void FormLegend_Load(object sender, EventArgs e)
        {
            pictureBoxRonaldo.Visible = false;
            pictureBoxRio.Visible = false;
            pictureBoxKeane.Visible = false;
            pictureBoxBeckham.Visible = false;
            pictureBoxGiggs.Visible = false;
            pictureBoxScholes.Visible = false;
            pictureBoxVidic.Visible = false;
            pictureBoxMU.Visible = true;
        }

        private void textBoxdate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxdate.Text == "5/2/1985")
            {
                pictureBoxRonaldo.Visible = true;
                pictureBoxRio.Visible = false;
                pictureBoxKeane.Visible = false;
                pictureBoxBeckham.Visible = false;
                pictureBoxGiggs.Visible = false;
                pictureBoxScholes.Visible = false;
                pictureBoxVidic.Visible = false;
                pictureBoxMU.Visible = false;
            }
            if (textBoxdate.Text == "29/11/1973")
            {
                pictureBoxRonaldo.Visible = false;
                pictureBoxRio.Visible = false;
                pictureBoxKeane.Visible = false;
                pictureBoxBeckham.Visible = false;
                pictureBoxGiggs.Visible = true;
                pictureBoxScholes.Visible = false;
                pictureBoxVidic.Visible = false;
                pictureBoxMU.Visible = false;
            }
            if (textBoxdate.Text == "16/11/1974")
            {
                pictureBoxRonaldo.Visible = false;
                pictureBoxRio.Visible = false;
                pictureBoxKeane.Visible = false;
                pictureBoxBeckham.Visible = false;
                pictureBoxGiggs.Visible = false;
                pictureBoxScholes.Visible = true;
                pictureBoxVidic.Visible = false;
                pictureBoxMU.Visible = false;
            }
            if (textBoxdate.Text == "10/8/1971")
            {
                pictureBoxRonaldo.Visible = false;
                pictureBoxRio.Visible = false;
                pictureBoxKeane.Visible = true;
                pictureBoxBeckham.Visible = false;
                pictureBoxGiggs.Visible = false;
                pictureBoxScholes.Visible = false;
                pictureBoxVidic.Visible = false;
                pictureBoxMU.Visible = false;
            }
            if (textBoxdate.Text == "2/5/1975")
            {
                pictureBoxRonaldo.Visible = false;
                pictureBoxRio.Visible = false;
                pictureBoxKeane.Visible = false;

                pictureBoxGiggs.Visible = false;
                pictureBoxScholes.Visible = false;
                pictureBoxVidic.Visible = false;
                pictureBoxMU.Visible = false;
                pictureBoxBeckham.Visible = true;
            }
            if (textBoxdate.Text == "7/11/1978")
            {
                pictureBoxRonaldo.Visible = false;
                pictureBoxRio.Visible = true;
                pictureBoxKeane.Visible = false;
                pictureBoxBeckham.Visible = false;
                pictureBoxGiggs.Visible = false;
                pictureBoxScholes.Visible = false;
                pictureBoxVidic.Visible = false;
                pictureBoxMU.Visible = false;
            }
            if (textBoxdate.Text == "21/10/1981")
            {
                pictureBoxRonaldo.Visible = false;
                pictureBoxRio.Visible = false;
                pictureBoxKeane.Visible = false;
                pictureBoxBeckham.Visible = false;
                pictureBoxGiggs.Visible = false;
                pictureBoxScholes.Visible = false;
                pictureBoxVidic.Visible = true;
                pictureBoxMU.Visible = false;
            }
        }
    }
}
