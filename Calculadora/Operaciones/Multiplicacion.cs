using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
   public class Multiplicacion
    {
        private double M1, M2, MR;

        public double MR2
        {
            get { return MR; }
            set { MR = value; }
        }

        public double MR1
        {
            get { return MR; }
            set { MR = value; }
        }

        public double M21
        {
            get { return M2; }
            set { M2 = value; }
        }

        public double M11
        {
            get { return M1; }
            set { M1 = value; }
        }

        public Multiplicacion() {
            this.M1 = 0;
            this.M2 = 0;
        }
        public double Calcular() {
            MR = M1 * M2;
            return MR;
        }
    }

}
