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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.commandLog = new System.Windows.Forms.TextBox();
            this.robotLog = new System.Windows.Forms.TextBox();
            this.labelComandos = new System.Windows.Forms.Label();
            this.labelRobot = new System.Windows.Forms.Label();
            this.labelCorriente = new System.Windows.Forms.Label();
            this.logCorriente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // commandLog
            // 
            this.commandLog.Location = new System.Drawing.Point(589, 50);
            this.commandLog.Multiline = true;
            this.commandLog.Name = "commandLog";
            this.commandLog.Size = new System.Drawing.Size(309, 118);
            this.commandLog.TabIndex = 0;
            // 
            // robotLog
            // 
            this.robotLog.Location = new System.Drawing.Point(589, 197);
            this.robotLog.Multiline = true;
            this.robotLog.Name = "robotLog";
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
            this.labelCorriente.Location = new System.Drawing.Point(586, 337);
            this.labelCorriente.Name = "labelCorriente";
            this.labelCorriente.Size = new System.Drawing.Size(52, 13);
            this.labelCorriente.TabIndex = 4;
            this.labelCorriente.Text = "Corriente:";
            // 
            // logCorriente
            // 
            this.logCorriente.Location = new System.Drawing.Point(589, 359);
            this.logCorriente.Name = "logCorriente";
            this.logCorriente.Size = new System.Drawing.Size(63, 20);
            this.logCorriente.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 445);
            this.Controls.Add(this.logCorriente);
            this.Controls.Add(this.labelCorriente);
            this.Controls.Add(this.labelRobot);
            this.Controls.Add(this.labelComandos);
            this.Controls.Add(this.robotLog);
            this.Controls.Add(this.commandLog);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

