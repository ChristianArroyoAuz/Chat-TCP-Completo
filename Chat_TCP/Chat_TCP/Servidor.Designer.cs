namespace Proyecto_Chat_TCP
{
    partial class Servidor
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
            this.etiquetaEstado = new System.Windows.Forms.Label();
            this.etiquetaTipoEstado = new System.Windows.Forms.Label();
            this.listaClientes = new System.Windows.Forms.ListBox();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.botonConectar = new System.Windows.Forms.Button();
            this.groupBoxConexion = new System.Windows.Forms.GroupBox();
            this.etiquetDireccionIP = new System.Windows.Forms.Label();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonLocalHost = new System.Windows.Forms.RadioButton();
            this.etiquetaLocal = new System.Windows.Forms.Label();
            this.groupBoxConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.AutoSize = true;
            this.etiquetaEstado.Font = new System.Drawing.Font("Dutch801 Rm BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaEstado.Location = new System.Drawing.Point(12, 9);
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(80, 25);
            this.etiquetaEstado.TabIndex = 0;
            this.etiquetaEstado.Text = "Estado:";
            // 
            // etiquetaTipoEstado
            // 
            this.etiquetaTipoEstado.AutoSize = true;
            this.etiquetaTipoEstado.Font = new System.Drawing.Font("Dutch801 Rm BT", 15.75F);
            this.etiquetaTipoEstado.Location = new System.Drawing.Point(98, 9);
            this.etiquetaTipoEstado.Name = "etiquetaTipoEstado";
            this.etiquetaTipoEstado.Size = new System.Drawing.Size(239, 25);
            this.etiquetaTipoEstado.TabIndex = 1;
            this.etiquetaTipoEstado.Text = "Conectado/Desconectado";
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(12, 37);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.ScrollAlwaysVisible = true;
            this.listaClientes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaClientes.Size = new System.Drawing.Size(326, 95);
            this.listaClientes.TabIndex = 2;
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.Location = new System.Drawing.Point(205, 216);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(132, 21);
            this.botonDesconectar.TabIndex = 4;
            this.botonDesconectar.Text = "Desconectar y Salir.";
            this.botonDesconectar.UseVisualStyleBackColor = true;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // botonConectar
            // 
            this.botonConectar.Location = new System.Drawing.Point(12, 216);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(75, 23);
            this.botonConectar.TabIndex = 5;
            this.botonConectar.Text = "Conectar.";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // groupBoxConexion
            // 
            this.groupBoxConexion.Controls.Add(this.etiquetDireccionIP);
            this.groupBoxConexion.Controls.Add(this.radioButtonRed);
            this.groupBoxConexion.Controls.Add(this.radioButtonLocalHost);
            this.groupBoxConexion.Controls.Add(this.etiquetaLocal);
            this.groupBoxConexion.Location = new System.Drawing.Point(12, 138);
            this.groupBoxConexion.Name = "groupBoxConexion";
            this.groupBoxConexion.Size = new System.Drawing.Size(325, 72);
            this.groupBoxConexion.TabIndex = 7;
            this.groupBoxConexion.TabStop = false;
            this.groupBoxConexion.Text = "Tipo de Conexión:";
            // 
            // etiquetDireccionIP
            // 
            this.etiquetDireccionIP.AutoSize = true;
            this.etiquetDireccionIP.Location = new System.Drawing.Point(2, 55);
            this.etiquetDireccionIP.Name = "etiquetDireccionIP";
            this.etiquetDireccionIP.Size = new System.Drawing.Size(0, 13);
            this.etiquetDireccionIP.TabIndex = 3;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(174, 35);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(108, 17);
            this.radioButtonRed.TabIndex = 2;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Direccion de Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.Click += new System.EventHandler(this.radioButtonRed_Click);
            // 
            // radioButtonLocalHost
            // 
            this.radioButtonLocalHost.AutoSize = true;
            this.radioButtonLocalHost.Location = new System.Drawing.Point(174, 12);
            this.radioButtonLocalHost.Name = "radioButtonLocalHost";
            this.radioButtonLocalHost.Size = new System.Drawing.Size(73, 17);
            this.radioButtonLocalHost.TabIndex = 1;
            this.radioButtonLocalHost.TabStop = true;
            this.radioButtonLocalHost.Text = "LocalHost";
            this.radioButtonLocalHost.UseVisualStyleBackColor = true;
            this.radioButtonLocalHost.Click += new System.EventHandler(this.radioButtonLocalHost_Click);
            // 
            // etiquetaLocal
            // 
            this.etiquetaLocal.AutoSize = true;
            this.etiquetaLocal.Location = new System.Drawing.Point(2, 16);
            this.etiquetaLocal.Name = "etiquetaLocal";
            this.etiquetaLocal.Size = new System.Drawing.Size(166, 13);
            this.etiquetaLocal.TabIndex = 0;
            this.etiquetaLocal.Text = "Que tipo de conexión desea usar:";
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 243);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxConexion);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.botonDesconectar);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.etiquetaTipoEstado);
            this.Controls.Add(this.etiquetaEstado);
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Servidor_Load);
            this.groupBoxConexion.ResumeLayout(false);
            this.groupBoxConexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaEstado;
        private System.Windows.Forms.Label etiquetaTipoEstado;
        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.GroupBox groupBoxConexion;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonLocalHost;
        private System.Windows.Forms.Label etiquetaLocal;
        private System.Windows.Forms.Label etiquetDireccionIP;
    }
}

