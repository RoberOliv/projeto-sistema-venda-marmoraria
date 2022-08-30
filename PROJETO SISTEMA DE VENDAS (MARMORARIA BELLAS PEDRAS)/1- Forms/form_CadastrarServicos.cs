using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            CarregarComboBoxClientes();
        }

        private void CarregarComboBoxClientes()
        {
            foreach (ConexaoSQL cliente in new List<ConexaoSQL>())
            {
                cmbNomeCliente.Items.Add(cliente.ConectarBancoDados());
            }
        }
    }
}