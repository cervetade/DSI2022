using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre_DSI
{
    internal class Menu
    {
        public static void MenuIteracion()
        {
            string valor;
            int ingreso;

            Console.Clear();
            Console.WriteLine("\t- Circulo de Sangre -");
            Console.WriteLine("--------------------------");
            Console.WriteLine("- 1. Lista de los socios.");
            Console.WriteLine("- 2. Registro de socios."); 
            Console.WriteLine("- 0. Salir.");
            Console.WriteLine("--------------------------");

            Console.Write("+ Ingrese su respuesta: ");
            ingreso = int.Parse(Console.ReadLine());

            Opciones(ingreso);
        }

        public static void Opciones(int resp)
        {
            Console.Clear();
            switch (resp)
            {
                case 1:
                    Console.WriteLine("\t - Lista de los socios -"); 
                    Socio.MostrarSocios();
                    Volver();
                    break;
                case 2:
                    Console.WriteLine("\t - Carga de socios -");
                    Socio.CargaDatos();
                    Volver();
                    break;
                case 0:
                    Console.Write("Ha salido del menu.");
                    break;
                default:
                    break;
            }
        }

        public static void Volver()
        {
            char respuesta;

            Console.Write("+ Desea regresar al menu? ('y' = si /'n' = no): ");
            respuesta = char.Parse(Console.ReadLine());

            if (respuesta== 'y') { MenuIteracion(); }
            Console.Clear();
            Console.Write("+ Usted ha salido del menu.");
        }

    }
}
