using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PobreTITO
{
    public partial class RegistrarIncidente : Form
    {
        public RegistrarIncidente(String Cuil)
        {
            InitializeComponent();
            textBoxCUIL.Text = Cuil;

            MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;pwd=3564;database='pobretito'");
            conexion.Open();

            DataTable dataTabl = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM pobretito.incidente;", conexion);
            adaptador.Fill(dataTabl);
            dataGridView.DataSource = dataTabl;

        }

        private void textBoxCUIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarIncidente_Click(object sender, EventArgs e)
        {
            var incidente = new Incidente();

            incidente.RegistrarIncidente(listBoxProblems.Text, textBoxDireccion.Text, textBoxCUIL.Text);

        }

        private void listBoxProblems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
