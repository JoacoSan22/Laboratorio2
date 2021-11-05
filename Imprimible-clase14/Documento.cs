using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14__Imprimible
{
    class Documento : Iimprimible 
    {
        public void Imprimir()
         {
            Console.WriteLine("Soy un documento de word.");
         }
    }
}
