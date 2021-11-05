using System;

namespace Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boing747 boing747 = new Boing747();
            Superman superman = new Superman();
            TorreDeControl torreDeControl = new TorreDeControl();

            torreDeControl.agregarVolador(superman);
            torreDeControl.agregarVolador(boing747);
            torreDeControl.agregarVolador(pato);

            torreDeControl.vuelenTodos();

            Console.ReadKey();

        }
    }
}
