using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._2_ConexaoSQL
{
    internal class CadastroMateriais
    {
        private ConexaoSQL conexao = new ConexaoSQL();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public CadastroMateriais(string nomeMaterial, string valor, string tipoMaterial)
        {
            cmd.CommandText = "INSERT INTO tb_Materiais(mt_nome,mt_valor,mt_tipo) values (@NOME,@VALOR,@TIPO)";

            cmd.Parameters.AddWithValue("@NOME", nomeMaterial);
            cmd.Parameters.AddWithValue("@VALOR", valor);
            cmd.Parameters.AddWithValue("@TIPO", tipoMaterial);

            try
            {
                cmd.Connection = conexao.ConectarBancoDados();

                cmd.ExecuteNonQuery();

                conexao.DesconectarBancoDados();

                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar Conectar com o bando de Dados";
            }
        }
    }
}