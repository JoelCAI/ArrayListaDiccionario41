using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario41
{
    public class Validador
    {
        public static DateTime ValidarFechaIngresada(string mensaje)
        {
            bool ingresoCorrecto;
            DateTime fechaValida;

            do
            {
                
                Console.Clear();
                Console.WriteLine("\n Recuerde que no puede repetir una fecha");
                Console.WriteLine("\n Ingrese un formato válido.");
                Console.WriteLine("\n El formato correcto es *dd/mm/aaaa*.");
                Console.WriteLine("\n También puede ser *dd/mm/aaaa hh:mm:ss*.");
                Console.WriteLine(mensaje);
                string ingresoNacimiento = Console.ReadLine();

                ingresoCorrecto = DateTime.TryParse(ingresoNacimiento, out fechaValida);

                if (!ingresoCorrecto)
                {
                    continue;
                }


            } while (!ingresoCorrecto);

            
            return fechaValida;
        }
        

        public static void RegistrarFecha(ref DateTime[] arregloFecha)
        {
            for (int i = 0; i < arregloFecha.Length; i++)
            {
                DateTime fecha;

                /*Este Do while verifica que el dato número "x" no se vuelva a ingresar dos veces
                  porque la funcion BuscarNumero verifica que ya hay una posicion para "x"  */
                do
                {
                    
                    fecha = ValidarFechaIngresada("\n Ingrese el número " + (i + 1).ToString() + ": ");
                    
                    Console.Clear();
                    if (!(BuscarFecha(arregloFecha, fecha) == -1))
                    {
                        Console.Clear();
                        Console.WriteLine("El elemento *" + fecha + "* ya existe. Utilice otra forma de nombrarlo");
                    }

                } while (BuscarFecha(arregloFecha, fecha) != -1);
                arregloFecha[i] = fecha;

            }

        }
        public static int BuscarFecha(DateTime[] arregloFecha, DateTime fecha)
        {
            int posicion = -1;
            for (int i = 0; i < arregloFecha.Length; i++)
            {
                /*Si el nombre ingresado por el usuario coincide con alguno del arreglo se retorna la posicion valida*/
                if (arregloFecha[i] == fecha)
                {
                    posicion = i;
                }


            }
            return posicion;
        }

        public static void MostrarListadoFecha(DateTime[] arregloNumero)
        {
            /*Console.Clear();*/
            Console.WriteLine("\n Listado de elementos en el Arreglo");
            for (int i = 0; i < arregloNumero.Length; i++)
            {
                Console.WriteLine(" " + arregloNumero[i].ToLongDateString());
            }
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }
    }
}
