using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxGastos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int cantidadDias;
            double[] gastos;
            double gasto, totalGasto = 0, diaMayor = 0;
         
            cantidadDias = Convert.ToInt32(txtCantidadDias.Text);
            gastos = new double[cantidadDias];
           
            for (int i = 0; i < cantidadDias; i++)
            {
                gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresar los gastos diarios"+(i+1)," gastos"));
                gastos[i] = gasto;

                if (gastos[i] > diaMayor)
                {
                    diaMayor = gastos[i];
                }

                totalGasto += gastos[i];
                cbxGastos.Items.Add(Convert.ToString(gastos[i]));
            }

            txtTotalGastos.Text = Convert.ToString(totalGasto);
            txtDiaMayorGasto.Text = Convert.ToString(diaMayor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantidadDias.Clear();
            cbxGastos.Items.Clear();
            txtTotalGastos.Clear();
            txtDiaMayorGasto.Clear();

        }
    }
}
