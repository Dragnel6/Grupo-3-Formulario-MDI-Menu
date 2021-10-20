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
    public partial class fusuario : Form
    {
       //Crear la variable.......para  la conexión
        public OleDbConnection miconexion;
        //Crear la variable.......para saber cuál actualizar
        public string usuario_modificar;

       // OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sistema.accdb");

        public fusuario()
        {
            //Crear cadena de conexion a la base
            miconexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema\sistema.accdb");
            InitializeComponent();
        }

        private void fusuario_Load(object sender, EventArgs e)
        {
            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            // TODO: esta linea de codigo carga datos en la tabla 'sistemaDataSet.tusuario'
            //puede moverla o quitarla segun sea necesario
            this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
        }
        private void btPrimero_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveFirst();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MovePrevious();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveNext();
        }

        private void btUltimo_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveLast();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            //El boton nuevo realmente solo habilita el formulario
            //para agregar un nuevo registro
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text  = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            btNuevo.Visible = false;
            btGuardar.Visible = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand Guardar = new OleDbCommand();
                miconexion.Open();
                Guardar.Connection = miconexion;
                Guardar.CommandType = CommandType.Text;

                Guardar.CommandText = "INSERT INTO tusuario ([nombre], [clave], [nivel]) Values('" + txtusuario.Text.ToString() + "','" + txtclave.Text.ToString() + " ',' " + lstnivel.Text.ToString() + "')";

                Guardar.ExecuteNonQuery();
                miconexion.Close();

                btNuevo.Visible = true;
                btGuardar.Visible = false;

                //Desabilitar campos, se activan al crear nuevo registro
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                btNuevo.Focus();

                //Mensaje que se guardo correctamente
                MessageBox.Show("Usuario agregado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
                this.tusuarioBindingSource.MoveLast();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);  
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            //El boton nuevo solo habilita el formulario
            //para actualizar el registro actual
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
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;

                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;

                //Podemos actualizar todos los campos de una vez
                actualizar.CommandText = "UPDATE tusuario SET nombre = '" + nom + "',clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                actualizar.ExecuteNonQuery();
                miconexion.Close();

                btModificar.Visible = true;
                btActualizar.Visible = false;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;

                //Mensaje que se guardo correctamente
                MessageBox.Show("Usuario actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
              catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;

                eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" + txtusuario.Text.ToString() + "'";

                eliminar.ExecuteNonQuery();
                this.tusuarioBindingSource.MoveNext();
                miconexion.Close();

                //Mensaje que se guardo correctamente
                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tusuarioBindingSource.MovePrevious();

            }
              catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
