using System;

namespace EjercicioPractico1
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter1 = 'q';
            Console.WriteLine("q={0}", (int) caracter1);

            char caracter2 = 'Q';
            Console.WriteLine("Q={0}", (int)caracter2);

            char caracter3 = 'ñ';
            Console.WriteLine("ñ={0}", (int)caracter3);

            char caracter4 = 'Ñ';
            Console.WriteLine("Ñ={0} \n q={1}", (int)caracter4, (int)caracter1); // crear cadena de caracteres

            //int x = 0, n = 12, i = 5, r = 0, m = 22;
            //r = m << 8;

            //Console.WriteLine(r);

            //int a = 12, b = 7, c = 3, d, e;
            //float x, y;

            //y = (float)a / b;
            ////Console.WriteLine(y);

            ////y = a / b;
            ////Console.WriteLine(y);

            //e = ++a - b;
            ////Console.WriteLine(e);

            //d = a + b++;
            ////Console.WriteLine(d);

            //x = a / b;
            ////Console.WriteLine(x);
            //c = (a < b) && (a < c);





            Console.ReadKey();
        }
    }
}
