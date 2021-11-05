using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14__Imprimible
{
    class Impresora
    {
        List<Iimprimible> ColaDeImpresion = new List<Iimprimible>();

        public Impresora() { }
        
 
        public void ImprimirTodo()
        {
            foreach (Iimprimible i in ColaDeImpresion)
            {
                i.Imprimir();
            }
        }

        public void AgregarImprimible(Iimprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
