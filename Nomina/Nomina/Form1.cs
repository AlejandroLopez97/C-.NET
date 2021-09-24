using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vendedor usuario1 = new Vendedor();
            usuario1.Nombre = txtNombre.Text;
            usuario1.Apellido = txtApellido.Text;
            usuario1.Documento = txtDocumento.Text;
            usuario1.Tipo = cbxTipo.Text;
            usuario1.Tipodecontrato = cbxContrato.Text;

            usuario1.calcularsueldo(2000000);

            dataGridView1.Rows.Insert(0, usuario1.Nombre, usuario1.Apellido, usuario1.Documento, usuario1.Tipo,usuario1.Sueldo);
            txtNombre.Clear();
            txtApellido.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
