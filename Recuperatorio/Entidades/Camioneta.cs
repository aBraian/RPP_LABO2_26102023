using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }

        public override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }

        protected override string GetInfo()
        {
            string tipoCabina = this.cabinaSimple ? "Simple" : "Doble";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.GetInfo()}, con cabina: {tipoCabina}");
            return sb.ToString();
        }
    }
}
