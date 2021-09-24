using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] altura = new float[3];
            double promedio = 0;
            double acumulador = 0;
            double altas = 0, bajas = 0;

            for (int i = 0; i < altura.Length; i++)
            {
                Console.WriteLine("Digite la altura ");
                altura[i] = float.Parse(Console.ReadLine());
                acumulador += altura[i];
                
            }
            promedio = acumulador / 3;

            for (int j = 0; j < altura.Length; j++)
            {
                if (altura[j] > promedio)
                {
                    altas += 1;
                }
                else
                {
                    bajas += 1;
                }
            }

            Console.WriteLine("El promedio de la estatura es {0}, existen {1} por encima del promedio y {2} por debajo del promedio",promedio,altas,bajas);
            Console.ReadKey();
        }
    }
}
