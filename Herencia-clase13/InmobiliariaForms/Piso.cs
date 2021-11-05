using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaForms
{
    public class Piso : Inmueble
    {
        public double ingresarPiso(double preFinal, int numPiso, int anios)
        {
            if (anios < 15)
            {
                preFinal -= (preFinal * 0.01);
            }
            else
            {
                preFinal -= (preFinal * 0.02);
            }
            if (numPiso >= 3)
            {
                preFinal += (preFinal * 0.03);
            }
            return preFinal;
        }

        

        
    }
}
