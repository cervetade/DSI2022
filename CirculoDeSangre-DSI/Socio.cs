using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CirculoDeSangre_DSI
{
    public class Socio : Categoria
    {
        public static List<Socio> listaSocio = new List<Socio>()
        {
            new Socio() {Nombre = "Tadeo", Apellido = "Cerve", Dni = "43299295" , FechaNacimiento = "20-05-2001", Domicilio = "Lavalle", Localidad = "San Fco" , Telefono = "3564411491", Mail = "tcerve@gmail.com", EnfermedadCronica = "n", MedicamentosTomados = "Ibu 1000" , GrupoSanguineo = "A-"  },
            new Socio() {Nombre = "Mariano", Apellido = "Perez", Dni = "43299285" , FechaNacimiento = "20-03-2001", Domicilio = "Lavalle", Localidad = "San Fco" , Telefono = "3564411491", Mail = "tcerve@gmail.com", EnfermedadCronica = "n", MedicamentosTomados = "No Consume" , GrupoSanguineo = "B-"  }

        };


        //DECLARACION DE VARIABLES
        private string nombre;
        private string apellido;
        private string grupoSanguineo;
        private string dni;
        private string fechaNacimiento;
        private string domicilio;
        private string telefono;
        private string localidad;
        private string mail;
        private string enfermedadCronica;
        private string medicamentosTomados;
        private string medicacionPermitida;

        //ENCAPSULAMIENTO DE VARIABLES
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Mail { get => mail; set => mail = value; }
        public string EnfermedadCronica { get => enfermedadCronica; set => enfermedadCronica = value; }
        public string MedicamentosTomados { get => medicamentosTomados; set => medicamentosTomados = value; }
        public string MedicacionPermitida { get => medicacionPermitida; set => medicacionPermitida = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string GrupoSanguineo { get => grupoSanguineo; set => grupoSanguineo = value; }

        public static void CargaDatos()
        {
            string dni, telefono,nombre, apellido, fechaNac, domicilio, localidad, mail, grupoSanguineo, medicacionTomada, enfermedadCronica, medicacionPerm="";
            string rta;

            int i = 1;

            //INGRESO DE DATOS PERSONALES
            do
            {
                i++;

              
                Console.Write("- Ingrese su nombre: ");
                nombre = Console.ReadLine();
                //Nombre = Validador.NombreValidar(Nombre);

                Console.Write("- Ingrese su apellido: ");
                apellido = Console.ReadLine();
                //Apellido = Validador.ApellidoValidar(Apellido);

                Console.Write("- Ingrese grupo sanguineo (A, B, AB, O): ");
                grupoSanguineo = Console.ReadLine();
                //GrupoSanguineo = Validador.GrupoSanguineoValidar(GrupoSanguineo);

                Console.Write("- Ingrese su numero de documento: ");
                dni = Console.ReadLine();
                //DNI = Validador.DniValidar(DNI);

                Console.Write("- Ingrese su fecha de nacimiento (dd-mm-aaaa): ");
                fechaNac = Console.ReadLine();
                //FechaNacimiento = Validador.FechaValidar(FechaNacimiento);

                Console.Write("- Ingrese domicilio (calle y numero): ");
                domicilio = Console.ReadLine();
                //Domicilio = Validador.DomicilioValidar(Domicilio);

                Console.Write("- Ingrese localidad: ");
                localidad = Console.ReadLine();
                //Localidad = Validador.LocalidadValidar(Localidad);

                Console.Write("- Ingrese su numero de telefono (caracteristica sin cero y numero sin 15): ");
                telefono = (Console.ReadLine());
                //Telefono = Validador.TelefonoValidar(Telefono);

                Console.Write("- Ingrese su mail (prueba@example.com): ");
                mail = Console.ReadLine();
                //Mail = Validador.MailValidar(Mail);

                do
                {
                    Console.Write("¿Padece de alguna enfermedad crónica?\n('y' = si /'n' = no): ");
                    enfermedadCronica = Console.ReadLine();
                    if (enfermedadCronica != "y" && enfermedadCronica != "n")
                    {
                        Console.WriteLine("ERROR: intente nuevamente\n");
                    }
                } while (enfermedadCronica != "y" && enfermedadCronica != "n");

                do
                {
                    Console.Write("¿Toma alguna medicación de forma permanente?\n('y' = si /'n' = no): ");
                    medicacionTomada = Console.ReadLine();
                    if (medicacionTomada != "y" && medicacionTomada != "n")
                    {
                        Console.WriteLine("ERROR: intente nuevamente\n");
                    }
                } while (medicacionTomada != "y" && medicacionTomada != "n");

                if (medicacionTomada == "y")
                {
                    Console.Write("Indicar la medicación que toma: ");
                    medicacionTomada = Console.ReadLine();
                }
                else
                {
                    medicacionTomada = "No Consume";
                }

                TerminosyCondiciones();
                Console.Write("\n+ El socio ingresado, acepta los terminos del circulo? ('y' = si /'n' = no): ");
                rta = Console.ReadLine();
                //rta = Validador.ValidacionYesNo(rtaCopy);

                if(rta == "y")
                {
                    listaSocio.Add(new Socio()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Dni = dni,
                        FechaNacimiento = fechaNac,
                        Domicilio = domicilio,
                        Localidad = localidad,
                        Telefono = telefono,
                        Mail = mail,
                        EnfermedadCronica = enfermedadCronica,
                        MedicamentosTomados = medicacionTomada,
                        MedicacionPermitida = medicacionPerm,
                        GrupoSanguineo = grupoSanguineo
                    });
                    Console.WriteLine("\n");
                    Console.WriteLine("\n+ El socio ha sido dado de alta!");
                    Console.Write("+ Desea ingresar un nuevo socio al sistema? ('y' = si /'n' = no): ");
                    rta = Console.ReadLine();
                    if(rta == "y")
                    {
                        Console.Clear();
                        rta = "y";
                    }
                    else 
                    {
                        Console.Clear();
                        rta = "n";

                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("\n+ El socio no ha sido dado de alta :(");
                    Console.Write("+ Desea ingresar un nuevo socio al sistema? ('y' = si /'n' = no): ");
                    rta=Console.ReadLine();
                    i -= 1;
                }


            } while (rta == "y");
        }

        public static void TerminosyCondiciones()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("El circulo de sangre RH Negativo reúne a todas las personas que posean el factor RH " +
                                        "Negativo, sea cual fuera su grupo sanguíneo, logrando de esta manera un sistema de autoprotección " +
                                        "mediante el cual los asociados, podrán donarse sangre entre si para el momento en que así lo " +
                                        "necesiten. \nExisten dos categorías de socios, activos y pasivos, los activos son quienes están " +
                                        "en condiciones de donar sangre y se determina por la edad (entre 18 y 56 años); los pasivos son " +
                                        "los menores a 18 años y mayores a 56 años. Además, se considera pasivos a quienes posean una enfermedad " +
                                        "crónica y deban tomar medicamentos de forma permanente. \nPara poder pertencer al Circulo las personas " +
                                        "se deben asociar y pagar una cuota de manera mensual.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");




        }

        public static void CargarSocio()
        {
            Categoria cat = new Categoria();
            for (int i = 0; i < listaSocio.Count; i++)
            {
                cat.CategoriaCalcular(listaSocio[i].EnfermedadCronica, listaSocio[i].FechaNacimiento, listaSocio[i].MedicamentosTomados);
            }
        }

        public static void MostrarSocios()
        {
            for (int i = 0; i < listaSocio.Count; i++)
            {
                Console.WriteLine("-------------------------------------------------------------");

                Console.WriteLine("- Socio nro: " + i);
                Console.WriteLine("- Nombre:" + listaSocio[i].nombre);
                Console.WriteLine("- Apellido: " + listaSocio[i].apellido);
                Console.WriteLine("- Grupo Sanguineo: " + listaSocio[i].grupoSanguineo);
                Console.WriteLine("- Dni: " + listaSocio[i].dni);
                Console.WriteLine("- Domicilio: " + listaSocio[i].domicilio);
                Console.WriteLine("- Localidad: " + listaSocio[i].localidad);
                Console.WriteLine("- Mail: " + listaSocio[i].mail);
                Console.WriteLine("- Enfermedad Cronica: " + listaSocio[i].enfermedadCronica);
                Console.WriteLine("- Medicamentos tomados: " + listaSocio[i].medicamentosTomados);
                Console.WriteLine("+ Se le ha asignado al socio la categoria de: {0}.\n", Cat[i].Tipo);

         

            }
            Console.WriteLine("-------------------------------------------------------------");
        }




    }
}