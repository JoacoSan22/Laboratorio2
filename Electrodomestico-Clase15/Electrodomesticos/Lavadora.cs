using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Lavadora : Electrodomesticos
    {
        private double _carga=5;

        public Lavadora() { }
        public Lavadora(double _precioBase, float _peso)
           : base(_precioBase, _peso)
        { }
        
        public Lavadora (double _carga, double _precioBase, string _color, char _consumoEnergetico, float _peso)
            :base(_precioBase, _color, _consumoEnergetico, _peso)
        {
            this._carga = _carga;
        }

        public double Carga
        {
            get => _carga;
        }

        public void precioFinal()
        {            
            if (_carga >= 30)
            {
                _precioBase += 50;
            }            
        }
    }
}
