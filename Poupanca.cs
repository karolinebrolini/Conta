using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria_RA_6323552
{
    public partial class Poupanca : Form
    {

        public Poupanca()
        {
            InitializeComponent();
            pnlpoupanca.Visible = true;
            pnlespecial.Visible = true;
        }
        List<Poupanca> poupanca = new List<Poupanca>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private float valor;
        private object txtSaldoinicial;

        private object txtSaldoincial { get; set; }
       

        public double Saldoinicial { get; set; }

        private void btnDeposito_Click(object sender, EventArgs e)
        {




            ContaBancaria conta = new ContaBancaria();

            if (conta != null)
            {
                conta.Depositar(valor);
            }
            else
            {
                MessageBox.Show("Conta não encontrada.");
            }

            Console.Clear();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupanca.Count; i++)
            {
                if (poupanca[i].Equals(txtNome.Text))
                {

                    double saque = Saldoinicial - Convert.ToDouble(txtSaldoincial);

                    
                    MessageBox.Show($"Saldo atual {saque}");
                    txtNome.Text = "";

                }
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btnpoupanca_Click(object sender, EventArgs e)
        {
            pnlespecial.Visible = false;
            btnDepositar.Visible = true;
            pnlpoupanca.Visible = true;
            btnpoupanca.Visible = true;
            btncriarconta.Visible = false;
            txtNome.Visible = true;
            txtNmrConta.Visible = true;
            btnrendimento.Visible = true;
            txtsaque.Visible = false;
            txtdepositar.Visible = true;

        }

        private void btnrendimento_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupanca.Count; i++)
            {
                if (poupanca[i].Equals(txtNome.Text))
                {

                    double rendimento = (Saldoinicial * 0.1);
                    Saldoinicial += rendimento;


                    MessageBox.Show($"Rendimento {rendimento}");
                    

                }
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupanca.Count; i++)
            {
                if (poupanca[i].Equals(txtNome.Text))
                {

                    double deposito = Convert.ToDouble(txtSaldoinicial);
                    Saldoinicial += deposito;
                    MessageBox.Show($"Deposito{Saldoinicial}");
                    
                  
                }
            }
        }

        private void btnespecial_Click(object sender, EventArgs e)
        {
            pnlespecial.Visible = true;
            btnDepositar.Visible = false;
            pnlpoupanca.Visible = false;
            btnpoupanca.Visible = false;
            btncriarconta.Visible = false;
            txtNomeespecial.Visible = true;
            txtNome.Visible = false;
            txtNmrConta.Visible = false;
            txtnumconta.Visible = true;
            btnrendimento.Visible = false;
            btnsacar.Visible = true;
            btnnovosaldo.Visible = true;
            txtsaque.Visible = true;
            txtdepositar.Visible = false;
        }
    }
}
