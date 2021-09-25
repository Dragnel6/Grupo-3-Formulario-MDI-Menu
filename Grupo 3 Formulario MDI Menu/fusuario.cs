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
    public partial class fusuario : Form
    {
        public fusuario()
        {
            InitializeComponent();
        }
        private void fusuario_Load(object sender, EventArgs e)
        {
            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            txtusuario.Enabled = false;
            lstnivel.Enabled = false;
            // TODO: esta linea de codigo carga datos en la tabla 'sistemaDataSet.tusuario'
            //puede moverla o quitarla segun sea necesario
            this.tusuarioTableAdapter.Fill(this.tusuario);
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


    }
}
