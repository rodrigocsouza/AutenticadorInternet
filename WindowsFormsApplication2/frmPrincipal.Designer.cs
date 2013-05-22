namespace WindowsFormsApplication2
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.sinalVermelho = new System.Windows.Forms.PictureBox();
            this.sinalVerde = new System.Windows.Forms.PictureBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferênciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.sinalVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinalVerde)).BeginInit();
            this.menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(12, 84);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(751, 20);
            this.txbEndereco.TabIndex = 0;
            this.txbEndereco.Text = "http://www.speedconnection.com.br";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(769, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Ir";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(12, 113);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.ScriptErrorsSuppressed = true;
            this.wb.Size = new System.Drawing.Size(832, 422);
            this.wb.TabIndex = 2;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Endereço:";
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // sinalVermelho
            // 
            this.sinalVermelho.Image = global::WindowsFormsApplication2.Properties.Resources.traffic_lights_red_icon;
            this.sinalVermelho.Location = new System.Drawing.Point(16, 28);
            this.sinalVermelho.Name = "sinalVermelho";
            this.sinalVermelho.Size = new System.Drawing.Size(32, 34);
            this.sinalVermelho.TabIndex = 4;
            this.sinalVermelho.TabStop = false;
            this.sinalVermelho.Visible = false;
            // 
            // sinalVerde
            // 
            this.sinalVerde.Image = global::WindowsFormsApplication2.Properties.Resources.traffic_lights_green_icon;
            this.sinalVerde.Location = new System.Drawing.Point(16, 28);
            this.sinalVerde.Name = "sinalVerde";
            this.sinalVerde.Size = new System.Drawing.Size(32, 34);
            this.sinalVerde.TabIndex = 5;
            this.sinalVerde.TabStop = false;
            this.sinalVerde.Visible = false;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(50, 46);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(16, 13);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "...";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.preferênciasToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(856, 24);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferênciasToolStripMenuItem1});
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.preferênciasToolStripMenuItem.Text = "Editar";
            // 
            // preferênciasToolStripMenuItem1
            // 
            this.preferênciasToolStripMenuItem1.Name = "preferênciasToolStripMenuItem1";
            this.preferênciasToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.preferênciasToolStripMenuItem1.Text = "Preferências";
            this.preferênciasToolStripMenuItem1.Click += new System.EventHandler(this.preferênciasToolStripMenuItem1_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(196, 25);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(648, 56);
            this.lbLog.TabIndex = 8;
            this.lbLog.ValueMemberChanged += new System.EventHandler(this.lbLog_ValueMemberChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "O Autenticador continua a ser executado...";
            this.notifyIcon1.BalloonTipTitle = "Autenticador Internet";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Autenticador Internet";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRestaurar,
            this.toolStripSeparator1,
            this.tsmSair});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 54);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // tsmRestaurar
            // 
            this.tsmRestaurar.Name = "tsmRestaurar";
            this.tsmRestaurar.Size = new System.Drawing.Size(123, 22);
            this.tsmRestaurar.Text = "Restaurar";
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(123, 22);
            this.tsmSair.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 547);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.sinalVerde);
            this.Controls.Add(this.sinalVermelho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticador Internet";
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sinalVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinalVerde)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.PictureBox sinalVermelho;
        private System.Windows.Forms.PictureBox sinalVerde;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRestaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

