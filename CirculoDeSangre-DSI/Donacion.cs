using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre_DSI
{
    internal class Donacion : Peticion
    {
        public static List<Donacion> Donaciones = new List<Donacion>();


        //Mostraremos la lista de donantes que se encuentren activos para donar 

        public static void ListaDePrioridad()
        {
            Socio.CargarSocio();
            Console.WriteLine("\n");
            Console.WriteLine(" DNI\t\tAsociado \tDonaciones-\n");
            for (int i = 0; i < Socio.listaSocio.Count; i++)
            {
                if (Categoria.Cat[i].Tipo == "Activo")
                {
                    Console.WriteLine($"{Socio.listaSocio[i].Dni}   ||\t{Socio.listaSocio[i].Nombre} {Socio.listaSocio[i].Apellido}\t");
                }
                Console.WriteLine("-------------------------------\n");

            }
            
        }





    }
}
