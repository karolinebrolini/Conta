using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria_RA_6323552
{
    public partial class CadastroConta : Form
    {
        public CadastroConta()
        {
            InitializeComponent();
            pnl1.Visible = true; 
           
           
        }
        ContaBancaria Nome = new ContaBancaria();
        ContaBancaria CPF = new ContaBancaria();
        ContaBancaria NmrConta = new ContaBancaria();
        ContaBancaria SaldoInicial = new ContaBancaria();

        Form tela;

        List<CadastroConta> cadastro = new List<CadastroConta>();
       
        private void btncriarconta_Click(object sender, EventArgs e)
        {
            txtNome.Visible = true;
            txtNmrConta.Visible = true;
            label2.Visible = true;
            label4.Visible= true;
            mtxcpf.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            txtSaldoinicial.Visible = true;
            btnCadastrar.Visible = true;
            pnl1.Visible=true;
            ContaBancaria.Conta.Nome = txtNome.Text;
            ContaBancaria.Conta.NmrConta = int.Parse(txtNmrConta.Text);
            ContaBancaria.Conta.CPF = int.Parse(mtxcpf.Text);
            ContaBancaria.Conta.SaldoInicial = Convert.ToInt32(txtSaldoinicial.Text);
            MessageBox.Show("Cadastro concluído com sucesso!");

           
        }

    }
}
