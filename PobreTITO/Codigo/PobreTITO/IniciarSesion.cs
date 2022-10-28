using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PobreTITO
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            var SQL = new Usuario();

            SQL.IniciarSesion(textBoxCUIL.Text, textBoxPassword.Text);

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.Show();
        }
    }
}
