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
        string[] placar = new string[] 
        {
            "Criador da cura do câncer","Melhor que o Tarantino",
            "Proximo Miquelangelo","Ganhador do Nobel","Outro Eistein",
            "Outro Hitler","Raquel","Outro Avilmar","Gandalf",
            "Pessoa que ama java","Um Bombeiro","Outro Bombeiro",
            "Aluno de Web","Ganhador do Oscar"
        }
      
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
