using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._3___Classe_ValidarDigitos_
{
    internal class ValidarDigitos
    {
        public static bool ApenasSpaceLetrasNumerosBackspace(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return false;
            }

            return false;
        }

        public static bool ApenasLetrasBackspace(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return false;
            }

            return false;
        }

        public static void PadraoTelefonicoTextBox(object sender, KeyPressEventArgs e)
        {
            TextBox Tel = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                Tel.SelectionStart = Tel.Text.Length + 1;

                if (Tel.Text.Length == 0 || Tel.Text.Length == 1)
                    Tel.Text += "(";
                else if (Tel.Text.Length == 3)
                    Tel.Text += ")";
                else if (Tel.Text.Length == 9)
                    Tel.Text += "-";
                Tel.SelectionStart = Tel.Text.Length + 1;
            }
        }

        public static bool ApenasNumerosBackspace(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                return false;
            }

            return false;
        }

        public static void PadraoDocumentoRGTextbox(object sender, KeyPressEventArgs e)
        {
            TextBox CPF = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                CPF.SelectionStart = CPF.Text.Length + 1;

                if (CPF.Text.Length == 2 || CPF.Text.Length == 6)
                    CPF.Text += ".";
                else if (CPF.Text.Length == 10)
                    CPF.Text += "-";
                CPF.SelectionStart = CPF.Text.Length + 1;
            }
        }

        public static void PadraoCEPRegiaoTextbox(object sender, KeyPressEventArgs e)
        {
            TextBox CEP = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                CEP.SelectionStart = CEP.Text.Length + 1;

                if (CEP.Text.Length == 3 || CEP.Text.Length == 3)
                    CEP.Text += "";
                else if (CEP.Text.Length == 5)
                    CEP.Text += "-";
                CEP.SelectionStart = CEP.Text.Length + 1;
            }
        }
    }
}