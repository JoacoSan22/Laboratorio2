using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repite = true;
            int opcion; 
            float cantidad = 0, porcentajeAplicado = 0; 
            double precio = 0, precioFinal = 0, por=0 ;

            do
            {
                Console.Clear();
                Console.WriteLine("\nSHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nMENU PRINCIPAL: ");
                Console.WriteLine("\n1. Ingrese (1) para añadir camisa al carro de compras");
                Console.WriteLine("\n2. Ingrese (2) para eliminar camisa del carro de compras");
                Console.WriteLine("\n3. Ingrese (3) para salir");
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine($"\n              -  La Cantidad de camisas en el carro de compras es de: {cantidad}");
                Console.WriteLine("\n              -   El Precio Unitario es de: $1000");
                Console.WriteLine("\n              -   El Precio total sin descuento es de: $" + precio);
                Console.WriteLine("\n              -   El Tipo de descuento aplicado es del: %" + porcentajeAplicado);
                Console.WriteLine("\n              -   El Precio final con descuento es de: $" + precioFinal);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("Ingrese una opcion del menu:");
                opcion=int.Parse(Console.ReadLine()); // convierto lo leido en int
                Console.Clear(); 

                switch (opcion)
                {
                    case 1:
                        cantidad += 1;
                        break;
                    case 2:
                        cantidad -= 1;
                        break;
                    case 3:
                        Console.Clear();    //limpio consola 
                        Console.WriteLine("\nEsta seguro de salir? 'S'  / 'N' ");
                        string salida =Console.ReadLine();
                         if (salida == "S")
                         {
                             repite = false; //finaliza el programa
                         }
                        Console.Clear();
                        break;
                }

                if (cantidad >= 3 && cantidad <=5)    //if de descuento para 3 y 5 camisas
                {
                    porcentajeAplicado = 10;
                    por=0.1;
                }

                if (cantidad > 5)    //if de descuento para mas de 6 camisas
                {
                    porcentajeAplicado = 20;
                    por=0.2;
                }

                precio = cantidad * 1000; 
                precioFinal = precio - (precio * por);     // se resta el porcentaje de descuento al precio sin descuento
                Console.Clear();
            } while (repite);















        }
    }
}
