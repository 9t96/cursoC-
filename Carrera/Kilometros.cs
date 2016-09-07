using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Kilometros
    {
        private int _cantidad;

        private Kilometros(int qty)
        {
            this._cantidad = qty;
        }

        public static Kilometros operator +(Kilometros auxKm, int km)
        {
            return auxKm._cantidad + km;
        }

        public static Kilometros operator +(Kilometros aux1, Kilometros aux2)
        {
            return aux1 + aux2;
        }

        public static Kilometros operator -(Kilometros aux, int km)
        {
            return aux - km;
        }

        public static Kilometros operator -(Kilometros aux1, Kilometros aux2)
        {
            return aux1 - aux2;
        }


        public static bool operator ==(Kilometros aux, int km)
        {
            return (aux == km);
        }

        public static bool operator ==(Kilometros aux1, Kilometros aux2)
        {
            return (aux1 == aux2);
        }

        public static bool operator !=(Kilometros aux, int km)
        {
            return !(aux == km);
        }

        public static bool operator !=(Kilometros aux1, Kilometros aux2)
        {
            return !(aux1 == aux2) ;
        }



        public static implicit operator Kilometros(int km)
        {
            return new Kilometros(km);
        }

        public static explicit operator int(Kilometros km)
        {
            return km._cantidad;
        }



        public static bool operator <(Kilometros km, int valor)
        {
            return (km < valor);
        }
        public static bool operator <(Kilometros km1, Kilometros km2)
        {
            return (km1 < km2);
        }
        public static bool operator >(Kilometros km, int valor)
        {
            return (km > valor);

        }
        public static bool operator >(Kilometros km1, Kilometros km2)
        {
            return (km1 > km2);
        }
        public void MostrarKilom()
        {
            Console.WriteLine(this._cantidad);
        }
    }
}
