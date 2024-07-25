using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Mancher
{
    public partial class CoachingStaff : Form
    {
        public CoachingStaff()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                ListViewItem lv1=listView1.SelectedItems[0];
                string id=lv1.SubItems[0].Text;
                string name=lv1.SubItems[1].Text;
                string date=lv1.SubItems[2].Text;
                string positions=lv1.SubItems[3].Text;
                string nationlity=lv1.SubItems[4].Text;
                textBoxSTT.Text = id;
                textBoxName.Text = name;
                textBoxDate.Text = date;
                comboBoxPos.Text = positions;
                textBoxNationality.Text = nationlity;

             }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Items: la cai dau tien
            Coach coach = new Coach();
            coach.id = textBoxSTT.Text;
            coach.name = textBoxName.Text;
            coach.namsinh=textBoxDate.Text;
            coach.nationality = textBoxNationality.Text;
            coach.nhiemvu=comboBoxPos.Text; 
            ListViewItem lv1 = new ListViewItem(textBoxSTT.Text);
            //SubItems:
            lv1.SubItems.Add(textBoxName.Text);
            lv1.SubItems.Add(textBoxDate.Text);
            lv1.SubItems.Add(comboBoxPos.Text);
            lv1.SubItems.Add(textBoxNationality.Text);
            if (coach.id == "" || coach.name == "" || coach.nhiemvu == "" || coach.namsinh == "" || coach.nationality == "")
            {
                MessageBox.Show("Please fill in complete information",
                    "Comfirm",
                                 MessageBoxButtons.OK);
            }
            else
            {
                listView1.Items.Add(lv1);
            }
            pictureBoxTen.Visible = false;
            pictureBoxRuud.Visible = false;
            pictureBoxGaag.Visible = false;
            pictureBoxSteve.Visible = false;
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
        }

        private void CoachingStaff_Load(object sender, EventArgs e)
        {
            pictureBoxTen.Visible = false;
            pictureBoxRuud.Visible = false;
            pictureBoxGaag.Visible = false;
            pictureBoxSteve.Visible = false;
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSTT_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSTT.Text == "01")
            {
                pictureBoxTen.Visible = true;
                pictureBoxRuud.Visible = false;
                pictureBoxGaag.Visible = false;
                pictureBoxSteve.Visible = false;
            }
            else if (textBoxSTT.Text == "02")
            {

                pictureBoxRuud.Visible = true;
                pictureBoxTen.Visible = false;
                pictureBoxGaag.Visible = false;
                pictureBoxSteve.Visible = false;
            }
            else if (textBoxSTT.Text == "03")
            {
                pictureBoxGaag.Visible = true;
                pictureBoxTen.Visible = false;
                pictureBoxRuud.Visible = false;
                pictureBoxSteve.Visible = false;
            }
            else if (textBoxSTT.Text == "04")
            {
                pictureBoxSteve.Visible = true;
                pictureBoxTen.Visible = false;
                pictureBoxRuud.Visible = false;
                pictureBoxGaag.Visible = false;
            }
        }
    }
}
