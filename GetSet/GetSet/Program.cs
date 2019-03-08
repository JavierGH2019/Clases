using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimiento variable base y altura usando get y set
            Console.WriteLine("Digite la base del rectangulo");
            double Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la  altura del rectangulo");
            double Altura = double.Parse(Console.ReadLine());

            Class1 obj = new Class1();
            obj.Setb(Base);
            obj.Seth(Altura);
            obj.imprimir();

            //Calculando el perimetro de un cuadrado
            Console.WriteLine("Digite el lado de el cuadrado ::");
            double L = double.Parse(Console.ReadLine());
            Perimetro obj2 = new Perimetro();
            obj2.SetLado(L);
            obj2.CalculoPerimetro(obj2.Lado);
            Console.WriteLine("Su perimetro calculado es: "+ obj2.imprimirP());

            Console.ReadKey();


            
        }
    }
}
