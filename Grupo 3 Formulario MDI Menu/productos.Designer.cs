
namespace Grupo_3_Formulario_MDI_Menu
{
    partial class productos
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.dtgvMenu = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Prec = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.btAutorizado = new System.Windows.Forms.Button();
            this.txtPromoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.AutoSize = true;
            this.btBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btBuscar.FlatAppearance.BorderSize = 3;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btBuscar.Location = new System.Drawing.Point(1009, 1);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(109, 62);
            this.btBuscar.TabIndex = 96;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dtgvMenu
            // 
            this.dtgvMenu.BackgroundColor = System.Drawing.Color.Crimson;
            this.dtgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgvMenu.Location = new System.Drawing.Point(565, 68);
            this.dtgvMenu.Name = "dtgvMenu";
            this.dtgvMenu.RowHeadersWidth = 51;
            this.dtgvMenu.RowTemplate.Height = 24;
            this.dtgvMenu.Size = new System.Drawing.Size(553, 381);
            this.dtgvMenu.TabIndex = 95;
            // 
            // usuario
            // 
            this.usuario.Image = global::Grupo_3_Formulario_MDI_Menu.Properties.Resources.Usuarios;
            this.usuario.Location = new System.Drawing.Point(27, 49);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(239, 209);
            this.usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usuario.TabIndex = 94;
            this.usuario.TabStop = false;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Imprint MT Shadow", 23F);
            this.menu.Location = new System.Drawing.Point(369, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(117, 46);
            this.menu.TabIndex = 93;
            this.menu.Text = "Menu";
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.cant.Location = new System.Drawing.Point(273, 122);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(128, 34);
            this.cant.TabIndex = 81;
            this.cant.Text = "Cantidad";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.Nom.Location = new System.Drawing.Point(280, 82);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(131, 34);
            this.Nom.TabIndex = 80;
            this.Nom.Text = "Producto";
            // 
            // Prec
            // 
            this.Prec.AutoSize = true;
            this.Prec.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.Prec.Location = new System.Drawing.Point(298, 167);
            this.Prec.Name = "Prec";
            this.Prec.Size = new System.Drawing.Size(95, 34);
            this.Prec.TabIndex = 112;
            this.Prec.Text = "Precio";
            // 
            // btActualizar
            // 
            this.btActualizar.AutoSize = true;
            this.btActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btActualizar.FlatAppearance.BorderSize = 3;
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btActualizar.Location = new System.Drawing.Point(125, 390);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(141, 62);
            this.btActualizar.TabIndex = 118;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.AutoSize = true;
            this.btGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btGuardar.FlatAppearance.BorderSize = 3;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btGuardar.Location = new System.Drawing.Point(6, 390);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(110, 62);
            this.btGuardar.TabIndex = 117;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.AutoSize = true;
            this.btNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btNuevo.FlatAppearance.BorderSize = 3;
            this.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevo.Font = new System.Drawing.Font("Georgia", 13F);
            this.btNuevo.Location = new System.Drawing.Point(7, 324);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(109, 62);
            this.btNuevo.TabIndex = 116;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click_2);
            // 
            // btEliminar
            // 
            this.btEliminar.AutoSize = true;
            this.btEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btEliminar.FlatAppearance.BorderSize = 3;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btEliminar.Location = new System.Drawing.Point(122, 324);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(128, 62);
            this.btEliminar.TabIndex = 115;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.AutoSize = true;
            this.btModificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btModificar.FlatAppearance.BorderSize = 3;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btModificar.Location = new System.Drawing.Point(256, 324);
            this.btModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(137, 62);
            this.btModificar.TabIndex = 114;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = true;
            this.btSalir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btSalir.FlatAppearance.BorderSize = 3;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Georgia", 13F);
            this.btSalir.Location = new System.Drawing.Point(399, 324);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(109, 62);
            this.btSalir.TabIndex = 113;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click_1);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtProducto.Location = new System.Drawing.Point(410, 82);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(121, 32);
            this.txtProducto.TabIndex = 124;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtPrecio.Location = new System.Drawing.Point(410, 167);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 32);
            this.txtPrecio.TabIndex = 127;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCantidad.Location = new System.Drawing.Point(410, 122);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 32);
            this.txtCantidad.TabIndex = 128;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtBuscar.Location = new System.Drawing.Point(882, 29);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 32);
            this.txtBuscar.TabIndex = 131;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.lblTabla.Location = new System.Drawing.Point(617, 25);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(165, 34);
            this.lblTabla.TabIndex = 145;
            this.lblTabla.Text = "Tabla menu";
            this.lblTabla.Click += new System.EventHandler(this.lblTabla_Click);
            // 
            // btAutorizado
            // 
            this.btAutorizado.AutoSize = true;
            this.btAutorizado.BackColor = System.Drawing.Color.DarkCyan;
            this.btAutorizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAutorizado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAutorizado.FlatAppearance.BorderSize = 3;
            this.btAutorizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAutorizado.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btAutorizado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAutorizado.Location = new System.Drawing.Point(841, 454);
            this.btAutorizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAutorizado.Name = "btAutorizado";
            this.btAutorizado.Size = new System.Drawing.Size(237, 45);
            this.btAutorizado.TabIndex = 147;
            this.btAutorizado.Text = "Personal autorizado";
            this.btAutorizado.UseVisualStyleBackColor = false;
            this.btAutorizado.Click += new System.EventHandler(this.btAutorizado_Click_1);
            // 
            // txtPromoc
            // 
            this.txtPromoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtPromoc.Location = new System.Drawing.Point(410, 212);
            this.txtPromoc.Multiline = true;
            this.txtPromoc.Name = "txtPromoc";
            this.txtPromoc.Size = new System.Drawing.Size(121, 32);
            this.txtPromoc.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.label1.Location = new System.Drawing.Point(289, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 34);
            this.label1.TabIndex = 148;
            this.label1.Text = "Promo...";
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1131, 505);
            this.Controls.Add(this.txtPromoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAutorizado);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.Prec);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dtgvMenu);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.Nom);
            this.Name = "productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dtgvMenu;
        private System.Windows.Forms.PictureBox usuario;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label cant;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prec;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btAutorizado;
        private System.Windows.Forms.TextBox txtPromoc;
        private System.Windows.Forms.Label label1;
    }
}