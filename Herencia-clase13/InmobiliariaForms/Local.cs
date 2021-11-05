using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaForms
{
    class Local : Inmueble
    {

        public double local(double preFinal, int anios, int metrosCuadrad, int numVentanas)
        {
            
            
            if (anios < 15)
            {
                preFinal -= (preFinal * 0.01);
            }
            else
            {
                preFinal -= (preFinal * 0.02);
            }
            if (metrosCuadrad > 50)
            {
                preFinal += (preFinal * 0.01);
            }
            if (numVentanas <= 1)
            {
                preFinal -= (preFinal * 0.02);
            }
            else if (numVentanas > 4)
            {
                preFinal += (preFinal * 0.02);
            }
            return preFinal;
        }







    }
}
