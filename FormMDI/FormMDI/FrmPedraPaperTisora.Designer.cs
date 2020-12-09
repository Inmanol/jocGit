namespace FormMDI
{
    partial class FrmPedraPaperTisora
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
            this.pbJugador = new System.Windows.Forms.PictureBox();
            this.pbIA = new System.Windows.Forms.PictureBox();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnTisora = new System.Windows.Forms.Button();
            this.lbJugador = new System.Windows.Forms.Label();
            this.lbIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pbJugador
            // 
            this.pbJugador.Image = global::FormMDI.Properties.Resources.qq;
            this.pbJugador.Location = new System.Drawing.Point(80, 60);
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.Size = new System.Drawing.Size(130, 130);
            this.pbJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJugador.TabIndex = 0;
            this.pbJugador.TabStop = false;
            // 
            // pbIA
            // 
            this.pbIA.Image = global::FormMDI.Properties.Resources.qq;
            this.pbIA.Location = new System.Drawing.Point(390, 60);
            this.pbIA.Name = "pbIA";
            this.pbIA.Size = new System.Drawing.Size(130, 130);
            this.pbIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIA.TabIndex = 1;
            this.pbIA.TabStop = false;
            // 
            // btnPedra
            // 
            this.btnPedra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedra.Location = new System.Drawing.Point(182, 250);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(75, 23);
            this.btnPedra.TabIndex = 2;
            this.btnPedra.Text = "Pedra";
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(263, 250);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 3;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnTisora
            // 
            this.btnTisora.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTisora.Location = new System.Drawing.Point(344, 250);
            this.btnTisora.Name = "btnTisora";
            this.btnTisora.Size = new System.Drawing.Size(75, 23);
            this.btnTisora.TabIndex = 4;
            this.btnTisora.Text = "Tisora";
            this.btnTisora.UseVisualStyleBackColor = true;
            this.btnTisora.Click += new System.EventHandler(this.btnTisora_Click);
            // 
            // lbJugador
            // 
            this.lbJugador.AutoSize = true;
            this.lbJugador.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJugador.Location = new System.Drawing.Point(96, 13);
            this.lbJugador.Name = "lbJugador";
            this.lbJugador.Size = new System.Drawing.Size(96, 23);
            this.lbJugador.TabIndex = 5;
            this.lbJugador.Text = "Jugador";
            // 
            // lbIA
            // 
            this.lbIA.AutoSize = true;
            this.lbIA.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIA.Location = new System.Drawing.Point(441, 13);
            this.lbIA.Name = "lbIA";
            this.lbIA.Size = new System.Drawing.Size(35, 23);
            this.lbIA.TabIndex = 6;
            this.lbIA.Text = "IA";
            // 
            // FrmPedraPaperTisora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbIA);
            this.Controls.Add(this.lbJugador);
            this.Controls.Add(this.btnTisora);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.pbIA);
            this.Controls.Add(this.pbJugador);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPedraPaperTisora";
            this.Text = "Pedra - Paper - Tisora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedraPaperTisora_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbJugador;
        private System.Windows.Forms.PictureBox pbIA;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnTisora;
        private System.Windows.Forms.Label lbJugador;
        private System.Windows.Forms.Label lbIA;
    }
}