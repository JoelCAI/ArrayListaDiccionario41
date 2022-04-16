using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario41
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Presione cualquier tecla para continuar: ");
            Console.ReadKey();

            DateTime[] arregloFecha = new DateTime[cantidad];

            Validador.RegistrarFecha(ref arregloFecha);

            Validador.MostrarListadoFecha(arregloFecha);

            Array.Sort(arregloFecha);

            Console.WriteLine("\n Aplicamos el orden Ascendente y obtenemos: ");
            Validador.MostrarListadoFecha(arregloFecha);

            Validador.Despedida();

        }

        public const int cantidad = 3;

        public void Iniciar()
        {
            MenuPrincipal();
        }

    }
}
