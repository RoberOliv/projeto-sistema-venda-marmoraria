using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._2_ConexaoSQL
{
    public class CadasdroClientes
    {
        private ConexaoSQL conexao = new ConexaoSQL();
        private SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public CadasdroClientes(string cl_nome, string cl_sobrenome, string cl_cpfCnpj, string cl_rg, string cl_email, string cl_telefone, string cl_celular, string cl_cep, string cl_endereco, string cl_numeroResidencia, string cl_bairro, string cl_cidade, string cl_uf)
        {
            cmd.CommandText = "insert into tb_Clientes(cl_nome,cl_sobrenome,cl_cpfCnpj,cl_rg,cl_email,cl_telefone,cl_celular,cl_cep,cl_endereco,cl_numeroResidencia,cl_bairro,cl_cidade,cl_uf)" +
                              " values (@cl_nome,@cl_sobrenome,@cl_cpfCnpj,@cl_rg,@cl_email,@cl_telefone,@cl_celular,@cl_cep,@cl_endereco,@cl_numeroResidencia,@cl_bairro,@cl_cidade,@cl_uf)";

            cmd.Parameters.AddWithValue("@cl_nome", cl_nome);
            cmd.Parameters.AddWithValue("@cl_sobrenome", cl_sobrenome);
            cmd.Parameters.AddWithValue("@cl_cpfCnpj", cl_cpfCnpj);
            cmd.Parameters.AddWithValue("@cl_rg", cl_rg);
            cmd.Parameters.AddWithValue("@cl_email", cl_email);
            cmd.Parameters.AddWithValue("@cl_telefone", cl_telefone);
            cmd.Parameters.AddWithValue("@cl_celular", cl_celular);
            cmd.Parameters.AddWithValue("@cl_cep", cl_cep);
            cmd.Parameters.AddWithValue("@cl_endereco", cl_endereco);
            cmd.Parameters.AddWithValue("@cl_numeroResidencia", cl_numeroResidencia);
            cmd.Parameters.AddWithValue("@cl_bairro", cl_bairro);
            cmd.Parameters.AddWithValue("@cl_cidade", cl_cidade);
            cmd.Parameters.AddWithValue("@cl_uf", cl_uf);

            try
            {
                cmd.Connection = conexao.ConectarBancoDados();

                cmd.ExecuteNonQuery();

                conexao.DesconectarBancoDados();

                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar Conectar com o bando de Dados";
            }
        }
    }
}