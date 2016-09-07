using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    class Program
    {
        static void Main()
        {           
            Carrera carrrera;
            carrrera = new Carrera();
            carrrera.CorrerCarreraTime(10);
            carrrera.MostrarCarrera();

            carrrera.CorrerCarrera(100);
            carrrera.MostrarCarrera();

            /*Rueda ggg = new Rueda("NIKE",40);

            ggg.MostrarRueda();*/
            /*
            Kilometros tiempito;
            tiempito = 90; //castea implicitamente a Tiempo y crea instancia de clase privada.
            tiempito.MostrarKilom();
            /*
            Efabricante fabricante;

            fabricante = Efabricante.Honda;
            
            Console.WriteLine(fabricante);
            fabricante = (Efabricante) 1; // Casteo 1 que seria el 2 fabricante del enumerado ya que es el tipo de dato.


           Console.WriteLine(fabricante);
            
            Auto nuevoAuto1 = new Auto();
            Auto nuevoAuto2 = new Auto();
            Auto nuevoAuto3 = new Auto();*/
            
            Console.ReadKey();
        }
    }
}
