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
            this.ButtonSend = new MaterialSkin.Controls.MaterialFlatButton();
            this.TextBoxMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbRememberMe = new MaterialSkin.Controls.MaterialCheckBox();
            this.SignInButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UserNameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfig = new MaterialSkin.Controls.MaterialRaisedButton();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.BackColor = System.Drawing.Color.Silver;
            this.RichTextBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxConsole.ForeColor = System.Drawing.Color.White;
            this.RichTextBoxConsole.Location = new System.Drawing.Point(12, 67);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(477, 419);
            this.RichTextBoxConsole.TabIndex = 3;
            this.RichTextBoxConsole.Text = "";
            this.RichTextBoxConsole.Visible = false;
            // 
            // ButtonSend
            // 
            this.ButtonSend.AutoSize = true;
            this.ButtonSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSend.Depth = 0;
            this.ButtonSend.Enabled = false;
            this.ButtonSend.Icon = null;
            this.ButtonSend.Location = new System.Drawing.Point(419, 491);
            this.ButtonSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Primary = false;
            this.ButtonSend.Size = new System.Drawing.Size(69, 36);
            this.ButtonSend.TabIndex = 1;
            this.ButtonSend.Text = "Enviar";
            this.ButtonSend.Visible = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Depth = 0;
            this.TextBoxMessage.Hint = "Digite aqui...";
            this.TextBoxMessage.Location = new System.Drawing.Point(12, 495);
            this.TextBoxMessage.MaxLength = 32767;
            this.TextBoxMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.PasswordChar = '\0';
            this.TextBoxMessage.SelectedText = "";
            this.TextBoxMessage.SelectionLength = 0;
            this.TextBoxMessage.SelectionStart = 0;
            this.TextBoxMessage.Size = new System.Drawing.Size(400, 23);
            this.TextBoxMessage.TabIndex = 2;
            this.TextBoxMessage.TabStop = false;
            this.TextBoxMessage.UseSystemPasswordChar = false;
            this.TextBoxMessage.Visible = false;
            this.TextBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMessage_KeyDown);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Depth = 0;
            this.cbRememberMe.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbRememberMe.Location = new System.Drawing.Point(12, 249);
            this.cbRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.cbRememberMe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbRememberMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Ripple = true;
            this.cbRememberMe.Size = new System.Drawing.Size(105, 30);
            this.cbRememberMe.TabIndex = 13;
            this.cbRememberMe.Text = "Lembrar-me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            this.SignInButton.AutoSize = true;
            this.SignInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignInButton.Depth = 0;
            this.SignInButton.Icon = null;
            this.SignInButton.Location = new System.Drawing.Point(261, 252);
            this.SignInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Primary = true;
            this.SignInButton.Size = new System.Drawing.Size(61, 36);
            this.SignInButton.TabIndex = 12;
            this.SignInButton.Text = "LOGIN";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Depth = 0;
            this.UserNameTextBox.Hint = "Nome";
            this.UserNameTextBox.Location = new System.Drawing.Point(12, 223);
            this.UserNameTextBox.MaxLength = 32767;
            this.UserNameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.SelectionLength = 0;
            this.UserNameTextBox.SelectionStart = 0;
            this.UserNameTextBox.Size = new System.Drawing.Size(310, 23);
            this.UserNameTextBox.TabIndex = 11;
            this.UserNameTextBox.TabStop = false;
            this.UserNameTextBox.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormsClient.Properties.Resources.chatlogo;
            this.pictureBox1.Location = new System.Drawing.Point(95, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = true;
            this.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfig.Depth = 0;
            this.btnConfig.Icon = global::WinFormsClient.Properties.Resources.config;
            this.btnConfig.Location = new System.Drawing.Point(290, 25);
            this.btnConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Primary = true;
            this.btnConfig.Size = new System.Drawing.Size(44, 36);
            this.btnConfig.TabIndex = 17;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "CHAT";
            this.myNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotifyIcon_MouseDoubleClick);
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
        private MaterialSkin.Controls.MaterialFlatButton ButtonSend;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxMessage;
        private MaterialSkin.Controls.MaterialCheckBox cbRememberMe;
        private MaterialSkin.Controls.MaterialRaisedButton SignInButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfig;
        private System.Windows.Forms.NotifyIcon myNotifyIcon;
    }
}

