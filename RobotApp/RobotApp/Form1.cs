using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace RobotApp
{
    public partial class Form1 : Form
    {

        
        public const string GIRO_DERECHA = "D";
        public const string GIRO_IZQUIERDA = "I";
        public const string ADELANTE = "F";
        public const string ATRAS = "B";
        public const string OBSTACULO_DERECHA = "OD";
        public const string OBSTACULO_IZQUIERDA = "OI";
        public const string OBSTACULO_TRASERO = "OT";
        public const string RECOGE = "R";
        public const string MOV_RECOGE = "MR";
        public const string DEPOSITA = "B";
        public const string MOV_DEPOSITA = "MB";
        public const string PALA_RECOGE = "U";
        public const string MOV_PALA_RECOGE = "MU";
        public const string POSICIONAR_PALA_ESCOBA = "PPE";
        public const string SOBRECORRIENTE = "SC";

        bool conectado = false;

        

        public Form1()
        {
            InitializeComponent();
        }

        


        private void commandRobot(object sender, KeyPressEventArgs e)
        {
            instrucciones.Text = "";
            instrucciones.Text += Char.ToString(e.KeyChar);
            commandLog.Text += ("Tecla: " + e.KeyChar + "; Comando: "+procesarComando(e.KeyChar) + System.Environment.NewLine);
            commandLog.Update();
            commandLog.SelectionStart = commandLog.Text.Length;
            commandLog.ScrollToCaret();
            procesarRespuesta();
        }

        private string procesarComando(char ch) { 
            if(ch == 'w'){
                serialPort1.WriteLine("w");
                return "Avanzar";
            }
            else if(ch == 's'){
                serialPort1.WriteLine("s");
                return "Retroceder";
            }
            else if(ch == 'a'){
                serialPort1.WriteLine("a");
                return "Doblar a la izquierda";
            }
            else if(ch == 'd'){
                serialPort1.WriteLine("d");
                return "Doblar a la derecha";
            }
            else if(ch == 'r'){
                serialPort1.WriteLine("r");
                return "Barrer";
            }
            else if(ch == 'u'){
                serialPort1.WriteLine("u");
                return "Posicion de recoleccion";
            }
            else if(ch == 'b'){
                serialPort1.WriteLine("b");
                return "Depositar";
            }
            else if (ch == 'p') {
                serialPort1.WriteLine("p");
                return "Parar";
            }
            else
                return "Nulo";
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            if (!conectado)  //Si no esta conectado el puerto, realizar la conexión
            {
                try
                {
                    //Definir los parámetros de la comunicación serial 
                    serialPort1.PortName = comboCOMs.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();  //Abrir la conexión
                    btnConexion.Text = "Cerrar Conexión";
                    conectado = true;
                }
                catch (ArgumentException ex)   // Código que se ejecuta en caso de error
                {
                    MessageBox.Show("Error conexión " + ex.Message);
                    serialPort1.Close(); //Cerrar la conexión
                }
                conectado = true;
            }
            else   //Cerrar conexión.
            {
                btnConexion.Text = "Iniciar Conexión";
                conectado = false;
                if (serialPort1 != null)
                    serialPort1.Close();
            }

        }

        private async void procesarRespuesta() {
            await Task.Delay(500);
            char[] delimitadores = new char[] { ':' }; 
            string[] respuesta = serialPort1.ReadLine().Split(delimitadores);

            //Segun el protocolo: "corriente:llave:valor"

            //Corriente sensada:
            string corriente = respuesta[0];
            //llave
            string llave = respuesta[1];
            //valor
            string valor = respuesta[2];

            logCorriente.Text = ("" + corriente);

            if (llave.Equals(GIRO_DERECHA)) {
                robotLog.Text += ("Giro a la derecha" + System.Environment.NewLine);
            }
            else if (llave.Equals(GIRO_IZQUIERDA))
            {
                robotLog.Text += ("Giro a la izquierda" + System.Environment.NewLine);
            }
            else if (llave.Equals(ADELANTE))
            {
                robotLog.Text += ("Avanza" + System.Environment.NewLine);
            }
            else if (llave.Equals(ATRAS))
            {
                robotLog.Text += ("Retrocede" + System.Environment.NewLine);
            }
            else if (llave.Equals(RECOGE))
            {
                robotLog.Text += ("Barre" + System.Environment.NewLine);
            }
            else if (llave.Equals(MOV_RECOGE))
            {
                robotLog.Text += ("Escoba en posicion de movimiento" + System.Environment.NewLine);
            }
            else if (llave.Equals(DEPOSITA))
            {
                robotLog.Text += ("Deposita" + System.Environment.NewLine);
            }
            else if (llave.Equals(PALA_RECOGE))
            {
                robotLog.Text += ("Pala en posicion de recoger" + System.Environment.NewLine);
            }
            else if (llave.Equals(MOV_DEPOSITA)||llave.Equals(MOV_PALA_RECOGE))
            {
                robotLog.Text += ("Pala en posicion de movimiento" + System.Environment.NewLine);
            }
            else if (llave.Equals(POSICIONAR_PALA_ESCOBA))
            {
                robotLog.Text += ("Posicionar pala y escoba para el movimiento" + System.Environment.NewLine);
            }
            else if (llave.Equals(SOBRECORRIENTE))
            {
                robotLog.Text += ("Corriente excedida, robot bloqueado" + System.Environment.NewLine);
            }
            else if (llave.Equals(OBSTACULO_DERECHA))
            {
                robotLog.Text += ("Obstaculo a la derecha" + System.Environment.NewLine);
            }
            else if (llave.Equals(OBSTACULO_IZQUIERDA))
            {
                robotLog.Text += ("Obstaculo a la izquierda" + System.Environment.NewLine);
            }
            else if (llave.Equals(OBSTACULO_TRASERO))
            {
                robotLog.Text += ("Obstaculo atras" + System.Environment.NewLine);
            }
            

            robotLog.Update();
            robotLog.SelectionStart = commandLog.Text.Length;
            robotLog.ScrollToCaret();
        }

       








       
    }
}
