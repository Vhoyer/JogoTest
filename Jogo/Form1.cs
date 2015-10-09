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
    public partial class frmMuseumverna : Form
    {
        bool canPaint; //Vê se ele já matou um bicho (precisa salvar não, diz que o sangue secou kk)
        private int Mclick = 0;
        Single x, y;
        Pen pen;
        Bitmap bmp;

        #region "Encapsulada"
        public bool CanPaint
        {
            get { return canPaint; }
            set { canPaint = value; }
        }
        #endregion

        public frmMuseumverna()
        {
            InitializeComponent();
        }

        private void ControlDialog()
        {
            if (canPaint)
            {
                switch (Mclick)
                {
                    case 0:
                        lblText.Text = "Mas Espere...";
                        break;
                    case 1:
                        lblText.Text = "Com esse sangue, talvez eu possa pintar na parede!";
                        break;
                    case 2:
                        pnlPaint.Visible = true;
                        pnlPaint.Dock = DockStyle.Fill;
                        break;
                }
            }
            else
            {
                switch (Mclick)
                {
                    case 0:
                        lblText.Text = "É... nada...";
                        break;
                    case 1:
                        this.Close();
                        break;
                }
            }
            Mclick++;
        }

        private void frmMuseumverna_Load(object sender, EventArgs e)
        {
            //para test já vai vir em true 
            canPaint = true;

            bmp = new Bitmap(461, 437);
            pen = new Pen(Color.Maroon, trkSize.Value);
        }

        private void frmMuseumverna_MouseDown(object sender, MouseEventArgs e)
        {
            ControlDialog();
        }

        private void ClearPaint()
        {
            Graphics graph = Graphics.FromImage(bmp);
            graph.Clear(Color.Transparent);
            pctPaint.Image = bmp;
        }

        private void LoadPaint()
        {
            opn.ShowDialog();
        }

        private void opn_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(opn.FileName, System.IO.FileMode.Open);
                bmp = new Bitmap(fs);
                fs.Close();
                pctPaint.Image = bmp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SavePaint()
        {
            svf.ShowDialog();
            /*
            cria aqui um metodo para salvar no destino da pasta independente de computador ;)
            depois disso da pra tirar o "opn" e o "svf"
            */
        }

        private void svf_FileOk(object sender, CancelEventArgs e)
        {
            bmp.Save(svf.FileName); 
        }

        private void pctPaint_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void trkSize_Scroll(object sender, EventArgs e)
        {
            pen = new Pen(Color.Maroon, trkSize.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavePaint();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPaint();
        }

        private void pctPaint_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graph = Graphics.FromImage(bmp);
            if (e.Button == MouseButtons.Left)
            {
                graph.DrawLine(pen, x, y, e.X, e.Y);
                pctPaint.Image = bmp;
                x = e.X;
                y = e.Y;
            }
        }
    }
}
