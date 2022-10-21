namespace WinFormsClient
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.btnApply = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbCloseToTray = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbMinimizeToTray = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnCorLinha = new MaterialSkin.Controls.MaterialRaisedButton();
            this.selectedColor = new System.Windows.Forms.PictureBox();
            this.tbServidor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbNotify = new MaterialSkin.Controls.MaterialCheckBox();
            this.backgroundColor = new System.Windows.Forms.PictureBox();
            this.btnCorFundo = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Depth = 0;
            this.btnApply.Icon = null;
            this.btnApply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApply.Location = new System.Drawing.Point(528, 307);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.Primary = false;
            this.btnApply.Size = new System.Drawing.Size(77, 36);
            this.btnApply.TabIndex = 113;
            this.btnApply.Text = "Aplicar";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbCloseToTray
            // 
            this.cbCloseToTray.AutoSize = true;
            this.cbCloseToTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbCloseToTray.Depth = 0;
            this.cbCloseToTray.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbCloseToTray.ForeColor = System.Drawing.Color.White;
            this.cbCloseToTray.Location = new System.Drawing.Point(16, 123);
            this.cbCloseToTray.Margin = new System.Windows.Forms.Padding(0);
            this.cbCloseToTray.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbCloseToTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbCloseToTray.Name = "cbCloseToTray";
            this.cbCloseToTray.Ripple = true;
            this.cbCloseToTray.Size = new System.Drawing.Size(387, 30);
            this.cbCloseToTray.TabIndex = 114;
            this.cbCloseToTray.Text = "O botão Fechar minimiza a janela do CHAT para a bandeja";
            this.cbCloseToTray.UseVisualStyleBackColor = false;
            // 
            // cbMinimizeToTray
            // 
            this.cbMinimizeToTray.AutoSize = true;
            this.cbMinimizeToTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbMinimizeToTray.Depth = 0;
            this.cbMinimizeToTray.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbMinimizeToTray.ForeColor = System.Drawing.Color.White;
            this.cbMinimizeToTray.Location = new System.Drawing.Point(16, 93);
            this.cbMinimizeToTray.Margin = new System.Windows.Forms.Padding(0);
            this.cbMinimizeToTray.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbMinimizeToTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbMinimizeToTray.Name = "cbMinimizeToTray";
            this.cbMinimizeToTray.Ripple = true;
            this.cbMinimizeToTray.Size = new System.Drawing.Size(406, 30);
            this.cbMinimizeToTray.TabIndex = 115;
            this.cbMinimizeToTray.Text = "O botão Minimizar minimiza a janela do CHAT para a bandeja";
            this.cbMinimizeToTray.UseVisualStyleBackColor = false;
            // 
            // btnCorLinha
            // 
            this.btnCorLinha.AutoSize = true;
            this.btnCorLinha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCorLinha.Depth = 0;
            this.btnCorLinha.Icon = null;
            this.btnCorLinha.Location = new System.Drawing.Point(16, 186);
            this.btnCorLinha.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCorLinha.Name = "btnCorLinha";
            this.btnCorLinha.Primary = true;
            this.btnCorLinha.Size = new System.Drawing.Size(197, 36);
            this.btnCorLinha.TabIndex = 116;
            this.btnCorLinha.Text = "Selecionar Cor da Linha";
            this.btnCorLinha.UseVisualStyleBackColor = true;
            this.btnCorLinha.Click += new System.EventHandler(this.btnCorLinha_Click);
            // 
            // selectedColor
            // 
            this.selectedColor.BackColor = System.Drawing.Color.White;
            this.selectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColor.Location = new System.Drawing.Point(223, 186);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(36, 36);
            this.selectedColor.TabIndex = 117;
            this.selectedColor.TabStop = false;
            // 
            // tbServidor
            // 
            this.tbServidor.Depth = 0;
            this.tbServidor.Hint = "URL Servidor";
            this.tbServidor.Location = new System.Drawing.Point(86, 315);
            this.tbServidor.MaxLength = 32767;
            this.tbServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.PasswordChar = '\0';
            this.tbServidor.SelectedText = "";
            this.tbServidor.SelectionLength = 0;
            this.tbServidor.SelectionStart = 0;
            this.tbServidor.Size = new System.Drawing.Size(391, 23);
            this.tbServidor.TabIndex = 118;
            this.tbServidor.TabStop = false;
            this.tbServidor.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 315);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 119;
            this.materialLabel1.Text = "Servidor:";
            // 
            // cbNotify
            // 
            this.cbNotify.AutoSize = true;
            this.cbNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbNotify.Depth = 0;
            this.cbNotify.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbNotify.ForeColor = System.Drawing.Color.White;
            this.cbNotify.Location = new System.Drawing.Point(16, 153);
            this.cbNotify.Margin = new System.Windows.Forms.Padding(0);
            this.cbNotify.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbNotify.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Ripple = true;
            this.cbNotify.Size = new System.Drawing.Size(277, 30);
            this.cbNotify.TabIndex = 120;
            this.cbNotify.Text = "Exibir notificações de mensagens novas";
            this.cbNotify.UseVisualStyleBackColor = false;
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.Color.White;
            this.backgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundColor.Location = new System.Drawing.Point(223, 228);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(36, 36);
            this.backgroundColor.TabIndex = 122;
            this.backgroundColor.TabStop = false;
            // 
            // btnCorFundo
            // 
            this.btnCorFundo.AutoSize = true;
            this.btnCorFundo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCorFundo.Depth = 0;
            this.btnCorFundo.Icon = null;
            this.btnCorFundo.Location = new System.Drawing.Point(16, 228);
            this.btnCorFundo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCorFundo.Name = "btnCorFundo";
            this.btnCorFundo.Primary = true;
            this.btnCorFundo.Size = new System.Drawing.Size(201, 36);
            this.btnCorFundo.TabIndex = 121;
            this.btnCorFundo.Text = "Selecionar Cor de Fundo";
            this.btnCorFundo.UseVisualStyleBackColor = true;
            this.btnCorFundo.Click += new System.EventHandler(this.btnCorFundo_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 358);
            this.Controls.Add(this.backgroundColor);
            this.Controls.Add(this.btnCorFundo);
            this.Controls.Add(this.cbNotify);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbServidor);
            this.Controls.Add(this.selectedColor);
            this.Controls.Add(this.btnCorLinha);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbMinimizeToTray);
            this.Controls.Add(this.cbCloseToTray);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Move += new System.EventHandler(this.FormSettings_Move);
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnApply;
        private MaterialSkin.Controls.MaterialCheckBox cbCloseToTray;
        private MaterialSkin.Controls.MaterialCheckBox cbMinimizeToTray;
        private MaterialSkin.Controls.MaterialRaisedButton btnCorLinha;
        private System.Windows.Forms.PictureBox selectedColor;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbServidor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox cbNotify;
        private System.Windows.Forms.PictureBox backgroundColor;
        private MaterialSkin.Controls.MaterialRaisedButton btnCorFundo;
    }
}