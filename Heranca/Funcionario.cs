using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalculaBonificacao()
        {
            return this.Salario * 0.1;
        }

        public virtual void ImprimeDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salário: {0:c}", this.Salario);
            Console.WriteLine("Bonificação: {0:c}", this.CalculaBonificacao());
        }
    }
}
