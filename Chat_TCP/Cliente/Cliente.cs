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

namespace Cliente_1
{
    public partial class Cliente : Form
    {
        // Variables para el nombre del cliente y para la lectura y envio del mensaje
        //Implementado para escribir y leer los caracteres de una secuencia en una codificación determinada.
        //Finalmente inicializamos una instacia para poder conectarnos a un servidor con una direccion y puerto
        private string nombreUsuario;
        private StreamWriter envioMensaje;
        private StreamReader lecturaMensaje;
        private TcpClient servidorTCP;

        // Delegado creado para actualizar los mensajes cuando llega el mensaje de otro hilo
        private delegate void actualizacionMensajes(string informacion_1);

        //Variables necesarias para crear el hilo por el cual se enviara el mensajes
        //Inicializamos la direccion IP con la cual se trabajara
        //Variable necesaria para informar a los demas clientes cuando otro cliente se ha conectado o desconectado
        private delegate void actualizacionInformacion(string informacion_2);
        private Thread hiloMensaje;
        private IPAddress direccionIP;
        private bool Conectado = false;

        public Cliente()
        {
            InitializeComponent();
            //IInformado a la aplicacion que evento aplicar cuando se cierra la aplicacion
            Application.ApplicationExit += new EventHandler(cerrandoAplicacion);
        }

        private void Cliente_1_Load(object sender, EventArgs e)
        {
            radioButtonNombre.Checked = true;
            radioButtonDefault.Checked = true;
            txtDireccion.Enabled = false;
            txtPuerto.Enabled = false;
            groupBoxMesajes.Enabled = false;
            botonDesconectar.Enabled = false;
        }

        //Evento desarrollado para cerrar correctamenete la aplicacion
        public void cerrandoAplicacion(object sender, EventArgs e)
        {
            try
            {
                //La aplicacion se cerra siempre y cuando este en un estado de conectado.
                if (Conectado == true)
                {
                    //Cierra las conexiones, los stream de lectura y escritura, el puerto, etc 
                    //Pasa a estado de desconectado
                    DialogResult resultado = MessageBox.Show("Se cerrara la ventana del chat del Cliente.", "Advertencia.", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        Conectado = false;
                        envioMensaje.Close();
                        lecturaMensaje.Close();
                        servidorTCP.Close();
                        Close();
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    Close();
                }
            }
            catch (Exception)
            {
                //No mostrar mensajes
            }
        }

        //Cerrando la conexion del cliente
        private void cerrandoConexion(string cerrar)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Se desconectara del Chat", "Saliendo.", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    //Cerrando todo las conexiones, puerto y streams y pasando a estado de no conectado
                    Conectado = false;
                    envioMensaje.Close();
                    lecturaMensaje.Close();
                    servidorTCP.Close();
                    groupBoxDatos.Enabled = true;
                    groupBoxConfiguracion.Enabled = true;
                    groupBoxIP_Puerto.Enabled = true;
                    botonIngresar.Enabled = true;
                    groupBoxMesajes.Enabled = false;
                    botonDesconectar.Enabled = false;
                    listaMensajes.Items.Clear();
                    txtNombre.Focus();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                //No hacer nada
            }
        }

