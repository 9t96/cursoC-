using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Tiempo
    {
        private int _cantidad;

        private Tiempo(int qty)
        {
            this._cantidad = qty;
        }
        /// <summary>
        /// Suma un entero al tiempo.
        /// </summary>
        /// <param name="tiempoaux">A ser incrementado</param>
        /// <param name="valor">A sumar</param>
        /// <returns>Tiempo</returns>
        public static Tiempo operator + (Tiempo t1, int valor) // sobrecarga de operador
        {          
            return  t1._cantidad + valor;
        }
        /// <summary>
        /// Suma Tiempo al Tiempo.
        /// </summary>
        /// <param name="aux1">Tiempo 1</param>
        /// <param name="aux2">Tiempo 2</param>
        /// <returns>Tiempo</returns>
        public static Tiempo operator +(Tiempo t1, Tiempo t2)
        {
            return t1._cantidad + t2._cantidad;
        }
        /// <summary>
        /// Resta un entero a un dato del tipo Tiempo
        /// </summary>
        /// <param name="tiempoAux">Dato tiempo</param>
        /// <param name="valor">valor a quitar al tiempo</param>
        /// <returns>Dato tipo tiempo</returns>
        public static Tiempo operator -(Tiempo tiempoAux, int valor)
        {
            return tiempoAux._cantidad - valor;
        }
        /// <summary>
        /// Resta un valor de tipo Tiempo a otro dato Tiempo
        /// </summary>
        /// <param name="aux1">Tiempo uno</param>
        /// <param name="aux2">Tiempo dos</param>
        /// <returns>Dato tipo tiempo</returns>
        public static Tiempo operator -(Tiempo aux1, Tiempo aux2)
        {
            return aux1._cantidad - aux2._cantidad;
        }

        public static bool operator ==(Tiempo tiempoAux, int valor)
        {
            return (tiempoAux._cantidad == valor);
        }

        public static bool operator ==(Tiempo aux1, Tiempo aux2)
        {
            return (aux1._cantidad == aux2._cantidad);

        }

        public static bool operator !=(Tiempo aux, int tiempo)
        {
            return !(aux._cantidad == tiempo);
        }

        public static bool operator !=(Tiempo aux1, Tiempo aux2)
        {
            return !(aux1._cantidad == aux2._cantidad);
        }




        public static implicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);
        }

        public static explicit operator int(Tiempo time)
        {
            return time._cantidad;
        }



        public static bool operator <(Tiempo t1, int time)
        {
            return (t1._cantidad < time);
        }

        public static bool operator <(Tiempo t1, Tiempo t2)
        {
            return (t1._cantidad < t2._cantidad);
        }

        public static bool operator >(Tiempo t1, int time)
        {
            return (t1._cantidad > time);

        }

        public static bool operator >(Tiempo t1, Tiempo t2)
        {
            return (t1._cantidad > t2._cantidad);
        }
        public void MostrarTiempo()
        {
            Console.WriteLine(this._cantidad);
        }

    }
}
