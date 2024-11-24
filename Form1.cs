using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace AccionamientoLineal
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadAvailablePorts();
            btnConectar.Click += ButtonConnect_Click;
        }

        #region Variables
        private SerialPort serialPort;

        #endregion Variables


        // Carga los puertos disponibles en el ComboBox
        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cbxPuertos.Items.AddRange(ports);
        }

        // Evento del botón para conectar al puerto seleccionado
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (cbxPuertos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un puerto antes de conectar.");
                return;
            }

            // Configura el puerto serie
            serialPort = new SerialPort(cbxPuertos.SelectedItem.ToString(), 9600);
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;
            serialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                serialPort.Open();
                MessageBox.Show("Conexión establecida.");
                btnConectar.Enabled = false; // Desactiva el botón de conexión después de conectar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        // Evento que se ejecuta cuando se reciben datos del puerto serie
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();
        }

        // Cierra el puerto cuando el formulario se cierra
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }
    }
}
