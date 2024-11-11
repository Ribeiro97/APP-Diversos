using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace APP_Diversos
{
    public class Sql
    {
        Conexao conexao = new Conexao();
        public Sql() { }


        public async Task GerarXML(string query, int CodigoFormulario, int CodigoEmpresa, int CodigoSerie, string Tipo, string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Realize a conexão com o banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int Forms = 0;                
                string res = String.Empty;

                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("Empresa", SqlDbType.Int).Value = CodigoEmpresa;
                    cmd.Parameters.Add("Serie", SqlDbType.Int).Value = CodigoSerie;
                    cmd.Parameters.Add("Formulario", SqlDbType.Int).Value = CodigoFormulario;
                    cmd.Parameters.Add("Modelo", SqlDbType.Int).Value = 58;
                    cmd.Parameters.Add("Ambiente", SqlDbType.VarChar).Value = "P";

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {

                        // Validar o TIPO para chamar a coluna correta
                        switch (Tipo)
                        {
                            case "NFe":
                                while (await reader.ReadAsync())
                                {
                                    res = reader["XML_NFe"].ToString();
                                }
                                break;

                            case "MDFe":
                                int codSerie = 0;
                                int codigoMDFE = 0;

                                while (await reader.ReadAsync())
                                {
                                    codSerie = Convert.ToInt32(reader["Codigo"]);
                                }
                                reader.Close();

                                cmd.CommandText = "Select Codigo From Fiscal_MDFe Where Empresa = @Empresa AND Serie = @Serie2 AND Formulario = @Formulario";
                                cmd.Parameters.Add("Serie2", SqlDbType.Int).Value = codSerie;
                                using (SqlDataReader reader2 = await cmd.ExecuteReaderAsync())
                                {
                                    while (await reader2.ReadAsync())
                                    {
                                        codigoMDFE = Convert.ToInt32(reader2["Codigo"]);
                                    }
                                    reader2.Close();

                                    cmd.CommandText = "Select Convert(xml, xml) as XML From Fiscal_MDFe_XML Where Cod_Fiscal_MDFe = @Codigo AND Evento = @Situacao";
                                    cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = codigoMDFE;
                                    cmd.Parameters.Add("Situacao", SqlDbType.VarChar).Value = "CADASTRO";

                                    using (SqlDataReader readerMDFE = await cmd.ExecuteReaderAsync())
                                    {
                                        while (await readerMDFE.ReadAsync())
                                        {
                                            res = readerMDFE["XML"].ToString();
                                        }
                                    }
                                }
                                break;

                            case "NFCe":
                                while (await reader.ReadAsync())
                                {
                                    res = reader["XML_NFe"].ToString();
                                }
                                break;

                            case "NFSe":
                                while (await reader.ReadAsync())
                                {
                                    Forms = Convert.ToInt32(reader["Codigo"]);
                                }

                                reader.Close();
                                cmd.Parameters.Clear();

                                cmd.CommandText = "Select Convert(XML, Conteudo_XML) as XML From Fiscal_Nfse_Xml Where Codigo_Fiscal_NFSe = @Forms";
                                cmd.Parameters.Add("Forms", SqlDbType.Int).Value = Forms;

                                using (SqlDataReader reader2 = await cmd.ExecuteReaderAsync())
                                {
                                    while (await reader2.ReadAsync())
                                    {
                                        res = reader2["XML"].ToString();
                                    }
                                }
                                break;

                            case "CTe":
                                while (await reader.ReadAsync())
                                {
                                    Forms = Convert.ToInt32(reader["Codigo"]);
                                }

                                reader.Close();
                                cmd.Parameters.Clear();

                                cmd.CommandText = "Select XML From Fiscal_CTe_XML Where Cod_Fiscal_CTe = @Forms";
                                cmd.Parameters.Add("Forms", SqlDbType.Int).Value = Forms;

                                using (SqlDataReader reader2 = await cmd.ExecuteReaderAsync())
                                {
                                    while (await reader2.ReadAsync())
                                    {
                                        res = reader2["XML"].ToString();
                                    }
                                }
                                break;
                        }




                        // Validação do xml
                        if (res == String.Empty || res == null)
                        {
                            MessageBox.Show("Nennhum XML foi gerado no banco para o código informadoah tá", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        else
                        {
                            // Criação do arquivo XML
                            XmlDocument xml = new XmlDocument();
                            try
                            {
                                xml.LoadXml(res);

                                SaveFileDialog salvarArquivo = new SaveFileDialog
                                {
                                    Filter = "XML files (*.xml)|*.xml",
                                    Title = "Salvar XML como"
                                };

                                if (salvarArquivo.ShowDialog() == DialogResult.OK)
                                {
                                    xml.Save(salvarArquivo.FileName);
                                    MessageBox.Show("Arquivo foi salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (XmlException msg)
                            {
                                MessageBox.Show($"{msg}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            catch (Exception msg)
                            {
                                MessageBox.Show($"{msg}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
