using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_3_Formulario_MDI_Menu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "pizzeria")
            {
                if (txtpass.Text == "12345")
                {
                    Formulario abrir = new Formulario();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                }

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
