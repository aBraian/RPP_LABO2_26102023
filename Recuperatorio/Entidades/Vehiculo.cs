namespace Entidades
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        protected Vehiculo(EPropulsion propulsion)
        {
            this.numeroDeChasis = new Guid();
            this.esAWD = false;
            this.propulsion = propulsion;
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) : this(propulsion)
        {
            this.esAWD = esAWD;
        }

        public EPropulsion Propulsion
        {
            get
            {
                return this.propulsion;
            }
        }

        public abstract string Tipo
        {
            get;
        }

        protected virtual string GetInfo()
        {
            string mensaje = string.Format("{0} con propulsion a {1}, {2:YesNo} es AWD, numero de chasis {3}", this.Tipo, this.Propulsion, this.esAWD, this.numeroDeChasis);
            return mensaje;
        }

        public override string ToString()
        {
            return this.GetInfo();
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.GetType == vehiculo2.GetType && vehiculo1.numeroDeChasis == vehiculo2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
    }
}