namespace WindowsFormsApplication2
{
    partial class frmPreferencias
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAtributoPesquisa = new System.Windows.Forms.TextBox();
            this.txbAtributoValorUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAtributoValorSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCampoUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCampoSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBotaoLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudTemporizador = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemporizador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(12, 32);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(464, 20);
            this.txbEndereco.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Atributo de Pesquisa:";
            // 
            // txbAtributoPesquisa
            // 
            this.txbAtributoPesquisa.Location = new System.Drawing.Point(12, 75);
            this.txbAtributoPesquisa.Name = "txbAtributoPesquisa";
            this.txbAtributoPesquisa.Size = new System.Drawing.Size(161, 20);
            this.txbAtributoPesquisa.TabIndex = 6;
            // 
            // txbAtributoValorUsuario
            // 
            this.txbAtributoValorUsuario.Location = new System.Drawing.Point(12, 122);
            this.txbAtributoValorUsuario.Name = "txbAtributoValorUsuario";
            this.txbAtributoValorUsuario.Size = new System.Drawing.Size(227, 20);
            this.txbAtributoValorUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Atributo de Valor para busca do campo usuário:";
            // 
            // txbAtributoValorSenha
            // 
            this.txbAtributoValorSenha.Location = new System.Drawing.Point(249, 122);
            this.txbAtributoValorSenha.Name = "txbAtributoValorSenha";
            this.txbAtributoValorSenha.Size = new System.Drawing.Size(227, 20);
            this.txbAtributoValorSenha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Atributo de Valor para busca do campo senha:";
            // 
            // txbCampoUsuario
            // 
            this.txbCampoUsuario.Location = new System.Drawing.Point(12, 169);
            this.txbCampoUsuario.Name = "txbCampoUsuario";
            this.txbCampoUsuario.Size = new System.Drawing.Size(227, 20);
            this.txbCampoUsuario.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Usuário:";
            // 
            // txbCampoSenha
            // 
            this.txbCampoSenha.Location = new System.Drawing.Point(249, 169);
            this.txbCampoSenha.Name = "txbCampoSenha";
            this.txbCampoSenha.Size = new System.Drawing.Size(227, 20);
            this.txbCampoSenha.TabIndex = 6;
            this.txbCampoSenha.TextChanged += new System.EventHandler(this.txbCampoSenha_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Senha:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbBotaoLogin
            // 
            this.txbBotaoLogin.Location = new System.Drawing.Point(249, 75);
            this.txbBotaoLogin.Name = "txbBotaoLogin";
            this.txbBotaoLogin.Size = new System.Drawing.Size(227, 20);
            this.txbBotaoLogin.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Atributo de Valor para o botão de login:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(401, 217);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudTemporizador
            // 
            this.nudTemporizador.Location = new System.Drawing.Point(12, 217);
            this.nudTemporizador.Name = "nudTemporizador";
            this.nudTemporizador.Size = new System.Drawing.Size(120, 20);
            this.nudTemporizador.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Temporizador:";
            // 
            // frmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 257);
            this.Controls.Add(this.nudTemporizador);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCampoSenha);
            this.Controls.Add(this.txbCampoUsuario);
            this.Controls.Add(this.txbBotaoLogin);
            this.Controls.Add(this.txbAtributoValorSenha);
            this.Controls.Add(this.txbAtributoValorUsuario);
            this.Controls.Add(this.txbAtributoPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEndereco);
            this.Name = "frmPreferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferências";
            this.Load += new System.EventHandler(this.frmPreferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTemporizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAtributoPesquisa;
        private System.Windows.Forms.TextBox txbAtributoValorUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAtributoValorSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCampoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCampoSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBotaoLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudTemporizador;
        private System.Windows.Forms.Label label8;
    }
}