        private void iniciandoConexion()
        {
            try
            {
                //Agregando la direccion IP del servidor en forma de ojeto tipo IPAddress 
                //Con los valores puestos por el programador
                if (radioButtonDefault.Checked == true)
                {
                    //Igresando la direccion de localhos para contactar con el servidor
                    direccionIP = IPAddress.Parse("127.0.0.1");
                    //Iniciando una nueva conexion con el servidor por el puerto pre-establecido y
                    //Pasando a la variable el nombre que se encuentra en el textbox
                    //Finalmente pasa a estado conectado
                    servidorTCP = new TcpClient();
                    servidorTCP.Connect(direccionIP, 11000);
                    Conectado = true;
                    //Seleccionando el tipo de nombre con el cual presentarse a los demas cleinte
                    envioMensaje = new StreamWriter(servidorTCP.GetStream());
                    if (radioButtonNombre.Checked == true)
                    {
                        // Enviando al servidor el nombre de usuario
                        nombreUsuario = txtNombre.Text;
                        envioMensaje.WriteLine(txtNombre.Text);
                    }
                    else
                    {
                        // Enviando al servidor el nombre de usuario
                        nombreUsuario = txtNickname.Text;
                        envioMensaje.WriteLine(txtNickname.Text);
                    }
                    envioMensaje.Flush();
                    //Iiniciando el hilo para la comunicacion y poder recibir los mensajes.
                    hiloMensaje = new Thread(new ThreadStart(reciviendoMensajes));
                    hiloMensaje.Start();
                }
                //Agregando la direccion IP del servidor en forma de ojeto tipo IPAddress 
                //Con los valores puestos por el cliente
                else
                {
                    //Igresando la direccion de localhos para contactar con el servidor
                    direccionIP = IPAddress.Parse(txtDireccion.Text);
                    //Iniciando una nueva conexion con el servidor por el puerto pre-establecido y
                    //Pasando a la variable el nombre que se encuentra en el textbox
                    //Finalmente pasa a estado conectado
                    servidorTCP = new TcpClient();
                    servidorTCP.Connect(direccionIP, Convert.ToInt32(txtPuerto.Text));
                    Conectado = true;
                    //Seleccionando el tipo de nombre con el cual presentarse a los demas cleinte
                    envioMensaje = new StreamWriter(servidorTCP.GetStream());
                    if (radioButtonNombre.Checked == true)
                    {
                        // Enviando al servidor el nombre de usuario
                        nombreUsuario = txtNombre.Text;
                        envioMensaje.WriteLine(txtNombre.Text);
                    }
                    else
                    {
                        // Enviando al servidor el nombre de usuario
                        nombreUsuario = txtNickname.Text;
                        envioMensaje.WriteLine(txtNickname.Text);
                    }
                    envioMensaje.Flush();
                    //Iniciando el hilo para la comunicacion y poder recibir los mensajes.
                    hiloMensaje = new Thread(new ThreadStart(reciviendoMensajes));
                    hiloMensaje.Start();
                }
                //Deshabilitando elementos
                groupBoxConfiguracion.Enabled = false;
                groupBoxDatos.Enabled = false;
                groupBoxIP_Puerto.Enabled = false;
                botonIngresar.Enabled = false;
                groupBoxMesajes.Enabled = true;
                botonDesconectar.Enabled = true;
                txtMensajeEnviar.Focus();
                txtNombre.Text = "";
                txtNickname.Text = "";
                radioButtonNombre.Checked = true;
                radioButtonNick.Checked = false;
                radioButtonDefault.Checked = true;
                radioButtonManual.Checked = false;
                txtDireccion.Text = "";
                txtPuerto.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error durante el intento de conexión ya que la parte conectada no respondió" + "\n" +
                                 "adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión" + "\n" +
                                 "establecida ya que el host conectado no ha podido responder", "Advertecia", MessageBoxButtons.OK);
                txtDireccion.Focus();

            }
        }

        private void reciviendoMensajes()
        {
            //Reciviendo las respuestas desde el servidor
            lecturaMensaje = new StreamReader(servidorTCP.GetStream());
            //Asignacon por medio de caracteres a conectado o desconectado
            //Si el primer caracter recibido es un 1 se establecera como conexion exitosa
            string respuestaServidor = lecturaMensaje.ReadLine();
            if (respuestaServidor[0] == '1')
            {
                //Informando a los clientes de los usuarios que pudieron conectarse exitosamente
                this.Invoke(new actualizacionMensajes(this.actualizarListaMensajes),
                            new object[] { "Se ha conectado Exitosamente..." });
            }
            //Si el primer caracter que llega del servidor es distinto de 1 se establecera como no conectado
            else
            {
                string noConectado = "No se ha podido establecer la conexion...";
                noConectado += respuestaServidor.Substring(2, respuestaServidor.Length - 2);
                this.Invoke(new actualizacionInformacion(this.cerrandoConexion),
                            new object[] { noConectado });
                return;
            }
            // Mientras este conectado el cliente se presentaran los mensajes en pantalla
            while (Conectado == true)
            {
                //Mostrando los mensajes en el ListBox
                try
                {
                    this.Invoke(new actualizacionMensajes(this.actualizarListaMensajes),
                                new object[] { lecturaMensaje.ReadLine() });

                }
                catch (Exception)
                {
                    //Mesaje de error
                    //MessageBox.Show("No se pudo mostrar el mensaje, debido a un error...", "Adertencia", MessageBoxButtons.OK);
                }
            }
        }

        //Metodo llamados desde otro hilo diferentes para poder actualizar el listbox
        private void actualizarListaMensajes(string mensajeRecivido)
        {
            listaMensajes.Items.Add(mensajeRecivido);
        }

        // Proceso de envio de mensajes al servidor
        private void enviarMensajeDestino()
        {
            if (txtMensajeEnviar.Lines.Length >= 1)
            {
                try
                {
                    envioMensaje.WriteLine(txtMensajeEnviar.Text);
                    envioMensaje.Flush();
                    txtMensajeEnviar.Lines = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo enviar el mensaje debido a que se perdio conexion con el servidor.", "Aviso.", MessageBoxButtons.OK);
                }
            }
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            if (Conectado == false)
            {
                //Control de los TextBox
                if (radioButtonDefault.Checked == true)
                {
                    if (txtNombre.Text == "" || txtNickname.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos.", "Advertencia", MessageBoxButtons.OK);
                        txtNombre.Focus();
                    }
                    else
                    {
                        //Iniciando la conexion con el servidor
                        iniciandoConexion();
                    }
                }
                else
                {
                    if (txtNombre.Text == "" || txtNickname.Text == "" || txtDireccion.Text == "" || txtPuerto.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos.", "Advertencia", MessageBoxButtons.OK);
                        txtNombre.Focus();
                    }
                    else
                    {
                        //Iniciando la conexion con el servidor
                        iniciandoConexion();
                    }
                }
            }
            else
            {
                cerrandoConexion("Desconectado por peticion del cliente.");
            }
        }

        //Proceso de envio de mensaje al servidor para su reenvio a los demas clientes
        private void botonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensajeEnviar.Text))
            {
                MessageBox.Show("No se pueden enviar mensajes en blanco", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                enviarMensajeDestino();
                txtMensajeEnviar.Text = "";
                txtMensajeEnviar.Focus();
            }
        }

        private void radioButtonDefault_Click(object sender, EventArgs e)
        {
            //Deshabilitando elementos
            txtDireccion.Enabled = false;
            txtDireccion.Clear();
            txtPuerto.Enabled = false;
            txtPuerto.Clear();
        }

        private void radioButtonManual_Click(object sender, EventArgs e)
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

            //Informando del puerto y de la direccion que puede usarse
            MessageBox.Show("Si elige esta opción tendra que ingresar manualmente la direcció IP y el Puerto." + "\n" +
                 "Esto podria ocasionar que no haya conexión si ingresa mal los parametros." + "\n" +
                 "Se le recomienda ingresar lo siguiente:" + "\n" +
                 "Dirección IP: " + direccionServidor + "\n" +
                 "Puerto: 11000", "ADVERTENCIA.", MessageBoxButtons.OK);
            txtDireccion.Enabled = true;
            txtPuerto.Enabled = true;
        }

        //Cerrando la conexion del Cliente
        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            cerrandoConexion("Cerrando");
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            //Cerrando la aplicacion
            cerrandoAplicacion(sender, e);
        }
    }
}