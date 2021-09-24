using System;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 18;
            //int b = 10;

            //Console.WriteLine(a += b);
            //Console.WriteLine(a -= b);
            //Console.WriteLine(a *= b);
            //Console.WriteLine(a /= b);


            //hacer un programa que solicite respuesta correctas, incorrectas y en blanco
            //de un examen de alumnos.
            //Calcular el puntaje final teniendo en cuenta las respuestas
            //correctas obtiene 5 puntos, incorrectas -1, en blanco 0

            /*double correctas, incorrectas, blanco;
            Console.WriteLine("Ingrese respuestas correctas: ");
            correctas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese respuestas incorrectas");
            incorrectas = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese respuestas en blanco");
            blanco = Double.Parse(Console.ReadLine());

            Console.WriteLine("*****Puntaje total******");
            Console.WriteLine((correctas *5) + (incorrectas*-1));
            Console.WriteLine((correctas*=5)+(incorrectas*=-1));//otra manera de hacerlo */

            /*Se requiere un programa para las colillas de pago de los empleados de acuerdo a sus horas 
             * laborales y el valor de la hora*/

            /* double valorHora, horasLaboradas;

             Console.WriteLine("Ingrese las horas laboradas:");
             horasLaboradas = Double.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese el valor de la hora:");
             valorHora = Double.Parse(Console.ReadLine());

             Console.WriteLine("*****Pago de nomina******");
             Console.WriteLine(horasLaboradas*=valorHora);*/

            //Ingrese un texto de 5 letras y que muestre el texto de forma horizontal 

            //string texto;
            //Console.WriteLine("Digite una palabra de 5 letras");
            //texto = Console.ReadLine();

            //Console.WriteLine(texto[0]);
            //Console.WriteLine(texto[1]);
            //Console.WriteLine(texto[2]);
            //Console.WriteLine(texto[3]);
            //Console.WriteLine(texto[4]);

            //Ingresar un numero de 2 digitos y mostrarlo en sentido contrario
            string num;
            Console.WriteLine("***** NÚMERO EN SENTIDO CONTRARIO *****");
            Console.WriteLine("Digite un número de 2 dígitos");
            num = Console.ReadLine();

            Console.WriteLine(string.Format("{0}{1}",num[1],num[0]));
            Console.ReadKey();
        }
    }
}
