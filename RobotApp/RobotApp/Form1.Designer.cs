namespace RobotApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.commandLog = new System.Windows.Forms.TextBox();
            this.robotLog = new System.Windows.Forms.TextBox();
            this.labelComandos = new System.Windows.Forms.Label();
            this.labelRobot = new System.Windows.Forms.Label();
            this.labelCorriente = new System.Windows.Forms.Label();
            this.logCorriente = new System.Windows.Forms.TextBox();
            this.labelDeposita = new System.Windows.Forms.Label();
            this.labelRecoge = new System.Windows.Forms.Label();
            this.labelBarre = new System.Windows.Forms.Label();
            this.instrucciones = new System.Windows.Forms.TextBox();
            this.labelInstrucciones = new System.Windows.Forms.Label();
            this.btnConexion = new System.Windows.Forms.Button();
            this.comboCOMs = new System.Windows.Forms.ComboBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.botones = new System.Windows.Forms.PictureBox();
            this.azulBarre = new System.Windows.Forms.PictureBox();
            this.azulRecoge = new System.Windows.Forms.PictureBox();
            this.azulDeposita = new System.Windows.Forms.PictureBox();
            this.verdeBarre = new System.Windows.Forms.PictureBox();
            this.verdeDeposita = new System.Windows.Forms.PictureBox();
            this.verdeRecoge = new System.Windows.Forms.PictureBox();
            this.verdeSensorTrasero = new System.Windows.Forms.PictureBox();
            this.verdeSensorDerecho = new System.Windows.Forms.PictureBox();
            this.verdeSensorIzquierdo = new System.Windows.Forms.PictureBox();
            this.rojoSensorTrasero = new System.Windows.Forms.PictureBox();
            this.rojoSensorDerecho = new System.Windows.Forms.PictureBox();
            this.rojoSensorIzquierdo = new System.Windows.Forms.PictureBox();
            this.verdePila = new System.Windows.Forms.PictureBox();
            this.rojoPila = new System.Windows.Forms.PictureBox();
            this.imgRobot = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.logVelocidad = new System.Windows.Forms.TextBox();
            this.labelVelocidadPWM = new System.Windows.Forms.Label();
            this.logVelocidadPwm = new System.Windows.Forms.TextBox();
            this.labelVelocidades = new System.Windows.Forms.Label();
            this.labelVelocidadBaja = new System.Windows.Forms.Label();
            this.labelVelocidadMedia = new System.Windows.Forms.Label();
            this.labelVelocidadAlta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.botones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulBarre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulRecoge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulDeposita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeBarre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeDeposita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeRecoge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeSensorTrasero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeSensorDerecho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeSensorIzquierdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoSensorTrasero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoSensorDerecho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoSensorIzquierdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // commandLog
            // 
            this.commandLog.AcceptsReturn = true;
            this.commandLog.Location = new System.Drawing.Point(589, 50);
            this.commandLog.Multiline = true;
            this.commandLog.Name = "commandLog";
            this.commandLog.ReadOnly = true;
            this.commandLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commandLog.Size = new System.Drawing.Size(309, 118);
            this.commandLog.TabIndex = 0;
            // 
            // robotLog
            // 
            this.robotLog.AcceptsReturn = true;
            this.robotLog.Location = new System.Drawing.Point(589, 197);
            this.robotLog.Multiline = true;
            this.robotLog.Name = "robotLog";
            this.robotLog.ReadOnly = true;
            this.robotLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.robotLog.Size = new System.Drawing.Size(309, 118);
            this.robotLog.TabIndex = 1;
            // 
            // labelComandos
            // 
            this.labelComandos.AutoSize = true;
            this.labelComandos.Location = new System.Drawing.Point(586, 34);
            this.labelComandos.Name = "labelComandos";
            this.labelComandos.Size = new System.Drawing.Size(96, 13);
            this.labelComandos.TabIndex = 2;
            this.labelComandos.Text = "Log de Comandos:";
            // 
            // labelRobot
            // 
            this.labelRobot.AutoSize = true;
            this.labelRobot.Location = new System.Drawing.Point(586, 181);
            this.labelRobot.Name = "labelRobot";
            this.labelRobot.Size = new System.Drawing.Size(77, 13);
            this.labelRobot.TabIndex = 3;
            this.labelRobot.Text = "Log del Robot:";
            // 
            // labelCorriente
            // 
            this.labelCorriente.AutoSize = true;
            this.labelCorriente.Location = new System.Drawing.Point(13, 349);
            this.labelCorriente.Name = "labelCorriente";
            this.labelCorriente.Size = new System.Drawing.Size(52, 13);
            this.labelCorriente.TabIndex = 4;
            this.labelCorriente.Text = "Corriente:";
            // 
            // logCorriente
            // 
            this.logCorriente.Location = new System.Drawing.Point(108, 346);
            this.logCorriente.Name = "logCorriente";
            this.logCorriente.ReadOnly = true;
            this.logCorriente.Size = new System.Drawing.Size(63, 20);
            this.logCorriente.TabIndex = 5;
            // 
            // labelDeposita
            // 
            this.labelDeposita.AutoSize = true;
            this.labelDeposita.Location = new System.Drawing.Point(13, 32);
            this.labelDeposita.Name = "labelDeposita";
            this.labelDeposita.Size = new System.Drawing.Size(52, 13);
            this.labelDeposita.TabIndex = 23;
            this.labelDeposita.Text = "Deposita:";
            // 
            // labelRecoge
            // 
            this.labelRecoge.AutoSize = true;
            this.labelRecoge.Location = new System.Drawing.Point(13, 63);
            this.labelRecoge.Name = "labelRecoge";
            this.labelRecoge.Size = new System.Drawing.Size(48, 13);
            this.labelRecoge.TabIndex = 24;
            this.labelRecoge.Text = "Recoge:";
            // 
            // labelBarre
            // 
            this.labelBarre.AutoSize = true;
            this.labelBarre.Location = new System.Drawing.Point(155, 63);
            this.labelBarre.Name = "labelBarre";
            this.labelBarre.Size = new System.Drawing.Size(35, 13);
            this.labelBarre.TabIndex = 25;
            this.labelBarre.Text = ":Barre";
            // 
            // instrucciones
            // 
            this.instrucciones.Location = new System.Drawing.Point(372, 63);
            this.instrucciones.Name = "instrucciones";
            this.instrucciones.Size = new System.Drawing.Size(80, 20);
            this.instrucciones.TabIndex = 26;
            this.instrucciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandRobot);
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.AutoSize = true;
            this.labelInstrucciones.Location = new System.Drawing.Point(293, 66);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(73, 13);
            this.labelInstrucciones.TabIndex = 27;
            this.labelInstrucciones.Text = "Instrucciones:";
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(698, 336);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(93, 26);
            this.btnConexion.TabIndex = 28;
            this.btnConexion.Text = "Iniciar Conexión";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // comboCOMs
            // 
            this.comboCOMs.FormattingEnabled = true;
            this.comboCOMs.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.comboCOMs.Location = new System.Drawing.Point(591, 341);
            this.comboCOMs.Name = "comboCOMs";
            this.comboCOMs.Size = new System.Drawing.Size(84, 21);
            this.comboCOMs.TabIndex = 29;
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(588, 325);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(41, 13);
            this.labelPuerto.TabIndex = 30;
            this.labelPuerto.Text = "Puerto:";
            // 
            // botones
            // 
            this.botones.Image = global::RobotApp.Properties.Resources.Botones;
            this.botones.Location = new System.Drawing.Point(219, 94);
            this.botones.Name = "botones";
            this.botones.Size = new System.Drawing.Size(341, 193);
            this.botones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botones.TabIndex = 34;
            this.botones.TabStop = false;
            // 
            // azulBarre
            // 
            this.azulBarre.Image = global::RobotApp.Properties.Resources.azul;
            this.azulBarre.Location = new System.Drawing.Point(122, 63);
            this.azulBarre.Name = "azulBarre";
            this.azulBarre.Size = new System.Drawing.Size(31, 25);
            this.azulBarre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.azulBarre.TabIndex = 33;
            this.azulBarre.TabStop = false;
            this.azulBarre.Visible = false;
            // 
            // azulRecoge
            // 
            this.azulRecoge.Image = global::RobotApp.Properties.Resources.azul;
            this.azulRecoge.Location = new System.Drawing.Point(67, 63);
            this.azulRecoge.Name = "azulRecoge";
            this.azulRecoge.Size = new System.Drawing.Size(31, 25);
            this.azulRecoge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.azulRecoge.TabIndex = 32;
            this.azulRecoge.TabStop = false;
            this.azulRecoge.Visible = false;
            // 
            // azulDeposita
            // 
            this.azulDeposita.Image = global::RobotApp.Properties.Resources.azul;
            this.azulDeposita.Location = new System.Drawing.Point(67, 20);
            this.azulDeposita.Name = "azulDeposita";
            this.azulDeposita.Size = new System.Drawing.Size(31, 25);
            this.azulDeposita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.azulDeposita.TabIndex = 31;
            this.azulDeposita.TabStop = false;
            this.azulDeposita.Visible = false;
            // 
            // verdeBarre
            // 
            this.verdeBarre.Image = global::RobotApp.Properties.Resources.verde;
            this.verdeBarre.Location = new System.Drawing.Point(122, 63);
            this.verdeBarre.Name = "verdeBarre";
            this.verdeBarre.Size = new System.Drawing.Size(31, 25);
            this.verdeBarre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verdeBarre.TabIndex = 22;
            this.verdeBarre.TabStop = false;
            // 
            // verdeDeposita
            // 
            this.verdeDeposita.Image = global::RobotApp.Properties.Resources.verde;
            this.verdeDeposita.Location = new System.Drawing.Point(67, 20);
            this.verdeDeposita.Name = "verdeDeposita";
            this.verdeDeposita.Size = new System.Drawing.Size(31, 25);
            this.verdeDeposita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verdeDeposita.TabIndex = 20;
            this.verdeDeposita.TabStop = false;
            // 
            // verdeRecoge
            // 
            this.verdeRecoge.Image = global::RobotApp.Properties.Resources.verde;
            this.verdeRecoge.Location = new System.Drawing.Point(67, 63);
            this.verdeRecoge.Name = "verdeRecoge";
            this.verdeRecoge.Size = new System.Drawing.Size(31, 25);
            this.verdeRecoge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verdeRecoge.TabIndex = 19;
            this.verdeRecoge.TabStop = false;
            // 
            // verdeSensorTrasero
            // 
            this.verdeSensorTrasero.Image = global::RobotApp.Properties.Resources.verde;
            this.verdeSensorTrasero.Location = new System.Drawing.Point(88, 305);
            this.verdeSensorTrasero.Name = "verdeSensorTrasero";
            this.verdeSensorTrasero.Size = new System.Drawing.Size(31, 25);
            this.verdeSensorTrasero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verdeSensorTrasero.TabIndex = 15;
            this.verdeSensorTrasero.TabStop = false;
            // 
            // verdeSensorDerecho
            // 
            this.verdeSensorDerecho.Image = global::RobotApp.Properties.Resources.verde;
            this.verdeSensorDerecho.Location = new System.Drawing.Point(159, 226);
            this.verdeSensorDerecho.Name = "verdeSensorDerecho";
            this.verdeSensorDerecho.Size = new System.Drawing.Size(31, 25);
            this.verdeSensorDerecho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verdeSensorDerecho.TabIndex = 14;
            this.verdeSensorDerecho.TabStop = false;
            // 
            // verdeSensorIzquierdo
            // 
            this.verdeSensorIzquierdo.Image = global::RobotApp.Properties.Resources.verde;
            this.verdeSensorIzquierdo.Location = new System.Drawing.Point(16, 226);
            this.verdeSensorIzquierdo.Name = "verdeSensorIzquierdo";
            this.verdeSensorIzquierdo.Size = new System.Drawing.Size(31, 25);
            this.verdeSensorIzquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verdeSensorIzquierdo.TabIndex = 13;
            this.verdeSensorIzquierdo.TabStop = false;
            // 
            // rojoSensorTrasero
            // 
            this.rojoSensorTrasero.Image = global::RobotApp.Properties.Resources.rojo;
            this.rojoSensorTrasero.Location = new System.Drawing.Point(88, 305);
            this.rojoSensorTrasero.Name = "rojoSensorTrasero";
            this.rojoSensorTrasero.Size = new System.Drawing.Size(31, 25);
            this.rojoSensorTrasero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rojoSensorTrasero.TabIndex = 12;
            this.rojoSensorTrasero.TabStop = false;
            this.rojoSensorTrasero.Visible = false;
            // 
            // rojoSensorDerecho
            // 
            this.rojoSensorDerecho.Image = global::RobotApp.Properties.Resources.rojo;
            this.rojoSensorDerecho.Location = new System.Drawing.Point(159, 226);
            this.rojoSensorDerecho.Name = "rojoSensorDerecho";
            this.rojoSensorDerecho.Size = new System.Drawing.Size(31, 25);
            this.rojoSensorDerecho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rojoSensorDerecho.TabIndex = 11;
            this.rojoSensorDerecho.TabStop = false;
            this.rojoSensorDerecho.Visible = false;
            // 
            // rojoSensorIzquierdo
            // 
            this.rojoSensorIzquierdo.Image = global::RobotApp.Properties.Resources.rojo;
            this.rojoSensorIzquierdo.Location = new System.Drawing.Point(16, 226);
            this.rojoSensorIzquierdo.Name = "rojoSensorIzquierdo";
            this.rojoSensorIzquierdo.Size = new System.Drawing.Size(31, 25);
            this.rojoSensorIzquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rojoSensorIzquierdo.TabIndex = 10;
            this.rojoSensorIzquierdo.TabStop = false;
            this.rojoSensorIzquierdo.Visible = false;
            // 
            // verdePila
            // 
            this.verdePila.Image = global::RobotApp.Properties.Resources.verde;
            this.verdePila.Location = new System.Drawing.Point(88, 196);
            this.verdePila.Name = "verdePila";
            this.verdePila.Size = new System.Drawing.Size(31, 25);
            this.verdePila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verdePila.TabIndex = 8;
            this.verdePila.TabStop = false;
            // 
            // rojoPila
            // 
            this.rojoPila.Image = global::RobotApp.Properties.Resources.rojo;
            this.rojoPila.Location = new System.Drawing.Point(88, 196);
            this.rojoPila.Name = "rojoPila";
            this.rojoPila.Size = new System.Drawing.Size(31, 25);
            this.rojoPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rojoPila.TabIndex = 7;
            this.rojoPila.TabStop = false;
            this.rojoPila.Visible = false;
            // 
            // imgRobot
            // 
            this.imgRobot.Image = global::RobotApp.Properties.Resources.robotd;
            this.imgRobot.Location = new System.Drawing.Point(53, 94);
            this.imgRobot.Name = "imgRobot";
            this.imgRobot.Size = new System.Drawing.Size(100, 208);
            this.imgRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgRobot.TabIndex = 6;
            this.imgRobot.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 35;
            this.button1.Text = "Limpiar Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.limpiarLogs);
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Location = new System.Drawing.Point(11, 375);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(91, 13);
            this.labelVelocidad.TabIndex = 36;
            this.labelVelocidad.Text = "Velocidad [rad/s]:";
            // 
            // logVelocidad
            // 
            this.logVelocidad.Location = new System.Drawing.Point(108, 372);
            this.logVelocidad.Name = "logVelocidad";
            this.logVelocidad.ReadOnly = true;
            this.logVelocidad.Size = new System.Drawing.Size(63, 20);
            this.logVelocidad.TabIndex = 37;
            // 
            // labelVelocidadPWM
            // 
            this.labelVelocidadPWM.AutoSize = true;
            this.labelVelocidadPWM.Location = new System.Drawing.Point(11, 405);
            this.labelVelocidadPWM.Name = "labelVelocidadPWM";
            this.labelVelocidadPWM.Size = new System.Drawing.Size(88, 13);
            this.labelVelocidadPWM.TabIndex = 38;
            this.labelVelocidadPWM.Text = "Velocidad [pwm]:";
            // 
            // logVelocidadPwm
            // 
            this.logVelocidadPwm.Location = new System.Drawing.Point(108, 402);
            this.logVelocidadPwm.Name = "logVelocidadPwm";
            this.logVelocidadPwm.ReadOnly = true;
            this.logVelocidadPwm.Size = new System.Drawing.Size(63, 20);
            this.logVelocidadPwm.TabIndex = 39;
            // 
            // labelVelocidades
            // 
            this.labelVelocidades.AutoSize = true;
            this.labelVelocidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidades.Location = new System.Drawing.Point(230, 305);
            this.labelVelocidades.Name = "labelVelocidades";
            this.labelVelocidades.Size = new System.Drawing.Size(136, 25);
            this.labelVelocidades.TabIndex = 40;
            this.labelVelocidades.Text = "Velocidades:";
            // 
            // labelVelocidadBaja
            // 
            this.labelVelocidadBaja.AutoSize = true;
            this.labelVelocidadBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidadBaja.Location = new System.Drawing.Point(230, 337);
            this.labelVelocidadBaja.Name = "labelVelocidadBaja";
            this.labelVelocidadBaja.Size = new System.Drawing.Size(180, 25);
            this.labelVelocidadBaja.TabIndex = 41;
            this.labelVelocidadBaja.Text = "Velocidad Baja: 1";
            // 
            // labelVelocidadMedia
            // 
            this.labelVelocidadMedia.AutoSize = true;
            this.labelVelocidadMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidadMedia.Location = new System.Drawing.Point(230, 366);
            this.labelVelocidadMedia.Name = "labelVelocidadMedia";
            this.labelVelocidadMedia.Size = new System.Drawing.Size(196, 25);
            this.labelVelocidadMedia.TabIndex = 42;
            this.labelVelocidadMedia.Text = "Velocidad Media: 2";
            // 
            // labelVelocidadAlta
            // 
            this.labelVelocidadAlta.AutoSize = true;
            this.labelVelocidadAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidadAlta.Location = new System.Drawing.Point(230, 393);
            this.labelVelocidadAlta.Name = "labelVelocidadAlta";
            this.labelVelocidadAlta.Size = new System.Drawing.Size(174, 25);
            this.labelVelocidadAlta.TabIndex = 43;
            this.labelVelocidadAlta.Text = "Velocidad Alta: 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 427);
            this.Controls.Add(this.labelVelocidadAlta);
            this.Controls.Add(this.labelVelocidadMedia);
            this.Controls.Add(this.labelVelocidadBaja);
            this.Controls.Add(this.labelVelocidades);
            this.Controls.Add(this.logVelocidadPwm);
            this.Controls.Add(this.labelVelocidadPWM);
            this.Controls.Add(this.logVelocidad);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botones);
            this.Controls.Add(this.azulBarre);
            this.Controls.Add(this.azulRecoge);
            this.Controls.Add(this.azulDeposita);
            this.Controls.Add(this.labelPuerto);
            this.Controls.Add(this.comboCOMs);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.instrucciones);
            this.Controls.Add(this.labelBarre);
            this.Controls.Add(this.labelRecoge);
            this.Controls.Add(this.labelDeposita);
            this.Controls.Add(this.verdeBarre);
            this.Controls.Add(this.verdeDeposita);
            this.Controls.Add(this.verdeRecoge);
            this.Controls.Add(this.verdeSensorTrasero);
            this.Controls.Add(this.verdeSensorDerecho);
            this.Controls.Add(this.verdeSensorIzquierdo);
            this.Controls.Add(this.rojoSensorTrasero);
            this.Controls.Add(this.rojoSensorDerecho);
            this.Controls.Add(this.rojoSensorIzquierdo);
            this.Controls.Add(this.verdePila);
            this.Controls.Add(this.rojoPila);
            this.Controls.Add(this.imgRobot);
            this.Controls.Add(this.logCorriente);
            this.Controls.Add(this.labelCorriente);
            this.Controls.Add(this.labelRobot);
            this.Controls.Add(this.labelComandos);
            this.Controls.Add(this.robotLog);
            this.Controls.Add(this.commandLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RobotApp";
            ((System.ComponentModel.ISupportInitialize)(this.botones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulBarre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulRecoge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulDeposita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeBarre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeDeposita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeRecoge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeSensorTrasero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeSensorDerecho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeSensorIzquierdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoSensorTrasero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoSensorDerecho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoSensorIzquierdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRobot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox commandLog;
        private System.Windows.Forms.TextBox robotLog;
        private System.Windows.Forms.Label labelComandos;
        private System.Windows.Forms.Label labelRobot;
        private System.Windows.Forms.Label labelCorriente;
        private System.Windows.Forms.TextBox logCorriente;
        private System.Windows.Forms.PictureBox imgRobot;
        private System.Windows.Forms.PictureBox rojoPila;
        private System.Windows.Forms.PictureBox verdePila;
        private System.Windows.Forms.PictureBox rojoSensorIzquierdo;
        private System.Windows.Forms.PictureBox rojoSensorDerecho;
        private System.Windows.Forms.PictureBox rojoSensorTrasero;
        private System.Windows.Forms.PictureBox verdeSensorIzquierdo;
        private System.Windows.Forms.PictureBox verdeSensorDerecho;
        private System.Windows.Forms.PictureBox verdeSensorTrasero;
        private System.Windows.Forms.PictureBox verdeRecoge;
        private System.Windows.Forms.PictureBox verdeDeposita;
        private System.Windows.Forms.PictureBox verdeBarre;
        private System.Windows.Forms.Label labelDeposita;
        private System.Windows.Forms.Label labelRecoge;
        private System.Windows.Forms.Label labelBarre;
        private System.Windows.Forms.TextBox instrucciones;
        private System.Windows.Forms.Label labelInstrucciones;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.ComboBox comboCOMs;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.PictureBox azulDeposita;
        private System.Windows.Forms.PictureBox azulRecoge;
        private System.Windows.Forms.PictureBox azulBarre;
        private System.Windows.Forms.PictureBox botones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.TextBox logVelocidad;
        private System.Windows.Forms.Label labelVelocidadPWM;
        private System.Windows.Forms.TextBox logVelocidadPwm;
        private System.Windows.Forms.Label labelVelocidades;
        private System.Windows.Forms.Label labelVelocidadBaja;
        private System.Windows.Forms.Label labelVelocidadMedia;
        private System.Windows.Forms.Label labelVelocidadAlta;
    }
}

