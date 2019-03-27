using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Suma
    {
        private double v1, v2,Resultado;

        public double V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }

        
        public Suma() {
            this.v1 = 0;
            this.v2 = 0;
        }
        public double Calcular() {
            Resultado = v1 + v2;
            return Resultado;
        }

    }
}
