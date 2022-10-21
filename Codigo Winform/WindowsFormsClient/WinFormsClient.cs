using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class WinFormsClient : MaterialForm
    {
        private bool AvisarNoTray = true;
        private String UserName { get; set; }
        public static Color ColorLine = Color.White;
        private IHubProxy HubMessageProxy { get; set; }
        private Timer timerWrite = new Timer();
        //public static string ServerURI = "http://localhost:53198/signalr";
        public static string ServerURI = "http://localhost:1234/signalr";

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private HubConnection Connection { get; set; }

        internal WinFormsClient()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(334, 321);
            try
            {
                var skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
            catch (Exception)
            {
            }
        }

        private async void ConnectAsync()
        {
            this.Text = "Conectando...";
            Connection = new HubConnection(ServerURI);
            Connection.Closed += Connection_Closed;
            HubMessageProxy = Connection.CreateHubProxy("MyHub");

            HubMessageProxy.On<string, string, Color>("AddMessage", (name, message, color) =>
                this.Invoke((Action)(() => Message(name, message, color)
                ))
            );

            HubMessageProxy.On<string>("addWrite", (name) =>
               this.Invoke((Action)(() => Write(name)
               ))
            );

            HubMessageProxy.On<string>("addEnter", (name) =>
                 this.Invoke((Action)(() => EnterChat(name)
                 ))
            );

            HubMessageProxy.On<string>("addLeave", (name) =>
                 this.Invoke((Action)(() => LeaveChat(name)
                 ))
              );

            try
            {
                await Connection.Start();

            }
            catch (HttpRequestException)
            {
                this.Text = "Não é possível conectar-se ao servidor: Inicie o servidor antes de conectar.";
                return;
            }

            RemoveLoginUI();
            AddChatUI();
            ButtonSend.Enabled = true;
            TextBoxMessage.Focus();
            this.Text = "CHAT - Online";
            try
            {
                //Entrou
                await HubMessageProxy.Invoke("EnterChat", UserName);
            }
            catch (Exception) { }

            if (cbRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = this.UserNameTextBox.Text;
            }
            else
            {
                Properties.Settings.Default.UserName = string.Empty;
            }
            Properties.Settings.Default.RememberMe = cbRememberMe.Checked;
            Properties.Settings.Default.Save();
        }

        private void LeaveChat(string name)
        {
            var texto = String.Format("{0} Saiu do CHAT", name);
            AppendTextMessage(texto, ColorLine, true);
            ExibirBalloonTip(name, texto);
        }

        private void EnterChat(string name)
        {
            var texto = String.Format("{0} Entrou no CHAT", name);
            AppendTextMessage(texto, ColorLine, true);
            ExibirBalloonTip(name, texto);
        }

        private void Message(string name, string message, Color color)
        {
            AppendTextMessage(String.Format("({0}) {1}: {2}" + Environment.NewLine, DateTime.Now.ToShortTimeString(), name, message), color, true);
            ExibirBalloonTip(name, message);
        }

        private void Write(string name)
        {
            this.Text = String.Format("{0} está digitando...", name);
            timerWrite.Enabled = true;
        }

        private void AppendTextMessage(string text, Color color, bool AddNewLine = false)
        {
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }

            RichTextBoxConsole.SelectionStart = RichTextBoxConsole.TextLength;
            RichTextBoxConsole.SelectionLength = 0;

            RichTextBoxConsole.SelectionColor = color;
            RichTextBoxConsole.AppendText(text);
            RichTextBoxConsole.SelectionColor = RichTextBoxConsole.ForeColor;
            RichTextBoxConsole.ScrollToCaret();
        }

        private void Connection_Closed()
        {
            //Deactivate chat UI; show login UI. 
            this.Invoke((Action)(() => RemoveChatUI()));
            this.Invoke((Action)(() => ButtonSend.Enabled = false));
            this.Invoke((Action)(() => this.Text = "Você foi desconectado."));
            this.Invoke((Action)(() => AddLoginUI()));
        }

        #region WINDOWS

        private void ExibirBalloonTip(string title, string message)
        {
            if (Properties.Settings.Default.ExibirNotify)
            {
                var processo = Process.GetProcessesByName("WinFormsClient");

                var processoSecundario = false;

                if (processo.Length > 0)
                {
                    if (processo[0].MainWindowHandle != GetForegroundWindow())
                    {
                        processoSecundario = true;
                    }
                }

                if (FormWindowState.Minimized == this.WindowState || processoSecundario)
                {
                    this.myNotifyIcon.Visible = false;
                    this.myNotifyIcon.Visible = true;
                    this.myNotifyIcon.BalloonTipTitle = title;
                    this.myNotifyIcon.BalloonTipText = message;
                    this.myNotifyIcon.ShowBalloonTip(500);
                    this.myNotifyIcon.BalloonTipClicked += new EventHandler(BalloonTip_Click);
                }
            }
        }


        private void BalloonTip_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                myNotifyIcon.Visible = false;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (!TextBoxMessage.Text.Trim().Equals(string.Empty))
            {
                HubMessageProxy.Invoke("Send", UserName, TextBoxMessage.Text, ColorLine);
                AppendTextMessage(String.Format("({0}) {1}: {2}" + Environment.NewLine, DateTime.Now.ToShortTimeString(), UserName, TextBoxMessage.Text), ColorLine, true);
                TextBoxMessage.Text = String.Empty;
                TextBoxMessage.Focus();
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserName = UserNameTextBox.Text;
            if (!String.IsNullOrEmpty(UserName))
            {
                this.Text = "Connectando ao server...";
                ConnectAsync();
            }
            else
            {
                FormMessageBox.Show("Preencha o campo nome", "Campo Obrigatório");
            }
        }

        private void WinFormsClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.CloseToTray)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    MinimizeToTray();
                    e.Cancel = true;
                }
            }
            else
            {
                if (Connection != null)
                {
                    try
                    {
                        HubMessageProxy.Invoke("LeaveChat", UserName);
                    }
                    catch (Exception) { }

                    Connection.Stop();
                    Connection.Dispose();
                }
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.ShowDialog();
        }

        private void WinFormsClient_Move(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                if (Properties.Settings.Default.MinimizeToTray)
                {
                    MinimizeToTray();
                }
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizeToTray()
        {

            AvisarNoTray = false;
            this.myNotifyIcon.Visible = true;
            this.Hide();
            if (AvisarNoTray)
            {
                this.myNotifyIcon.BalloonTipTitle = "Minimizado";
                this.myNotifyIcon.BalloonTipText = "O CHAT foi minimizado";
                this.myNotifyIcon.ShowBalloonTip(500);
            }
        }

        private void myNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            myNotifyIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void WinFormsClient_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                if (Properties.Settings.Default.MinimizeToTray)
                {
                    MinimizeToTray();
                }
            }
        }

        private void WinFormsClient_Load(object sender, EventArgs e)
        {
            ColorLine = Properties.Settings.Default.ColorLine;
            this.RichTextBoxConsole.BackColor = Properties.Settings.Default.ColorBackground;

            timerWrite.Interval = 3000;
            timerWrite.Enabled = false;
            timerWrite.Tick += new System.EventHandler(UserWrite);

            if (Properties.Settings.Default.RememberMe)
            {
                this.cbRememberMe.Checked = true;
                this.UserNameTextBox.Text = Properties.Settings.Default.UserName;
            }
            ServerURI = Properties.Settings.Default.ServidorURL;
        }

        private void TextBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            HubMessageProxy.Invoke("Write", UserName);
        }

        private void UserWrite(object sender, EventArgs e)
        {
            this.Text = "CHAT - Online";
            timerWrite.Enabled = false;
        }

        private void RemoveLoginUI()
        {
            var size = new System.Drawing.Size(501, 530);
            this.MaximumSize = size;
            this.MinimumSize = size;
            this.Size = size;
            this.btnConfig.Location = new Point(452, 25);
            UserNameTextBox.Visible = false;
            pictureBox1.Visible = false;
            cbRememberMe.Visible = false;
            SignInButton.Visible = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void AddLoginUI()
        {
            var size = new System.Drawing.Size(334, 321);
            this.MaximumSize = size;
            this.MinimumSize = size;
            this.Size = size;
            this.btnConfig.Location = new Point(290, 25);
            UserNameTextBox.Visible = true;
            pictureBox1.Visible = true;
            cbRememberMe.Visible = true;
            SignInButton.Visible = true;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void RemoveChatUI()
        {
            RichTextBoxConsole.Visible = false;
            ButtonSend.Visible = false;
            TextBoxMessage.Visible = false;
        }

        private void AddChatUI()
        {
            RichTextBoxConsole.Visible = true;
            ButtonSend.Visible = true;
            TextBoxMessage.Visible = true;
        }

        #endregion

    }
}
