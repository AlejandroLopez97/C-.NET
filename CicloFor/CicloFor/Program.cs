using System;

namespace CicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3; int num;
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine("Digite un número:");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("La decima parte es: {0} y la sexta parte es: {1}",num/10, num/6);
            //    Console.WriteLine("-------------------------------");
            //}

            //Calcular el sueldo de mis alumnos

            //double sueldo = 0;
            //int cantidad;

            //Console.WriteLine("Digite la cantidad de alumnos:");
            //cantidad = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine("Digite el sueldo del alumno "+ (i+1));
            //    sueldo += Convert.ToDouble(Console.ReadLine());
            //}
            //Console.WriteLine("Para la cantidad de {0} alumnos, existe un promedio de sueldos de: {1}",cantidad,sueldo/cantidad);

            // Hacer una encuesta para 5 personas donde le pregunte si se separo o no 
            //si contesta de forma afirmativa debe imprimir buena decision 
            //si contesta de forma negativa debe imprimir considerelo

            //string respuesta;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("¿Eres separado? Responda unicamente si / no");
            //    respuesta = Console.ReadLine();
            //    if (respuesta.Equals("si"))
            //    {
            //        Console.WriteLine("Usted tomo la mejor decision");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Debes considerarlo");
            //    }
            //    Console.WriteLine("---------------------------------");
            //}

            /*Un equipo de futbol desea evaluar a sus delanteros, para lo que solicita el numero de goles
             marcados en la última temporada; si estos son mayor a 15 goles mostrar un mensaje que diga excelente condicion
            goleadora, si anoto entre 10 y 15 mostrar un mensaje que diga buena condición goleadora
            de lo contrario debe decir, debes trabajar en definición*/

            //int goles, cantidad;
            //Console.WriteLine("CONDICIÓN DELANTERO DE EQUIPO DE FUTBOL");
            //Console.WriteLine("¿Cuantos jugadores son?");
            //cantidad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------------");

            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine("Digite la cantida de goles marcados por el jugador "+(i+1));
            //    goles = int.Parse(Console.ReadLine());

            //    if (goles>15)
            //    {
            //        Console.WriteLine("Excelente condición goleadora");
            //    }
            //    else
            //    {
            //        if (goles>10 && goles<15)
            //        {
            //            Console.WriteLine("Buena condición goleadora");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Malo, debe trabajar en definición");
            //        }
            //    }
            //    Console.WriteLine("--------------------------------------------------------");
            //    Console.WriteLine("");
            //}

            //leer 5 números y vamos a mostrar el mayor 

            int a, super=0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite un número: ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a>super)
                {
                    super = a;
                }
            }

            Console.WriteLine("El mayor es: {0}", super);

            Console.ReadKey();
        }
    }
}
