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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 445);
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
    }
}

