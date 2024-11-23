using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Diversos
{
    public class Conexao
    {
        private string connectionString = String.Empty;

        public Conexao() { }

        public async Task<string> ConectarDatabase(string servidor, string usuario, string banco, string senha)
        {
            #region Campos Conexão
            // Validação de campos na conexão
            string msg = String.Empty;

            if (string.IsNullOrEmpty(servidor))
            {
                msg = "Servidor não está sendo informado.\n";
            }

            if (string.IsNullOrEmpty(usuario))
            {
                msg += "Usuario não está sendo informado.\n";

            }

            if (string.IsNullOrEmpty(banco))
            {
                msg += "Banco não está sendo informado.\n";
            }

            if (string.IsNullOrEmpty(senha))
            {
                msg += "Senha não esta sendo informada.";
            }

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show($"{msg}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            this.connectionString = $"Server={servidor};Database={banco};User Id={usuario};Password={senha};TrustServerCertificate=True;";
            #endregion

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    await conn.OpenAsync();
                    MessageBox.Show("Conexão estabelecida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return this.connectionString;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao conectar: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }       
    }
}
