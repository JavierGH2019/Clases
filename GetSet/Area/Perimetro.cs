using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
   public class Perimetro
    {
        public double Lado;
        double Resultado;

        public void SetLado(double l) {
            this.Lado = l;
        }

        public double GetLado() {
            return Lado;
        }

        public void CalculoPerimetro(double l) {
             Resultado = 4 * l;
             
        }
        public double imprimirP() {
            return Resultado;
        }
    }
}
