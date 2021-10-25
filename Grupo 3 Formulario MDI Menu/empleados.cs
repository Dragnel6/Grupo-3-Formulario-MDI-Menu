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
    public partial class empleados : Form
    {
        //Creamos cadena de conexion como variable publica antes de la funcion fusuario()
        public string cadena_conexion = "Database=restaurante; Data Source=localhost; User Id=walter; Password=123";

        public string usuario_modificar;
        public string usuario_eliminar;

        public empleados()
        {
            InitializeComponent();
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            //Deshabilitar campos, se activan al crear un nuevo registro
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtDui.Enabled = false;
            txtTipo_em.Enabled = false;
            txtCorreo.Enabled = false;
            txtDomicilio.Enabled = false;

            dtgvUsuarios.Visible = false;
            tEmpleados.Visible = false;


            try
            {
                string consulta = "select * from empleados";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "restaurante");
                dtgvEmpleados.DataSource = ds;
                dtgvEmpleados.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            /*El boton nuevo realmente solo habilita el formulario para agregar un nuevo registro*/

            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            txtDui.Enabled = true;
            txtTipo_em.Enabled = true;
            txtCorreo.Enabled = true;
            txtDomicilio.Enabled = true;

            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDui.Text = "";
            txtTipo_em.Text = "";
            txtCorreo.Text = "";
            txtDomicilio.Text = "";
            txtNombre.Focus();

            btAgregar.Visible = false;
            btGuardar.Visible = true;

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Guardamos el nuevo registro con INSER INTO
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO empleados(nombre,apellidos,telefono,dui,tipo_empleado,correo,domicilio) Values(?nombre,?apellidos,?telefono,?dui,?tipo_empleado,?correo,?domicilio)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 50).Value = txtNombre.Text;
                myCommand.Parameters.Add("?apellidos", MySqlDbType.VarChar, 50).Value = txtApellidos.Text;
                myCommand.Parameters.Add("?telefono", MySqlDbType.Int32, 50).Value = txtTelefono.Text;
                myCommand.Parameters.Add("?dui", MySqlDbType.Int32, 30).Value = txtDui.Text;
                myCommand.Parameters.Add("?tipo_empleado", MySqlDbType.VarChar, 100).Value = txtTipo_em.Text;
                myCommand.Parameters.Add("?correo", MySqlDbType.VarChar, 50).Value = txtCorreo.Text;
                myCommand.Parameters.Add("?domicilio", MySqlDbType.VarChar, 100).Value = txtDomicilio.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Empleado agregado con éxito", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from empleados";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "restaurante");
                dtgvEmpleados.DataSource = ds;
                dtgvEmpleados.DataMember = "restaurante";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el empleado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btAgregar.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtDui.Enabled = false;
            txtTipo_em.Enabled = false;
            txtCorreo.Enabled = false;
            txtDomicilio.Enabled = false;

            btAgregar.Focus();

            /*dtgvMenu.Enabled = true;
            dtgvClientes.Enabled = false;*/

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            //El boton modificar solo habilita el formulario para actualizar el registro actual
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            txtDui.Enabled = true;
            txtTipo_em.Enabled = true;
            txtCorreo.Enabled = true;
            txtDomicilio.Enabled = true;

            txtNombre.Focus();

            btModificar.Visible = false;
            btActualizar.Visible = true;

            usuario_modificar = txtNombre.Text.ToString();

        }
        private void btActualizar_Click(object sender, EventArgs e)
        {
            //Aplica los cambios realizados al registro actual
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string nom = txtNombre.Text.ToString();
                string ape = txtApellidos.Text.ToString();
                string tel = txtTelefono.Text.ToString();
                string du = txtDui.Text.ToString();
                string ti_e = txtTipo_em.Text.ToString();
                string cor = txtCorreo.Text.ToString();
                string dom = txtDomicilio.Text.ToString();

                //string myInsertQuery = "UPDATE contactos SET nombre = ?nombre, clave = ? clave, nivel = ? nivel Where nombre = " + usuario_modificar + "";

                string myInsertQuery = "UPDATE empleados SET nombre = '" + nom + "', apellidos = '" + ape + "',telefono = '" + tel + "',dui = '" + du + "',tipo_empleado = '" + ti_e + "',correo = '" + cor + "',domicilio = '" + dom + "' WHERE nombre = '" + usuario_modificar + "'";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                //myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 50).Value = txtclave.Text;
                //myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 15).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Empleado modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from empleados";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "restaurante");
                dtgvEmpleados.DataSource = ds;
                dtgvEmpleados.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el empleado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btModificar.Visible = true;
            btActualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtDui.Enabled = false;
            txtTipo_em.Enabled = false;
            txtCorreo.Enabled = false;
            txtDomicilio.Enabled = false;
            btModificar.Focus();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "select * from empleados Where idempleado = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtNombre.Text = (myReader.GetString(1));
                    txtApellidos.Text = (myReader.GetString(2));
                    txtTelefono.Text = (myReader.GetString(3));
                    txtDui.Text = (myReader.GetString(4));
                    txtTipo_em.Text = (myReader.GetString(5));
                    txtCorreo.Text = (myReader.GetString(6));
                    txtDomicilio.Text = (myReader.GetString(7));
                }
                else
                {
                    MessageBox.Show("El empleado no existe", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btAgregar.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtDui.Enabled = false;
            txtTipo_em.Enabled = false;
            txtCorreo.Enabled = false;
            txtDomicilio.Enabled = false;

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
                string myInsertQuery = "delete from empleados Where idempleado = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("empleado eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Clear();

                string consulta = "select * from empleados";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "restaurante");
                dtgvEmpleados.DataSource = ds;
                dtgvEmpleados.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar el empleado! Primero realice búsqueda del usuario y después puede eliminar", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btAgregar.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtDui.Enabled = false;
            txtTipo_em.Enabled = false;
            txtCorreo.Enabled = false;
            txtDomicilio.Enabled = false;
            //btNuevo.Focus();

            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDui.Text = "";
            txtTipo_em.Text = "";
            txtCorreo.Text = "";
            txtDomicilio.Text = "";

            txtBuscar.Focus();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tUsuarios_Click(object sender, EventArgs e)
        {
            dtgvEmpleados.Visible = false;
            dtgvUsuarios.Visible = true;
            tEmpleados.Visible = true;
            tUsuarios.Visible = false;
            lblTabla.Text = "Tabla usuarios";
            try
            {
                string consulta = "select * from usuarios";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "restaurante");
                dtgvUsuarios.DataSource = ds;
                dtgvUsuarios.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tEmpleados_Click(object sender, EventArgs e)
        {
            dtgvEmpleados.Visible = true;
            dtgvUsuarios.Visible = false;
            tEmpleados.Visible = false;
            tUsuarios.Visible = true;
            lblTabla.Text = "Tabla empleados";
            try
            {
                string consulta = "select * from empleados";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "restaurante");
                dtgvEmpleados.DataSource = ds;
                dtgvEmpleados.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
