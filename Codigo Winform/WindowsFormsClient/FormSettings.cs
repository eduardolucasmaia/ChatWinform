using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class FormSettings : MaterialForm
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
            this.backgroundColor.BackColor = Properties.Settings.Default.ColorBackground;
        }

        public FormSettings()
        {
            InitializeComponent();

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

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.MinimizeToTray = this.cbMinimizeToTray.Checked;
                Properties.Settings.Default.CloseToTray = this.cbCloseToTray.Checked;
                Properties.Settings.Default.ColorLine = this.selectedColor.BackColor;
                Properties.Settings.Default.ColorBackground = this.backgroundColor.BackColor;
                Properties.Settings.Default.ServidorURL = this.tbServidor.Text;
                Properties.Settings.Default.ExibirNotify = this.cbNotify.Checked;
                Properties.Settings.Default.Save();
                WinFormsClient.ColorLine = this.selectedColor.BackColor;
                WinFormsClient.ServerURI = this.tbServidor.Text;

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
    }
}
