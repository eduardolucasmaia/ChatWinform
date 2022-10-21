using System;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class FormSettings : Form
    {


        private void Settings_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.cbCloseToTray.Checked = Properties.Settings.Default.CloseToTray;
            this.cbMinimizeToTray.Checked = Properties.Settings.Default.MinimizeToTray;
            this.selectedColor.BackColor = Properties.Settings.Default.ColorLine;
            this.tbServidor.Text = Properties.Settings.Default.ServidorURL;
            this.cbNotify.Checked = Properties.Settings.Default.ExibirNotify;
            this.backgroundColor.BackColor = Properties.Settings.Default.BackgroundColor;
            this.labelExemplo.Font = Properties.Settings.Default.FontLine;
        }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.MinimizeToTray = this.cbMinimizeToTray.Checked;
                Properties.Settings.Default.CloseToTray = this.cbCloseToTray.Checked;
                Properties.Settings.Default.ColorLine = this.selectedColor.BackColor;
                Properties.Settings.Default.BackgroundColor = this.backgroundColor.BackColor;
                Properties.Settings.Default.FontLine = this.labelExemplo.Font;
                Properties.Settings.Default.ServidorURL = this.tbServidor.Text;
                Properties.Settings.Default.ExibirNotify = this.cbNotify.Checked;

                Properties.Settings.Default.Save();
                WinFormsClient.ColorLine = this.selectedColor.BackColor;
                WinFormsClient.ServerURI = this.tbServidor.Text;

                MessageBox.Show("Restart a aplicação para que mude o visual.");

                this.Close();
            }
            catch (Exception)
            {
            }
        }

        private void FormSettings_Move(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnCorLinha_Click(object sender, EventArgs e)
        {
            var colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.selectedColor.BackColor = colorDialog1.Color;

            }
        }

        private void btnCorFundo_Click(object sender, EventArgs e)
        {
            var colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.backgroundColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            var fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                labelExemplo.Font = fontDialog1.Font;
            }

        }
    }
}
