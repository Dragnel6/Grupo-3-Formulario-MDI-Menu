
namespace Grupo_3_Formulario_MDI_Menu
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregregarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaConOrillaDeQuesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaHawuainaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaDePeperoniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaDeSalamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaDeJamonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaConVerdurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.proveedoresToolStripMenuItem.Text = "Bebidas";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.comprasToolStripMenuItem.Text = "Complementos";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregregarOrdenToolStripMenuItem});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.inventariosToolStripMenuItem.Text = "Servicio a domicilio";
            this.inventariosToolStripMenuItem.Click += new System.EventHandler(this.inventariosToolStripMenuItem_Click);
            // 
            // agregregarOrdenToolStripMenuItem
            // 
            this.agregregarOrdenToolStripMenuItem.Name = "agregregarOrdenToolStripMenuItem";
            this.agregregarOrdenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregregarOrdenToolStripMenuItem.Text = "Agregregar orden ";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda ";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalAToolStripMenuItem,
            this.pizzaConOrillaDeQuesoToolStripMenuItem,
            this.pizzaHawuainaToolStripMenuItem,
            this.pizzaDePeperoniToolStripMenuItem,
            this.pizzaDeSalamiToolStripMenuItem,
            this.pizzaDeJamonToolStripMenuItem,
            this.pizzaConVerdurasToolStripMenuItem});
            this.formulariosToolStripMenuItem.Image = global::Grupo_3_Formulario_MDI_Menu.Properties.Resources._3986693_architecture_building_culture_pizza_pizzeria_restorant_icon_112267;
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formulariosToolStripMenuItem.Text = "Menu";
            this.formulariosToolStripMenuItem.Click += new System.EventHandler(this.formulariosToolStripMenuItem_Click);
            // 
            // personalAToolStripMenuItem
            // 
            this.personalAToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.personalAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.personalAToolStripMenuItem.Name = "personalAToolStripMenuItem";
            this.personalAToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.personalAToolStripMenuItem.Text = "Solo personal autorizado";
            this.personalAToolStripMenuItem.Click += new System.EventHandler(this.personalAToolStripMenuItem_Click);
            // 
            // pizzaConOrillaDeQuesoToolStripMenuItem
            // 
            this.pizzaConOrillaDeQuesoToolStripMenuItem.Name = "pizzaConOrillaDeQuesoToolStripMenuItem";
            this.pizzaConOrillaDeQuesoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pizzaConOrillaDeQuesoToolStripMenuItem.Text = "Pizza con orilla de queso";
            this.pizzaConOrillaDeQuesoToolStripMenuItem.Click += new System.EventHandler(this.pizzaConOrillaDeQuesoToolStripMenuItem_Click);
            // 
            // pizzaHawuainaToolStripMenuItem
            // 
            this.pizzaHawuainaToolStripMenuItem.Name = "pizzaHawuainaToolStripMenuItem";
            this.pizzaHawuainaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pizzaHawuainaToolStripMenuItem.Text = "Pizza hawaiana";
            this.pizzaHawuainaToolStripMenuItem.Click += new System.EventHandler(this.pizzaHawuainaToolStripMenuItem_Click);
            // 
            // pizzaDePeperoniToolStripMenuItem
            // 
            this.pizzaDePeperoniToolStripMenuItem.Name = "pizzaDePeperoniToolStripMenuItem";
            this.pizzaDePeperoniToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pizzaDePeperoniToolStripMenuItem.Text = "Pizza de peperoni";
            this.pizzaDePeperoniToolStripMenuItem.Click += new System.EventHandler(this.pizzaDePeperoniToolStripMenuItem_Click);
            // 
            // pizzaDeSalamiToolStripMenuItem
            // 
            this.pizzaDeSalamiToolStripMenuItem.Name = "pizzaDeSalamiToolStripMenuItem";
            this.pizzaDeSalamiToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pizzaDeSalamiToolStripMenuItem.Text = "Pizza de salami ";
            this.pizzaDeSalamiToolStripMenuItem.Click += new System.EventHandler(this.pizzaDeSalamiToolStripMenuItem_Click);
            // 
            // pizzaDeJamonToolStripMenuItem
            // 
            this.pizzaDeJamonToolStripMenuItem.Name = "pizzaDeJamonToolStripMenuItem";
            this.pizzaDeJamonToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pizzaDeJamonToolStripMenuItem.Text = "Pizza de Jamon ";
            this.pizzaDeJamonToolStripMenuItem.Click += new System.EventHandler(this.pizzaDeJamonToolStripMenuItem_Click);
            // 
            // pizzaConVerdurasToolStripMenuItem
            // 
            this.pizzaConVerdurasToolStripMenuItem.Name = "pizzaConVerdurasToolStripMenuItem";
            this.pizzaConVerdurasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pizzaConVerdurasToolStripMenuItem.Text = "Pizza con verduras";
            this.pizzaConVerdurasToolStripMenuItem.Click += new System.EventHandler(this.pizzaConVerdurasToolStripMenuItem_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaConOrillaDeQuesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaHawuainaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaDePeperoniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaDeSalamiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaDeJamonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaConVerdurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregregarOrdenToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem personalAToolStripMenuItem;
    }
}