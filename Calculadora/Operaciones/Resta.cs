using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
   public class Resta
    {
        private double R1, R2, RR;

        public double RR1
        {
            get { return RR; }
            set { RR = value; }
        }

        

        public double R21
        {
            get { return R2; }
            set { R2 = value; }
        }

        public double R11
        {
            get { return R1; }
            set { R1 = value; }
        }
        public Resta() {
            this.RR1 = 0;
            this.R2 = 0;
        }
        public double Calcular() {
            RR = R1 - R2;
            return RR;
        }
    }
}
