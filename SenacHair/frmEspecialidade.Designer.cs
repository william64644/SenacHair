﻿namespace SenacHair
{
    partial class frmEspecialidade
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialidade));
			this.grpLista = new System.Windows.Forms.GroupBox();
			this.grdDados = new System.Windows.Forms.DataGridView();
			this.grpPesquisa = new System.Windows.Forms.GroupBox();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.lblPesquisa = new System.Windows.Forms.Label();
			this.lblEspecialidade = new System.Windows.Forms.Label();
			this.txtEspecialidade = new System.Windows.Forms.TextBox();
			this.btnGravar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.grpDados = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.grpLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
			this.grpPesquisa.SuspendLayout();
			this.grpDados.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpLista
			// 
			this.grpLista.Controls.Add(this.grdDados);
			this.grpLista.Location = new System.Drawing.Point(12, 80);
			this.grpLista.Name = "grpLista";
			this.grpLista.Size = new System.Drawing.Size(360, 215);
			this.grpLista.TabIndex = 25;
			this.grpLista.TabStop = false;
			this.grpLista.Text = "Especialidades Cadastradas";
			// 
			// grdDados
			// 
			this.grdDados.AllowUserToAddRows = false;
			this.grdDados.AllowUserToDeleteRows = false;
			this.grdDados.AllowUserToResizeColumns = false;
			this.grdDados.AllowUserToResizeRows = false;
			this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDados.Location = new System.Drawing.Point(0, 19);
			this.grdDados.MultiSelect = false;
			this.grdDados.Name = "grdDados";
			this.grdDados.ReadOnly = true;
			this.grdDados.RowHeadersVisible = false;
			this.grdDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDados.Size = new System.Drawing.Size(342, 190);
			this.grdDados.TabIndex = 0;
			// 
			// grpPesquisa
			// 
			this.grpPesquisa.Controls.Add(this.txtPesquisa);
			this.grpPesquisa.Controls.Add(this.lblPesquisa);
			this.grpPesquisa.Location = new System.Drawing.Point(12, 21);
			this.grpPesquisa.Name = "grpPesquisa";
			this.grpPesquisa.Size = new System.Drawing.Size(360, 53);
			this.grpPesquisa.TabIndex = 24;
			this.grpPesquisa.TabStop = false;
			this.grpPesquisa.Text = "Dados para Pesquisa";
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(83, 22);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(265, 20);
			this.txtPesquisa.TabIndex = 0;
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
			// lblEspecialidade
			// 
			this.lblEspecialidade.AutoSize = true;
			this.lblEspecialidade.Location = new System.Drawing.Point(6, 26);
			this.lblEspecialidade.Name = "lblEspecialidade";
			this.lblEspecialidade.Size = new System.Drawing.Size(73, 13);
			this.lblEspecialidade.TabIndex = 19;
			this.lblEspecialidade.Text = "Especialidade";
			// 
			// txtEspecialidade
			// 
			this.txtEspecialidade.Location = new System.Drawing.Point(85, 23);
			this.txtEspecialidade.MaxLength = 100;
			this.txtEspecialidade.Name = "txtEspecialidade";
			this.txtEspecialidade.Size = new System.Drawing.Size(263, 20);
			this.txtEspecialidade.TabIndex = 0;
			// 
			// btnGravar
			// 
			this.btnGravar.Location = new System.Drawing.Point(12, 363);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(115, 41);
			this.btnGravar.TabIndex = 27;
			this.btnGravar.Text = "&Gravar";
			this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGravar.UseVisualStyleBackColor = true;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(134, 363);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(115, 41);
			this.btnLimpar.TabIndex = 28;
			this.btnLimpar.Text = "&Limpar";
			this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// grpDados
			// 
			this.grpDados.Controls.Add(this.lblEspecialidade);
			this.grpDados.Controls.Add(this.txtEspecialidade);
			this.grpDados.Location = new System.Drawing.Point(12, 301);
			this.grpDados.Name = "grpDados";
			this.grpDados.Size = new System.Drawing.Size(360, 56);
			this.grpDados.TabIndex = 26;
			this.grpDados.TabStop = false;
			this.grpDados.Text = "Dados para Cadastro";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(257, 363);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(115, 41);
			this.btnCancelar.TabIndex = 29;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// frmEspecialidade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 402);
			this.Controls.Add(this.grpLista);
			this.Controls.Add(this.grpPesquisa);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.grpDados);
			this.Controls.Add(this.btnCancelar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEspecialidade";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmEspecialidade";
			this.grpLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
			this.grpPesquisa.ResumeLayout(false);
			this.grpPesquisa.PerformLayout();
			this.grpDados.ResumeLayout(false);
			this.grpDados.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Button btnCancelar;
    }
}