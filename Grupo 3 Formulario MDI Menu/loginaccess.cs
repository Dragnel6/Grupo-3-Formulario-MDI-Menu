using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Grupo_3_Formulario_MDI_Menu
{
    public partial class loginaccess : Form
    {
        public loginaccess()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Basededatos.accdb");
            conexion.Open();
            string consulta = "select password, cuenta_usuario from usuarios where password='" + txtPassword.Text + "'and cuenta_usuario = '" + txtUsuario.Text + "';";

            OleDbCommand comando = new OleDbCommand(consulta, conexion);

            OleDbDataReader lectorDatos;

            lectorDatos = comando.ExecuteReader();

            Boolean ExistenciaRegistros = lectorDatos.HasRows;


            if (ExistenciaRegistros)
            { MessageBox.Show(" Bienvenido al sistema"+ txtUsuario.Text, "Usuario autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Formulario FrmPrincipal = new Formulario();
                FrmPrincipal.Show();
                this.Hide();
            }
            else
            {
               MessageBox.Show("Acceso denegado" + txtUsuario.Text, "Usuario NO autorizado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            conexion.Close();

        }

        private void loginaccess_Load(object sender, EventArgs e)
        {

        }
    }
}
