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
    public partial class login_trabajadores : Form
    {
        public login_trabajadores()
        {
            InitializeComponent();
        }

        private void login_trabajadores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                
                
                    /* //crear la conexion
                     SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog = login; Integrated Security=True;");

                     //abrir conexion
                     conexion.Open();

                     //cadena de consulta
                     SqlCommand consulta = new SqlCommand("select usuario, clave from tusuario where usuario = '" + txtusuario.Text + "'And clave = '" + txtclave.Text + "' ", conexion);

                     //ejecuta una instruccion de sql devolviendo el numero de filas encontradas
                     consulta.ExecuteNonQuery();
                     DataSet ds = new DataSet();
                     SqlDataAdapter da = new SqlDataAdapter(consulta);

                     //Llenando el dataAdapter con los datos de la tabla
                     da.Fill(ds, "tusuario");

                     //fila de la tabla con la que se trabajara
                     DataRow registro;
                     registro = ds.Tables["tusuario"].Rows[0];*/

                    //evaluando que clave y usuario sean correctos
                    if (txtusuario.Text == "empleado")
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
                    }
                
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
