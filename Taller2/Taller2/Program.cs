using System;

namespace Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Libreria 
            //double totalCompra, descuento;
            //string cargo;

            //Console.WriteLine("--------FERIA DE LIBRO--------");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("--------Factura de venta------");
            //Console.WriteLine();
            //Console.WriteLine("Para el cargo ingrese");
            //Console.WriteLine("E=Estudiante, P=Profesor, M=Medico \n I=Ingeniero, D=Director");
            //cargo = Console.ReadLine();
            //Console.WriteLine("Valor de la compra: ");
            //totalCompra = Convert.ToInt32(Console.ReadLine());


            //switch(cargo){
            //    case ("E"):
            //        descuento = totalCompra * 0.20;
            //        break;
            //    case ("P"):
            //        descuento = totalCompra * 0.15;
            //        break;
            //    case ("D"):
            //        descuento = totalCompra * 0.10;
            //        break;
            //    default:
            //        descuento = 0;
            //        break;
            //}
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Se realizo un descuento de: {0} y el total a pagar es: {1}",descuento,(totalCompra-descuento));

            ////Banco interes anual
            //double cantidad, interes;

            //Console.WriteLine("Ingrese la cantidad de dinero: ");
            //cantidad = Convert.ToInt32(Console.ReadLine());

            //if (cantidad>10000000)
            //{
            //    interes = cantidad * 0.10;
            //}
            //else
            //{
            //    if (cantidad>=5000000 && cantidad<=10000000)
            //    {
            //        interes = cantidad * 0.08;
            //    }
            //    else
            //    {
            //        if (cantidad >= 2000000 && cantidad <= 5000000)
            //        {
            //            interes = cantidad * 0.05;
            //        }
            //        else
            //        {
            //            interes = 0;
            //        }
            //    }
            //}

            //Console.WriteLine("Su interes anual es de: {0}",interes);

            // Numeros enteros iguales y pares 

            //int num1, num2, num3;
            //Console.WriteLine("Digite el primer número: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite el segundo número: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite el tercer número: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == num2 && num2 == num3)
            //{
            //    Console.WriteLine("-----LOS NUMEROS SON IGUALES-----");                
            //}

            //if (num1 % 2 == 0 || num2 % 2 == 0 || num3 % 2 == 0)
            //{
            //    if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
            //    {
            //        Console.WriteLine("Todos son pares");

            //    }
            //    else
            //    {
            //        if (num1 % 2 == 0)
            //        {
            //            Console.WriteLine("primer numero es par ");
            //        }
            //        if (num2 % 2 == 0)
            //        {
            //            Console.WriteLine("segundo numero es par ");
            //        }
            //        if (num3 % 2 == 0)
            //        {
            //            Console.WriteLine("tercer numero es par ");
            //        }
            //    }
            //}}


            // Control de peso saludable 

            int peso = 72;
            int pesoideal = 70;
            int estatura = 170;

            if(peso == pesoideal)
            {
                Console.WriteLine("Se encuentra en el peso ideal");
            }
            else
            {
                Console.WriteLine("Su estatura es de {0} se encuentra en sobrepeso por {1} kilogramos, debes estar pesando {2} kilogramos", estatura, peso - pesoideal, pesoideal);
            }
                       

            Console.ReadKey();
        }
    }
}
