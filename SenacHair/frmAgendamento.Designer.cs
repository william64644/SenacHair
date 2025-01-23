namespace SenacHair
{
    partial class frmAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamento));
            this.grpAgendamento = new System.Windows.Forms.GroupBox();
            this.grdAgendamento = new System.Windows.Forms.DataGridView();
            this.dtpAgendamento = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.cboDentista = new System.Windows.Forms.ComboBox();
            this.lblDentista = new System.Windows.Forms.Label();
            this.grpAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgendamento
            // 
            this.grpAgendamento.Controls.Add(this.grdAgendamento);
            this.grpAgendamento.Location = new System.Drawing.Point(12, 40);
            this.grpAgendamento.Name = "grpAgendamento";
            this.grpAgendamento.Size = new System.Drawing.Size(459, 352);
            this.grpAgendamento.TabIndex = 7;
            this.grpAgendamento.TabStop = false;
            // 
            // grdAgendamento
            // 
            this.grdAgendamento.AllowUserToAddRows = false;
            this.grdAgendamento.AllowUserToDeleteRows = false;
            this.grdAgendamento.AllowUserToResizeColumns = false;
            this.grdAgendamento.AllowUserToResizeRows = false;
            this.grdAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgendamento.Location = new System.Drawing.Point(6, 10);
            this.grdAgendamento.MultiSelect = false;
            this.grdAgendamento.Name = "grdAgendamento";
            this.grdAgendamento.ReadOnly = true;
            this.grdAgendamento.RowHeadersVisible = false;
            this.grdAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAgendamento.Size = new System.Drawing.Size(447, 336);
            this.grdAgendamento.TabIndex = 0;
            // 
            // dtpAgendamento
            // 
            this.dtpAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAgendamento.Location = new System.Drawing.Point(369, 13);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(96, 20);
            this.dtpAgendamento.TabIndex = 6;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(333, 12);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // cboDentista
            // 
            this.cboDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDentista.FormattingEnabled = true;
            this.cboDentista.Location = new System.Drawing.Point(80, 12);
            this.cboDentista.Name = "cboDentista";
            this.cboDentista.Size = new System.Drawing.Size(236, 21);
            this.cboDentista.TabIndex = 9;
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDentista.Location = new System.Drawing.Point(15, 14);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(62, 13);
            this.lblDentista.TabIndex = 8;
            this.lblDentista.Text = "Cabeleireiro";
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 447);
            this.Controls.Add(this.grpAgendamento);
            this.Controls.Add(this.dtpAgendamento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cboDentista);
            this.Controls.Add(this.lblDentista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgendamento";
            this.Text = "frmAgendamento";
            this.grpAgendamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgendamento;
        private System.Windows.Forms.DataGridView grdAgendamento;
        private System.Windows.Forms.DateTimePicker dtpAgendamento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cboDentista;
        private System.Windows.Forms.Label lblDentista;
    }
}