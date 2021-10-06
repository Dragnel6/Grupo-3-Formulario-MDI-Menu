
namespace Grupo_3_Formulario_MDI_Menu
{
    partial class fusuario
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
            this.components = new System.ComponentModel.Container();
            this.Sesion = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btUltimo = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btPrimero = new System.Windows.Forms.Button();
            this.Nel = new System.Windows.Forms.Label();
            this.Contra = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.tusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet = new Grupo_3_Formulario_MDI_Menu.sistemaDataSet();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.tusuarioTableAdapter = new Grupo_3_Formulario_MDI_Menu.sistemaDataSetTableAdapters.tusuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sesion
            // 
            this.Sesion.AutoSize = true;
            this.Sesion.Font = new System.Drawing.Font("Georgia", 20F);
            this.Sesion.Location = new System.Drawing.Point(143, 22);
            this.Sesion.Name = "Sesion";
            this.Sesion.Size = new System.Drawing.Size(218, 39);
            this.Sesion.TabIndex = 33;
            this.Sesion.Text = "Iniciar sesion";
            // 
            // btActualizar
            // 
            this.btActualizar.AutoSize = true;
            this.btActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btActualizar.FlatAppearance.BorderSize = 3;
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Georgia", 13F);
            this.btActualizar.Location = new System.Drawing.Point(283, 450);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(141, 62);
            this.btActualizar.TabIndex = 32;
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
            this.btGuardar.Location = new System.Drawing.Point(19, 450);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(123, 62);
            this.btGuardar.TabIndex = 31;
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
            this.btNuevo.Location = new System.Drawing.Point(19, 382);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(109, 62);
            this.btNuevo.TabIndex = 30;
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
            this.btEliminar.Location = new System.Drawing.Point(149, 382);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(128, 62);
            this.btEliminar.TabIndex = 29;
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
            this.btModificar.Location = new System.Drawing.Point(283, 382);
            this.btModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(137, 62);
            this.btModificar.TabIndex = 28;
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
            this.btSalir.Location = new System.Drawing.Point(425, 382);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(109, 62);
            this.btSalir.TabIndex = 27;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btUltimo
            // 
            this.btUltimo.AutoSize = true;
            this.btUltimo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUltimo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btUltimo.FlatAppearance.BorderSize = 3;
            this.btUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUltimo.Font = new System.Drawing.Font("Georgia", 13F);
            this.btUltimo.Location = new System.Drawing.Point(425, 314);
            this.btUltimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(109, 62);
            this.btUltimo.TabIndex = 26;
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
            this.btSiguiente.Location = new System.Drawing.Point(285, 314);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(135, 62);
            this.btSiguiente.TabIndex = 25;
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
            this.btAnterior.Location = new System.Drawing.Point(149, 314);
            this.btAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(124, 62);
            this.btAnterior.TabIndex = 24;
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
            this.btPrimero.Location = new System.Drawing.Point(19, 314);
            this.btPrimero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(121, 62);
            this.btPrimero.TabIndex = 23;
            this.btPrimero.Text = "Primero";
            this.btPrimero.UseVisualStyleBackColor = false;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // Nel
            // 
            this.Nel.AutoSize = true;
            this.Nel.Font = new System.Drawing.Font("Georgia", 15F);
            this.Nel.Location = new System.Drawing.Point(308, 188);
            this.Nel.Name = "Nel";
            this.Nel.Size = new System.Drawing.Size(70, 30);
            this.Nel.TabIndex = 21;
            this.Nel.Text = "Nivel";
            // 
            // Contra
            // 
            this.Contra.AutoSize = true;
            this.Contra.Font = new System.Drawing.Font("Georgia", 15F);
            this.Contra.Location = new System.Drawing.Point(300, 150);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(73, 30);
            this.Contra.TabIndex = 20;
            this.Contra.Text = "Clave";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Georgia", 15F);
            this.User.Location = new System.Drawing.Point(281, 106);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 30);
            this.User.TabIndex = 19;
            this.User.Text = "Usuario";
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuarioBindingSource, "clave", true));
            this.txtclave.Font = new System.Drawing.Font("Georgia", 13F);
            this.txtclave.Location = new System.Drawing.Point(393, 149);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtclave.Multiline = true;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(133, 34);
            this.txtclave.TabIndex = 18;
            // 
            // tusuarioBindingSource
            // 
            this.tusuarioBindingSource.DataMember = "tusuario";
            this.tusuarioBindingSource.DataSource = this.sistemaDataSet;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "sistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtusuario
            // 
            this.txtusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuarioBindingSource, "nombre", true));
            this.txtusuario.Font = new System.Drawing.Font("Georgia", 13F);
            this.txtusuario.Location = new System.Drawing.Point(393, 105);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(133, 31);
            this.txtusuario.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo_3_Formulario_MDI_Menu.Properties.Resources.Usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(19, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lstnivel
            // 
            this.lstnivel.DataSource = this.tusuarioBindingSource;
            this.lstnivel.DisplayMember = "nivel";
            this.lstnivel.Font = new System.Drawing.Font("Georgia", 13F);
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Location = new System.Drawing.Point(393, 188);
            this.lstnivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(133, 35);
            this.lstnivel.TabIndex = 22;
            // 
            // tusuarioTableAdapter
            // 
            this.tusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // fusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(555, 535);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fusuario";
            this.Load += new System.EventHandler(this.fusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sesion;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btUltimo;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btPrimero;
        private System.Windows.Forms.Label Nel;
        private System.Windows.Forms.Label Contra;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox lstnivel;
        private sistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource tusuarioBindingSource;
        private sistemaDataSetTableAdapters.tusuarioTableAdapter tusuarioTableAdapter;
    }
}