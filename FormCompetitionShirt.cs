using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancher
{
    public partial class FormCompetitionShirt : Form
    {
        public FormCompetitionShirt()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAway_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "................";
            if (openFile.ShowDialog() == DialogResult.OK && radioButtonHome.Checked)
            { 
                //6.Van dung mo file anh, dua len picturebox:
                pictureInsertHome1.Image = Image.FromFile(openFile.FileName);
            }
            else if(openFile.ShowDialog()==DialogResult.OK && radioButtonAway.Checked)
            {
                pictureBoxInsertAway1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void radioButtonHome_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelhomecourt_Click(object sender, EventArgs e)
        {

        }

        private void FormCompetitionShirt_Load(object sender, EventArgs e)
        {

        }
    }
}
