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
        }

        private string procesarComando(char ch) { 
            if(ch == 'w'){
                return "Avanzar";
            }
            else if(ch == 's'){
                return "Retroceder";
            }
            else if(ch == 'a'){
                return "Doblar a la izquierda";
            }
            else if(ch == 'd'){
                return "Doblar a la derecha";
            }
            else if(ch == 'r'){
                return "Barrer";
            }
            else if(ch == 'u'){
                return "Posicion de recoleccion";
            }
            else if(ch == 'b'){
                return "Depositar";
            }
            else if (ch == 'p') {
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

       








       
    }
}
