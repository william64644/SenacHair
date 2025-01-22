namespace SenacHair
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTiposTelefone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSituacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcedimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormasPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDominios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sai&r";
            // 
            // mnuTiposTelefone
            // 
            this.mnuTiposTelefone.Name = "mnuTiposTelefone";
            this.mnuTiposTelefone.Size = new System.Drawing.Size(219, 22);
            this.mnuTiposTelefone.Text = "Tipos de &Telefones";
            // 
            // mnuTipos
            // 
            this.mnuTipos.Name = "mnuTipos";
            this.mnuTipos.Size = new System.Drawing.Size(219, 22);
            this.mnuTipos.Text = "Tipos de &Cliente";
            // 
            // mnuSituacoes
            // 
            this.mnuSituacoes.Name = "mnuSituacoes";
            this.mnuSituacoes.Size = new System.Drawing.Size(219, 22);
            this.mnuSituacoes.Text = "&Situações de Agendamento";
            // 
            // mnuProcedimentos
            // 
            this.mnuProcedimentos.Name = "mnuProcedimentos";
            this.mnuProcedimentos.Size = new System.Drawing.Size(219, 22);
            this.mnuProcedimentos.Text = "&Procedimentos";
            // 
            // mnuFormasPagamento
            // 
            this.mnuFormasPagamento.Name = "mnuFormasPagamento";
            this.mnuFormasPagamento.Size = new System.Drawing.Size(219, 22);
            this.mnuFormasPagamento.Text = "&Formas de Pagamento";
            // 
            // mnuEspecialidades
            // 
            this.mnuEspecialidades.Name = "mnuEspecialidades";
            this.mnuEspecialidades.Size = new System.Drawing.Size(219, 22);
            this.mnuEspecialidades.Text = "&Especialidades";
            // 
            // mnuDominios
            // 
            this.mnuDominios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEspecialidades,
            this.mnuFormasPagamento,
            this.mnuProcedimentos,
            this.mnuSituacoes,
            this.mnuTipos,
            this.mnuTiposTelefone});
            this.mnuDominios.Name = "mnuDominios";
            this.mnuDominios.Size = new System.Drawing.Size(70, 20);
            this.mnuDominios.Text = "Do&mínios";
            // 
            // mnuAgendamentos
            // 
            this.mnuAgendamentos.Name = "mnuAgendamentos";
            this.mnuAgendamentos.Size = new System.Drawing.Size(100, 20);
            this.mnuAgendamentos.Text = "&Agendamentos";
            // 
            // mnuCadastroDentista
            // 
            this.mnuCadastroDentista.Name = "mnuCadastroDentista";
            this.mnuCadastroDentista.Size = new System.Drawing.Size(167, 22);
            this.mnuCadastroDentista.Text = "Cadastro &Dentista";
            // 
            // mnuDentistas
            // 
            this.mnuDentistas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroDentista});
            this.mnuDentistas.Name = "mnuDentistas";
            this.mnuDentistas.Size = new System.Drawing.Size(67, 20);
            this.mnuDentistas.Text = "&Dentistas";
            // 
            // mnuCadastroPaciente
            // 
            this.mnuCadastroPaciente.Name = "mnuCadastroPaciente";
            this.mnuCadastroPaciente.Size = new System.Drawing.Size(169, 22);
            this.mnuCadastroPaciente.Text = "Cadastro &Paciente";
            // 
            // mnuPacientes
            // 
            this.mnuPacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroPaciente});
            this.mnuPacientes.Name = "mnuPacientes";
            this.mnuPacientes.Size = new System.Drawing.Size(69, 20);
            this.mnuPacientes.Text = "&Pacientes";
            // 
            // mnuCadastroUsuario
            // 
            this.mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            this.mnuCadastroUsuario.Size = new System.Drawing.Size(164, 22);
            this.mnuCadastroUsuario.Text = "&Cadastro Usuário";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroUsuario});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mnuUsuarios.Text = "&Usuários";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuPacientes,
            this.mnuDentistas,
            this.mnuAgendamentos,
            this.mnuDominios,
            this.mnuSobre,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(49, 20);
            this.mnuSobre.Text = "&Sobre";
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Enabled = true;
            this.tmrPrincipal.Interval = 1000;
            // 
            // lblTempo
            // 
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(261, 17);
            this.lblTempo.Spring = true;
            this.lblTempo.Text = "Tempo: 00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConexao
            // 
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(261, 17);
            this.lblConexao.Spring = true;
            this.lblConexao.Text = "Servidor: 192.168.10.15 | Banco: Cliente";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(261, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuario: ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblConexao,
            this.lblTempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuTiposTelefone;
        private System.Windows.Forms.ToolStripMenuItem mnuTipos;
        private System.Windows.Forms.ToolStripMenuItem mnuSituacoes;
        private System.Windows.Forms.ToolStripMenuItem mnuProcedimentos;
        private System.Windows.Forms.ToolStripMenuItem mnuFormasPagamento;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mnuDominios;
        private System.Windows.Forms.ToolStripMenuItem mnuAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroDentista;
        private System.Windows.Forms.ToolStripMenuItem mnuDentistas;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroPaciente;
        private System.Windows.Forms.ToolStripMenuItem mnuPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.Timer tmrPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.ToolStripStatusLabel lblConexao;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}