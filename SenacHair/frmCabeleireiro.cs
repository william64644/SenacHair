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
    public partial class frmCabeleireiro : Form
    {
        public frmCabeleireiro()
        {
            InitializeComponent();
        }
        //Instanciamos o objeto principal do formulário
        Cabeleireiro cabeleireiro = new Cabeleireiro();
        //Criamos o método para preencher o ComboBox com as especialidades disponíveis no banco de dados

        private void PreencherEspecialidades()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Instanciamos o objeto
                Especialidade e = new Especialidade();
                //Carregamos o ComboBox com o resultado da consulta das especialidades (DataTable)
                cboEspecialidade.DataSource = e.Consultar();
                //Definimos o valor a ser exibido para o usuário
                cboEspecialidade.DisplayMember = "Especialidade";
                //Definimos o valor a ser armazenado após o usuário selecionar um item
                cboEspecialidade.ValueMember = "Id";
                //Definimos que o ComboBox irá ser iniciado sem nenhuma opção escolhida
                cboEspecialidade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Mostramos a mensagem de erro ao usuário
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCabeleireiro_Load(object sender, EventArgs e)
        {
            //Chamamos o método para preencher o ComboBox com as especialidades
            PreencherEspecialidades();
            //Copiamos as definições de exibição e atribuição de valores do ComboBox para o ListBox
            lstEspecialidade.DisplayMember = cboEspecialidade.DisplayMember;
            lstEspecialidade.ValueMember = cboEspecialidade.ValueMember;
            //Chamamos o método para preencher o Grid com os Dentistas cadastrados
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Preenchemos o Grid com o resultado da consulta dos dentistas
                grdDados.DataSource = cabeleireiro.Consultar();
                //Ocultar colunas
                grdDados.Columns[0].Visible = false; //Id
                //Cabeçalho das colunas
                grdDados.Columns[1].HeaderText = "Nome";
                grdDados.Columns[2].HeaderText = "Email";
                //Largura das colunas
                grdDados.Columns[1].Width = 250;
                grdDados.Columns[2].Width = 150;

            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Mostramos a mensagem de erro ao usuário
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Caso não tenhamos nenhuma especialidade selecionada, não executamos nenhuma ação
            if (cboEspecialidade.SelectedIndex == -1) return;

            if (lstEspecialidade.Items.IndexOf(cboEspecialidade.SelectedItem) != -1)
            {
                //Caso a especialidade já tenha sido adicionada anteriormente
                //Exibimos a mensagem ao usuário e não executamos nenhuma ação
                MessageBox.Show("Especialidade já selecionada.",
                    "Cadastro de Dentistas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Adicionamos ao ListBox a especialidade selecionada no ComboBox
            lstEspecialidade.Items.Add(cboEspecialidade.SelectedItem);
            //Posicionamos o ComboBox na opção em branco
            cboEspecialidade.SelectedIndex = -1;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Resetamos o objeto             
            cabeleireiro = new Cabeleireiro();
            //Atribuímos o nome para pesquisa
            cabeleireiro.nome = txtPesquisa.Text;
            //Chamamos o método para preencher o Grid com o resultado do filtro aplicado
            CarregarGrid();
        }

        private void PreencherFormulario()
        {
            //Preenchemos os controle do formulário com suas
            //respectivas informações contidas no objeto
            txtNome.Text = cabeleireiro.nome;
            txtEmail.Text = cabeleireiro.email;
            //Limpamos o ListBox
            lstEspecialidade.Items.Clear();
            //Percorremos todas as especialidades retornadas do banco de dados
            foreach (Especialidade e in cabeleireiro.especialidades)
            {
                //Posicionamos o ComboBox na opção correspondente à especialidade cadastrada
                cboEspecialidade.SelectedValue = e.id;
                //Simulamos o click no botão Adicionar (+)
                btnAdd.PerformClick();
            }
        }
        private void PreencherClasse()
        {
            //Atribuímos às propriedades do objeto os respectivos valores informados no formulário
            cabeleireiro.nome = txtNome.Text;
            cabeleireiro.email = txtEmail.Text;
            //Limpamos a lista de especialidades
            cabeleireiro.especialidades.Clear();
            //Percorremos todas as especialidades adicionadas ao ListBox
            foreach (DataRowView item in lstEspecialidade.Items)
            {
                //Instanciamos um objeto de especialidade
                Especialidade e = new Especialidade();
                //Atribuímos os respectivos valores às propriedades do objeto
                e.id = Convert.ToInt32(item.Row.ItemArray[0]);
                e.especialidade = item.Row.ItemArray[1].ToString();
                //Adicionamos o objeto à lista de especialidades do objeto principal
                cabeleireiro.especialidades.Add(e);
            }
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Resetamos o objeto  
                cabeleireiro = new Cabeleireiro();
                //Atribuímos o Id do dentista a propriedade
                cabeleireiro.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                //Efetuamos a consulta para obter os dados do dentista
                cabeleireiro.Consultar();
                //Chamamos o método para preencher os dados do formulário
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Mostramos a mensagem de erro ao usuário
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Efetuamos a validação do preenchimento do formulário
                //e armazenamos as mensagens de erro retornadas pelo método
                string mensagemErro = ValidarPreenchimento();
                if (mensagemErro != string.Empty)
                {
                    //Caso seja encontrada algum conteúdo na mensagem de Erro
                    //Exibimos a mensagem ao usuário e encerramos o fluxo de gravação
                    MessageBox.Show(mensagemErro, "Erro de Preenchimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Chamamos o método para preencher o objeto com os dados
                //Preenchidos no formulário
                PreencherClasse();
                //Chamamos o método para efetivar a gravação dos dados
                cabeleireiro.Gravar();
                //Exibimos a mensagem de sucesso na gravação dos dados
                MessageBox.Show("Dentista gravado com sucesso!",
                    "Cadastro de Dentistas",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                //chamamos o método para limpar o formulário
                LimparCampos();
                //Atualizamos o grid com os dados gravados no banco de dados
                CarregarGrid();
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Mostramos a mensagem de erro ao usuário
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fechamos o formulário
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chamamos o método para limpar o formulário
            LimparCampos();
        }

        private void LimparCampos()
        {
            //Resetamos o objeto 
            cabeleireiro = new Cabeleireiro();
            //Limpamos todos os TextBox
            txtPesquisa.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            //Removemos todos os items adicionados no ListBox
            lstEspecialidade.Items.Clear();
            //Posicionamos o ComboBox na opção em branco
            cboEspecialidade.SelectedIndex = -1;
            //colocamos o cursor no TextBox de Pesquisa
            txtPesquisa.Focus();
        }
        private string ValidarPreenchimento()
        {
            //Fazemos a validação do preenchimento do formulário
            string msgErro = string.Empty;
            if (txtNome.Text == string.Empty)
            {
                msgErro = "Preencha o NOME.\n";
            }
            if (txtEmail.Text == string.Empty)
            {
                msgErro += "Preencha o EMAIL.\n";
            }
            if (lstEspecialidade.Items.Count == 0)
            {
                msgErro += "Preencha as ESPECIALIDADES.\n";
            }
            //Retornamos as mensagens de erro encontradas
            return msgErro;
        }
        private void btnRem_Click(object sender, EventArgs e)
        {
            //Caso não tenhamos nenhuma especialidade adicionada, não executamos nenhuma ação
            if (lstEspecialidade.SelectedIndex == -1) return;

            //Exibimos a mensagem ao usuário, solicitando a confirmação da exclusão
            //da especialidade selecionada
            string item = lstEspecialidade.Text;
            if (MessageBox.Show($"Deseja remover o item {item}?",
                "Cadastro de Dentistas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            //Caso o usuário confirma a intenção, removemos a especialidade selecionada
            lstEspecialidade.Items.Remove(lstEspecialidade.SelectedItem);
        }
    }
}
