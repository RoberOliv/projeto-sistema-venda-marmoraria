using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
    public partial class form_CadastrarMateriais : Form
    {
        public form_CadastrarMateriais()
        {
            InitializeComponent();
            CarregarTabelaMateriais();
        }

        public static string StrConnection
        {
            get { return $@"Data Source=DESKTOP-SCOEKP8\SQLEXPRESS;Initial Catalog=Marmoraria;Persist Security Info=True;User ID=sa;Password=12345"; }
        }

        private void CarregarTabelaMateriais()
        {
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                var sqlQuery = "SELECT mt_id AS ID,mt_nome AS NOME,mt_valor AS VALOR,mt_tipo AS TIPO  FROM tb_Materiais ORDER BY mt_id DESC";

                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gdvExibirListaMateriais.DataSource = dt;
            }
        }

        private void btnCadastrarMateriais_Click(object sender, EventArgs e)
        {
            CadastroMateriais cad =
                new CadastroMateriais(txtNomeMaterial.Text, txtValorProduto.Text, cmbTiposMateriais.Text);
            CarregarTabelaMateriais();
            MessageBox.Show(cad.mensagem);
        }

        private void ctxDeletarMateriais_Click(object sender, EventArgs e)
        {
            int _idCliente = Convert.ToInt32(gdvExibirListaMateriais.SelectedCells[0].Value);
            DeletarCliente(_idCliente);
            CarregarTabelaMateriais();
            MessageBox.Show("Deletado com sucesso!");
        }

        private void DeletarCliente(int _idCliente)
        {
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                cn.Open();

                var sqlQuery = "DELETE FROM tb_Materiais WHERE mt_id = @mt_id ";

                SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                cmd.Parameters.AddWithValue("@mt_id", _idCliente);
                cmd.ExecuteNonQuery();
            }
        }

        private void BuscarNomePorMaterial(string _nomeMaterial)
        {
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                var sqlQuery = $"SELECT mt_id AS ID,mt_nome AS NOME, mt_valor AS VALOR,mt_tipo AS TIPO FROM tb_Materiais WHERE  mt_nome LIKE  '%{_nomeMaterial}%'";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, cn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gdvExibirListaMateriais.DataSource = dt;
            }
        }

        private void txtBuscarNomeMaterial_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarNomePorMaterial(txtBuscarNomeMaterial.Text);
        }

        private void form_CadastrarMateriais_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(StrConnection))
            {
                var sqlQuery = "SELECT mt_id AS ID,mt_nome AS NOME,mt_valor AS VALOR,mt_tipo AS TIPO  FROM tb_Materiais";

                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gdvExibirListaMateriais.DataSource = dt;
            }
        }
    }
}