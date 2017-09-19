using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Gerente : Funcionario
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public override double CalculaBonificacao()
        {
            return this.Salario * 0.6 + 100;
        }

        public override void ImprimeDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salário: {0:c}", this.Salario);
            Console.WriteLine("Bonificação: {0:c}", this.CalculaBonificacao());
            Console.WriteLine("Usuário: " + this.Usuario);
            Console.WriteLine("Senha: " + this.Senha);
        }
    }
}
