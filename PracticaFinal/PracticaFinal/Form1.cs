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

namespace PracticaFinal
{
    public partial class Libreria : Form
    {
        public Libreria()
        {
            InitializeComponent();
        }
        //Este es el objeto que creamos para poder utilizar la biblioteca clases 
        Libro Btitulo = new Libro();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // me cierra el programa al presionar el boton 
            Close();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            //al presionar el boton, inmediatamente llamo al objeto para almacenar la informacion de los libros
            Btitulo.LlenarTitulo();
            Btitulo.LlenarAutor();
            Btitulo.LlenarCantidad();
            Btitulo.LlenarUbicacion();
            //llamo a la funcion para buscar por nombre del libro o titulo
            Btitulo.BuscarNombre(txtLibro.Text.Replace(" ",String.Empty));
            //generamos una condicion, donde comparamos con un booleano creado en la biblioteca clase llamado
            //encontrado, si lo encuentra, me llena el datagrid que son los datos del libro que se le mostrara 
            //al usuario 
            if (Btitulo.Encontrado == true)
            {
                LlenarDataGrid(); //llamo al datagrid
            }
            else
            {
                MessageBox.Show("Libro no encontrado");//si no encuentra el libro me saca un mensaje
            }
        }

        private void LlenarDataGrid() //metodo para llenar el datagrid
        {
            int posicion = Btitulo.Posicion; // llamo al atributi posicion de la clase libro
            //aca llenamos el datagrid
            dataGridViewResultado.Rows.Insert(0, Btitulo.Titulo1[posicion], Btitulo.Autor1[posicion], Btitulo.Cantidad1[posicion], Btitulo.Ubicacion1[posicion]);
      
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            //al presionar el boton, inmediatamente llamo al objeto para almacenar la informacion de los libros
            // este metodo cumple la misma funcion que la del boton btnLibro, en diferencia que este busca
            //por autor del libro
            Btitulo.LlenarTitulo();
            Btitulo.LlenarAutor();
            Btitulo.LlenarCantidad();
            Btitulo.LlenarUbicacion();
            Btitulo.BuscarAutor (txtAutor.Text.Replace(" ",String.Empty));//este metodo me elimina espacios en el string enviado por el usuario para poder comparar
            if (Btitulo.Encontrado == true)
            {
                LlenarDataGrid();
            }
            else
            {
                MessageBox.Show("Libro no encontrado");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //aca nos encargamos de limpiar todo el formulario para una nueva consulta
            txtAutor.Clear();
            txtLibro.Clear();
            dataGridViewResultado.Rows.Clear();
        }
    }
}
