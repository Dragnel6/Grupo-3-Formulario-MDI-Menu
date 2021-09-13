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
       
        SqlConnection connection = new SqlConnection("server=DESKTOP-1V6O9PB ; database= sistema ; INTEGRATED SECURITY = true");
        //private object txtcontraseña;

        private void login_trabajadores_Load(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASEÑA FROM PERSONA WHERE USUARIO = @vuusuario and Contraseña = @vcontraseña", connection);
          
            SqlParameter sqlParameter1 = comando.Parameters.AddWithValue("@vusuario", txtusuario.Text);
            SqlParameter sqlParameter = sqlParameter1;
            comando.Parameters.AddWithValue("@contraseña", txtcontra.Text);


              SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                connection.Close();
                Autorizado a = new Autorizado();
                a.Show();
            }


            //evaluando que clave y usuario sean correctos
           /* if (txtusuario.Text == "empleado")
                    {
                        if (txtcontra.Text == "98765")
                        {
                            Autorizado a = new Autorizado();
                            a.Show();
                            this.Hide();
                        }
                        else
                        {
                    DialogResult b = MessageBox.Show("contraseña incorrecta","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }*/
                
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
