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
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas f = new Ventas();
            f.MdiParent = this;
            f.Text = "Ventas - " + this.MdiChildren.Length.ToString();
            f.Show();


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Clientes f = new Clientes();
            f.MdiParent = this;
            f.Text = "Clientes - " + this.MdiChildren.Length.ToString();
            f.Show();

        }
    }
}
