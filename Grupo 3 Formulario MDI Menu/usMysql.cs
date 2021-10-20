using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Grupo_3_Formulario_MDI_Menu
{
    public partial class usMysql : Form
    {    
        //Creamos cadena de conexion como variable publica antes de la funcion fusuario()
        public string cadena_conexion = "Database=agenda; Data Source=localhost; User Id=dba; Password=dba";
       
        public string usuario_modificar;
        public string usuario_eliminar;

        public usMysql()
        {
            InitializeComponent();
        }


        private void usMysql_Load(object sender, EventArgs e)
        {
            //Deshabilitar campos, se activan al crear un nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            try
            {        
                string consulta = "select * from contactos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Navegacion de registros primero, anterior, siguiente y ultimo
        private void btPrimero_Click(object sender, EventArgs e)
        {

        }

        private void btAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btUltimo_Click(object sender, EventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            /*El boton nuevo realmente solo habilita el formulario
            para agregar un nuevo registro*/

            txtusuario.Enabled = true;
            txtclave.Enabled = true; 
            lstnivel.Enabled = true;

            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            btNuevo.Visible = false;
            btGuardar.Visible = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Guardamos el nuevo registro con INSER INTO
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO contactos(nombre,clave,nivel) Values(?nombre,?clave,?nivel)"; 
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text; 
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 50).Value = txtclave.Text; 
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 15).Value = lstnivel.Text;
               
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close(); 

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                
                string consulta = "select * from contactos";
                
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion); 
                System.Data.DataSet ds = new System.Data.DataSet(); 
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds; 
                dataGridView1.DataMember = "agenda";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btNuevo.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            btNuevo.Focus();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            //El boton modificar solo habilita el formulario para actualizar el registro actual
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtusuario.Focus(); 
            btModificar.Visible = false; 
            btActualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            //Aplica los cambios realizados al registro actual
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;

                //string myInsertQuery = "UPDATE contactos SET nombre = ?nombre, clave = ? clave, nivel = ? nivel Where nombre = " + usuario_modificar + "";

                string myInsertQuery = "UPDATE contactos SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                //myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 50).Value = txtclave.Text;
                //myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 15).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                string consulta = "select * from contactos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btModificar.Visible = true;
            btActualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            btModificar.Focus();
        }
   

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "select * from contactos Where codigo = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
               
                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                
                if (myReader.Read())
                {
                    txtusuario.Text = (myReader.GetString(1));
                    txtclave.Text = (myReader.GetString(2));
                    lstnivel.Text = (myReader.GetString(3));
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btNuevo.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            btModificar.Focus();

            /*Finalizada la busqueda y llenado de campos
              guardamos el contenido de txtusuario.Text por si se quiere eliminar por medio del usuario
              usuario_eliminar = txtusuario.Text;*/
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "delete from contactos Where codigo = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from contactos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar el usuario! Primero realice búsqueda del usuario y después puede eliminar", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btNuevo.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtBuscar.Focus();     
    }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
