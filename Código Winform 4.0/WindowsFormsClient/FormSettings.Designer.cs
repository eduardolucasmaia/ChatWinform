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
            this.btnApply = new System.Windows.Forms.Button();
            this.cbCloseToTray = new System.Windows.Forms.CheckBox();
            this.cbMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.btnCorLinha = new System.Windows.Forms.Button();
            this.selectedColor = new System.Windows.Forms.PictureBox();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.cbNotify = new System.Windows.Forms.CheckBox();
            this.backgroundColor = new System.Windows.Forms.PictureBox();
            this.btnCorFundo = new System.Windows.Forms.Button();
            this.btnFonte = new System.Windows.Forms.Button();
            this.labelExemplo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApply.Location = new System.Drawing.Point(377, 203);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(49, 23);
            this.btnApply.TabIndex = 113;
            this.btnApply.Text = "Aplicar";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbCloseToTray
            // 
            this.cbCloseToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbCloseToTray.Location = new System.Drawing.Point(9, 39);
            this.cbCloseToTray.Margin = new System.Windows.Forms.Padding(0);
            this.cbCloseToTray.Name = "cbCloseToTray";
            this.cbCloseToTray.Size = new System.Drawing.Size(417, 30);
            this.cbCloseToTray.TabIndex = 114;
            this.cbCloseToTray.Text = "O botão Fechar minimiza a janela do CHAT para a bandeja";
            this.cbCloseToTray.UseVisualStyleBackColor = false;
            // 
            // cbMinimizeToTray
            // 
            this.cbMinimizeToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMinimizeToTray.Location = new System.Drawing.Point(9, 9);
            this.cbMinimizeToTray.Margin = new System.Windows.Forms.Padding(0);
            this.cbMinimizeToTray.Name = "cbMinimizeToTray";
            this.cbMinimizeToTray.Size = new System.Drawing.Size(417, 30);
            this.cbMinimizeToTray.TabIndex = 115;
            this.cbMinimizeToTray.Text = "O botão Minimizar minimiza a janela do CHAT para a bandeja";
            this.cbMinimizeToTray.UseVisualStyleBackColor = false;
            // 
            // btnCorLinha
            // 
            this.btnCorLinha.AutoSize = true;
            this.btnCorLinha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCorLinha.Location = new System.Drawing.Point(16, 132);
            this.btnCorLinha.Name = "btnCorLinha";
            this.btnCorLinha.Size = new System.Drawing.Size(77, 23);
            this.btnCorLinha.TabIndex = 116;
            this.btnCorLinha.Text = "Cor da Linha";
            this.btnCorLinha.UseVisualStyleBackColor = true;
            this.btnCorLinha.Click += new System.EventHandler(this.btnCorLinha_Click);
            // 
            // selectedColor
            // 
            this.selectedColor.BackColor = System.Drawing.Color.White;
            this.selectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColor.Location = new System.Drawing.Point(99, 132);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(24, 24);
            this.selectedColor.TabIndex = 117;
            this.selectedColor.TabStop = false;
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(79, 203);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(237, 20);
            this.tbServidor.TabIndex = 118;
            this.tbServidor.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 202);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 18);
            this.materialLabel1.TabIndex = 119;
            this.materialLabel1.Text = "Servidor:";
            // 
            // cbNotify
            // 
            this.cbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbNotify.Location = new System.Drawing.Point(9, 69);
            this.cbNotify.Margin = new System.Windows.Forms.Padding(0);
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Size = new System.Drawing.Size(417, 30);
            this.cbNotify.TabIndex = 120;
            this.cbNotify.Text = "Exibir notificações de mensagens novas";
            this.cbNotify.UseVisualStyleBackColor = false;
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.Color.White;
            this.backgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundColor.Location = new System.Drawing.Point(99, 103);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(24, 24);
            this.backgroundColor.TabIndex = 122;
            this.backgroundColor.TabStop = false;
            // 
            // btnCorFundo
            // 
            this.btnCorFundo.AutoSize = true;
            this.btnCorFundo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCorFundo.Location = new System.Drawing.Point(12, 103);
            this.btnCorFundo.Name = "btnCorFundo";
            this.btnCorFundo.Size = new System.Drawing.Size(81, 23);
            this.btnCorFundo.TabIndex = 121;
            this.btnCorFundo.Text = "Cor do Fundo";
            this.btnCorFundo.UseVisualStyleBackColor = true;
            this.btnCorFundo.Click += new System.EventHandler(this.btnCorFundo_Click);
            // 
            // btnFonte
            // 
            this.btnFonte.AutoSize = true;
            this.btnFonte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFonte.Location = new System.Drawing.Point(5, 161);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(88, 23);
            this.btnFonte.TabIndex = 123;
            this.btnFonte.Text = "Fonte da Linha";
            this.btnFonte.UseVisualStyleBackColor = true;
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // labelExemplo
            // 
            this.labelExemplo.AutoSize = true;
            this.labelExemplo.Location = new System.Drawing.Point(99, 166);
            this.labelExemplo.Name = "labelExemplo";
            this.labelExemplo.Size = new System.Drawing.Size(162, 13);
            this.labelExemplo.TabIndex = 124;
            this.labelExemplo.Text = "(12:43) Nome: Texto de Exemplo";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 231);
            this.Controls.Add(this.labelExemplo);
            this.Controls.Add(this.btnFonte);
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
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox cbCloseToTray;
        private System.Windows.Forms.CheckBox cbMinimizeToTray;
        private System.Windows.Forms.Button btnCorLinha;
        private System.Windows.Forms.PictureBox selectedColor;
        private System.Windows.Forms.TextBox tbServidor;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.CheckBox cbNotify;
        private System.Windows.Forms.PictureBox backgroundColor;
        private System.Windows.Forms.Button btnCorFundo;
        private System.Windows.Forms.Button btnFonte;
        private System.Windows.Forms.Label labelExemplo;
    }
}