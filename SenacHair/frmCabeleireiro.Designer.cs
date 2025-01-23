namespace SenacHair
{
    partial class frmCabeleireiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCabeleireiro));
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnRem = new System.Windows.Forms.Button();
            this.lstProcedimentos = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboEspecialidades = new System.Windows.Forms.ComboBox();
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpDados.SuspendLayout();
            this.grpLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(6, 25);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(71, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar por";
            // 
            // btnRem
            // 
            this.btnRem.Image = global::SenacHair.Properties.Resources.Minus_16;
            this.btnRem.Location = new System.Drawing.Point(323, 102);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(25, 27);
            this.btnRem.TabIndex = 25;
            this.btnRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRem.UseVisualStyleBackColor = true;
            // 
            // lstProcedimentos
            // 
            this.lstProcedimentos.FormattingEnabled = true;
            this.lstProcedimentos.Location = new System.Drawing.Point(94, 100);
            this.lstProcedimentos.Name = "lstProcedimentos";
            this.lstProcedimentos.Size = new System.Drawing.Size(223, 108);
            this.lstProcedimentos.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::SenacHair.Properties.Resources.add_16;
            this.btnAdd.Location = new System.Drawing.Point(323, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 27);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboEspecialidades
            // 
            this.cboEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidades.FormattingEnabled = true;
            this.cboEspecialidades.Location = new System.Drawing.Point(94, 73);
            this.cboEspecialidades.Name = "cboEspecialidades";
            this.cboEspecialidades.Size = new System.Drawing.Size(223, 21);
            this.cboEspecialidades.TabIndex = 22;
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Location = new System.Drawing.Point(10, 76);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(77, 13);
            this.lblEspecialidades.TabIndex = 21;
            this.lblEspecialidades.Text = "Procedimentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(83, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(265, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.lblPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(360, 53);
            this.grpPesquisa.TabIndex = 18;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Dados para Pesquisa";
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.AllowUserToResizeColumns = false;
            this.grdDados.AllowUserToResizeRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(6, 19);
            this.grdDados.MultiSelect = false;
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.RowHeadersVisible = false;
            this.grdDados.RowHeadersWidth = 62;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(342, 190);
            this.grdDados.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(55, 47);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 21);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(293, 20);
            this.txtNome.TabIndex = 1;
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.btnRem);
            this.grpDados.Controls.Add(this.lstProcedimentos);
            this.grpDados.Controls.Add(this.btnAdd);
            this.grpDados.Controls.Add(this.cboEspecialidades);
            this.grpDados.Controls.Add(this.lblEspecialidades);
            this.grpDados.Controls.Add(this.label1);
            this.grpDados.Controls.Add(this.txtEmail);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Location = new System.Drawing.Point(12, 292);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(360, 214);
            this.grpDados.TabIndex = 20;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdDados);
            this.grpLista.Location = new System.Drawing.Point(12, 71);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(360, 215);
            this.grpLista.TabIndex = 19;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Cabeleireiros Cadastrados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SenacHair.Properties.Resources.eraser;
            this.btnLimpar.Location = new System.Drawing.Point(133, 513);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::SenacHair.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(12, 513);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 41);
            this.btnGravar.TabIndex = 30;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SenacHair.Properties.Resources.exit;
            this.btnCancelar.Location = new System.Drawing.Point(256, 513);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCabeleireiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 566);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCabeleireiro";
            this.Text = "frmCabeleireiro";
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.ListBox lstProcedimentos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboEspecialidades;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}