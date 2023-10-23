namespace ContaBancaria_RA_6323552
{
    partial class Poupanca
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNmrConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btncriarconta = new System.Windows.Forms.Button();
            this.btnespecial = new System.Windows.Forms.Button();
            this.btnpoupanca = new System.Windows.Forms.Button();
            this.pnlpoupanca = new System.Windows.Forms.Panel();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnrendimento = new System.Windows.Forms.Button();
            this.pnlespecial = new System.Windows.Forms.Panel();
            this.btnnovosaldo = new System.Windows.Forms.Button();
            this.btnsacar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumconta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeespecial = new System.Windows.Forms.TextBox();
            this.txtsaque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdepositar = new System.Windows.Forms.TextBox();
            this.pnl2.SuspendLayout();
            this.pnlpoupanca.SuspendLayout();
            this.pnlespecial.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(206, 65);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(514, 39);
            this.txtNome.TabIndex = 4;
            // 
            // txtNmrConta
            // 
            this.txtNmrConta.Location = new System.Drawing.Point(206, 136);
            this.txtNmrConta.Multiline = true;
            this.txtNmrConta.Name = "txtNmrConta";
            this.txtNmrConta.Size = new System.Drawing.Size(514, 39);
            this.txtNmrConta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número da Conta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.btncriarconta);
            this.pnl2.Controls.Add(this.btnespecial);
            this.pnl2.Controls.Add(this.btnpoupanca);
            this.pnl2.Location = new System.Drawing.Point(12, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(276, 649);
            this.pnl2.TabIndex = 10;
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
            this.btnespecial.Click += new System.EventHandler(this.btnespecial_Click);
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
            this.btnpoupanca.Click += new System.EventHandler(this.btnpoupanca_Click);
            // 
            // pnlpoupanca
            // 
            this.pnlpoupanca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpoupanca.Controls.Add(this.pnlespecial);
            this.pnlpoupanca.Controls.Add(this.txtdepositar);
            this.pnlpoupanca.Controls.Add(this.label6);
            this.pnlpoupanca.Controls.Add(this.btnDepositar);
            this.pnlpoupanca.Controls.Add(this.btnrendimento);
            this.pnlpoupanca.Controls.Add(this.label1);
            this.pnlpoupanca.Controls.Add(this.txtNmrConta);
            this.pnlpoupanca.Controls.Add(this.label2);
            this.pnlpoupanca.Controls.Add(this.txtNome);
            this.pnlpoupanca.Location = new System.Drawing.Point(301, 28);
            this.pnlpoupanca.Name = "pnlpoupanca";
            this.pnlpoupanca.Size = new System.Drawing.Size(751, 328);
            this.pnlpoupanca.TabIndex = 11;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(453, 242);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(227, 46);
            this.btnDepositar.TabIndex = 11;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnrendimento
            // 
            this.btnrendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrendimento.Location = new System.Drawing.Point(108, 242);
            this.btnrendimento.Name = "btnrendimento";
            this.btnrendimento.Size = new System.Drawing.Size(227, 46);
            this.btnrendimento.TabIndex = 10;
            this.btnrendimento.Text = "Calcular Rendimentos";
            this.btnrendimento.UseVisualStyleBackColor = true;
            this.btnrendimento.Click += new System.EventHandler(this.btnrendimento_Click);
            // 
            // pnlespecial
            // 
            this.pnlespecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlespecial.Controls.Add(this.label5);
            this.pnlespecial.Controls.Add(this.txtsaque);
            this.pnlespecial.Controls.Add(this.btnnovosaldo);
            this.pnlespecial.Controls.Add(this.btnsacar);
            this.pnlespecial.Controls.Add(this.label3);
            this.pnlespecial.Controls.Add(this.txtnumconta);
            this.pnlespecial.Controls.Add(this.label4);
            this.pnlespecial.Controls.Add(this.txtNomeespecial);
            this.pnlespecial.Location = new System.Drawing.Point(3, -1);
            this.pnlespecial.Name = "pnlespecial";
            this.pnlespecial.Size = new System.Drawing.Size(751, 328);
            this.pnlespecial.TabIndex = 12;
            // 
            // btnnovosaldo
            // 
            this.btnnovosaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovosaldo.Location = new System.Drawing.Point(453, 242);
            this.btnnovosaldo.Name = "btnnovosaldo";
            this.btnnovosaldo.Size = new System.Drawing.Size(227, 46);
            this.btnnovosaldo.TabIndex = 11;
            this.btnnovosaldo.Text = "Consultar Novo Saldo";
            this.btnnovosaldo.UseVisualStyleBackColor = true;
            // 
            // btnsacar
            // 
            this.btnsacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsacar.Location = new System.Drawing.Point(108, 242);
            this.btnsacar.Name = "btnsacar";
            this.btnsacar.Size = new System.Drawing.Size(227, 46);
            this.btnsacar.TabIndex = 10;
            this.btnsacar.Text = "Sacar";
            this.btnsacar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            // 
            // txtnumconta
            // 
            this.txtnumconta.Location = new System.Drawing.Point(206, 129);
            this.txtnumconta.Multiline = true;
            this.txtnumconta.Name = "txtnumconta";
            this.txtnumconta.Size = new System.Drawing.Size(514, 39);
            this.txtnumconta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número da Conta:";
            // 
            // txtNomeespecial
            // 
            this.txtNomeespecial.Location = new System.Drawing.Point(206, 65);
            this.txtNomeespecial.Multiline = true;
            this.txtNomeespecial.Name = "txtNomeespecial";
            this.txtNomeespecial.Size = new System.Drawing.Size(514, 39);
            this.txtNomeespecial.TabIndex = 4;
            // 
            // txtsaque
            // 
            this.txtsaque.Location = new System.Drawing.Point(206, 191);
            this.txtsaque.Multiline = true;
            this.txtsaque.Name = "txtsaque";
            this.txtsaque.Size = new System.Drawing.Size(514, 39);
            this.txtsaque.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor para Saque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor para Depositar:";
            // 
            // txtdepositar
            // 
            this.txtdepositar.Location = new System.Drawing.Point(206, 194);
            this.txtdepositar.Multiline = true;
            this.txtdepositar.Name = "txtdepositar";
            this.txtdepositar.Size = new System.Drawing.Size(514, 39);
            this.txtdepositar.TabIndex = 13;
            // 
            // Poupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 689);
            this.Controls.Add(this.pnlpoupanca);
            this.Controls.Add(this.pnl2);
            this.Name = "Poupanca";
            this.Text = "TelaContas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl2.ResumeLayout(false);
            this.pnlpoupanca.ResumeLayout(false);
            this.pnlpoupanca.PerformLayout();
            this.pnlespecial.ResumeLayout(false);
            this.pnlespecial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNmrConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btncriarconta;
        private System.Windows.Forms.Button btnespecial;
        private System.Windows.Forms.Button btnpoupanca;
        private System.Windows.Forms.Panel pnlpoupanca;
        private System.Windows.Forms.Button btnrendimento;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Panel pnlespecial;
        private System.Windows.Forms.Button btnnovosaldo;
        private System.Windows.Forms.Button btnsacar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumconta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeespecial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsaque;
        private System.Windows.Forms.TextBox txtdepositar;
        private System.Windows.Forms.Label label6;
    }
}

