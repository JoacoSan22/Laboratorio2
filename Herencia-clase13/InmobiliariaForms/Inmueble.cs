using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaForms
{
    public abstract class Inmueble
    {
        private String direccion;

        public string Direccion { get => direccion; set => direccion = value; }
    }
}
