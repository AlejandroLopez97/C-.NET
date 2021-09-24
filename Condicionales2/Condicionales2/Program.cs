using System;

namespace Condicionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero;
            //double ValorCompra;

            //Console.WriteLine("------RULETA DE DESCUENTOS-----");
            //Console.WriteLine("Digite el número de la ruleta");
            //numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite el valor de la compra");
            //ValorCompra = Convert.ToDouble(Console.ReadLine());

            //switch (numero)
            //{
            //    case (0):
            //    case (1):
            //        Console.WriteLine("Tiene un descuento de: {0} \n y el valor de la compra es: {1}",ValorCompra*0.05,ValorCompra - (ValorCompra*0.05));
            //        break;

            //    case (2):
            //    case (3):
            //        Console.WriteLine("Tiene un descuento de: {0} \n y el valor de la compra es: {1}", ValorCompra * 0.10, ValorCompra - (ValorCompra * 0.10));
            //        break;

            //    case (4):
            //    case (5):
            //        Console.WriteLine("Tiene un descuento de: {0} \n y el valor de la compra es: {1}", ValorCompra * 0.15, ValorCompra - (ValorCompra * 0.15));
            //        break;

            //    case (6):
            //    case (7):
            //        Console.WriteLine("Tiene un descuento de: {0} \n y el valor de la compra es: {1}", ValorCompra * 0.20, ValorCompra - (ValorCompra * 0.20));
            //        break;

            //    default:
            //        break;

            //}

            //Generar números aleatorios del 1 al 30 y vamos a determinar los números pares

            //Random aleatorio = new Random();
            //int num;
            //num = aleatorio.Next(1, 30);
            //Console.WriteLine(num);
            //num = num % 2;

            //if(num == 0)
            //{
            //    Console.WriteLine("El número es par ");
            //}
            //else
            //{
            //    Console.WriteLine("El número es impar");
            //}

            //Ingresar el número ganador de una rifa, generar un número al azar entre 1 y 10 determinar si gano 
            // de 50mil pesos o indicar que perdio

            //int num, azar;

            //Console.WriteLine("-----RIFA-----");
            //Console.WriteLine("Ingresar el número ganador");
            //num = Convert.ToInt32(Console.ReadLine());

            //Random aleatorio = new Random();
            //azar = aleatorio.Next(1, 5);

            //if (num == azar)
            //{
            //    Console.WriteLine("Eres el ganador");
            //}
            //else
            //{
            //    Console.WriteLine("No eres el ganador");
            //}

            //Crear un programa que contenga los números pares del 1 al 10

            //int num;

            //for (num = 0; num <= 10; num++)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }

            //}

            //Calcular el sueldo promedio de un grupo de empleados

            int empleados;
            double sueldos, acum = 0;
            Console.WriteLine("Digite el número de empleados");
            empleados = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < empleados; i++)
            {
                Console.WriteLine("Digite el sueldo: ");
                sueldos = Convert.ToDouble(Console.ReadLine());
                acum = acum + sueldos;
            }
            Console.WriteLine("El promedio para {0} empleados es de: {1}",empleados, (acum/empleados));

            Console.ReadKey();
        }
    }
}
