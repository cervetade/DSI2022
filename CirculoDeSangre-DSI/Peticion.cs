using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CirculoDeSangre_DSI
{
    public class Peticion
    {
        public static List<Peticion> Peticiones = new List<Peticion>()
        {
           new Peticion() {Fecha = "20/05/2022" , CantDonantes = 1 , FechaLimite = "20/06/2022"}

        };

        public string Fecha { get; set; }
        public int CantDonantes { get; set; }
        public string FechaLimite { get; set; }


        public static void AtenderPeticion()
        {
            int cantidad;
            string fechaLimite, grupoSanguineo, cantidadS;
            char resp;


            Console.Write("- Ingrese el tipo de sangre necesario: ");
            grupoSanguineo = Console.ReadLine();

            Console.Write("- Ingrese la cantidad de donantes: ");
            cantidadS = Console.ReadLine();
            cantidad = CantidadVal(cantidadS);
           



            Console.Write($"- Ingrese una fecha limite no mayor a 30 dias de la fecha actual ({DateTime.Now.ToString("dd-MM-yyyy")}): ");
            fechaLimite = Console.ReadLine();
            

            Console.Write($"\n+ Esta seguro de registrar la nueva peticion N°{Peticiones.Count()} cuya fecha limite es el {fechaLimite} con {cantidad} donantes? (y='si'/n='no'): ");
            resp = char.Parse(Console.ReadLine());
      

            if (resp == 'y')
            {

                Console.WriteLine("\n+ El registro se ha realizado correctamente!");
                Peticiones.Add(new Peticion { Fecha = DateTime.Now.ToString("dd/MM/yyyy"), CantDonantes = cantidad, FechaLimite = fechaLimite });

            }
            else
            {
                Console.WriteLine("+ Se ha cancelado el registro!\n");
                Menu.Volver();
            }

        }

        public static int CantidadVal(string cantidadStr)
        {
            int cantidad;
            while (!Regex.Match(cantidadStr.ToString(), @"^\d{1}$|^\d{2}$").Success)
            {
                Console.Write("+ Ingrese correctamente un numero valido: ");
                cantidadStr = Console.ReadLine();
            }
            cantidad = Int32.Parse(cantidadStr);
            while (cantidad < 0 && cantidad > 10)
            {
                Console.WriteLine("+ Ingrese una cantidad dentro del limite valido: ");
                cantidad = Int32.Parse(Console.ReadLine());
            }

            return cantidad;
        }

        public static void MostrarPeticiones()
        {
            for (int i = 0; i < Peticiones.Count(); i++)
            {
                Console.WriteLine($"\n -> Peticion [N°{i}] || Fecha limite -> {Peticiones[i].FechaLimite} || Solicitados -> {Peticiones[i].CantDonantes} asociado/s.");
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------------");
        }
    }
}
