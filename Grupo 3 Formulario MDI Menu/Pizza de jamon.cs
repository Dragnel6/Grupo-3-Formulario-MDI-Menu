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
    public partial class Pizza_de_jamon : Form
    {
        public Pizza_de_jamon()
        {
            InitializeComponent();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void b_si_no_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("¿Estas seguro de esta compra?", "¿Confirmar compra?", MessageBoxButtons.YesNoCancel);
            if (m == DialogResult.Yes)
            {
                MessageBox.Show("Su compra se ha ordenado con exito!", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (m == DialogResult.No)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (m == DialogResult.Cancel)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
