using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._2_ConexaoSQL;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._1__Forms
{
    public partial class form_ListaDeClientes : Form
    {
        public form_ListaDeClientes()
        {
            InitializeComponent();
        }

        public static string StrConnection
        {
            get { return $@"Data Source=DESKTOP-SCOEKP8\SQLEXPRESS;Initial Catalog=Marmoraria;Persist Security Info=True;User ID=sa;Password=12345"; }
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarJanela_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void form_ListaDeClientes_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                cn.Open();

                var sqlQuery = "SELECT cl_id AS ID,cl_nome AS NOME,cl_sobrenome AS SOBRENOME, cl_cpfCnpj AS [CPF/CNPJ],cl_rg AS RG,cl_email AS [E-MAIL]," +
                               "cl_celular AS CELULAR,cl_cep AS CEP,cl_endereco AS ENDEREÇO,cl_numeroResidencia AS [Nº RESIDÊNCIA],cl_bairro AS BAIRRO,cl_cidade AS CIDADE,cl_uf AS UF FROM tb_Clientes";
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gdvExibirListaClientes.DataSource = dt;
            }
        }

        private void BuscarNomePorCliente(string _nomeCliente)
        {
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                var sqlQuery = "SELECT cl_id AS ID,cl_nome AS NOME,cl_sobrenome AS SOBRENOME, cl_cpfCnpj AS [CPF/CNPJ],cl_rg AS RG,cl_email AS [E-MAIL]," +
                               $"cl_celular AS CELULAR,cl_cep AS CEP,cl_endereco AS ENDEREÇO,cl_numeroResidencia AS [Nº RESIDÊNCIA],cl_bairro AS BAIRRO," +
                               $"cl_cidade AS CIDADE,cl_uf AS UF FROM tb_Clientes WHERE  cl_nome LIKE  '%{_nomeCliente}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, cn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gdvExibirListaClientes.DataSource = dt;
            }
        }

        private void txtBuscarNomeCliente_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarNomePorCliente(txtBuscarNomeCliente.Text);
        }
    }
}