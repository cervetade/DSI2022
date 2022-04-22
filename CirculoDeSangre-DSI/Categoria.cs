using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre_DSI
{
    public class Categoria
    {
        public static List<Categoria> Cat = new List<Categoria>();

        public string? Tipo { get; set; }

        public void CategoriaCalcular(string enfermedad, string nacimiento, string medicamentosTomados)
        {
            DateTime time = new DateTime(1900, 01, 01);
            string categ = "";


            if (DateTime.TryParse(nacimiento, out time))
            {
                TimeSpan diasEnteros = DateTime.Now.Subtract(time);

                int edad = diasEnteros.Days / 365;

                if (edad >= 18 && edad <= 56 && enfermedad == "n" && medicamentosTomados == "No Consume")
                {
                    categ = "Activo";

                }
                else if (edad >= 18 && edad <= 56 && enfermedad == "y" && medicamentosTomados != "No Consume")
                {
                    categ = "Pasivo";

                }

                else
                {
                    categ = "Pasivo";

                }

                Cat.Add(new Categoria() { Tipo = categ });
                Console.WriteLine("+ Se le ha asignado al socio la categoria de: {0}.\n", categ);
            }

        }
    }
}