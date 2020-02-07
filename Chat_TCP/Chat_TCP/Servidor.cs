// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 10/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System;

namespace Proyecto_Chat_TCP
{
    public partial class Servidor : Form
    {
        //Delegado usado para actualizar el estado de los clientes
        private delegate void actualizarEstadoClientes(string mensjaes);
        //Creacion del servidor
        servidorChat servidorPrincipal;
        IPAddress direccionIP;
        
        public Servidor()
        {
            InitializeComponent();
        }

        private void Servidor_Load(object sender, EventArgs e)
        {
            radioButtonLocalHost.Checked = true;
            etiquetaTipoEstado.Text = "Desconectado";
            etiquetaTipoEstado.ForeColor = Color.Red;
            etiquetDireccionIP.Visible = false;
        }

        public void cabiosServidorPrincipal(object sender, ServidorTCP e)
        {
            try
            {
                //Realiza una actualizacion en las tablas para saber cuando el servidor se ha desconectado
                this.Invoke(new actualizarEstadoClientes(this.actualizarEstado),
                        new object[] { e.EventoMensaje });
            }
            catch (Exception)
            {
                MessageBox.Show("El servidor se ha desconectado... No puede Enviar mensajes.", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void actualizarEstado(string nuevoMensaje)
        {
            //Actuallizacion de la tabla de mensajes
            listaClientes.Items.Add(nuevoMensaje);
        }

        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Proceso de desconectar el servidpr
                etiquetaTipoEstado.Text = "Desconectado";
                etiquetaTipoEstado.ForeColor = Color.Red;
                listaClientes.Items.Clear();
                listaClientes.Items.Add("Servidor se es Cerrando...");
                Environment.Exit(0);
            }
            catch (Exception)
            {
            }
        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            //Habilitando, deshabilitando y seteando algunos valores en los controles visuales
            botonConectar.Enabled = false;
            etiquetaTipoEstado.Text = "Conectado.";
            etiquetaTipoEstado.ForeColor = Color.ForestGreen;
            groupBoxConexion.Enabled = false;

            if (radioButtonLocalHost.Checked == true)
            {
                //Agregando la direccion IP con la cual se va a trabajar
                direccionIP = IPAddress.Parse("127.0.0.1");
                //Creando una nueva instancia tipoChatServer
                servidorPrincipal = new servidorChat(direccionIP);
                //Enganchandonos a la clase servidorChat
                servidorChat.cambioEstado += new ServidorTCP_PasoDatos(cabiosServidorPrincipal);
                //Inicio del proceso de escucha y espera por nuevas conexiones
                servidorPrincipal.escuchandoClientes();
                //Mostrando las nuevas conexiones iniciadas en el servidor
                listaClientes.ForeColor = Color.Red;
                listaClientes.Items.Clear();
                listaClientes.Items.Add("Esperando por Clientes...");
            }
            else
            {
                listaClientes.Focus();
                //Consiguiendo la direccion IP de la red a la cual se encuentra conectado la PC
                IPAddress[] direccionesIP = Dns.GetHostAddresses(Dns.GetHostName());
                IPAddress direccionServidor = direccionesIP[0];
                foreach (IPAddress ip in direccionesIP)
                {
                    //Imprimiendo las direcciones IP
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        //Si no esta conectado a ninguna red imprimir la direccion de hostlocal
                        if (!ip.Equals("127.0.0.1"))
                        {
                            direccionServidor = ip;
                        }
                    }
                }
                //Agregando la direccion IP con la cual se va a trabajar
                direccionIP = IPAddress.Parse(direccionServidor.ToString());
                //Creando una nueva instancia tipoChatServer
                servidorPrincipal = new servidorChat(direccionIP);
                //Enganchandonos a la clase servidorChat
                servidorChat.cambioEstado += new ServidorTCP_PasoDatos(cabiosServidorPrincipal);
                //Inicio del proceso de escucha y espera por nuevas conexiones
                servidorPrincipal.escuchandoClientes();
                //Mostrando las nuevas conexiones iniciadas en el servidor
                listaClientes.ForeColor = Color.Red;
                listaClientes.Items.Add("Esperando por Clientes...");
            }
        }

        private void radioButtonRed_Click(object sender, EventArgs e)
        {
            //Consiguiendo la direccion IP de la red a la cual se encuentra conectado la PC
            IPAddress[] direccionesIP = Dns.GetHostAddresses(Dns.GetHostName());
            IPAddress direccionServidor = direccionesIP[0];
            foreach (IPAddress ip in direccionesIP)
            {
                //Imprimiendo las direcciones IP
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    //Si no esta conectado a ninguna red imprimir la direccion de hostlocal
                    if (!ip.Equals("127.0.0.1"))
                    {
                        direccionServidor = ip;
                    }
                }
            }
            //Informando de la direccionque esta usando
            etiquetDireccionIP.Visible = true;
            etiquetDireccionIP.ForeColor = Color.Red;
            etiquetDireccionIP.Text = "La dirección IP del servidor sera: " + direccionServidor;
        }

        private void radioButtonLocalHost_Click(object sender, EventArgs e)
        {
            etiquetDireccionIP.Visible = false;
        }
    }
}