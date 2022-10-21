namespace WinFormsClient
{
    partial class WinFormsClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormsClient));
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxConsole.Location = new System.Drawing.Point(12, 38);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(477, 451);
            this.RichTextBoxConsole.TabIndex = 3;
            this.RichTextBoxConsole.Text = "";
            this.RichTextBoxConsole.Visible = false;
            // 
            // ButtonSend
            // 
            this.ButtonSend.AutoSize = true;
            this.ButtonSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSend.Enabled = false;
            this.ButtonSend.Location = new System.Drawing.Point(442, 498);
            this.ButtonSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(47, 23);
            this.ButtonSend.TabIndex = 1;
            this.ButtonSend.Text = "Enviar";
            this.ButtonSend.Visible = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(12, 498);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(423, 20);
            this.TextBoxMessage.TabIndex = 2;
            this.TextBoxMessage.TabStop = false;
            this.TextBoxMessage.Visible = false;
            this.TextBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMessage_KeyDown);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbRememberMe.Location = new System.Drawing.Point(12, 229);
            this.cbRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(104, 21);
            this.cbRememberMe.TabIndex = 13;
            this.cbRememberMe.Text = "Lembrar-me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            this.SignInButton.AutoSize = true;
            this.SignInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignInButton.Location = new System.Drawing.Point(272, 227);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(50, 23);
            this.SignInButton.TabIndex = 12;
            this.SignInButton.Text = "LOGIN";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(12, 201);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(310, 20);
            this.UserNameTextBox.TabIndex = 11;
            this.UserNameTextBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormsClient.Properties.Resources.chatlogo;
            this.pictureBox1.Location = new System.Drawing.Point(95, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "CHAT";
            this.myNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotifyIcon_MouseDoubleClick);
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = true;
            this.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfig.Location = new System.Drawing.Point(265, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(57, 23);
            this.btnConfig.TabIndex = 18;
            this.btnConfig.Text = "CONFIG";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // WinFormsClient
            // 
            this.AcceptButton = this.ButtonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 530);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.RichTextBoxConsole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.UserNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WinFormsClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
            this.Load += new System.EventHandler(this.WinFormsClient_Load);
            this.Move += new System.EventHandler(this.WinFormsClient_Move);
            this.Resize += new System.EventHandler(this.WinFormsClient_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.Button btnConfig;
    }
}

