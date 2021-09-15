using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_3_Formulario_MDI_Menu
{
    public partial class login_trabajadores : Form
    {
        public login_trabajadores()
        {
            InitializeComponent();
        }

        private void login_trabajadores_Load(object sender, EventArgs e)
        {
            
        }

        SqlConnection conect = new SqlConnection("server = LAPTOP-JCD60568; database = Login; Integrated Security = true");

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                conect.Open();
                SqlCommand com = new SqlCommand("select Usuario, Contrasena from Empleado where Usuario = @user AND Contrasena = @pass", conect);
                com.Parameters.AddWithValue("@user", txtusuario.Text);
                com.Parameters.AddWithValue("@pass", txtcontra.Text);

                SqlDataReader lec = com.ExecuteReader();

                if (lec.Read())
                {
                    conect.Close();
                    Autorizado emple = new Autorizado();
                    emple.Show();
                    this.Hide();
                }

            }
            catch 
            {
                conect.Close();
                MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

