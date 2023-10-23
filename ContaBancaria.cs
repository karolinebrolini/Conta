using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria_RA_6323552
{
    class ContaBancaria
    {
        private static ContaBancaria C;
        public static ContaBancaria Conta
        {
            get
            {
                if (C == null)
                {
                    C = new ContaBancaria();
                }
                return C;
            }
        }
        public string Nome { get; set; }
        public int NmrConta { get; set; }
        public float Saldo { get; set; }

        public int CPF { get; set; }
        

        public void Depositar(float valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado. Novo saldo: R${Saldo}");
        }
        public float Limite { get; set; }

        public void Sacar(float valor)
        {
            float novoSaldo = Saldo - valor;
            if (novoSaldo >= -Limite)
            {
                Saldo = novoSaldo;
                Console.WriteLine($"Saque de R${valor} realizado. Novo saldo: R${Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }
        public int Rendimento { get; set; }
        public int SaldoInicial { get; internal set; }

        public void CalcularNovoSaldo(float taxaRendimento)
        {
            float rendimento = Saldo * taxaRendimento / 100;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento aplicado. Novo saldo: R${Saldo}");
        }
    }
}

