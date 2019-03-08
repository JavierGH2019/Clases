using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Class1
    {
        double b;
        double h;

        public void Setb(double b) {
            this.b = b;
        
        }
        public double Getb() {
            return b;
        }

        public void Seth(double h)
        {
            this.h= h;

        }
        public double Geth()
        {
            return h;
        }
       

        public void imprimir()
        {
            Console.WriteLine("su Base digitada es: "+Getb());
            Console.WriteLine("su Altura digitada es: "+Geth());
            Console.WriteLine("El area del rectangulo es: "+(Getb()*Geth()));
        }


    }
}
