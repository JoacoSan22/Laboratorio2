using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Television : Electrodomesticos
    {
        private double _resolucion = 20;
        private Boolean _TDT = false;

        public Television() { }

        public Television(double _precioBase, float _peso)
           : base(_precioBase, _peso)
        { }

        public Television(double _resolucion, Boolean _TDT, double _precioBase, string _color, char _consumoEnergetico, float _peso)
            : base(_precioBase, _color, _consumoEnergetico, _peso)
        {
            this._resolucion = _resolucion;
            this._TDT = _TDT;
        }

        public double Resolucion
        {
            get => _resolucion;
        }

        public Boolean TDT
        {
            get => _TDT;
        }

        public void precioFinal()
        {
            if (_resolucion >= 40)
            {
                _precioBase = _precioBase * 1.3;
            }

            if (_TDT == true)
            {
                _precioBase = _precioBase * 1.5;
            }
        }
    }
}
