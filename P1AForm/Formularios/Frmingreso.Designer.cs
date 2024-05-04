namespace P1AForm.Formularios
{
    partial class Frmingreso
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.comboBoxFacultades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(170, 118);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(110, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Ingrese numero 1";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(307, 115);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 22);
            this.textBoxNum1.TabIndex = 3;
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(307, 169);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNum2.TabIndex = 4;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(307, 228);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 22);
            this.textBoxResultado.TabIndex = 5;
            // 
            // buttonSumar
            // 
            this.buttonSumar.Location = new System.Drawing.Point(322, 295);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(75, 23);
            this.buttonSumar.TabIndex = 6;
            this.buttonSumar.Text = "Sumar";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // comboBoxFacultades
            // 
            this.comboBoxFacultades.FormattingEnabled = true;
            this.comboBoxFacultades.Location = new System.Drawing.Point(281, 45);
            this.comboBoxFacultades.Name = "comboBoxFacultades";
            this.comboBoxFacultades.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFacultades.TabIndex = 7;
            this.comboBoxFacultades.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultades_SelectedIndexChanged);
            // 
            // Frmingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFacultades);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "Frmingreso";
            this.Text = "Frmingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.ComboBox comboBoxFacultades;
    }
}