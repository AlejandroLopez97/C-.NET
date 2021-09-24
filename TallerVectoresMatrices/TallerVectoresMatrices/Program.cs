using System;

namespace TallerVectoresMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Diseñe un algoritmo que lea una vector de N elementos e imprima los números
            primos.*/

            int[] vec;
            int n, divisible, num;

            Console.Write("Digite el numero de elementos:  ");
            n = Convert.ToInt32(Console.ReadLine());
            Random aleatorio = new Random();

            vec = new int[n];

            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = aleatorio.Next(1, 50);
            }

            for (int j = 0; j < vec.Length; j++)
            {
                divisible = 0;
                num = vec[j];
                for (int y = 1; y <= num; y++)
                {
                    if (num % y == 0)
                    {
                        divisible++;
                    }
                }
                if (divisible == 2)
                {
                    Console.Write(" " + num);
                }
            }

            Console.WriteLine("");
            /*Se tiene una matriz de 7 columnas y 4 filas, cada columna representa un día
            de la semana y cada fila una semana del mes, cada celda representa las ventas de
            un día. Se desea conocer el promedio de ventas de un mes, en caso de que este sea
            mayor a 10000 se desea mostrar las ventas de la primera semana, en caso de que
            sea menor se desea mostrar las ventas de la última semana.*/

            int[,] ventas = new int[4, 7];
            int acum = 0, promedio, cont = 28;
            Random Valeatorio = new Random();

            /*Lleno la matriz con datos aleatorios y la sumo*/
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    ventas[f, c] = Valeatorio.Next(1000, 30000);
                    acum += ventas[f, c];
                }
            }

            /*muestro la matriz*/
            Console.WriteLine();
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write(" " + ventas[f, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            promedio = acum / cont;
            Console.WriteLine("El promedio es:  {0}", promedio);
            Console.WriteLine();
            if (promedio > 10000)
            {
                for (int f = 0; f < 1; f++)
                {
                    for (int c = 0; c < 7; c++)
                    {
                        Console.Write(" " + ventas[0, c]);
                    }
                }

            }
            else
            {
                for (int f = 0; f < 4; f++)
                {
                    for (int c = 0; c < 7; c++)
                    {
                        Console.Write(" " + ventas[3, c]);
                    }
                }

            }

            Console.WriteLine("\n");
            /*Diseñe un algoritmo que le pida 10 números a un usuario y los entregue en
            orden inverso a como el usuario los escribió.*/

            int[] numeros = new int[10];
            int aux = 10 - 1;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite el número que desea ingresar: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int j = 0; j < numeros.Length; j++)
            {
                Console.Write(numeros[aux] + " ");
                aux--;
            }

            Console.WriteLine("\n");
            /*Desarrolle un algoritmo que calcule el valor del factorial de los elementos de
            una vector de N elementos.*/

            int[] vecFactorial; int entrada, factorial = 1;

            Console.Write("Digite un numero: ");
            entrada = Convert.ToInt32(Console.ReadLine());

            vecFactorial = new int[entrada];

            for (int i = 1; i < vecFactorial.Length; i++)
            {
                vecFactorial[i] = i + 1;
            }

            for (int j = 1; j < vecFactorial.Length; j++)
            {
                factorial = factorial * vecFactorial[j];
            }
            Console.Write("\nEl Factorial es: " + factorial);

            /*Dada una vector de estudiantes, desarrolle un algoritmo que busque el
            nombre de “Estefanía” en el vector, al encontrarla indicará también la posición en
            la que se encuentra, de no encontrarla, deberá indicar que no se encuentra en la
            vector.*/

            string[] BuscarNombre; int estudiantes, posicion = 0;
            string nombre; bool encontrado = false;
            Console.Write("Digite la cantidad de estudiantes: ");
            estudiantes = Convert.ToInt32(Console.ReadLine());
            BuscarNombre = new string[estudiantes];

            for (int i = 0; i < BuscarNombre.Length; i++)
            {
                Console.Write("Digite el nombre a ingresar: ");
                BuscarNombre[i] = nombre = Console.ReadLine();
            }
            for (int j = 0; j < BuscarNombre.Length; j++)
            {
                if (BuscarNombre[j].Equals("Estefania"))
                {
                    encontrado = true;
                    posicion = j;
                }

            }

            if (encontrado == true)
            {
                Console.WriteLine("Estefania se encuentra en la posicion: {0}", posicion);
            }
            else
            {
                Console.WriteLine("Estefania no se encuentra almacenado");
            }


            /*Se entrega una tabla con el nombre de N estudiantes en su primera
            Columna, la nota del primer examen en la segunda, la nota del segundo
            examen en la tercera y la nota del tercer examen en la cuarta, desarrolle un


            algoritmo que imprima el nombre de cada estudiante, junto con el promedio
            de calificación y si este es mayor o igual a 3 indicar que ha ganado la materia,
            en caso contrario indicar que la ha perdido*/

            // no fui capaz 



            Console.WriteLine("\n");
            /*Dado un vector de números de longitud N, desarrolle un algoritmo que los
            organice de mayor a menor.
            Por ejemplo, si se entrega Vector = [5, 21,45, 1, 2]
            debe entregar Vector = [45, 21, 5, 2, 1]*/

            int[] ordenar; int cant, ayuda;
            Random suerte = new Random();
            Console.Write("Digite un numero: ");
            cant = Convert.ToInt32(Console.ReadLine());
            ordenar = new int[cant];

            for (int i = 0; i < ordenar.Length; i++)
            {
                ordenar[i] = suerte.Next(1, 20);
            }

            for (int m = 0; m < ordenar.Length; m++)
            {
                Console.Write(ordenar[m] + " ");
            }

            Console.WriteLine("\n");
            for (int j = 1; j < ordenar.Length; j++)
            {
                for (int b = 0; b < ordenar.Length - 1; b++)
                {
                    if (ordenar[b] < ordenar[b + 1])
                    {
                        ayuda = ordenar[b];
                        ordenar[b] = ordenar[b + 1];
                        ordenar[b + 1] = ayuda;
                    }
                }

            }

            for (int n = 0; n < ordenar.Length; n++)
            {
                Console.Write(ordenar[n] + " ");
            }

            Console.WriteLine("\n");
            /*Desarrolle un algoritmo que recorra una matriz e imprima los valores
            presentes en su diagonal principal, posterior mente imprima los valores de la
            diagonal secundaria.*/

            int[,] diagonal; int diag;
            Random azar = new Random();
            Console.Write("Digite un numero: ");
            diag = Convert.ToInt32(Console.ReadLine());

            diagonal = new int[diag, diag];

            for (int f = 0; f < diag; f++)
            {
                for (int c = 0; c < diag; c++)
                {
                    diagonal[f, c] = azar.Next(1, 10);
                }
            }

            for (int f = 0; f < diag; f++)
            {
                for (int c = 0; c < diag; c++)
                {

                    Console.Write(diagonal[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int f = 0; f < diag; f++)
            {
                for (int c = 0; c < diag; c++)
                {
                    if (f == c)
                    {
                        Console.Write(diagonal[f, c] + "\t");
                    }
                }
            }

            Console.WriteLine("\n");
            for (int x = 0; x < diag; x++)
            {
                for (int y = 0; y < diag; y++)
                {
                    if (y + x == diag - 1)
                    {
                        Console.Write(diagonal[x, y] + "\t");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
