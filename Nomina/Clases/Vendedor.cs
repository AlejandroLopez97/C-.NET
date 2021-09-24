using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vendedor:Persona
    {
        private string tipodecontrato;
        private double sueldo;

        public string Tipodecontrato { get => tipodecontrato; set => tipodecontrato = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public void calcularsueldo(double basesueldo)
        {
            if (this.Tipodecontrato == "Nuevo")
            {
                this.Sueldo = basesueldo + 106000;
            }
            else if(this.Tipodecontrato=="Antiguo")
            {
                this.Sueldo = basesueldo + 212000;
            }
            else
            {
                this.Sueldo = 0;
            }
        }
    }
}
