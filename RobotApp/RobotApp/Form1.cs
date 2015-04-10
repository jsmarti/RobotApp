using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotApp
{
    public partial class Form1 : Form
    {
       
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

       








       
    }
}
