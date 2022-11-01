using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PobreTITO
{
    internal class Incidente
    {

        public void RegistrarIncidente(string Problema, string Direcion, string Cuil)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;pwd=3564;database='pobretito'");
            conexion.Open();

            var id = Environment.TickCount;

            string scc = "insert into pobretito.incidente values(" + id + "," + Cuil + ",'" + Problema + "','" + Direcion + "');";
            MessageBox.Show(scc);

            MySqlCommand comando = new MySqlCommand(scc, conexion);
            try
            {
                int filas = comando.ExecuteNonQuery();
                MessageBox.Show("Incidente registrado");

            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
            conexion.Close();
        }
    }
}
