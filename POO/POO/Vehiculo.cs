using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Vehiculo
    {
        public void arrancarVehiculo(string sonidoarranque)
        {
            Console.WriteLine($"Arrancar el vehiculo: {sonidoarranque}");
        }

        public void pararVehiculo(string sonidodepare)
        {
            Console.WriteLine($"Parar el vehiculo: {sonidodepare}");
        }
    }
}
