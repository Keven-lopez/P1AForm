using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1AForm.Formularios
{
    public partial class Frmingreso : Form
    {
        public Frmingreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            int resultado = num1 + num2;
            string resul = resultado.ToString();
            textBoxResultado.Text = resul;
            comboBoxFacultades.Items.Add("Ingenieria");
            comboBoxFacultades.Items.Add("Medicina");
            comboBoxFacultades.Items.Add("Derecho");

        }

        private void comboBoxFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxFacultades.SelectedItem.ToString());
        }
    }
}
