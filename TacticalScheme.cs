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
    public partial class TacticalScheme : Form
    {
        public TacticalScheme()
        {
            InitializeComponent();
        }

        private void pictureBox442_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Are you sure you want to use the 4-4-2 formation?",
                "Confrim",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if( kq == DialogResult.Yes )
            {
                MessageBox.Show("You have chosen the formation: 4-4-2");
            }
        }

        private void pictureBox352_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Are you sure you want to use the 3-5-2 formation?",
                "Confrim",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("You have chosen the formation: 3-5-2");
            }
        }

        private void pictureBox4231_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Are you sure you want to use the 4-2-3-1 formation?",
                "Confrim",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("You have chosen the formation: 4-2-3-1");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Are you sure you want to use the 4-3-3 formation?",
                "Confrim",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("You have chosen the formation: 4-3-3");
            }

        }
              
private void pictureBox532_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Are you sure you want to use the 5-3-2 formation?",
                "Confrim",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("You have chosen the formation: 5-3-2");
            }
        }
    }
}

