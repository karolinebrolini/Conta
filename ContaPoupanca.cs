using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria_RA_6323552
{
    
     internal class ContaPoupanca : ContaBancaria
    {
        public float saldo { get; set; }
        public int rendimento { get; set; }
        
        public new void CalcularNovoSaldo(float taxaRendimento)
        {

            float rendimento = (Saldo * taxaRendimento) ;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento aplicado. Novo saldo: R${Saldo}");
        }
    }
}
