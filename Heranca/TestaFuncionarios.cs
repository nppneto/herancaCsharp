using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class TestaFuncionarios
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Nelson Neto";
            g.Salario = 2000;
            g.Usuario = "nelson.neto";
            g.Senha = "codesp1909";
            g.ImprimeDados();

            Console.WriteLine("--------------------------------------------");

            Telefonista t = new Telefonista();
            t.Nome = "Natasha Alves";
            t.Salario = 1500;
            t.EstacaoDeTrabalho = 13;
            t.ImprimeDados();

            Console.WriteLine("--------------------------------------------");

            Secretaria s = new Secretaria();
            s.Nome = "Geyse Arruda";
            s.Salario = 970;
            s.Ramal = 198;
            s.ImprimeDados();

            //Console.WriteLine("GERENTE");
            //Console.WriteLine("Nome: " + g.Nome);
            //Console.WriteLine("Salário: {0:c}", g.Salario);
            //Console.WriteLine("Bonificação: {0:c}", g.CalculaBonificacao());
            //Console.WriteLine("Usuário: " + g.Usuario);
            //Console.WriteLine("Senha: " + g.Senha);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("TELEFONISTA");
            //Console.WriteLine("Nome: " + t.Nome);
            //Console.WriteLine("Salário: {0:c}", t.Salario);
            //Console.WriteLine("Bonificação: {0:c}", t.CalculaBonificacao());
            //Console.WriteLine("Estação de trabalho: " + t.EstacaoDeTrabalho);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("SECRETÁRIA");
            //Console.WriteLine("Nome: " + s.Nome);
            //Console.WriteLine("Salário: {0:c}", s.Salario);
            //Console.WriteLine("Bonificação: {0:c}", s.CalculaBonificacao());
            //Console.WriteLine("Ramal: " + s.Ramal);

            Console.ReadKey();
        }
    }
}
