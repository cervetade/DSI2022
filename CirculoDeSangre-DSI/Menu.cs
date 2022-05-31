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
            
            int ingreso;

            Console.Clear();
            Console.WriteLine("\t- Circulo de Sangre -");
            Console.WriteLine("--------------------------");
            Console.WriteLine("- 1. Lista de los socios.");
            Console.WriteLine("- 2. Registro de socios.");
            Console.WriteLine("- 3. Peticion de Banco De Sangre.");
            Console.WriteLine("- 0. Salir.");
            Console.WriteLine("--------------------------");

            Console.Write("+ Ingrese su respuesta: ");
            ingreso = int.Parse(Console.ReadLine());

            Opciones(ingreso);
        }

        public static void Opciones(int resp)
        {
            int rta,rtaCase1;

            Console.Clear();
            switch (resp)
            {
                case 1:
                    Console.WriteLine("\t -1 Mostrar la lista de los socios -");
                    Console.WriteLine("\t -2 Eliminar a algun socio -");
                    Console.WriteLine("\t -3 Volver al menu -");
                    Console.WriteLine("--------------------------");
                    Console.Write("+ Ingrese su respuesta: ");

                    rtaCase1 = int.Parse(Console.ReadLine());

                    switch (rtaCase1)
                    {
                        case 1:
                            Socio.CargarSocio();
                            Socio.MostrarSocios();
                            
                            Volver();
                            break;
                        case 2:
                            Socio.EliminarSocio();
                            Volver();
                            break;
                        case 3:
                            Volver();
                            break;

                    }

                 
                    
                    break;
                case 2:
                    Console.WriteLine("\t - Carga de socios -");
                    Socio.CargaDatos();
                    Volver();
                    break;
                case 3:
                    Console.WriteLine("\n Peticiones del Banco De Sangre");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("- 1. Mostrar las peticiones.");
                    Console.WriteLine("- 2. Registrar nueva peticion.");
                    Console.WriteLine("- 3. Mostrar lista de prioridad de donantes..");
                    Console.WriteLine("- 0. Salir.");
                    Console.WriteLine("--------------------------");
                    
                    Console.Write("+ Ingrese su respuesta: ");
                    rta = int.Parse(Console.ReadLine());

                    switch (rta)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\t - Lista de Peticiones -");
                            Peticion.MostrarPeticiones();
                            Volver();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("\t - Registro de Peticiones -");
                            Peticion.AtenderPeticion();
                            Volver();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("\t - Listas de Prioridad -");
                            Donacion.ListaDePrioridad();
                            Volver();
                            break;

                        case 0:
                            Console.Clear();
                            Console.Write("Usted ha salido! Hasta pronto :)");
                            break;

                        default:
                            break;
                    }


                    break;
                case 0:
                    Console.Write("Ha salido del menu! Hasta pronto :)");
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
