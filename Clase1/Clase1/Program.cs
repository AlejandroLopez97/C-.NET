using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar tres variables de tipo entero y en otra variable numerica 
            //guardar el resultado de estas 
            //int num1 = 4;
            //int num2 = 5;
            //int num3 = 8;

            //int resultado = num1 + num2 + num3;

            //Console.WriteLine(resultado);
            //Console.WriteLine("Hello World!");

            //imprimir en consola nuestro nombre y edad 

            //String Nombre = "Alejo";
            //int Edad = 23;

            //Console.WriteLine("Por favor ingrese su nombre: ");
            //string Nombre = Console.ReadLine();

            //Console.WriteLine("Por favor ingrese su edad: ");
            //int Edad = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Nombre + " Tiene " + Edad + " años");

            //Realizar un programa que sume 2 numeros enteros
            //Console.WriteLine("SUMA DE NUMEROS ENTEROS");

            //Console.WriteLine("Ingrese el primer numero: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese un segundo numero: ");
            //int num2 = Int32.Parse(Console.ReadLine());
            //int resultado = num1 + num2;

            //if (num1 > num2)
            //{
            //    Console.WriteLine("El numero 1 es mayor al numero 2");
            //}
            //else
            //{
            //    Console.WriteLine("El numero 2 es mayor al numero 1");
            //}
            //Console.WriteLine("La suma es: " + resultado);

            //Ingresar 3 numeros y mostrar el promedio de los 3 numeros
            Console.WriteLine("PROMEDIO DE 3 NUMEROS");

            Console.WriteLine("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            int num3 = Int32.Parse(Console.ReadLine());

            int promedio = (num1 + num2 + num3) / 3;

            Console.WriteLine(promedio);
            Console.ReadKey();
        }
    }
}
