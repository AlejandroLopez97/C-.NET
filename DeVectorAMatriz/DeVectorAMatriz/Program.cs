using System;

namespace DeVectorAMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[16];
            int[,] matriz = new int[4, 4];
            int cont = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = i + 1;
            }

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]+" ");
            }
            Console.WriteLine("\n");

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matriz[f, c] = vector[cont++];
                }
            }

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(matriz[f,c]+"\t");
                }
                Console.WriteLine("\n");
            }


            /*Ejercicio numero dos de llenar 2 vectores de 8 posiciones, uno de numero y otro de letras; 
             * ubicarlos en una matriz*/

            int[] vec = new int[8];
            string[] vec2 = new string[8];
            int num = 0, contador = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = contador++;
            }
            for (int j = 0; j < vec2.Length; j++)
            {
                char letra = (char)(((int)'A')+num);
                Console.WriteLine($"{letra}{vec[j]}");
                num++;
            }

            Console.ReadKey();
        }
    }
}
