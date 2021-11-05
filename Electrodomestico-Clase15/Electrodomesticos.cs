using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    abstract class Electrodomesticos
    {
        protected double _precioBase=100.0;
        protected readonly string[] _colores = { "blanco", "Blanco", "negro", "Negro", "azul", "Azul", "gris", "Gris" };
        protected string _color="blanco";
        protected char _consumoEnergetico='F';
        protected float _peso=5.0f;

        public Electrodomesticos() { }

        public Electrodomesticos(double _precioBase, string _color)
        {
            this._precioBase = _precioBase;
            this._color = _color;
        }

        public Electrodomesticos(double _precioBase, float _peso)
        {
            this._precioBase = _precioBase;
            this._peso = _peso;
        }

        public Electrodomesticos(double _precioBase, string _color, char _consumoEnergetico, float _peso)
        {
            this._precioBase = _precioBase;
            ComprobarColor(_color);
            comprobarConsumoEnergetico(_consumoEnergetico);
            this._peso = _peso;
        }

        public double PrecioBase
        {
            get => _precioBase;
            set => _precioBase = value;
        }
        
        public string [] ColoresDisponibles
        {
            get { return this._colores; }
        }
        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public char ConsumoEnergetico
        {
            get => _consumoEnergetico;
            set => _consumoEnergetico = value;
        }

        public float Peso
        {
            get => _peso;
            set => _peso = value;
        }

       private void comprobarConsumoEnergetico(char letra)
        {
            switch (letra.ToString().ToUpper().ToCharArray()[0])
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                    ConsumoEnergetico = letra;
                    break;
                default:
                    ConsumoEnergetico = 'F';
                    break;
            }
        }      

        private void ComprobarColor(string color)
        {          
            color = color.ToLower();
            foreach (string _color in ColoresDisponibles)
            {
               if (_color == color)
               {
                  Color = color;
                  return;
               }
            }
            Color = "blanco";           
        }

        public void precioFinal()
        {
            
            switch (_consumoEnergetico)
            {
                case 'A':
                    _precioBase = 100;
                    break;

                case 'B':
                    _precioBase = 80;
                    break;

                case 'C':
                    _precioBase = 60;
                    break;

                case 'D':
                    _precioBase = 50;
                    break;

                case 'E':
                    _precioBase = 30;
                    break;

                case 'F':
                    _precioBase = 10;
                    break;
            }

            if (_peso <= 19)
            {
                _precioBase += 10;
            } 
            else if (_peso <=20 && _peso >=49)
            {
                _precioBase += 50;
            }
            else if (_peso <= 50 && _peso >= 79)
            {
                _precioBase += 80;
            } 
            else
            {
                _precioBase += 100;
            }           
        }
    }
}
