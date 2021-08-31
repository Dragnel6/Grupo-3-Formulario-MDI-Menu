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

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores f = new Proveedores();
            f.MdiParent = this;
            f.Text = "Proveedores - " + this.MdiChildren.Length.ToString();
            f.Show();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Compras f = new Compras();
            f.MdiParent = this;
            f.Text = "compras - " + this.MdiChildren.Length.ToString();
            f.Show();

        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventarios f = new inventarios();
            f.MdiParent = this;
            f.Text = "inventarios";
            f.Show();

        }
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda f = new Ayuda();
            f.MdiParent = this;
            f.Text = "Ayuda";
            f.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.MdiParent = this;
            f.Text = "acerca de..."; 
            f.Show();
        }

        
    }
}
