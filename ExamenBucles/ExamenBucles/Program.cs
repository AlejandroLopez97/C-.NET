using System;

namespace ExamenBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * La serie de Fibonacci se construye de tal manera que cada término de la seria
               es igual a la suma de los dos anteriores. Escriba un programa que imprima en
               pantalla la serie de números de Fibonacci menores de 100. Por ejemplo, si
               empezamos desde el número 1, la serie tendrá la siguiente apariencia:

               1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, …
             
             */

            int num1 = 0, num2 = 1, aux;

            while (num1 < 100)
            {
                aux = num1;
                num1 = num2;
                num2 = aux + num1;
                if (num1 < 99)
                {
                    Console.WriteLine(num1);
                }
                
            }

            /*
             * Se presentan 3 alumnos para ser representantes de grupo Nuñez, Maria y
               Santiago leer voto por voto y mostrar el porcentaje que obtuvo cada uno
               considerando solo los votos válidos. También imprimir el nombre del ganador.
               No se conoce cuantas personas votaran
             
             */
            Console.WriteLine("VOTACIONES PARA REPRESENTANTE DE GRUPO");
            int respuesta = 1, voto, contadorVoto = 0;
            int nunez = 0, santiago = 0, maria = 0;

            while (respuesta == 1)
            {
                Console.WriteLine("NUEVO REGISTRO\nPARA VOTAR DIGITA ASI:\n1.VOTAR POR NUÑEZ\n2.VOTAR POR SANTIAGO\n3.VOTAR POR MARIA");
                voto = Convert.ToInt32(Console.ReadLine());

                if (voto==1 || voto==2 || voto==3)
                {
                    contadorVoto++;
                    switch (voto)
                    {
                        case 1:
                            nunez++;
                            break;
                        case 2:
                            santiago++;
                            break;
                        case 3:
                            maria++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("¡SELECCION NO VALIDA!");
                }
                
                Console.WriteLine("¿Desea realizar un nuevo registro?\n1.Para continuar\n2.Para salir");
                respuesta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nASI QUEDARON LAS VOTACIONES");
            Console.WriteLine("NUÑEZ OBTUVO UN {0}% DE LA TOTALIDAD DE VOTACIONES",((nunez*100)/contadorVoto));
            Console.WriteLine("SANTIAGO OBTUVO UN {0}% DE LA TOTALIDAD DE VOTACIONES", ((santiago * 100) / contadorVoto));
            Console.WriteLine("MARIA OBTUVO UN {0}% DE LA TOTALIDAD DE VOTACIONES", ((maria * 100) / contadorVoto));

            if (nunez>santiago && nunez>maria)
            {
                Console.WriteLine("\n¡NUÑEZ ES EL GANADOR, FELICIDADES!");
            }
            else
            {
                if (santiago > nunez && santiago > maria)
                {
                    Console.WriteLine("\n¡SANTIAGO ES EL GANADOR, FELICIDADES!");
                }
                else
                {
                    Console.WriteLine("\n¡MARIA ES EL GANADOR, FELICIDADES!");
                }
            }

            //Estudio sobre calorias 

            Console.WriteLine("ESTUDIO DE LICORES DE ACUERDO A CALORIAS");
            int licor = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nNUEVO REGISTRO\nSELECCIONE LA BEBIDA DE SU PREFERENCIA:\n1.CERVEZA\n2.VINO TINTO\n3.CHAMPAGNE\n4.VODKA\n5.AGUARDIENTE\n6.COÑAC\n7.WHISKY\n8.GINEBRA\n9.RON\n10.CREMA DE MENTA\n11.LICOR DULCE\n12.LICOR DE CAFÉ\n");
                licor = Convert.ToInt32(Console.ReadLine());
                switch (licor)
                {
                    case 1:
                        Console.WriteLine("LA CERVEZA TIENE 45 CALORIAS Y SU NIVEL ES BAJO");
                        break;
                    case 2:
                        Console.WriteLine("EL VINO TINTO TIENE 65 CALORIAS Y SU NIVEL ES BAJO");
                        break;
                    case 3:
                        Console.WriteLine("LA CHAMPAGNE TIENE 65 CALORIAS Y SU NIVEL ES BAJO");
                        break;
                    case 4:
                        Console.WriteLine("EL VODKA TIENE 121 CALORIAS Y SU NIVEL ES BAJO");
                        break;
                    case 5:
                        Console.WriteLine("EL AGUARDIENTE TIENE 222 CALORIAS Y SU NIVEL ES BAJO");
                        break;
                    case 6:
                        Console.WriteLine("EL COÑAC TIENE 222 CALORIAS Y SU NIVEL ES BAJO");
                        break;
                    case 7:
                        Console.WriteLine("EL WHISKY TIENE 244 CALORIAS Y SU NIVEL ES NORMAL");
                        break;
                    case 8:
                        Console.WriteLine("EL GINEBRA TIENE 244 CALORIAS Y SU NIVEL ES NORMAL");
                        break;
                    case 9:
                        Console.WriteLine("EL RON TIENE 244 CALORIAS Y SU NIVEL ES NORMAL");
                        break;
                    case 10:
                        Console.WriteLine("LA CREMA DE MENTA TIENE 372 CALORIAS Y SU NIVEL ES ALTO");
                        break;
                    case 11:
                        Console.WriteLine("EL LICOR DULCE TIENE 372 CALORIAS Y SU NIVEL ES ALTO");
                        break;
                    case 12:
                        Console.WriteLine("EL LICOR DE CAFÉ TIENE 376 CALORIAS Y SU NIVEL ES ALTO");
                        break;
                }
            }
            Console.ReadKey();
            
        }
    }

}
