namespace Jogo
{
    partial class Sperm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbSpermMain = new System.Windows.Forms.PictureBox();
            this.btnNadar1 = new System.Windows.Forms.Button();
            this.btnNadar2 = new System.Windows.Forms.Button();
            this.pgsBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.dgvPlacar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpermMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSpermMain
            // 
            this.pbSpermMain.BackColor = System.Drawing.Color.Transparent;
            this.pbSpermMain.Image = global::Jogo.Properties.Resources.sperm2;
            this.pbSpermMain.Location = new System.Drawing.Point(227, 292);
            this.pbSpermMain.Name = "pbSpermMain";
            this.pbSpermMain.Size = new System.Drawing.Size(93, 183);
            this.pbSpermMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpermMain.TabIndex = 0;
            this.pbSpermMain.TabStop = false;
            // 
            // btnNadar1
            // 
            this.btnNadar1.Location = new System.Drawing.Point(36, 334);
            this.btnNadar1.Name = "btnNadar1";
            this.btnNadar1.Size = new System.Drawing.Size(91, 111);
            this.btnNadar1.TabIndex = 1;
            this.btnNadar1.Text = "Nadar";
            this.btnNadar1.UseVisualStyleBackColor = true;
            this.btnNadar1.Click += new System.EventHandler(this.btnNadar1_Click);
            // 
            // btnNadar2
            // 
            this.btnNadar2.Location = new System.Drawing.Point(419, 334);
            this.btnNadar2.Name = "btnNadar2";
            this.btnNadar2.Size = new System.Drawing.Size(91, 111);
            this.btnNadar2.TabIndex = 2;
            this.btnNadar2.Text = "Nadar";
            this.btnNadar2.UseVisualStyleBackColor = true;
            this.btnNadar2.Visible = false;
            this.btnNadar2.Click += new System.EventHandler(this.btnNadar2_Click);
            // 
            // pgsBar
            // 
            this.pgsBar.Location = new System.Drawing.Point(36, 7);
            this.pgsBar.Maximum = 167;
            this.pgsBar.Name = "pgsBar";
            this.pgsBar.Size = new System.Drawing.Size(474, 23);
            this.pgsBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Progresso";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // dgvPlacar
            // 
            this.dgvPlacar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacar.Location = new System.Drawing.Point(555, 7);
            this.dgvPlacar.Name = "dgvPlacar";
            this.dgvPlacar.Size = new System.Drawing.Size(231, 468);
            this.dgvPlacar.TabIndex = 6;
            // 
            // Sperm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Jogo.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(797, 487);
            this.Controls.Add(this.dgvPlacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgsBar);
            this.Controls.Add(this.btnNadar2);
            this.Controls.Add(this.btnNadar1);
            this.Controls.Add(this.pbSpermMain);
            this.Name = "Sperm";
            this.Text = "Sperm";
            ((System.ComponentModel.ISupportInitialize)(this.pbSpermMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpermMain;
        private System.Windows.Forms.Button btnNadar1;
        private System.Windows.Forms.Button btnNadar2;
        private System.Windows.Forms.ProgressBar pgsBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.DataGridView dgvPlacar;
    }
}