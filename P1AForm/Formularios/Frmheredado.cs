using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P1AForm.Formularios
{
    public partial class Frmheredado : P1AForm.MyApp
    {
        public Frmheredado()
        {
            InitializeComponent();
        }

        private void buttonSaludos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }
    }
}
