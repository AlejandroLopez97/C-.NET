using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probar nuestro carro");

            Carro micarro = new Carro();
            micarro.arrancarVehiculo("Runrunrunrunrunrun");
            micarro.pararVehiculo("shesheshessehhhhsss");
            micarro.acelerar();
            micarro.frenar();

            Console.WriteLine("Probar la moto");

            Moto mimoto = new Moto();
            mimoto.arrancarVehiculo("Runrunrunrunrunrun");
            mimoto.pararVehiculo("shesheshessehhhhsss");
            mimoto.pique();
            mimoto.endo();

            Console.ReadKey();
        }
    }
}
