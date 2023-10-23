using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria_RA_6323552
{
    public partial class TelaPoupanca : Form
    {
        public TelaPoupanca()
        {
            InitializeComponent();
        }






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TelaPoupanca_Load(object sender, EventArgs e)
        {

        }
        public float Saldo { get; set; }
        public int Rendimento { get; set; }

        private void button1_Click(object sender, EventArgs e)
        { }


        public void CalcularNovoSaldo(float taxaRendimento)
        {
            float rendimento = Saldo * taxaRendimento / 100;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento aplicado. Novo saldo: R${Saldo}");
        }
    }
    }
 


   