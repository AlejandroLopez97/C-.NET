using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro
    {
        //Creo vectores paralelos para almacenar la información del usuario ingresada por el formulario
        //vendrian siendo los atributos de la clase libro
        private string[] Titulo = new string[5];
        private string[] Autor = new string[5];
        private string[] Cantidad = new string[5];
        private string[] Ubicacion = new string[5];

        //creo atributos adicionales para el control de busqueda y validación
        private int posicion;
        private bool encontrado;

        //encapsulo los atributos de la clase para poder ser utilizados en otras clases
        public int Posicion { get => posicion; set => posicion = value; }
        public bool Encontrado { get => encontrado; set => encontrado = value; }
        public string[] Titulo1 { get => Titulo; set => Titulo = value; }
        public string[] Autor1 { get => Autor; set => Autor = value; }
        public string[] Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string[] Ubicacion1 { get => Ubicacion; set => Ubicacion = value; }

        //en las siguientes funciones/metodos lleno los atributos vectores con información
        public void LlenarTitulo()
        {
            this.Titulo1[0] = "lucesdebohemia";
            this.Titulo1[1] = "cienañosdesoledad";
            this.Titulo1[2] = "lasalmasmuertas";
            this.Titulo1[3] = "inquebrantables";
            this.Titulo1[4] = "covid19";

        }
        public void LlenarAutor()
        {
            this.Autor1[0] = "ramondelvalle";
            this.Autor1[1] = "gabrielgarciamarquez";
            this.Autor1[2] = "nicolasgogol";
            this.Autor1[3] = "danielhabfit";
            this.Autor1[4] = "alejandrolopez";

        }
        public void LlenarCantidad()
        {
            this.Cantidad1[0] = "15";
            this.Cantidad1[1] = "3";
            this.Cantidad1[2] = "54";
            this.Cantidad1[3] = "12";
            this.Cantidad1[4] = "36";
        }
        public void LlenarUbicacion()
        {
            this.Ubicacion1[0] = "L456-sede centro";
            this.Ubicacion1[1] = "M63-sede centro";
            this.Ubicacion1[2] = "M89-sede centro";
            this.Ubicacion1[3] = "K41-sede laureles";
            this.Ubicacion1[4] = "J102-sede robledo";
        }

        //en esta función / metodo busco el libro en los vectores paralelos por el titulo ingresado por el usuario
        //no retornan ningun valor, por esto se encuentra void
        public void BuscarNombre(string nombre)//aqui en nombre se recibe como parametro sin espacios para poder ser comparado
        {
            
            for (int i = 0; i < 5; i++)
            {
                if (nombre.Equals(this.Titulo1[i]))//con este ciclo recorro el vector-atributo titulo para comparar con lo ingresado por el usuario
                {
                    this.Encontrado = true; //el atributo encontrado le asigno el valor verdadero porque cumple con la condicion
                    this.Posicion = i;//aqui asigno al atributo posicion, la posicion "i" en la que se encuentra el vector, para poder ser utilizado a la hora de mostrar la informacion en el datagrid
                }
            }
        }

        //en esta función / metodo busco el libro en los vectores paralelos por el autor ingresado por el usuario
        //no retornan ningun valor, por esto se encuentra void
        public void BuscarAutor(string autor)//aqui el autor se recibe como parametro sin espacios para poder ser comparado
        {
            for (int i = 0; i < 5; i++)
            {
                if (autor.Equals(this.Autor1[i]))//con este ciclo recorro el vector-atributo autor para comparar con lo ingresado por el usuario
                {
                    this.Encontrado = true;//el atributo encontrado le asigno el valor verdadero porque cumple con la condicion
                    this.Posicion = i;//aqui asigno al atributo posicion, la posicion "i" en la que se encuentra el vector, para poder ser utilizado a la hora de mostrar la informacion en el datagrid
                }
            }
           
        }
    }

}
