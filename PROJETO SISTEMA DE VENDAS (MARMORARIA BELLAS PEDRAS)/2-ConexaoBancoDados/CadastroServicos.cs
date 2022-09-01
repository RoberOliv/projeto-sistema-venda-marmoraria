using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._2_ConexaoSQL;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._2_ConexaoBancoDados
{
    internal class CadastroServicos
    {
        private ConexaoSQL conexao = new ConexaoSQL();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public CadastroServicos(string dadosCompraCliente, string dadosMateriais, string nomeServico, string quantidade, string comprimento, string largura, string descricao)
        {
            cmd.CommandText = "INSERT INTO tb_Servicos (sv_dadoscompracliente, sv_dadosmateriais, sv_nomeservico , sv_quantidade,sv_comprimento,sv_largura,sv_descricao) values " +
                              "(@DADOSCOMPRACLIENTE,@DADOSMATERIAIS,@NOMESERVICO,@QUANTIDADE,@COMPRIMENTO,@LARGURA,@DESCRICAO)";

            cmd.Parameters.AddWithValue("@DADOSCOMPRACLIENTE", dadosCompraCliente);
            cmd.Parameters.AddWithValue("@DADOSMATERIAIS", dadosMateriais);
            cmd.Parameters.AddWithValue("@NOMESERVICO", nomeServico);
            cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);
            cmd.Parameters.AddWithValue("@COMPRIMENTO", comprimento);
            cmd.Parameters.AddWithValue("@LARGURA", largura);
            cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
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