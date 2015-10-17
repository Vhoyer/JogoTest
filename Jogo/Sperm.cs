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
        //variavel dos nomes
        string[] placar = new string[]
        {
            "Você", "Criador da cura do AIDS","Melhor que o Tarantino",
            "Proximo Miquelangelo","Ganhador do Nobel","Outro Eistein",
            "Outro Hitler","Raquel","Outro Avilmar","Gandalf",
            "Pessoa que ama java","Um Bombeiro","Outro Bombeiro",
            "Aluno de Web","Ganhador do Oscar","Um médico"
        };
        //classe do placar, bem óbvio
        Placar plc;
<<<<<<< HEAD
        //variavel de test
        string[] plcArr;
        List<string> plclist;
        DataView dv;
        DataTable dt;
=======

        //227; 292 >> 227; 125 (167)
>>>>>>> batente

        public Sperm()
        {
            InitializeComponent();
            plc = new Placar(placar);
            dv = new DataView(plc.table);

<<<<<<< HEAD
            //dgvPlacar.DataSource = plc.table.Select(" ");
            plcArr = (from Jogo in plc.table.AsEnumerable()
                      orderby plc.table.Columns[1]
                      select plc.table.Columns[0].ToString()).ToArray();
            lstbPlacar.DataSource = plcArr;
        }

        #region "Nado do protagonista"
        /// <summary>
        /// Controla o "Nado" do esperma =D (não, não foi o marciano)
        /// </summary>
=======
            lstPosition.DataSource = plc.Update();
        }

        #region "nado do personagem"
>>>>>>> batente
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
            if (!tmr.Enabled)
            {
                tmr.Start();
            }
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
            int pos = pbSpermMain.Location.Y, 
                nextStep = 3;
            string winners = ""; 

            //controla a correnteza, nem sei se é assim que escreve...
            if (pos <= 125)
            {
                tmr.Stop();
            }
            if (pos + nextStep < 292)
            {
                pgsBar.Value -= nextStep;
                plc.table.Rows[0][1] = pgsBar.Value;
                pbSpermMain.Location = new Point(227, pbSpermMain.Location.Y + nextStep);
            }

            //Controla o nado dos "npc's" e checka se alguem ganhou 
            //--atualizar quando o list estiver pronto;
            #region "Controla os npc's"
            Random rnd = new Random();
            for (int i = 1; i < plc.table.Rows.Count; i++)
            {
                int step = rnd.Next(11) + 1;
                plc.table.Rows[i][1] = Convert.ToInt32(plc.table.Rows[i][1]) + step;
                if (Convert.ToInt32(plc.table.Rows[i][1]) > 167)
                {
                    tmr.Stop();
                    btnNadar1.Visible = false;
                    btnNadar2.Visible = false;
                    winners = "um candango";
                    MessageBox.Show("Aparentemente, você acabou de perder para " + winners + ".\n\nTente novamente em outra oportunidade!", "Perdeu!");
                    break;
                }
            }
<<<<<<< HEAD
            #endregion

            //aqui tem que atualizar o listView/dataGridView, de alguma maneira
            //EnumerableRowCollection<DataColumn> query =

            plcArr = (from Jogo in plc.table.AsEnumerable()
             orderby plc.table.Columns[1]
             select plc.table.Columns[0].ToString()).ToArray();
            lstbPlacar.DataSource = plcArr;

=======

            lstPosition.DataSource = plc.Update();
>>>>>>> batente
        }
    }
}
