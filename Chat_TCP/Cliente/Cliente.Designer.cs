namespace Cliente_1
{
    partial class Cliente
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.etiquetaNickname = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.groupBoxConfiguracion = new System.Windows.Forms.GroupBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.radioButtonNick = new System.Windows.Forms.RadioButton();
            this.etiquetaSelecionNombre = new System.Windows.Forms.Label();
            this.radioButtonManual = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.etiquetaIP_Puerto = new System.Windows.Forms.Label();
            this.groupBoxIP_Puerto = new System.Windows.Forms.GroupBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.etiquetaPuerto = new System.Windows.Forms.Label();
            this.etiquetaDireccion = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.listaMensajes = new System.Windows.Forms.ListBox();
            this.groupBoxMesajes = new System.Windows.Forms.GroupBox();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.txtMensajeEnviar = new System.Windows.Forms.TextBox();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxConfiguracion.SuspendLayout();
            this.groupBoxIP_Puerto.SuspendLayout();
            this.groupBoxMesajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.txtNickname);
            this.groupBoxDatos.Controls.Add(this.etiquetaNickname);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.etiquetaNombre);
            this.groupBoxDatos.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(424, 94);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Ingresa Tus Datos:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(82, 51);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(336, 28);
            this.txtNickname.TabIndex = 3;
            // 
            // etiquetaNickname
            // 
            this.etiquetaNickname.AutoSize = true;
            this.etiquetaNickname.Location = new System.Drawing.Point(6, 58);
            this.etiquetaNickname.Name = "etiquetaNickname";
            this.etiquetaNickname.Size = new System.Drawing.Size(70, 21);
            this.etiquetaNickname.TabIndex = 1;
            this.etiquetaNickname.Text = "Nickname:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 28);
            this.txtNombre.TabIndex = 2;
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(6, 24);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(62, 21);
            this.etiquetaNombre.TabIndex = 0;
            this.etiquetaNombre.Text = "Nombre:";
            // 
            // groupBoxConfiguracion
            // 
            this.groupBoxConfiguracion.Controls.Add(this.radioButtonNombre);
            this.groupBoxConfiguracion.Controls.Add(this.radioButtonNick);
            this.groupBoxConfiguracion.Controls.Add(this.etiquetaSelecionNombre);
            this.groupBoxConfiguracion.Font = new System.Drawing.Font("Papyrus", 9.75F);
            this.groupBoxConfiguracion.Location = new System.Drawing.Point(12, 112);
            this.groupBoxConfiguracion.Name = "groupBoxConfiguracion";
            this.groupBoxConfiguracion.Size = new System.Drawing.Size(424, 58);
            this.groupBoxConfiguracion.TabIndex = 1;
            this.groupBoxConfiguracion.TabStop = false;
            this.groupBoxConfiguracion.Text = "Configuración Nombres:";
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(245, 20);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(80, 25);
            this.radioButtonNombre.TabIndex = 1;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre.";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonNick
            // 
            this.radioButtonNick.AutoSize = true;
            this.radioButtonNick.Location = new System.Drawing.Point(331, 20);
            this.radioButtonNick.Name = "radioButtonNick";
            this.radioButtonNick.Size = new System.Drawing.Size(88, 25);
            this.radioButtonNick.TabIndex = 2;
            this.radioButtonNick.TabStop = true;
            this.radioButtonNick.Text = "Nickname.";
            this.radioButtonNick.UseVisualStyleBackColor = true;
            // 
            // etiquetaSelecionNombre
            // 
            this.etiquetaSelecionNombre.AutoSize = true;
            this.etiquetaSelecionNombre.Location = new System.Drawing.Point(6, 24);
            this.etiquetaSelecionNombre.Name = "etiquetaSelecionNombre";
            this.etiquetaSelecionNombre.Size = new System.Drawing.Size(223, 21);
            this.etiquetaSelecionNombre.TabIndex = 0;
            this.etiquetaSelecionNombre.Text = "Como quieres que te vean los demás:";
            // 
            // radioButtonManual
            // 
            this.radioButtonManual.AutoSize = true;
            this.radioButtonManual.Location = new System.Drawing.Point(237, 20);
            this.radioButtonManual.Name = "radioButtonManual";
            this.radioButtonManual.Size = new System.Drawing.Size(120, 25);
            this.radioButtonManual.TabIndex = 2;
            this.radioButtonManual.TabStop = true;
            this.radioButtonManual.Text = "Ingreso Manual.";
            this.radioButtonManual.UseVisualStyleBackColor = true;
            this.radioButtonManual.Click += new System.EventHandler(this.radioButtonManual_Click);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(152, 20);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(79, 25);
            this.radioButtonDefault.TabIndex = 1;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default.";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.Click += new System.EventHandler(this.radioButtonDefault_Click);
            // 
            // etiquetaIP_Puerto
            // 
            this.etiquetaIP_Puerto.AutoSize = true;
            this.etiquetaIP_Puerto.Location = new System.Drawing.Point(7, 24);
            this.etiquetaIP_Puerto.Name = "etiquetaIP_Puerto";
            this.etiquetaIP_Puerto.Size = new System.Drawing.Size(139, 21);
            this.etiquetaIP_Puerto.TabIndex = 0;
            this.etiquetaIP_Puerto.Text = "Dirección IP y Puerto:";
            // 
            // groupBoxIP_Puerto
            // 
            this.groupBoxIP_Puerto.Controls.Add(this.txtPuerto);
            this.groupBoxIP_Puerto.Controls.Add(this.txtDireccion);
            this.groupBoxIP_Puerto.Controls.Add(this.etiquetaPuerto);
            this.groupBoxIP_Puerto.Controls.Add(this.etiquetaDireccion);
            this.groupBoxIP_Puerto.Controls.Add(this.etiquetaIP_Puerto);
            this.groupBoxIP_Puerto.Controls.Add(this.radioButtonDefault);
            this.groupBoxIP_Puerto.Controls.Add(this.radioButtonManual);
            this.groupBoxIP_Puerto.Font = new System.Drawing.Font("Papyrus", 9.75F);
            this.groupBoxIP_Puerto.Location = new System.Drawing.Point(12, 176);
            this.groupBoxIP_Puerto.Name = "groupBoxIP_Puerto";
            this.groupBoxIP_Puerto.Size = new System.Drawing.Size(424, 128);
            this.groupBoxIP_Puerto.TabIndex = 2;
            this.groupBoxIP_Puerto.TabStop = false;
            this.groupBoxIP_Puerto.Text = "Configuracion Dirección y Puerto:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(98, 85);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(320, 28);
            this.txtPuerto.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(98, 51);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(320, 28);
            this.txtDireccion.TabIndex = 5;
            // 
            // etiquetaPuerto
            // 
            this.etiquetaPuerto.AutoSize = true;
            this.etiquetaPuerto.Location = new System.Drawing.Point(7, 92);
            this.etiquetaPuerto.Name = "etiquetaPuerto";
            this.etiquetaPuerto.Size = new System.Drawing.Size(53, 21);
            this.etiquetaPuerto.TabIndex = 4;
            this.etiquetaPuerto.Text = "Puerto:";
            // 
            // etiquetaDireccion
            // 
            this.etiquetaDireccion.AutoSize = true;
            this.etiquetaDireccion.Location = new System.Drawing.Point(6, 58);
            this.etiquetaDireccion.Name = "etiquetaDireccion";
            this.etiquetaDireccion.Size = new System.Drawing.Size(86, 21);
            this.etiquetaDireccion.TabIndex = 3;
            this.etiquetaDireccion.Text = "Dirección IP:";
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(12, 310);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(424, 52);
            this.botonIngresar.TabIndex = 4;
            this.botonIngresar.Text = "Ingresar al Chat.";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // listaMensajes
            // 
            this.listaMensajes.FormattingEnabled = true;
            this.listaMensajes.Location = new System.Drawing.Point(442, 20);
            this.listaMensajes.Name = "listaMensajes";
            this.listaMensajes.ScrollAlwaysVisible = true;
            this.listaMensajes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaMensajes.Size = new System.Drawing.Size(288, 147);
            this.listaMensajes.TabIndex = 5;
            // 
            // groupBoxMesajes
            // 
            this.groupBoxMesajes.Controls.Add(this.botonEnviar);
            this.groupBoxMesajes.Controls.Add(this.txtMensajeEnviar);
            this.groupBoxMesajes.Location = new System.Drawing.Point(442, 180);
            this.groupBoxMesajes.Name = "groupBoxMesajes";
            this.groupBoxMesajes.Size = new System.Drawing.Size(288, 124);
            this.groupBoxMesajes.TabIndex = 3;
            this.groupBoxMesajes.TabStop = false;
            this.groupBoxMesajes.Text = "Ingreso del Mesaje:";
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(6, 95);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(276, 23);
            this.botonEnviar.TabIndex = 1;
            this.botonEnviar.Text = "Enviar Mensaje.";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // txtMensajeEnviar
            // 
            this.txtMensajeEnviar.Location = new System.Drawing.Point(6, 16);
            this.txtMensajeEnviar.Multiline = true;
            this.txtMensajeEnviar.Name = "txtMensajeEnviar";
            this.txtMensajeEnviar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensajeEnviar.Size = new System.Drawing.Size(276, 73);
            this.txtMensajeEnviar.TabIndex = 0;
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.Location = new System.Drawing.Point(442, 310);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(288, 23);
            this.botonDesconectar.TabIndex = 6;
            this.botonDesconectar.Text = "Desconectar el Chat";
            this.botonDesconectar.UseVisualStyleBackColor = true;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(442, 339);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(288, 23);
            this.botonSalir.TabIndex = 7;
            this.botonSalir.Text = "Salir del Porgrama.";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 370);
            this.ControlBox = false;
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonDesconectar);
            this.Controls.Add(this.groupBoxMesajes);
            this.Controls.Add(this.listaMensajes);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.groupBoxIP_Puerto);
            this.Controls.Add(this.groupBoxConfiguracion);
            this.Controls.Add(this.groupBoxDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_1_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxConfiguracion.ResumeLayout(false);
            this.groupBoxConfiguracion.PerformLayout();
            this.groupBoxIP_Puerto.ResumeLayout(false);
            this.groupBoxIP_Puerto.PerformLayout();
            this.groupBoxMesajes.ResumeLayout(false);
            this.groupBoxMesajes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label etiquetaNickname;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.GroupBox groupBoxConfiguracion;
        private System.Windows.Forms.RadioButton radioButtonNick;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.Label etiquetaSelecionNombre;
        private System.Windows.Forms.RadioButton radioButtonManual;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.Label etiquetaIP_Puerto;
        private System.Windows.Forms.GroupBox groupBoxIP_Puerto;
        private System.Windows.Forms.Label etiquetaPuerto;
        private System.Windows.Forms.Label etiquetaDireccion;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.ListBox listaMensajes;
        private System.Windows.Forms.GroupBox groupBoxMesajes;
        private System.Windows.Forms.Button botonEnviar;
        private System.Windows.Forms.TextBox txtMensajeEnviar;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.Button botonSalir;
    }
}
