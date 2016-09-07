using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        private static Random rnd;

        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
            rnd = new Random();
        }

        public void CorrerCarreraTime(Tiempo time)
        {
            for (int i = 0; i < (int) time; i++)
            {
                this.auto1.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto2.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto3.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto4.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto5.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto6.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
            }
        }

        public void CorrerCarrera(Kilometros kilometros)
        {
            for (int i = 0; i < (int) kilometros; i++)
            {
                this.auto1.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto2.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto3.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto4.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto5.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto6.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
            }
        }

        public void MostrarCarrera()
        {
            this.auto1.MostarAuto();
            this.auto2.MostarAuto();
            this.auto3.MostarAuto();
            this.auto4.MostarAuto();
            this.auto5.MostarAuto();
            this.auto6.MostarAuto();
        }

    }

}
