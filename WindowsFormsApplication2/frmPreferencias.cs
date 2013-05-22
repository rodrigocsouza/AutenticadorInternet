using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication2
{
    public partial class frmPreferencias : Form
    {
        public frmPreferencias()
        {
            InitializeComponent();
            
        }

        private void CarregaConfiguracoes()
        {
            txbEndereco.Text = ConfigurationManager.AppSettings["EnderecoPaginaLogin"].ToString();
            txbAtributoPesquisa.Text = ConfigurationManager.AppSettings["AtributoPesquisa"].ToString();
            txbAtributoValorUsuario.Text = ConfigurationManager.AppSettings["AtributoValorUsuario"].ToString();
            txbAtributoValorSenha.Text = ConfigurationManager.AppSettings["AtributoValorSenha"].ToString();
            txbCampoUsuario.Text = ConfigurationManager.AppSettings["CampoUsuario"].ToString();
            txbCampoSenha.Text = ConfigurationManager.AppSettings["CampoSenha"].ToString();
            txbBotaoLogin.Text = ConfigurationManager.AppSettings["BotaoLogin"].ToString();
            nudTemporizador.Value = Convert.ToInt32(ConfigurationManager.AppSettings["TempoVerificarConexaoInternet"].ToString());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbCampoSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Salvar os dados no App.Config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings["EnderecoPaginaLogin"].Value = txbEndereco.Text;
            app.Settings["AtributoPesquisa"].Value =txbAtributoPesquisa.Text;
            app.Settings["AtributoValorUsuario"].Value =txbAtributoValorUsuario.Text;
            app.Settings["AtributoValorSenha"].Value =txbAtributoValorSenha.Text;
            app.Settings["CampoUsuario"].Value =txbCampoUsuario.Text;
            app.Settings["CampoSenha"].Value =txbCampoSenha.Text;
            app.Settings["BotaoLogin"].Value =txbBotaoLogin.Text;
            app.Settings["TempoVerificarConexaoInternet"].Value =nudTemporizador.Value.ToString();
            config.Save();//ConfigurationSaveMode.Modified);
            //app.
            this.Close();
            this.Dispose();
        }

        private void frmPreferencias_Load(object sender, EventArgs e)
        {
            CarregaConfiguracoes();
        }
    }
}
