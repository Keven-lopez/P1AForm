namespace P1AForm.Formularios
{
    partial class Frmheredado
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
            this.buttonSaludos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaludos
            // 
            this.buttonSaludos.Location = new System.Drawing.Point(168, 211);
            this.buttonSaludos.Name = "buttonSaludos";
            this.buttonSaludos.Size = new System.Drawing.Size(75, 23);
            this.buttonSaludos.TabIndex = 3;
            this.buttonSaludos.Text = "Saludo";
            this.buttonSaludos.UseVisualStyleBackColor = true;
            this.buttonSaludos.Click += new System.EventHandler(this.buttonSaludos_Click);
            // 
            // Frmheredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaludos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frmheredado";
            this.Controls.SetChildIndex(this.buttonSaludos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludos;
    }
}
