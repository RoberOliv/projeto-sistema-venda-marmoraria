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
    public partial class form_CadastrarServicos : Form
    {
        public form_CadastrarServicos()
        {
            InitializeComponent();
        }

        public static string StrConnection
        {
            get { return $@"Data Source=DESKTOP-SCOEKP8\SQLEXPRESS;Initial Catalog=Marmoraria;Persist Security Info=True;User ID=sa;Password=12345"; }
        }

        public struct ClienteMaterialEstrutura
        {
            public string NomeCliente { get; set; }

            public string Sobrenome { get; set; }

            public string CPFCNPJ { get; set; }

            public string NomeMaterial { get; set; }

            public string TipoMaterial { get; set; }

            public Decimal ValorMaterial { get; set; }
        }

        private List<ClienteMaterialEstrutura> BuscarVariosClientes()
        {
            List<ClienteMaterialEstrutura> listaNomes = new List<ClienteMaterialEstrutura>();
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                cn.Open();

                var sqlQuery = $"SELECT * FROM tb_Clientes WHERE cl_nome LIKE '%%'";

                SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaNomes.Add(new ClienteMaterialEstrutura { NomeCliente = dr.GetString(1), Sobrenome = dr.GetString(2), CPFCNPJ = dr.GetString(3) });
                }

                return listaNomes;
            }
        }

        private void form_CadastrarServicos_Load(object sender, EventArgs e)
        {
            foreach (ClienteMaterialEstrutura listaNomes in BuscarVariosClientes())
            {
                cmbNomeClientes.Items.Add(listaNomes.NomeCliente + " " + listaNomes.Sobrenome + " - " + listaNomes.CPFCNPJ);
            }

            CarregarVariosMateriais();
        }

        private List<ClienteMaterialEstrutura> BuscarVariosMateriais()
        {
            List<ClienteMaterialEstrutura> listaMateriais = new List<ClienteMaterialEstrutura>();
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                cn.Open();

                var sqlQuery = $"SELECT * FROM tb_Materiais WHERE mt_nome LIKE '%%'";

                SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaMateriais.Add(new ClienteMaterialEstrutura { NomeMaterial = dr.GetString(1), TipoMaterial = dr.GetString(3), ValorMaterial = dr.GetDecimal(2) });
                }

                return listaMateriais;
            }
        }

        private void CarregarVariosMateriais()
        {
            foreach (ClienteMaterialEstrutura listaNomes in BuscarVariosMateriais())
            {
                cmbNomeMateriais.Items.Add(listaNomes.NomeMaterial + " - " + "R$ " + listaNomes.ValorMaterial + " - " + listaNomes.TipoMaterial);
            }
        }
    }
}