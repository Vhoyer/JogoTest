using System;
using System.Collections;
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
            "Você", "Criador da cura do AIDS","Melhor que o Tarantino",
            "Proximo Miquelangelo","Ganhador do Nobel","Outro Eistein",
            "Outro Hitler","Raquel","Outro Avilmar","Gandalf",
            "Pessoa que ama java","Um Bombeiro","Outro Bombeiro",
            "Aluno de Web","Ganhador do Oscar","Um médico"
        };
        Placar plc;

        //227; 292 >> 227; 125 (167)

        public Sperm()
        {
            InitializeComponent();
            plc = new Placar(placar);

            lstPosition.DataSource = plc.Update();
        }

        #region "nado do personagem"
        private void Nadar()
        {
            Random rnd = new Random();
            int step = rnd.Next(9) + 1;
            int pos = pbSpermMain.Location.Y;

            if (pos - step > 125)
            {
                pbSpermMain.Location = new Point(227, pos - step);
                pgsBar.Value += step;
                plc.table.Rows[0][1] = pgsBar.Value;
            }
            else
            {
                tmr.Stop();
                btnNadar1.Visible = false;
                btnNadar2.Visible = false; 
                pbSpermMain.Location = new Point(227, 125);
                pgsBar.Value = pgsBar.Maximum;
                MessageBox.Show("Parabêns, você acaba de ganhar o direito de nascer!", "Ganhou!");
            }
        }

        private void btnNadar1_Click(object sender, EventArgs e)
        {
            pbSpermMain.Image = Jogo.Properties.Resources.sperm1;
            btnNadar1.Visible = false;
            btnNadar2.Visible = true;
            Nadar();
        }

        private void btnNadar2_Click(object sender, EventArgs e)
        {
            pbSpermMain.Image = Jogo.Properties.Resources.sperm2;
            btnNadar2.Visible = false;
            btnNadar1.Visible = true;
            Nadar();
        }
        #endregion

        private void tmr_Tick(object sender, EventArgs e)
        {
            int pos = pbSpermMain.Location.Y;

            if (pos <= 125)
            {
                tmr.Stop();
            }
            if (pos + 2 < 292)
            {
                pgsBar.Value -= 2;
                plc.table.Rows[0][1] = pgsBar.Value;
                pbSpermMain.Location = new Point(227, pbSpermMain.Location.Y + 2);
            }
            Random rnd = new Random();
            for (int i = 1; i < plc.table.Rows.Count; i++)
            {
                int step = rnd.Next(9) + 1;
                plc.table.Rows[i][1] = Convert.ToInt32(plc.table.Rows[i][1]) + step;
            }

            lstPosition.DataSource = plc.Update();
        }
    }
}
