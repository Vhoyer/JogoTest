using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Sperm : Form
    {
        public Sperm()
        {
            InitializeComponent();
        }

        private void btnNadar1_Click(object sender, EventArgs e)
        {
            pbSpermMain.Image = Jogo.Properties.Resources.sperm1;
            btnNadar1.Visible = false;
            btnNadar2.Visible = true;
        }

        private void btnNadar2_Click(object sender, EventArgs e)
        {
            pbSpermMain.Image = Jogo.Properties.Resources.sperm2;
            btnNadar2.Visible = false;
            btnNadar1.Visible = true;
        }
    }
}
