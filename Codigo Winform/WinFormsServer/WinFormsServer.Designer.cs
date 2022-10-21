namespace SignalRChat
{
    partial class WinFormsServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormsServer));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.btnCmd = new System.Windows.Forms.Button();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(13, 13);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(81, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start SignalR";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(234, 12);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(81, 23);
            this.ButtonStop.TabIndex = 0;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.Location = new System.Drawing.Point(13, 75);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(302, 193);
            this.RichTextBoxConsole.TabIndex = 1;
            this.RichTextBoxConsole.Text = "";
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(120, 13);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(81, 23);
            this.btnCmd.TabIndex = 2;
            this.btnCmd.Text = "Start Servidor";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "CHAT - SERVIDOR";
            this.myNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotifyIcon_MouseDoubleClick);
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(13, 42);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(302, 20);
            this.tbServidor.TabIndex = 3;
            this.tbServidor.Text = "http://localhost:53198";
            this.tbServidor.TextChanged += new System.EventHandler(this.tbServidor_TextChanged);
            // 
            // WinFormsServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.tbServidor);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.RichTextBoxConsole);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WinFormsServer";
            this.Text = "WinForms SignalR Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsServer_FormClosing);
            this.Load += new System.EventHandler(this.WinFormsServer_Load);
            this.Move += new System.EventHandler(this.WinFormsServer_Move);
            this.Resize += new System.EventHandler(this.WinFormsServer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.TextBox tbServidor;
    }
}

