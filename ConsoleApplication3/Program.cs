using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    class Program
    {
        static void Main()
        {
            List<Auto> listaCar = new List<Auto>(); //Lista generic. [Ligada al tipo de dato].
            ArrayList lista = new ArrayList(); //Lista no-generic. 
            //Stack juan = new Stack();
            //Queue pepe = new Queue();

            //Hashtable coco = new Hashtable();

            lista.Add(new Auto());
            lista.Add(new Auto());
          
            /*Carrera miCarrera;
            miCarrera = new Carrera();
            for (int i = 0; i < 10; i++)
            {
                miCarrera = miCarrera + new Auto();
            }
            miCarrera.CorrerCarreraTime(10);
            miCarrera.MostrarCarrera();
            Console.WriteLine("----------------CARRERA POR KILOMETROS--------------------");
            miCarrera.volverACero();
            miCarrera.CorrerCarrera(100);
            miCarrera.MostrarCarrera();*/

            #region coments
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
            #endregion
            Console.ReadKey();
        }
    }
}
