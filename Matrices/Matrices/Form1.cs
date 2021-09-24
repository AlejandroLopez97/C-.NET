using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public string[,] Datos;
        public int CantidadArticulos;
        public int stock;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            CantidadArticulos = Convert.ToInt32(txtCantidadArticulos.Text);
            Datos = new string[CantidadArticulos, 3];

            for (int f = 0; f < CantidadArticulos; f++)
            {
                Datos[f, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del articulo"+(f+1),"Tienda");
                Datos[f, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio del articulo" + (f + 1), "Tienda");
                Datos[f, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el stock del articulo" + (f + 1), "Tienda");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string articulo;
            articulo = txtArticulo.Text;
            for (int c = 0; c < CantidadArticulos; c++)
            {
                if (Datos[c, 0].Equals(articulo))
                {
                    txtPrecio.Text = Datos[c, 1];
                    txtCantidad.Text = Datos[c, 2];
                    stock = c;

                }
            }
        }
    }
}
