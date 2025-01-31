using HappySmile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacHair
{
    public partial class frmPrincipal : Form
    {
        private void AbrirForm(Form form)
        {
            if (Application.OpenForms[form.Name] != null)
            {
                Application.OpenForms[form.Name].Activate();
            }
            else
            {
                form.Show();
            }
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuario());
        }

        private void mnuCadastroCabeleireiro_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCabeleireiro());
        }

        private void mnuCadastroClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCliente());
        }

        private void mnuAgendamentos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgendamento());
        }

        private void mnuFormasPagamento_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmFormaPagamento());
        }


        private void mnuProcedimentos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProcedimento());
        }

        private void mnuSituacaoAgendamento_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmSituacao());
        }


        private void mnuSobre_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmSobre());
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
