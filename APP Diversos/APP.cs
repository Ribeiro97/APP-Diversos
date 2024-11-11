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
            string Tipo = String.Empty;

            try
            {
                if (XML_radioNFe.Checked == true)
                {
                    Tipo = "NFe";
                    string query = "Select Convert(xml, xml_nfe) as XML_NFe From Fiscal_NF where Empresa = @Empresa AND Serie = @Serie AND Formulario = @Formulario AND Modelo = 55;";

                    await sql.GerarXML(query, Formulario, Empresa, Serie, Tipo, this.connectionstring);
                }

                else if (XML_radioMDFe.Checked == true)
                {
                    Tipo = "MDFe";
                    string query = "Select Codigo From Fiscal_Serie_NF where Empresa = @Empresa AND Modelo = @Modelo AND Ambiente = @Ambiente AND Serie_NFP = @Serie";

                    await sql.GerarXML(query, Formulario, Empresa, Serie, Tipo, this.connectionstring);
                }

                else if (XML_radioNFCe.Checked == true)
                {
                    Tipo = "NFCe";
                    string query = "Select Convert(xml, xml_nfe) as XML_NFe From Fiscal_NF where Empresa = @Empresa AND Serie = @Serie AND Formulario = @Formulario AND Modelo = 65;";

                    await sql.GerarXML(query, Formulario, Empresa, Serie, Tipo, this.connectionstring);
                }

                else if (XML_radioNFSe.Checked == true)
                {
                    Tipo = "NFSe";
                    string query = "Select Codigo From Fiscal_NFSe where Empresa = @Empresa AND Serie = @Serie AND NumeroNfse = @Formulario";

                    await sql.GerarXML(query, Formulario, Empresa, Serie, Tipo, this.connectionstring);
                }

                else if (XML_radioCTe.Checked == true)
                {
                    Tipo = "CTe";
                    string query = "Select Codigo From Fiscal_CTe where Empresa = @Empresa AND Serie = @Serie AND Formulario = @Formulario";

                    await sql.GerarXML(query, Formulario, Empresa, Serie, Tipo, this.connectionstring);
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
    }
}
