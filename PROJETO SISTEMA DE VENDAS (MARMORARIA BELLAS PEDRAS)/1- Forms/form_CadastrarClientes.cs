using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._2_ConexaoSQL;
using PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._3___Classe_ValidarDigitos_;
using PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._3__ValidarDigitosTextBox;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._1__Forms
{
    public partial class form_CadastrarClientes : Form
    {
        private int contadorCNPJ = 0;
        private int contadorCPF = 0;

        public form_CadastrarClientes()
        {
            InitializeComponent();
        }

        private void btnExibirListaDeClientes_Click(object sender, EventArgs e)
        {
            form_ListaDeClientes form = new form_ListaDeClientes();
            form.ShowDialog();
        }

        private void btnSalvarClientes_Click(object sender, EventArgs e)
        {
            CadasdroClientes cad = new CadasdroClientes(txtNomeCliente.Text, txtSobrenome.Text, txtCPF_CNPJ.Text,
                txtRG.Text, txtEmail.Text, txtTelefone.Text,
                txtCelular.Text, txtCEP.Text, txtEndereco.Text, txtNumeroApComplemento.Text, txtBairro.Text,
                txtCidade.Text, txtUF.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDigitos.ApenasLetrasBackspace(e);
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDigitos.ApenasLetrasBackspace(e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDigitos.ApenasNumerosBackspace(e);
            ValidarDigitos.PadraoTelefonicoTextBox(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDigitos.ApenasNumerosBackspace(e);
            ValidarDigitos.PadraoTelefonicoTextBox(sender, e);
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDigitos.ApenasLetrasBackspace(e);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCEP.PlaceholderText == "CEP")
            {
                txtCEP.PlaceholderText = "";
            }
            else if (txtCEP.Text == "")
            {
                txtCEP.PlaceholderText = "CEP";
            }

            ValidarDigitos.ApenasNumerosBackspace(e);
            ValidarDigitos.PadraoCEPRegiaoTextbox(sender, e);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDigitos.ApenasLetrasBackspace(e);
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            txtUF.Text = txtUF.Text.ToUpper();
            txtUF.MaxLength = 2;
        }

        private void txtCPF_CNPJ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarDigitos.ApenasNumerosBackspace(e);
            Regex pattern = new Regex("[./-]");
            string cpfApenasDigitos = pattern.Replace(txtCPF_CNPJ.Text, "");
            if (cpfApenasDigitos.Length <= 12)
            {
                contadorCNPJ = 0;
                if (contadorCPF == 0)
                {
                    FormatarCampos.FormatarTodaStringParaCpf(sender, txtCPF_CNPJ);
                    contadorCPF++;
                }
                else
                {
                    FormatarCampos.FormatandoEmTempoRealParaCpf(sender, e);
                }
            }
            else
            {
                contadorCPF = 0;
                if (contadorCNPJ == 0)
                {
                    FormatarCampos.FormatarTodaStringParaCnpj(sender, txtCPF_CNPJ);
                    contadorCNPJ++;
                }
                else
                {
                    FormatarCampos.FormatandoEmTempoRealParaCnpj(sender, e);
                }
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRG.PlaceholderText == "RG")
            {
                txtRG.PlaceholderText = "";
            }
            else if (txtRG.Text == "")
            {
                txtRG.PlaceholderText = "RG";
            }

            ValidarDigitos.PadraoDocumentoRGTextbox(sender, e);
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCamposTextBox();
        }

        private void LimparCamposTextBox()
        {
            txtRG.Clear();
            txtUF.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtCPF_CNPJ.Clear();
            txtCelular.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtNomeCliente.Clear();
            txtSobrenome.Clear();
            txtNumeroApComplemento.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
        }
    }
}