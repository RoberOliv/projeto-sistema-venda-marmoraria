using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._1__Forms;
using System.Runtime.InteropServices;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_
{
    public partial class form_Principal : Form
    {
        private Form currentChildForm;

        public form_Principal()
        {
            InitializeComponent();
        }

        private void showChildForminPanel(Form form)
        {
            if (this.pnlDesktop.Controls.Count > 0)
            {
                this.pnlDesktop.Controls.RemoveAt(0);
            }

            //Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(form);
            form.Show();
        }

        private void OpenChildForm(Form formFilho)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.Dispose();
            }
            currentChildForm = formFilho;
            //End
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(formFilho);
            pnlDesktop.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
            //lblAbaAtual.Text = formFilho.Text;
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpcoesMenu_Click(object sender, EventArgs e)
        {
            //pnlMenu.BackgroundColor = Color.FromArgb(51, 51, 51);
            //btnCadastrarClientes.Visible = false;
            //btnCadastrarServicos.Visible = false;
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_Financeiro());
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            //showChildForminPanel(new form_CadastrarClientes());

            if (Application.OpenForms.OfType<form_CadastrarClientes>().Count() > 0)
            {
                //MessageBox.Show("O já está aberto!");
            }
            else
            {
                OpenChildForm(new form_CadastrarClientes());
            }
        }

        private void btnMinimizarJanela_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrarMateriais_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_CadastrarMateriais>().Count() > 0)
            {
                //MessageBox.Show("O já está aberto!");
            }
            else
            {
                OpenChildForm(new form_CadastrarMateriais());
            }
        }

        private void btnCadastrarServicos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_CadastrarServicos>().Count() > 0)
            {
                //MessageBox.Show("O já está aberto!");
            }
            else
            {
                OpenChildForm(new form_CadastrarServicos());
            }
        }
    }
}