using System;

namespace VectorPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random ran = new Random();
            Console.WriteLine("Digite el tamaño del vector");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vec = new int[n];
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = ran.Next(1,50);
            }

            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i]%2==0)
                {
                    Console.WriteLine(vec[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
