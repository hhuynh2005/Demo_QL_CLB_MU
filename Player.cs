using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mancher
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(textBoxso.Text);
            lv1.SubItems.Add(textBoxName.Text);
            lv1.SubItems.Add(textBoxdate.Text);
            lv1.SubItems.Add(textBoxNationality.Text);
            lv1.SubItems.Add(comboBox1.Text);
         
            if (textBoxso.Text == "" || textBoxName.Text == "" || textBoxdate.Text == "" || textBoxNationality.Text == ""  || comboBox1.Text == "")
            {
                MessageBox.Show("Please fill in complete information",
                    "Comfirm",
                                 MessageBoxButtons.OK);
            }
            else
            {
                listView1.Items.Add(lv1);
            }
            pictureBoxAtony.Visible = false;
            pictureBoxHojlund.Visible = false;
            pictureBoxMaguire.Visible = false;
            pictureBoxMainoo.Visible = false;
            pictureBoxMartinez.Visible = false;
            pictureBoxMount.Visible = false;
            pictureBoxOnana.Visible = false;
            pictureBoxSancho.Visible = false;
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = listView1.SelectedItems[0];

                textBoxso.Text = lv1.SubItems[0].Text;
                textBoxName.Text = lv1.SubItems[1].Text;
                textBoxdate.Text = lv1.SubItems[2].Text;
                textBoxNationality.Text = lv1.SubItems[3].Text;
                comboBox1.Text = lv1.SubItems[4].Text;
                

            }
        }

        private void textBoxso_TextChanged(object sender, EventArgs e)
        {
            if (textBoxso.Text == "24")
            {
                pictureBoxAtony.Visible = false;
                pictureBoxHojlund.Visible = false;
                pictureBoxMaguire.Visible = false;
                pictureBoxMainoo.Visible = false;
                pictureBoxMartinez.Visible = false;
                pictureBoxMount.Visible = false;
                pictureBoxOnana.Visible = true;
                pictureBoxSancho.Visible = false;
            }
            if (textBoxso.Text == "5")
            {
                pictureBoxAtony.Visible = false;
                pictureBoxHojlund.Visible = false;
                pictureBoxMaguire.Visible = true;
                pictureBoxMainoo.Visible = false;
                pictureBoxMartinez.Visible = false;
                pictureBoxMount.Visible = false;
                pictureBoxOnana.Visible = false;
                pictureBoxSancho.Visible = false;
            }
            if (textBoxso.Text == "6")
            {
                pictureBoxAtony.Visible = false;
                pictureBoxHojlund.Visible = false;
                pictureBoxMaguire.Visible = false;
                pictureBoxMainoo.Visible = false;
                pictureBoxMartinez.Visible = true;
                pictureBoxMount.Visible = false;
                pictureBoxOnana.Visible = false;
                pictureBoxSancho.Visible = false;
            }
            if (textBoxso.Text == "7")
            {
                pictureBoxAtony.Visible = false;
                pictureBoxHojlund.Visible = false;
                pictureBoxMaguire.Visible = false;
                pictureBoxMainoo.Visible = false;
                pictureBoxMartinez.Visible = false;
                pictureBoxMount.Visible = true;
                pictureBoxOnana.Visible = false;
                pictureBoxSancho.Visible = false;
            }
            if (textBoxso.Text == "37")
            {
                pictureBoxAtony.Visible = false;
                pictureBoxHojlund.Visible = false;
                pictureBoxMaguire.Visible = false;
                pictureBoxMainoo.Visible = true;
                pictureBoxMartinez.Visible = false;
                pictureBoxMount.Visible = false;
                pictureBoxOnana.Visible =false;
                pictureBoxSancho.Visible = false;
            }
            if (textBoxso.Text == "11")
            {
                pictureBoxAtony.Visible = false;
                pictureBoxHojlund.Visible = true;
                pictureBoxMaguire.Visible = false;
                pictureBoxMainoo.Visible = false;
                pictureBoxMartinez.Visible = false;
                pictureBoxMount.Visible = false;
                pictureBoxOnana.Visible = false;
                pictureBoxSancho.Visible = false;
            }
            if (textBoxso.Text == "21")
            {
                pictureBoxAtony.Visible = true;
                pictureBoxHojlund.Visible = false;
                pictureBoxMaguire.Visible = false;
                pictureBoxMainoo.Visible = false;
                pictureBoxMartinez.Visible = false;
                pictureBoxMount.Visible = false;
                pictureBoxOnana.Visible = false;
                pictureBoxSancho.Visible = false;
            }
            if (textBoxso.Text == "25")
            {
                pictureBoxAtony.Visible = false;
                pictureBoxHojlund.Visible = false;
                pictureBoxMaguire.Visible = false;
                pictureBoxMainoo.Visible = false;
                pictureBoxMartinez.Visible = false;
                pictureBoxMount.Visible = false;
                pictureBoxOnana.Visible = false;
                pictureBoxSancho.Visible = true;
            }

        }

        private void Player_Load(object sender, EventArgs e)
        {
            pictureBoxAtony.Visible = false;
            pictureBoxHojlund.Visible = false;
            pictureBoxMaguire.Visible = false;
            pictureBoxMainoo.Visible = false;
            pictureBoxMartinez.Visible = false;
            pictureBoxMount.Visible = false;
            pictureBoxOnana.Visible = false;
            pictureBoxSancho.Visible = false;
            
        }
    }
}
