using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancher
{
    public partial class FormMusic : Form
    {
        private SoundPlayer choinhac;
        public FormMusic()
        {
            InitializeComponent();
            choinhac = new SoundPlayer(@"GloryGloryManUnited-MUTeam_kzff.wav");
        }

        private void checkBoxNhac_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNhac.Checked==true)
            {
                choinhac.Play();
            }else
            {
                choinhac.Stop();
            }
        }

        private void FormMusic_Load(object sender, EventArgs e)
        {

        }
    }
}
