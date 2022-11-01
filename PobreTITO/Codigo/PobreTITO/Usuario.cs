using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PobreTITO
{
    public class Usuario
    {

        public string UsuarioCUIL;

        public string CUIL { get => UsuarioCUIL; set => UsuarioCUIL = value; }
        
      

        public void RegistrarUsuario(string CUIL, string Contraseña, String Telefono)
        {
            MySqlConnection connectionDB = new MySqlConnection("server=localhost;user=root;pwd=3564;database='pobretito'");
            connectionDB.Open();

            string scc = "insert into usuario values(" + CUIL + ",'" + Contraseña + "'," + Telefono + ")";
            MySqlCommand command = new MySqlCommand(scc, connectionDB);

            try
            {
                int filas = command.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado !");

                RegistrarIncidente registrarusuario = new RegistrarIncidente(CUIL);
                registrarusuario.Show();

            }
            catch
            {
                MessageBox.Show("EL usuario ya existe");
            }
            connectionDB.Close();

        }

        public void IniciarSesion (String CUIL, string Contraseña)
        {
            MySqlConnection connectionDB = new MySqlConnection("server=localhost;user=root;pwd=3564;database='pobretito'");
            connectionDB.Open ();  

            string scc = ("Select *from usuario where CUIL = " + CUIL + " and Contraseña = '" + Contraseña + "'");
            MySqlCommand command = new MySqlCommand (scc, connectionDB);

            try
            {
                int filas = command.ExecuteNonQuery ();

                RegistrarIncidente registrarusuario = new RegistrarIncidente(CUIL);
                registrarusuario.Show();
            }

            catch
            {
                MessageBox.Show("Contraseña ingresada es incorrecta");

            }
            connectionDB.Close ();
        
        
        }

    }
}
