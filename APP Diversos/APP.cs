using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Diversos
{
    public partial class Diversos : Form
    {
        private string connectionstring;
        private List<string> ListaMsgRealizado;
        private List<string> ListaMsgErro;

        public Diversos()
        {
            InitializeComponent();

            XML_radioSat.Click += XML_radioButton_Click;
            XML_radioNFe.Click += XML_radioButton_Click;
            XML_radioNFCe.Click += XML_radioButton_Click;
            XML_radioCTe.Click += XML_radioButton_Click;
            XML_radioMDFe.Click += XML_radioButton_Click;
            XML_radioNFSe.Click += XML_radioButton_Click;
        }

        private async void Btn_ConectarDatabase_Click(object sender, EventArgs e)
        {
            string servidor = Conexao_Servidor.Text.Trim();
            string usuario = Conexao_Usuario.Text.Trim();
            string banco = Conexao_Banco.Text.Trim();
            string senha = Conexao_Senha.Text.Trim();

            Conexao conexao = new Conexao();
            this.connectionstring = await conexao.ConectarDatabase(servidor, usuario, banco, senha);
        }

        private void Btn_LimparConexao_Click(object sender, EventArgs e)
        {
            Conexao_Servidor.Text = String.Empty;
            Conexao_Usuario.Text = String.Empty;
            Conexao_Banco.Text = String.Empty;
            Conexao_Senha.Text = String.Empty;
        }

        private async void XML_btnGerar_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            int Formulario = Convert.ToInt32(XML_Codigo.Value);
            int Empresa = Convert.ToInt32(XML_Empresa.Value);
            int Serie = Convert.ToInt32(XML_Serie.Value);
            string checkboxHomologacao = "P";
            string Tipo = String.Empty;

            if(checkBox_XML_Homologacao.Checked == true)
            {
                checkboxHomologacao = "H";
            }

            try
            {
                if (XML_radioNFe.Checked == true)
                {
                    Tipo = "NFe";
                    //string query = "Select Convert(xml, xml_nfe) as XML_NFe From Fiscal_NF where Empresa = @Empresa AND Serie = @Serie AND Formulario = @Formulario AND Modelo = 55;";

                    string query = "Select Codigo From Fiscal_Serie_NF where Empresa = @Empresa AND Modelo = 55 AND Ambiente = @Ambiente AND Serie_NFP = @Serie";

                    await sql.getXML(query, Formulario, Empresa, Serie, Tipo, checkboxHomologacao, this.connectionstring);
                }

                else if (XML_radioMDFe.Checked == true)
                {
                    Tipo = "MDFe";
                    string query = "Select Codigo From Fiscal_Serie_NF where Empresa = @Empresa AND Modelo = 58 AND Ambiente = @Ambiente AND Serie_NFP = @Serie";

                    await sql.getXML(query, Formulario, Empresa, Serie, Tipo, checkboxHomologacao, this.connectionstring);
                }

                else if (XML_radioNFCe.Checked == true)
                {
                    Tipo = "NFCe";
                    string query = "Select Convert(xml, xml_nfe) as XML_NFe From Fiscal_NF where Empresa = @Empresa AND Serie = @Serie AND Formulario = @Formulario AND Modelo = 65;";

                    await sql.getXML(query, Formulario, Empresa, Serie, Tipo, checkboxHomologacao, this.connectionstring); 
                }

                else if (XML_radioNFSe.Checked == true)
                {
                    Tipo = "NFSe";
                    string query = "Select Codigo From Fiscal_NFSe where Empresa = @Empresa AND Serie = @Serie AND NumeroNfse = @Formulario";

                    await sql.getXML(query, Formulario, Empresa, Serie, Tipo, checkboxHomologacao, this.connectionstring);
                }

                else if (XML_radioCTe.Checked == true)
                {
                    Tipo = "CTe";
                    // string query = "Select Codigo From Fiscal_CTe where Empresa = @Empresa AND Serie = @Serie AND Formulario = @Formulario";

                    string query = "Select Codigo From Fiscal_Serie_NF WHERE Empresa = @Empresa AND Serie_NFP = @Serie AND Ambiente = @Ambiente AND Modelo = 57";

                    await sql.getXML(query, Formulario, Empresa, Serie, Tipo, checkboxHomologacao, this.connectionstring);
                }

                else if (XML_radioSat.Checked == true)
                {
                    Tipo = "Sat";
                    
                    string query = "SELECT XML_CFE From SAT_NF_XML WHERE Cod_CFe = @Formulario AND Cod_SAT = @Serie";

                    await sql.getXML(query, Formulario, Empresa, Serie, Tipo, checkboxHomologacao, this.connectionstring);

                }

                else if (XML_radioNFe.Checked == false && XML_radioMDFe.Checked == false && XML_radioNFCe.Checked == false && XML_radioNFSe.Checked == false && XML_radioCTe.Checked == false)
                {
                    MessageBox.Show("Nenhuma Tipo de documento foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                else
                {
                    MessageBox.Show("Deu ruim, chama o suporte", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show($"{msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #region Eventos RadioButtons
        private void XML_radioButton_Click(object radio, EventArgs e)
        {
            // Verifica qual RadioButton foi clicado
            if (radio is RadioButton radioButton)
            {
                // Desabilita o checkbox apenas para o RadioButton XML_radioSat
                if (radioButton == XML_radioSat)
                {
                    checkBox_XML_Homologacao.Visible = false;
                    checkBox_XML_Homologacao.Checked = false;
                }
                else
                {
                    checkBox_XML_Homologacao.Visible = true;
                }
            }
        }
        #endregion
    }
}
