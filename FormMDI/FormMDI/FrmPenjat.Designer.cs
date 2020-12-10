namespace FormMDI
{
    partial class FrmPenjat
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
            this.lbGuiones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGuiones
            // 
            this.lbGuiones.AutoSize = true;
            this.lbGuiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuiones.Location = new System.Drawing.Point(33, 80);
            this.lbGuiones.Name = "lbGuiones";
            this.lbGuiones.Size = new System.Drawing.Size(18, 20);
            this.lbGuiones.TabIndex = 2;
            this.lbGuiones.Text = "_";
            // 
            // FrmPenjat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(414, 488);
            this.Controls.Add(this.lbGuiones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPenjat";
            this.Text = "El Penjat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPenjat_FormClosing);
            this.Load += new System.EventHandler(this.FrmPenjat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbGuiones;
    }
}