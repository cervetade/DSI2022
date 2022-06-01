using System.Net.Mail;
using System.Configuration;
using System.Web;
using System.Net;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
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
                //EnviarMail();
            }
            
        }

        public static void EnviarMail()
        {
            int i;

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("CirculoDeSangre@gmail.com", "Kyocode", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add("tcervellati@facultad.sanfrancisco.utn.edu.ar"); //Correo destino?
            correo.Subject = $"Usted ha sido seleccionado para donar sangre. Fecha limite a presentarse: "; //Asunto {Peticion.Peticiones[i].FechaLimite}
            correo.Body = "Este es un correo de prueba desde c#"; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("xxxxxx@gmail.com", "*******");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);
        }

        public static void nviarMail()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("CirculoDeSangre@gmail.com");
                mail.To.Add("tcervellati@facultad.sanfrancisco.utn.edu.ar");
                mail.Subject = "Hello World";
                mail.Body = "<h1>Hello</h1>";
                mail.IsBodyHtml = true;
                

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("email@gmail.com", "password");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

        public static void fechaDonacion()
        {
            Console.WriteLine("Ultima fecha de donacion: ");

        }



    }
}
