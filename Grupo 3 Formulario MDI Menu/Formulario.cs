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
           /* Ventas f = new Ventas();
            f.MdiParent = this;
            f.Text = "Ventas - " + this.MdiChildren.Length.ToString();
            f.Show();*/


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Clientes f = new Clientes();
            f.MdiParent = this;
            f.Text = "Clientes - " + this.MdiChildren.Length.ToString();
            f.Show();*/

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bebidas f = new bebidas();
            f.MdiParent = this;
            f.Show();

            /*  Proveedores f = new Proveedores();
            f.MdiParent = this;
            f.Text = "Proveedores - " + this.MdiChildren.Length.ToString();
            f.Show();*/

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complementos f = new Complementos();
            f.MdiParent = this;
            f.Show();

            /*  Compras f = new Compras();
            f.MdiParent = this;
            f.Text = "compras - " + this.MdiChildren.Length.ToString();
            f.Show();*/

        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*inventarios f = new inventarios();
            f.MdiParent = this;
            f.Text = "inventarios";
            f.Show();*/

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

        private void pizzaConVerdurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pizza_verdura f = new pizza_verdura();
            f.MdiParent = this;
            f.Show();

        }

        private void pizzaDeJamonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza_de_jamon f = new Pizza_de_jamon();
            f.MdiParent = this;
            f.Show();

        }

        private void pizzaDeSalamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza_de_salami f = new Pizza_de_salami();
            f.MdiParent = this;
            f.Show();
        }

        private void pizzaDePeperoniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza_de_peperoni f = new Pizza_de_peperoni();
            f.MdiParent = this;
            f.Show();
        }

        private void pizzaHawuainaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza_Hawaiana f = new Pizza_Hawaiana();
            f.MdiParent = this;
            f.Show();
        }

        private void pizzaConOrillaDeQuesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza_con_orilla_de_queso f = new Pizza_con_orilla_de_queso();
            f.MdiParent = this;
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginConSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_trabajadores t = new login_trabajadores();
            t.Show();
        }
        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fusuario u = new fusuario();
            u.Show();
        }


        private void mYSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usMysql s = new usMysql();
            s.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos m = new productos();
            m.Show();
        } 

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
