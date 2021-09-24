using System;

namespace PruebaTecnica
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba tecnica");

            //punto 1
            double[] vec = new double[5];
            double prom;
            Random aleatorio = new Random();
            for (int i = 0; i < 5; i++)
            {
                vec[i] = aleatorio.Next(0, 10) + 1;
            }

            prom = Promedio(vec);
            Console.WriteLine("En el punto 1 el promedio de los numeros es {0}",prom);

            //punto 2
            double valorTotal;
            Console.WriteLine("Digita un valor total: ");
            valorTotal = Convert.ToDouble(Console.ReadLine());
            EtiquetarValor(valorTotal);

            //punto 3
            NumeroBinario(7);
            
            
        }

        //punto 1
        public static double Promedio(double[] numero)
        {
            double acum = 0, prom = 0, n;
            n = numero.Length;

            for (int i=0; i<n; i++)
            {
                acum = acum + numero[i];
            }
            prom = acum / n;

            return prom;
        }

        //punto 2
        public static void EtiquetarValor(double total)
        {
            double iva = total * 0.16;
            Console.WriteLine("El valor del IVA de {0} es {1}",total,iva);

            if (total<100000)
            {
                Console.WriteLine("BARATO");
            }
            else
            {
                if (total>100000 && total<150000)
                {
                    Console.WriteLine("COMUN");
                }
                else
                {
                    Console.WriteLine("CARO");
                }
            }
        }

        //punto 3

        //    char[] binarioT = binario.ToCharArray();
        //    string reves = String.Empty;

        //    for (int i = binarioT.Length - 1; i >= 0; i--)
        //    {
        //        reves += binarioT[i];
        //    }

        //    return reves;
        //}

        public static void NumeroBinario(int num)
        {
            int binario = 0, dig = 0;

            for (int i = num%2, x = 0; num > 0; num /= 2, i =num%2, x++)
            {
                dig = i % 2;
                binario += dig * (int)Math.Pow(10, x);
            }

            Console.WriteLine("El numero binario es {0}",binario);
        }
    }
}
