using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Rueda
    {
        public string marca;
        public string modelo;
        public float tamaño;
       
        ///No se puede hacer sobrecarga del mismo tipo de dato, pero
        ///si son dos variables distintas cambiando el orden de estos se hace posible.

        /// <summary>
        /// Por defecto inicializa marca en "sin marca" y el tamaño en 0.
        /// </summary>
        public Rueda()
        {
            this.marca = "Sin marca";
        }
        /// <summary>
        /// Inicializa la marca que es pasada como parametro.
        /// </summary>
        /// <param name="marca">Marca de la rueda.</param>
        public Rueda(string marca)
        {
            this.marca = marca;
        }
        /// <summary>
        /// Inicializa el tamaño de la rueda.
        /// </summary>
        /// <param name="tamaño">Tamaño de la rueda.</param>
        public Rueda(int tamaño): this()
        {           
            this.tamaño = tamaño;
        }
        /// <summary>
        /// Incializa tamaño y marca de la rueda pasados por parametro.
        /// </summary>
        /// <param name="marca">Marca de la rueda.</param>
        /// <param name="tamaño">Tamaño de la rueda.</param>
        public Rueda(string marca, int tamaño):this(tamaño)
        {
            this.marca = marca;
        }

        public Rueda(int tamaño, string marca)
        {
            this.marca = marca;
            this.tamaño = tamaño;
        }

        public void MostrarRueda()
        { 
            Console.WriteLine("Tamaño: {0} Marca: {1}" , this.tamaño, this.marca);
        }
    }
}
