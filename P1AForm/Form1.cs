using P1AForm.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1AForm
{
    public partial class MyApp : Form
    {
        int intentos = 0;
        public MyApp()
        {
            InitializeComponent();
        }

        private void MyApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }

        private void MyApp_Activated(object sender, EventArgs e)
        {
        }

        //private void buttonInicio_Click(object sender, EventArgs e)
        //{
        //    labelTitulo.Text = "Bienvenido a mi app";
        //    Frmingreso forma = new Frmingreso();
        //    forma.Show();
        //}

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            if (intentos < 3)
            {
                if (textBoxUsuario.Text.ToLower() == "keven" && textBoxContrasena.Text.ToLower() == "lopez")
                {
                    Frmingreso forma = new Frmingreso();
                    forma.Show();
                }
                else
                {
                    MessageBox.Show($"Usuario o contrasena incorrecta. Tienes {3-intentos} intentos mas.");
                    textBoxUsuario.Text = "";
                    textBoxContrasena.Text = "";
                    intentos++;
                }
            }
            else
            {
                MessageBox.Show("Ya no tienes mas intentos. El sistema se bloqueo.");
                buttonIngreso.Enabled = false;
            }
        }
    }
}
