using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamensprojekt
{
    public partial class frm_Præmier : Form
    {
        public frm_Præmier()
        {
            InitializeComponent();
            ptb_GrayPrize.Image = Pictures.Gray;
        }

        private void frm_Præmier_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frm_Main.checkfrm_Præmer = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
