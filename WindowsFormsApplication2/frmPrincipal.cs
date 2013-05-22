using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Configuration;

namespace WindowsFormsApplication2
{
    public partial class frmPrincipal : Form
    {
        private string EnderecoPaginaLogin;
        private string AtributoPesquisa;
        private string AtributoValorUsuario;
        private string AtributoValorSenha;
        private string CampoUsuario;
        private string CampoSenha;
        private string BotaoLogin;
        private int TempoVerificarConexaoInternet;
        private int contadorTempo;
        private bool okParaAutenticar;

        public frmPrincipal()
        {
            InitializeComponent();
            wb.ScriptErrorsSuppressed = true;
            CarregaConfiguracoes();
            txbEndereco.Text = EnderecoPaginaLogin;
            contadorTempo = TempoVerificarConexaoInternet;
            okParaAutenticar = false;
            lbLog.Items.Insert(0, string.Format("{0} - Aplicação inicializada", DateTime.Now.ToString()));
        }

        private void CarregaConfiguracoes()
        {
            EnderecoPaginaLogin = ConfigurationManager.AppSettings["EnderecoPaginaLogin"].ToString();
            AtributoPesquisa = ConfigurationManager.AppSettings["AtributoPesquisa"].ToString();
            AtributoValorUsuario = ConfigurationManager.AppSettings["AtributoValorUsuario"].ToString();
            AtributoValorSenha = ConfigurationManager.AppSettings["AtributoValorSenha"].ToString();
            CampoUsuario = ConfigurationManager.AppSettings["CampoUsuario"].ToString();
            CampoSenha = ConfigurationManager.AppSettings["CampoSenha"].ToString();
            BotaoLogin = ConfigurationManager.AppSettings["BotaoLogin"].ToString();
            TempoVerificarConexaoInternet = Convert.ToInt32(ConfigurationManager.AppSettings["TempoVerificarConexaoInternet"].ToString());
            contadorTempo = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            wb.Navigate(txbEndereco.Text);
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (okParaAutenticar)
            {
                okParaAutenticar = false;
                try
                {
                    HtmlElementCollection col = wb.Document.GetElementsByTagName("input");

                    foreach (HtmlElement item in col)
                    {
                        if (item.GetAttribute(AtributoPesquisa) == AtributoValorUsuario)
                        {
                            HtmlElement wanted;
                            wanted = item;
                            wanted.SetAttribute("value", CampoUsuario);
                            lbLog.Items.Insert(0, string.Format("{0} - Campo usuário encontrado", DateTime.Now.ToString()));
                        }
                        if (item.GetAttribute(AtributoPesquisa) == AtributoValorSenha)
                        {
                            HtmlElement wanted;
                            wanted = item;
                            wanted.SetAttribute("value", CampoSenha);
                            lbLog.Items.Insert(0, string.Format("{0} - Campo senha encontrado", DateTime.Now.ToString()));
                        }
                        if (item.GetAttribute(AtributoPesquisa) == BotaoLogin)
                        {
                            HtmlElement wanted;
                            wanted = item;
                            wanted.InvokeMember("click");
                            lbLog.Items.Insert(0, string.Format("{0} - Botão de Login encontrado, fazendo autenticação", DateTime.Now.ToString()));
                        }
                    }
                }
                catch (Exception exx)
                {
                    lbLog.Items.Insert(0, string.Format("{0} - Erro na autenticação, verifique os parâmetros - {1}", DateTime.Now.ToString(), exx.Message));
                } 
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = contadorTempo.ToString() + "s";
            contadorTempo--;
            Application.DoEvents();
            if (contadorTempo == 0)
            {
                contadorTempo = TempoVerificarConexaoInternet;
                lblTempo.Text = "Checando...";
                Application.DoEvents();
                if (CheckForInternetConnection())
                {
                    sinalVerde.Visible = true;
                    sinalVermelho.Visible = false;
                    lbLog.Items.Insert(0, string.Format("{0} - Verificação de conexão OK", DateTime.Now.ToString()));
                    okParaAutenticar = true;
                }
                else
                {
                    sinalVermelho.Visible = true;
                    sinalVerde.Visible = false;
                    lbLog.Items.Insert(0, string.Format("{0} - Verificação de conexão NÃO OK", DateTime.Now.ToString()));
                    okParaAutenticar = true;
                }
                wb.Navigate(EnderecoPaginaLogin);
                Application.DoEvents();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okParaAutenticar = false;
            temporizador.Enabled = false;
            Application.Exit();
        }

        private void preferênciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Abrir o form para editar os dados
            frmPreferencias frmP = new frmPreferencias();
            frmP.ShowDialog();
        }

        private void lbLog_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tsmSair" )
            {
                okParaAutenticar = false;
                temporizador.Enabled = false;
                Application.Exit();
            }
            else
            {
                if (e.ClickedItem.Name == "tsmRestaurar")
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.BringToFront();
                }
            }
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                //notifyIcon1.BalloonTipText = "My application still working...";
                //notifyIcon1.BalloonTipTitle = "My Sample Application";
                //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info; 
                this.Hide();
                notifyIcon1.ShowBalloonTip(3000, "Autenticador Internet", "O autenticador continua sendo executado.", ToolTipIcon.Info);
                
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
    }
}
