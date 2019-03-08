using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
 

namespace Ejercicios07032019
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Seleccione ejercicio a evaluar");
            Console.WriteLine("Presione 1 para ejercicio semaforo-----");
            Console.WriteLine("Presione 2 para ejercicio buenas noches-----");
            int opcion=int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Semaforo OSemaforo = new Semaforo();
                Console.WriteLine("Digite su nombre: ");
                string Nombre = Console.ReadLine();
                OSemaforo.EstadoSemaforo(Nombre);
                Console.ReadKey();
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Digite su Nombre: ");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Digite su Apellido: ");
                string Apellido = Console.ReadLine();
                Console.WriteLine("Digite su Direccion: ");
                string Direccion = Console.ReadLine();

                Saludo OSaludo = new Saludo();
                OSaludo.Nombre1 = Nombre;
                OSaludo.Apellido1 = Apellido;
                OSaludo.Direccion1 = Direccion;

                Console.WriteLine("Buenas noches: " + OSaludo.Nombre1 + "  " + OSaludo.Apellido1 + " Tu vives en " + OSaludo.Direccion1);
                Console.ReadKey();
            }
            else {
                Console.WriteLine("Solo puede elegir ejercicio 1 o 2");
                Console.ReadKey();
            }
        }
    }
}
