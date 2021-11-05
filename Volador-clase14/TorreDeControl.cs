using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class TorreDeControl
    {
        List<Ivolador> voladores = new List<Ivolador>();

        public void vuelenTodos()
        {
            foreach(Ivolador v in voladores)
            {
                v.volador();
            }
        }

        public void agregarVolador(Ivolador unVolable)
        {
            voladores.Add(unVolable);
        }
    }
}
