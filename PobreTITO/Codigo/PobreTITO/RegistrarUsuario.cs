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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            var SQL = new Usuario();
            SQL.RegistrarUsuario(textBoxCUIL.Text, textBoxPassword.Text, textBoxTelefono.Text);
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
