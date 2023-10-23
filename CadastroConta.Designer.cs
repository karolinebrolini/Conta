namespace ContaBancaria_RA_6323552
{
    partial class CadastroConta
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtSaldoinicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxcpf = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNmrConta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpoupanca = new System.Windows.Forms.Button();
            this.btnespecial = new System.Windows.Forms.Button();
            this.btncriarconta = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.txtSaldoinicial);
            this.pnl1.Controls.Add(this.label6);
            this.pnl1.Controls.Add(this.mtxcpf);
            this.pnl1.Controls.Add(this.btnCadastrar);
            this.pnl1.Controls.Add(this.txtNmrConta);
            this.pnl1.Controls.Add(this.txtNome);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Location = new System.Drawing.Point(299, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(998, 624);
            this.pnl1.TabIndex = 0;
            // 
            // txtSaldoinicial
            // 
            this.txtSaldoinicial.Location = new System.Drawing.Point(261, 382);
            this.txtSaldoinicial.Multiline = true;
            this.txtSaldoinicial.Name = "txtSaldoinicial";
            this.txtSaldoinicial.Size = new System.Drawing.Size(340, 32);
            this.txtSaldoinicial.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saldo Inicial:";
            // 
            // mtxcpf
            // 
            this.mtxcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxcpf.Location = new System.Drawing.Point(261, 312);
            this.mtxcpf.Mask = "000,000,000-00";
            this.mtxcpf.Name = "mtxcpf";
            this.mtxcpf.Size = new System.Drawing.Size(179, 34);
            this.mtxcpf.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(338, 453);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(263, 56);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Criar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtNmrConta
            // 
            this.txtNmrConta.Location = new System.Drawing.Point(261, 232);
            this.txtNmrConta.Multiline = true;
            this.txtNmrConta.Name = "txtNmrConta";
            this.txtNmrConta.Size = new System.Drawing.Size(551, 36);
            this.txtNmrConta.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(261, 166);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(551, 33);
            this.txtNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número da conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTA ";
            // 
            // btnpoupanca
            // 
            this.btnpoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoupanca.Location = new System.Drawing.Point(20, 7);
            this.btnpoupanca.Name = "btnpoupanca";
            this.btnpoupanca.Size = new System.Drawing.Size(241, 103);
            this.btnpoupanca.TabIndex = 1;
            this.btnpoupanca.Text = "Conta Poupança";
            this.btnpoupanca.UseVisualStyleBackColor = true;
            // 
            // btnespecial
            // 
            this.btnespecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnespecial.Location = new System.Drawing.Point(20, 184);
            this.btnespecial.Name = "btnespecial";
            this.btnespecial.Size = new System.Drawing.Size(241, 103);
            this.btnespecial.TabIndex = 2;
            this.btnespecial.Text = "Conta Especial";
            this.btnespecial.UseVisualStyleBackColor = true;
            // 
            // btncriarconta
            // 
            this.btncriarconta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriarconta.Location = new System.Drawing.Point(20, 368);
            this.btncriarconta.Name = "btncriarconta";
            this.btncriarconta.Size = new System.Drawing.Size(241, 103);
            this.btncriarconta.TabIndex = 3;
            this.btncriarconta.Text = "Clique aqui para criar uma conta";
            this.btncriarconta.UseVisualStyleBackColor = true;
            this.btncriarconta.Click += new System.EventHandler(this.btncriarconta_Click);
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.btncriarconta);
            this.pnl2.Controls.Add(this.btnespecial);
            this.pnl2.Controls.Add(this.btnpoupanca);
            this.pnl2.Location = new System.Drawing.Point(8, 12);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(276, 623);
            this.pnl2.TabIndex = 4;
            // 
            // CadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 648);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "CadastroConta";
            this.Text = "CadastroConta";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNmrConta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxcpf;
        private System.Windows.Forms.TextBox txtSaldoinicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnpoupanca;
        private System.Windows.Forms.Button btnespecial;
        private System.Windows.Forms.Button btncriarconta;
        private System.Windows.Forms.Panel pnl2;
    }
}