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
    public partial class Complementos : Form
    {
        public Complementos()
        {
            InitializeComponent();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("¿Estas seguro de agregar esto?", "¿Confirmar compra?", MessageBoxButtons.YesNoCancel);
            if (m == DialogResult.Yes)
            {
                MessageBox.Show("Compra realizada!", "Pan con ajo, ordenado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void b_agregar2_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("¿Estas seguro de agregar esto?", "¿Confirmar compra?", MessageBoxButtons.YesNoCancel);
            if (m == DialogResult.Yes)
            {
                MessageBox.Show("Compra realizada!", "Nuditos de ajo, ordenada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
