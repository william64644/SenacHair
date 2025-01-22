namespace SenacHair
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(15, 182);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(277, 82);
            this.lblTexto.TabIndex = 38;
            this.lblTexto.Text = resources.GetString("lblTexto.Text");
            // 
            // lblSistema
            // 
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(12, 83);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(157, 93);
            this.lblSistema.TabIndex = 37;
            this.lblSistema.Text = "Happy Smile \r\nSistema Gerenciamento de Consultórios\r\nVersão 3.6.45\r\n(c)2024 Code " +
    "Technology\r\nTodos os direitos reservados.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SenacHair.Properties.Resources.exit;
            this.btnCancelar.Location = new System.Drawing.Point(298, 182);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 81);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::SenacHair.Properties.Resources.Logo_Code_Black;
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(157, 68);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 36;
            this.pctLogo.TabStop = false;
            // 
            // pctCliente
            // 
            this.pctCliente.Image = global::SenacHair.Properties.Resources.facebook;
            this.pctCliente.Location = new System.Drawing.Point(175, 12);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(180, 164);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctCliente.TabIndex = 35;
            this.pctCliente.TabStop = false;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 283);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pctCliente);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSobre";
            this.Text = "frmSobre";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.Button btnCancelar;
    }
}