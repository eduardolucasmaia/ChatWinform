using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRChat
{
    /// <summary>
    /// WinForms host for a SignalR server. The host can stop and start the SignalR
    /// server, report errors when trying to start the server on a URI where a
    /// server is already being hosted, and monitor when clients connect and disconnect. 
    /// The hub used in this server is a simple echo service, and has the same 
    /// functionality as the other hubs in the SignalR Getting Started tutorials.
    /// </summary>
    public partial class WinFormsServer : Form
    {
        private IDisposable SignalRMessage { get; set; }
        //const string ServerMessageURI = "http://localhost:53198";
        string ServerMessageURI = "http://localhost:1234";
        private Process process = new Process();

        internal WinFormsServer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calls the StartServer method with Task.Run to not
        /// block the UI thread. 
        /// </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            WriteToConsole("Iniciando Servidor...");
            ButtonStart.Enabled = false;
            Task.Run(() => StartServerMessage());
        }

        /// <summary>
        /// Stops the server and closes the form. Restart functionality omitted
        /// for clarity.
        /// </summary>
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            //SignalR will be disposed in the FormClosing event
            Close();
        }

        /// <summary>
        /// Starts the server and checks for error thrown when another server is already 
        /// running. This method is called asynchronously from Button_Start.
        /// </summary>
        private void StartServerMessage()
        {
            try
            {
                SignalRMessage = WebApp.Start(ServerMessageURI);
            }
            catch (TargetInvocationException)
            {
                WriteToConsole("Servidor Message falhou ao iniciar. Um servidor já está sendo executado " + ServerMessageURI);
                //Re-enable button to let user try to start server again
                this.Invoke((Action)(() => ButtonStart.Enabled = true));
                return;
            }
            this.Invoke((Action)(() => ButtonStop.Enabled = true));
            WriteToConsole("Servidor Message iniciado em " + ServerMessageURI);
        }


        internal void WriteToConsole(String message)
        {
            if (RichTextBoxConsole.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToConsole(message)
                ));
                return;
            }
            RichTextBoxConsole.AppendText(message + Environment.NewLine);
        }

        private void WinFormsServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SignalRMessage != null)
            {
                SignalRMessage.Dispose();
            }

            //Process[] processRunning = Process.GetProcessesByName("NGROK");

            //foreach (Process pr in processRunning)
            //{
            //    pr.Kill();
            //    pr.Close();
            //    pr.Dispose();
            //}
        }

        private void WinFormsServer_Load(object sender, EventArgs e)
        {
            tbServidor.Text = Properties.Settings.Default.ServidorURL;
            ServerMessageURI = Properties.Settings.Default.ServidorURL;
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = System.IO.Directory.GetCurrentDirectory() + "\\NgrokStart - IIS.bat";
                process.StartInfo = startInfo;
                process.Start();
                WriteToConsole("Servidor NGROK iniciado");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível iniciar o servidor NGROK.");
                WriteToConsole("Não foi possível iniciar o servidor NGROK.");
            }
        }

        private void WinFormsServer_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                MinimizeToTray();
            }
        }

        private void MinimizeToTray()
        {
            this.myNotifyIcon.Visible = true;
            this.Hide();
            this.myNotifyIcon.BalloonTipTitle = "Minimizado";
            this.myNotifyIcon.BalloonTipText = "O CHAT - SERVIDOR foi minimizado";
            this.myNotifyIcon.ShowBalloonTip(500);
        }

        private void WinFormsServer_Move(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                MinimizeToTray();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void myNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            myNotifyIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void tbServidor_TextChanged(object sender, EventArgs e)
        {
            ServerMessageURI = tbServidor.Text;
            Properties.Settings.Default.ServidorURL = tbServidor.Text;
            Properties.Settings.Default.Save();

        }
    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }

    public class MyHub : Hub
    {
        public void Send(string name, string message, Color colorLine)
        {
            Clients.Others.addMessage(name, message, colorLine);
        }

        public void Write(string name)
        {
            Clients.Others.addWrite(name);
        }

        public void EnterChat(string name)
        {
            Clients.Others.addEnter(name);
        }

        public void LeaveChat(string name)
        {
            Clients.Others.addLeave(name);
        }

        public override Task OnConnected()
        {
            Clients.Others.addEnter(Context.ConnectionId);
            Program.MainForm.WriteToConsole("Cliente conectado: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected()
        {
            Clients.Others.addLeave(Context.ConnectionId);
            Program.MainForm.WriteToConsole("Cliente disconectado: " + Context.ConnectionId);
            return base.OnDisconnected();
        }
    }
}
