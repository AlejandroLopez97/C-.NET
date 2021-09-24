using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int[] notas = new int[3];
            notas[0] = 4;
            notas[1] = 3;
            notas[2] = 3;

            int suma = 0;
            int promedio;

            for (int i = 0; i < notas.Length; i++)
            {
                cbxNotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 3;
            txtPromedio.Text = promedio.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            cbxNotas.Items.Clear();
        }
    }
}
