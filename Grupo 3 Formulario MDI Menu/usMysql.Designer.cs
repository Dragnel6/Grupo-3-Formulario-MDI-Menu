
namespace Grupo_3_Formulario_MDI_Menu
{
    partial class usMysql
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
            this.usuario = new System.Windows.Forms.PictureBox();
            this.Sesion = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btUltimo = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btPrimero = new System.Windows.Forms.Button();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.Nel = new System.Windows.Forms.Label();
            this.Contra = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Image = global::Grupo_3_Formulario_MDI_Menu.Properties.Resources.Usuarios;
            this.usuario.Location = new System.Drawing.Point(18, 52);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(239, 209);
            this.usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usuario.TabIndex = 52;
            this.usuario.TabStop = false;
            // 
            // Sesion
            // 
            this.Sesion.AutoSize = true;
            this.Sesion.Font = new System.Drawing.Font("Georgia", 20F);
            this.Sesion.Location = new System.Drawing.Point(266, 9);
            this.Sesion.Name = "Sesion";
            this.Sesion.Size = new System.Drawing.Size(218, 39);
            this.Sesion.TabIndex = 51;
            this.Sesion.Text = "Iniciar sesion";
            // 
            // btGuardar
            // 
            this.btGuardar.AutoSize = true;
            this.btGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btGuardar.FlatAppearance.BorderSize = 3;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btGuardar.Location = new System.Drawing.Point(18, 424);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(123, 62);
            this.btGuardar.TabIndex = 49;
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
            this.btNuevo.Location = new System.Drawing.Point(18, 356);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(109, 62);
            this.btNuevo.TabIndex = 48;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.AutoSize = true;
            this.btEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btEliminar.FlatAppearance.BorderSize = 3;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btEliminar.Location = new System.Drawing.Point(148, 356);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(128, 62);
            this.btEliminar.TabIndex = 47;
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
            this.btModificar.Location = new System.Drawing.Point(282, 356);
            this.btModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(137, 62);
            this.btModificar.TabIndex = 46;
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
            this.btSalir.Location = new System.Drawing.Point(424, 356);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(109, 62);
            this.btSalir.TabIndex = 45;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            // 
            // btUltimo
            // 
            this.btUltimo.AutoSize = true;
            this.btUltimo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUltimo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btUltimo.FlatAppearance.BorderSize = 3;
            this.btUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUltimo.Font = new System.Drawing.Font("Georgia", 13F);
            this.btUltimo.Location = new System.Drawing.Point(424, 288);
            this.btUltimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(109, 62);
            this.btUltimo.TabIndex = 44;
            this.btUltimo.Text = "Ultimo";
            this.btUltimo.UseVisualStyleBackColor = false;
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.AutoSize = true;
            this.btSiguiente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btSiguiente.FlatAppearance.BorderSize = 3;
            this.btSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSiguiente.Font = new System.Drawing.Font("Georgia", 13F);
            this.btSiguiente.Location = new System.Drawing.Point(284, 288);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(135, 62);
            this.btSiguiente.TabIndex = 43;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = false;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.AutoSize = true;
            this.btAnterior.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btAnterior.FlatAppearance.BorderSize = 3;
            this.btAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnterior.Font = new System.Drawing.Font("Georgia", 13F);
            this.btAnterior.Location = new System.Drawing.Point(148, 288);
            this.btAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(124, 62);
            this.btAnterior.TabIndex = 42;
            this.btAnterior.Text = "Anterior";
            this.btAnterior.UseVisualStyleBackColor = false;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btPrimero
            // 
            this.btPrimero.AutoSize = true;
            this.btPrimero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPrimero.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btPrimero.FlatAppearance.BorderSize = 3;
            this.btPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrimero.Font = new System.Drawing.Font("Georgia", 13F);
            this.btPrimero.Location = new System.Drawing.Point(18, 288);
            this.btPrimero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(121, 62);
            this.btPrimero.TabIndex = 41;
            this.btPrimero.Text = "Primero";
            this.btPrimero.UseVisualStyleBackColor = false;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // lstnivel
            // 
            this.lstnivel.DisplayMember = "nivel";
            this.lstnivel.Font = new System.Drawing.Font("Georgia", 13F);
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.lstnivel.Location = new System.Drawing.Point(400, 164);
            this.lstnivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(133, 35);
            this.lstnivel.TabIndex = 40;
            // 
            // Nel
            // 
            this.Nel.AutoSize = true;
            this.Nel.Font = new System.Drawing.Font("Georgia", 15F);
            this.Nel.Location = new System.Drawing.Point(315, 164);
            this.Nel.Name = "Nel";
            this.Nel.Size = new System.Drawing.Size(70, 30);
            this.Nel.TabIndex = 39;
            this.Nel.Text = "Nivel";
            // 
            // Contra
            // 
            this.Contra.AutoSize = true;
            this.Contra.Font = new System.Drawing.Font("Georgia", 15F);
            this.Contra.Location = new System.Drawing.Point(307, 126);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(73, 30);
            this.Contra.TabIndex = 38;
            this.Contra.Text = "Clave";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Georgia", 15F);
            this.User.Location = new System.Drawing.Point(288, 82);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 30);
            this.User.TabIndex = 37;
            this.User.Text = "Usuario";
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Georgia", 13F);
            this.txtclave.Location = new System.Drawing.Point(400, 125);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtclave.Multiline = true;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(133, 34);
            this.txtclave.TabIndex = 36;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Georgia", 13F);
            this.txtusuario.Location = new System.Drawing.Point(400, 81);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(133, 31);
            this.txtusuario.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(539, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 381);
            this.dataGridView1.TabIndex = 53;
            // 
            // btBuscar
            // 
            this.btBuscar.AutoSize = true;
            this.btBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btBuscar.FlatAppearance.BorderSize = 3;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btBuscar.Location = new System.Drawing.Point(983, 21);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(109, 62);
            this.btBuscar.TabIndex = 54;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Georgia", 13F);
            this.txtBuscar.Location = new System.Drawing.Point(844, 52);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(133, 31);
            this.txtBuscar.TabIndex = 55;
            // 
            // btActualizar
            // 
            this.btActualizar.AutoSize = true;
            this.btActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btActualizar.FlatAppearance.BorderSize = 3;
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btActualizar.Location = new System.Drawing.Point(282, 424);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(141, 62);
            this.btActualizar.TabIndex = 50;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // usMysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1099, 495);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.Sesion);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btUltimo);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.btPrimero);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.Nel);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.User);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Name = "usMysql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usMysql";
            this.Load += new System.EventHandler(this.usMysql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox usuario;
        private System.Windows.Forms.Label Sesion;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btUltimo;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btPrimero;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.Label Nel;
        private System.Windows.Forms.Label Contra;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btActualizar;
    }
}