using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Mancher
{
    public partial class Man : Form
    {
        private SoundPlayer choinhac;
        public Man()
        {
            InitializeComponent();
            choinhac = new SoundPlayer(@"C:\Users\ADMIN\Downloads\GloryGloryManUnited-MUTeam_kzff.wav");
           
        }
       
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(ChildForm);
            panel_Body.Tag= ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Player());
            label_form.Text=buttonPlayer.Text;

        }

        private void Man_Load(object sender, EventArgs e)
        {

        }

        private void buttonCoach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CoachingStaff());
            label_form.Text = buttonCoach.Text;
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMusic());
            label_form.Text= buttonMusic.Text;
        }

        private void buttonAo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCompetitionShirt());
            label_form.Text=buttonAo.Text;
        }

        private void buttonSodo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TacticalScheme());
            label_form.Text=buttonSodo.Text;
        }

        private void buttonHuyenth_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLegend());
            label_form.Text=buttonHuyenth.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
