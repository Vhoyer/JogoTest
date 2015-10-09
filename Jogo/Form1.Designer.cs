namespace Jogo
{
    partial class frmMuseumverna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuseumverna));
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.pctPaint = new System.Windows.Forms.PictureBox();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.btnC4 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.trkSize = new System.Windows.Forms.TrackBar();
            this.opn = new System.Windows.Forms.OpenFileDialog();
            this.svf = new System.Windows.Forms.SaveFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlDialog.SuspendLayout();
            this.pnlPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPaint)).BeginInit();
            this.grpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDialog
            // 
            this.pnlDialog.BackColor = System.Drawing.Color.White;
            this.pnlDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDialog.Controls.Add(this.lblText);
            this.pnlDialog.Location = new System.Drawing.Point(12, 353);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(630, 100);
            this.pnlDialog.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(15, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(115, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Você vê uma parede...";
            // 
            // pnlPaint
            // 
            this.pnlPaint.Controls.Add(this.pctPaint);
            this.pnlPaint.Controls.Add(this.grpTools);
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaint.Location = new System.Drawing.Point(0, 0);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(654, 465);
            this.pnlPaint.TabIndex = 1;
            this.pnlPaint.Visible = false;
            // 
            // pctPaint
            // 
            this.pctPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctPaint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctPaint.BackgroundImage")));
            this.pctPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPaint.Location = new System.Drawing.Point(12, 12);
            this.pctPaint.Name = "pctPaint";
            this.pctPaint.Size = new System.Drawing.Size(461, 437);
            this.pctPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPaint.TabIndex = 2;
            this.pctPaint.TabStop = false;
            this.pctPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseDown);
            this.pctPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseMove);
            // 
            // grpTools
            // 
            this.grpTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTools.Controls.Add(this.btnClear);
            this.grpTools.Controls.Add(this.label1);
            this.grpTools.Controls.Add(this.lblN1);
            this.grpTools.Controls.Add(this.btnC4);
            this.grpTools.Controls.Add(this.btnC3);
            this.grpTools.Controls.Add(this.btnC2);
            this.grpTools.Controls.Add(this.btnC1);
            this.grpTools.Controls.Add(this.trkSize);
            this.grpTools.Location = new System.Drawing.Point(479, 13);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(163, 436);
            this.grpTools.TabIndex = 1;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Ferramentas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cor";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(6, 36);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(94, 13);
            this.lblN1.TabIndex = 5;
            this.lblN1.Text = "Tamanho do traço";
            // 
            // btnC4
            // 
            this.btnC4.Location = new System.Drawing.Point(9, 235);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(144, 23);
            this.btnC4.TabIndex = 4;
            this.btnC4.Text = "Sangue do Animal 4";
            this.btnC4.UseVisualStyleBackColor = true;
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(9, 205);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(144, 23);
            this.btnC3.TabIndex = 3;
            this.btnC3.Text = "Sangue do Animal 3";
            this.btnC3.UseVisualStyleBackColor = true;
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(9, 175);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(144, 23);
            this.btnC2.TabIndex = 2;
            this.btnC2.Text = "Sangue do Animal 2";
            this.btnC2.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(10, 145);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(144, 23);
            this.btnC1.TabIndex = 1;
            this.btnC1.Text = "Sangue do Animal 1";
            this.btnC1.UseVisualStyleBackColor = true;
            // 
            // trkSize
            // 
            this.trkSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkSize.Location = new System.Drawing.Point(7, 52);
            this.trkSize.Minimum = 1;
            this.trkSize.Name = "trkSize";
            this.trkSize.Size = new System.Drawing.Size(150, 45);
            this.trkSize.TabIndex = 0;
            this.trkSize.Value = 2;
            this.trkSize.Scroll += new System.EventHandler(this.trkSize_Scroll);
            // 
            // opn
            // 
            this.opn.FileName = "opn";
            this.opn.FileOk += new System.ComponentModel.CancelEventHandler(this.opn_FileOk);
            // 
            // svf
            // 
            this.svf.FileOk += new System.ComponentModel.CancelEventHandler(this.svf_FileOk);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 369);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Mover para o lado";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMuseumverna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 465);
            this.Controls.Add(this.pnlPaint);
            this.Controls.Add(this.pnlDialog);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 504);
            this.Name = "frmMuseumverna";
            this.Text = "Museumverna";
            this.Load += new System.EventHandler(this.frmMuseumverna_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMuseumverna_MouseDown);
            this.pnlDialog.ResumeLayout(false);
            this.pnlDialog.PerformLayout();
            this.pnlPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPaint)).EndInit();
            this.grpTools.ResumeLayout(false);
            this.grpTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.PictureBox pctPaint;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.TrackBar trkSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog opn;
        private System.Windows.Forms.SaveFileDialog svf;
        private System.Windows.Forms.Button btnClear;
    }
}

