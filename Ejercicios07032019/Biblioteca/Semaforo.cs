using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Biblioteca
{
   public class Semaforo
    {
        public void EstadoSemaforo(string Nombre) {
 
            //Aleatroiamente se establece un color mediante la variable r
            Random r = new Random();
           int a= r.Next(1, 4);
            
            if(a==1){
                Console.WriteLine("Estado del semaforo: Verde");
                Console.WriteLine("Seguir: "+Nombre);            
            }
            else if (a == 2)
            {
                Console.WriteLine("Estado del semaforo: Rojo");
                Console.WriteLine("Detenerse: " + Nombre);
            }
            else {
                Console.WriteLine("Estado del semaforo: Amarillo");
                Console.WriteLine("Precaucion: " + Nombre);
            }
        }
    }
}
