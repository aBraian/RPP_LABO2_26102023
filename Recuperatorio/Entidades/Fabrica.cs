using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.Vehiculos.Count <= fabrica.capacidad)
            {
                fabrica.Vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in fabrica.Vehiculos)
            {
                if (vehiculo == v)
                {
                    fabrica.Vehiculos.Remove(v);
                    break;
                }
            }
            return fabrica;
        }
    }
}
