
namespace Grupo_3_Formulario_MDI_Menu
{
    partial class empleados
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
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.empl = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tEmpleados = new System.Windows.Forms.Button();
            this.tUsuarios = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.telef = new System.Windows.Forms.Label();
            this.tipo_emp = new System.Windows.Forms.Label();
            this.dui = new System.Windows.Forms.Label();
            this.apell = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.domi = new System.Windows.Forms.Label();
            this.txtTipo_em = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.Label();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblTabla = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
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
            this.btBuscar.Location = new System.Drawing.Point(1047, 11);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(109, 62);
            this.btBuscar.TabIndex = 75;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgvUsuarios.Location = new System.Drawing.Point(603, 78);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.RowTemplate.Height = 24;
            this.dtgvUsuarios.Size = new System.Drawing.Size(553, 381);
            this.dtgvUsuarios.TabIndex = 74;
            // 
            // empl
            // 
            this.empl.AutoSize = true;
            this.empl.Font = new System.Drawing.Font("Imprint MT Shadow", 23F);
            this.empl.Location = new System.Drawing.Point(458, 9);
            this.empl.Name = "empl";
            this.empl.Size = new System.Drawing.Size(190, 46);
            this.empl.TabIndex = 72;
            this.empl.Text = "Empleado";
            // 
            // btActualizar
            // 
            this.btActualizar.AutoSize = true;
            this.btActualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btActualizar.FlatAppearance.BorderSize = 3;
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btActualizar.Location = new System.Drawing.Point(301, 361);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(159, 73);
            this.btActualizar.TabIndex = 71;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.AutoSize = true;
            this.btGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btGuardar.FlatAppearance.BorderSize = 3;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btGuardar.Location = new System.Drawing.Point(10, 361);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(132, 73);
            this.btGuardar.TabIndex = 70;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.AutoSize = true;
            this.btAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btAgregar.FlatAppearance.BorderSize = 3;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btAgregar.Location = new System.Drawing.Point(12, 284);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(113, 73);
            this.btAgregar.TabIndex = 69;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.AutoSize = true;
            this.btEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btEliminar.FlatAppearance.BorderSize = 3;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btEliminar.Location = new System.Drawing.Point(152, 284);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(136, 73);
            this.btEliminar.TabIndex = 68;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.AutoSize = true;
            this.btModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btModificar.FlatAppearance.BorderSize = 3;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btModificar.Location = new System.Drawing.Point(307, 284);
            this.btModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(146, 73);
            this.btModificar.TabIndex = 67;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = true;
            this.btSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btSalir.FlatAppearance.BorderSize = 3;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.btSalir.Location = new System.Drawing.Point(466, 284);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(109, 73);
            this.btSalir.TabIndex = 66;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // tEmpleados
            // 
            this.tEmpleados.AutoSize = true;
            this.tEmpleados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.tEmpleados.FlatAppearance.BorderSize = 3;
            this.tEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tEmpleados.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.tEmpleados.Location = new System.Drawing.Point(737, 464);
            this.tEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tEmpleados.Name = "tEmpleados";
            this.tEmpleados.Size = new System.Drawing.Size(159, 47);
            this.tEmpleados.TabIndex = 79;
            this.tEmpleados.Text = "Templeados";
            this.tEmpleados.UseVisualStyleBackColor = false;
            this.tEmpleados.Click += new System.EventHandler(this.tEmpleados_Click);
            // 
            // tUsuarios
            // 
            this.tUsuarios.AutoSize = true;
            this.tUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.tUsuarios.FlatAppearance.BorderSize = 3;
            this.tUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tUsuarios.Font = new System.Drawing.Font("Imprint MT Shadow", 15F);
            this.tUsuarios.Location = new System.Drawing.Point(900, 464);
            this.tUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsuarios.Name = "tUsuarios";
            this.tUsuarios.Size = new System.Drawing.Size(151, 47);
            this.tUsuarios.TabIndex = 81;
            this.tUsuarios.Text = "Tusuarios";
            this.tUsuarios.UseVisualStyleBackColor = false;
            this.tUsuarios.Click += new System.EventHandler(this.tUsuarios_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtApellidos.Location = new System.Drawing.Point(422, 76);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(121, 32);
            this.txtApellidos.TabIndex = 138;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtTelefono.Location = new System.Drawing.Point(152, 113);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 32);
            this.txtTelefono.TabIndex = 137;
            // 
            // txtDui
            // 
            this.txtDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtDui.Location = new System.Drawing.Point(422, 115);
            this.txtDui.Multiline = true;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(121, 32);
            this.txtDui.TabIndex = 136;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCorreo.Location = new System.Drawing.Point(152, 155);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(121, 32);
            this.txtCorreo.TabIndex = 135;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNombre.Location = new System.Drawing.Point(152, 76);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 32);
            this.txtNombre.TabIndex = 134;
            // 
            // telef
            // 
            this.telef.AutoSize = true;
            this.telef.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.telef.Location = new System.Drawing.Point(21, 113);
            this.telef.Name = "telef";
            this.telef.Size = new System.Drawing.Size(125, 34);
            this.telef.TabIndex = 133;
            this.telef.Text = "Telefono";
            // 
            // tipo_emp
            // 
            this.tipo_emp.AutoSize = true;
            this.tipo_emp.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.tipo_emp.Location = new System.Drawing.Point(11, 192);
            this.tipo_emp.Name = "tipo_emp";
            this.tipo_emp.Size = new System.Drawing.Size(237, 34);
            this.tipo_emp.TabIndex = 132;
            this.tipo_emp.Text = "Tipo de empleado";
            // 
            // dui
            // 
            this.dui.AutoSize = true;
            this.dui.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.dui.Location = new System.Drawing.Point(288, 115);
            this.dui.Name = "dui";
            this.dui.Size = new System.Drawing.Size(76, 34);
            this.dui.TabIndex = 131;
            this.dui.Text = "DUI";
            // 
            // apell
            // 
            this.apell.AutoSize = true;
            this.apell.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.apell.Location = new System.Drawing.Point(281, 74);
            this.apell.Name = "apell";
            this.apell.Size = new System.Drawing.Size(131, 34);
            this.apell.TabIndex = 130;
            this.apell.Text = "Apellidos";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.Nom.Location = new System.Drawing.Point(18, 74);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(118, 34);
            this.Nom.TabIndex = 129;
            this.Nom.Text = "Nombre";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtDomicilio.Location = new System.Drawing.Point(422, 158);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(121, 32);
            this.txtDomicilio.TabIndex = 140;
            // 
            // domi
            // 
            this.domi.AutoSize = true;
            this.domi.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.domi.Location = new System.Drawing.Point(281, 155);
            this.domi.Name = "domi";
            this.domi.Size = new System.Drawing.Size(140, 34);
            this.domi.TabIndex = 139;
            this.domi.Text = "Domicilio";
            // 
            // txtTipo_em
            // 
            this.txtTipo_em.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtTipo_em.Location = new System.Drawing.Point(254, 192);
            this.txtTipo_em.Multiline = true;
            this.txtTipo_em.Name = "txtTipo_em";
            this.txtTipo_em.Size = new System.Drawing.Size(158, 32);
            this.txtTipo_em.TabIndex = 142;
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.correo.Location = new System.Drawing.Point(35, 153);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(101, 34);
            this.correo.TabIndex = 141;
            this.correo.Text = "Correo";
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgvEmpleados.Location = new System.Drawing.Point(603, 78);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.RowHeadersWidth = 51;
            this.dtgvEmpleados.RowTemplate.Height = 24;
            this.dtgvEmpleados.Size = new System.Drawing.Size(553, 367);
            this.dtgvEmpleados.TabIndex = 143;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Imprint MT Shadow", 17F);
            this.lblTabla.Location = new System.Drawing.Point(673, 41);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(223, 34);
            this.lblTabla.TabIndex = 144;
            this.lblTabla.Text = "Tabla empleados";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtBuscar.Location = new System.Drawing.Point(920, 35);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 32);
            this.txtBuscar.TabIndex = 145;
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1168, 516);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dtgvEmpleados);
            this.Controls.Add(this.txtTipo_em);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.domi);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.telef);
            this.Controls.Add(this.tipo_emp);
            this.Controls.Add(this.dui);
            this.Controls.Add(this.apell);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.tUsuarios);
            this.Controls.Add(this.tEmpleados);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dtgvUsuarios);
            this.Controls.Add(this.empl);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btSalir);
            this.Name = "empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Label empl;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button tEmpleados;
        private System.Windows.Forms.Button tUsuarios;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label telef;
        private System.Windows.Forms.Label tipo_emp;
        private System.Windows.Forms.Label dui;
        private System.Windows.Forms.Label apell;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label domi;
        private System.Windows.Forms.TextBox txtTipo_em;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}