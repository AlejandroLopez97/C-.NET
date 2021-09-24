using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre, apellido y edad, imprima los datos de solo los mayores de edad
            //suponiendo para el numero de estudiantes de clase 14 

            //string nombre, apellido;
            //int edad, i = 1;

            //while (i<=14)
            //{
            //    Console.WriteLine("Digite su nombre");
            //    nombre = Console.ReadLine();
            //    Console.WriteLine("Digite su apellido");
            //    apellido = Console.ReadLine();
            //    Console.WriteLine("Digite su edad");
            //    edad = Convert.ToInt32(Console.ReadLine());

            //    if (edad>=18)
            //    {
            //        Console.WriteLine("\nLos datos son: \nNombre:{0}\nApellido:{1}\nEdad:{2}\n",nombre,apellido,edad);
            //    }

            //    i++;
            //}

            //Vamos a calcular el dinero, las opciones en que nos vamos a gastar y que nos mestre el total
            /*Opciones 
             * 1.Dulces
             * 2.Papitas 
             * 3.Chocolatinas
             * 4.Helado
             * 5.Salir            
             */

            //int dinero, total = 0, opcion = 0;

            //Console.WriteLine("Ingrese la cantidad de dinero");
            //dinero = Convert.ToInt32(Console.ReadLine());

            //while (dinero>0 && opcion!=5)
            //{
            //    if (dinero >= 0)
            //    {
            //        Console.WriteLine("\nSelecione una opcion\n1.Dulces\n2.Papitas\n3.Chocolates\n4.Helado\n5.Salir\n");
            //        opcion = int.Parse(Console.ReadLine());
            //        switch (opcion)
            //        {
            //            case 1:
            //                dinero -= 500;
            //                total += 500;
            //                break;
            //            case 2:
            //                dinero -= 1000;
            //                total += 1000;
            //                break;
            //            case 3:
            //                dinero -= 2500;
            //                total += 2500;
            //                break;
            //            case 4:
            //                dinero -= 3000;
            //                total += 3000;
            //                break;
            //            case 5:
            //                Console.WriteLine("Adios");
            //                break;
            //            default:
            //                break;
            //        }
                   
            //        Console.WriteLine("Tienes en dinero: {0} y has gastado {1}", dinero, total);
              
            //    }
            //    else
            //    {
            //        Console.WriteLine("No te alcanza, escoge otra opción");
                    
            //    }
                
            //}

            //Revisar si es par y multiplo de 3 o no, cada número de un grupo de 10 

            Console.ReadKey();
        }
    }
}
