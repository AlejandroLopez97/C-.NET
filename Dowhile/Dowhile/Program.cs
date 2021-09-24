using System;

namespace Dowhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, i;
            string respuesta;

            do
            {
                Console.WriteLine("ingrese el numero");
                numero = int.Parse(Console.ReadLine());
                respuesta = "Es Primo";

                for (i = 2; i <= numero - 1; i++)
                {
                    if (numero % i == 0)
                    {
                        respuesta = "No es primo";
                    }
                }
                Console.WriteLine("{0}", respuesta);
            } while (numero!=0);
        }
    }
}
