using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos a validar la edad de dos hermanos y decir cual es mayor y mostrar la diferencia en edad.

            //int edad1, edad2;

            //Console.WriteLine("Ingrese la edad del primer hermano");
            //edad1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese la edad del segundo hermano");
            //edad2 = Convert.ToInt32(Console.ReadLine());

            //if (edad1>edad2)
            //{
            //    Console.WriteLine("El hermano mayor es el primer ingresado y la diferencia de edad es de {0} años", edad1-edad2);
            //}
            //else
            //{
            //    Console.WriteLine("El hermano mayor es el segundo ingresado y la diferencia de edad es de {0} años", edad2-edad1);
            //}

            //ingresar 3 numeros enteros diferentes y que el programa nos diga cual es el mayor 

            //int n1, n2, n3;
            //Console.WriteLine("Digite el primer numero");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite el segundo numero");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite el tercer numero");
            //n3 = int.Parse(Console.ReadLine());

            //if (n1>n2 && n2>n3)
            //{
            //    Console.WriteLine("El primer número ingresado es el mayor ");
            //}
            //else
            //{
            //    if (n2>n3)
            //    {
            //        Console.WriteLine("El segundo número ingresado es el mayor");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El tercer número ingresado es el mayor");
            //    }
            //}

            //Realizar un programa para identificar el tipo de triangulo conociendo sus tres lados 
            // Escaleno lados diferentes, equilatero lados iguales, isosceles dos lados iguales y uno diferente 

            //int l1, l2, l3;
            //Console.WriteLine("Digite el primer lado del triangulo");
            //l1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite el segundo lado del triangulo");
            //l2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite el tercer lado del triangulo");
            //l3 = Convert.ToInt32(Console.ReadLine());

            //if (l1==l2 && l2==l3)
            //{
            //    Console.WriteLine("El triangulo es Equilatero");
            //}
            //else
            //{
            //    if (l1==l2 && l2!=l3 || l2==l3 && l3!=l1 || l1==l3 && l3!=l2)
            //    {
            //        Console.WriteLine("El triangulo es Escaleno");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El triangulo es Isosceles");
            //    }
            //}

            //Crear un programa que pida un número entero y muestre un mensaje indicando dia de la semana 

            int n;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case (1):
                    Console.WriteLine("Es el día lunes");
                    break;
                case (2):
                    Console.WriteLine("Es el día martes");
                    break;
                case (3):
                    Console.WriteLine("Es el día miercoles");
                    break;
                case (4):
                    Console.WriteLine("Es el día jueves");
                    break;
                case (5):
                    Console.WriteLine("Es el día viernes");
                    break;
                case (6):
                    Console.WriteLine("Es el día sabado");
                    break;
                case (7):
                    Console.WriteLine("Es el día domingo");
                    break;

                default:
                    Console.WriteLine("El número ingresado no pertenece a ningun día");
                    break;
            }

            //Crear un programa que permita ingresar el monto de venta alcanzado por un vendedor y calcular la comision que le
            // corresponde ---> de 0-10.000 -> 0%, 10.000-50.000 -> 5%, 50.000-100.000 -> 10%

            double totalVenta,comision = 0;
            Console.WriteLine("Digite el total de la venta del empleado");
            totalVenta = double.Parse(Console.ReadLine());

            if (totalVenta>10000 && totalVenta<=50000)
            {
                comision = totalVenta * 0.05;
            }
            else
            {
                if (totalVenta>50000 && totalVenta<=100000)
                {
                    comision = totalVenta * 0.10;
                }
                else
                {
                   
                    Console.WriteLine("Tus comisiones superar el rango de comisiones");
                }
            }

            Console.WriteLine("Las ventas por {0}, tienen una comision de {1}",totalVenta,comision);
               

            Console.ReadKey();
        }
    }
}
