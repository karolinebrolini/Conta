using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria_RA_6323552
{
    internal class ContaEspecial : ContaBancaria
        
    {
        public new float Limite { get; set; }
        public new void Sacar(float valor)
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
    }
    
}


