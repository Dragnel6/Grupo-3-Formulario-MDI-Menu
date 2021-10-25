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
    public partial class productos : Form
    {
        //Creamos cadena de conexion como variable publica antes de la funcion fusuario()
        public string cadena_conexion = "Database=restaurante; Data Source=localhost; User Id=walter; Password=123";

        public string usuario_modificar;
        public string usuario_eliminar;

        public productos()
        {
            InitializeComponent();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            //Deshabilitar campos, se activan al crear un nuevo registro
            txtProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtPromoc.Enabled = false;
            try
            {
                string consulta = "select * from menu";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "restaurante");
                dtgvMenu.DataSource = ds;
                dtgvMenu.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btNuevo_Click_2(object sender, EventArgs e)
        {
            /*El boton nuevo realmente solo habilita el formulario para agregar un nuevo registro*/

            txtProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecio.Enabled = true;
            txtPromoc.Enabled = true;

            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtPromoc.Text = "";
            txtProducto.Focus();

            btNuevo.Visible = false;
            btGuardar.Visible = true;
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Guardamos el nuevo registro con INSER INTO
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO menu(producto,cantidad,precio,promociones) Values(?producto,?cantidad,?precio,?promociones)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?producto", MySqlDbType.VarChar, 75).Value = txtProducto.Text;
                myCommand.Parameters.Add("?cantidad", MySqlDbType.VarChar, 50).Value = txtCantidad.Text;
                myCommand.Parameters.Add("?precio", MySqlDbType.Double, 6).Value = txtPrecio.Text;
                myCommand.Parameters.Add("?promociones", MySqlDbType.Double, 6).Value = txtPromoc.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Pedido agregado con éxito", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from menu";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "restaurante");
                dtgvMenu.DataSource = ds;
                dtgvMenu.DataMember = "restaurante";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el pedido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btNuevo.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtPromoc.Enabled = false;

            btNuevo.Focus();

            /*dtgvMenu.Enabled = true;
            dtgvClientes.Enabled = false;*/
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            //El boton modificar solo habilita el formulario para actualizar el registro actual
            txtProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecio.Enabled = true;
            txtPromoc.Enabled = true;

            txtProducto.Focus();

            btModificar.Visible = false;
            btActualizar.Visible = true;

            usuario_modificar = txtProducto.Text.ToString();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            //Aplica los cambios realizados al registro actual
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string nom = txtProducto.Text.ToString();
                string cant = txtCantidad.Text.ToString();
                string pre = txtPrecio.Text.ToString();
                string pro = txtPromoc.Text.ToString(); 

                //string myInsertQuery = "UPDATE contactos SET nombre = ?nombre, clave = ? clave, nivel = ? nivel Where nombre = " + usuario_modificar + "";

                string myInsertQuery = "UPDATE menu SET producto = '" + nom + "',cantidad = '" + cant + "',precio = '" + pre + "',promociones = '" + pro + "' WHERE producto = '" + usuario_modificar + "'";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                //myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 50).Value = txtclave.Text;
                //myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 15).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("pedido modificado con éxito", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from menu";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "restaurante");
                dtgvMenu.DataSource = ds;
                dtgvMenu.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el pedido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btModificar.Visible = true;
            btActualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtPromoc.Enabled = false;
            btModificar.Focus();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "select * from menu Where idproducto = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtProducto.Text = (myReader.GetString(1));
                    txtCantidad.Text = (myReader.GetString(2));
                    txtPrecio.Text = (myReader.GetString(3));
                    txtPromoc.Text = (myReader.GetString(4));
                }
                else
                {
                    MessageBox.Show("El pedido no existe", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtPromoc.Enabled = false;

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
                string myInsertQuery = "delete from menu Where idproducto = " + txtBuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("pedido eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Clear();
                string consulta = "select * from menu";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "restaurante");
                dtgvMenu.DataSource = ds;
                dtgvMenu.DataMember = "restaurante";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar el pedido! Primero realice búsqueda del pedido y después puede eliminar", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btNuevo.Visible = true;
            btGuardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtProducto.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtPromoc.Enabled = false;
            //btNuevo.Focus();

            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtPromoc.Text = "";

            txtBuscar.Focus();

            //txtNombre.Focus();
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAutorizado_Click_1(object sender, EventArgs e)
        {
            empleados l = new empleados();
            l.Show();
            this.Close();
        }

        private void lblTabla_Click(object sender, EventArgs e)
        {

        }


        
    }
}
