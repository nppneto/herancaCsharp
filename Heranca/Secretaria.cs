using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Secretaria : Funcionario
    {
        public int Ramal { get; set; }

        public override void ImprimeDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salário: {0:c}", this.Salario);
            Console.WriteLine("Bonificação: {0:c}", this.CalculaBonificacao());
            Console.WriteLine("Ramal: " + this.Ramal);
        }
    }
}
