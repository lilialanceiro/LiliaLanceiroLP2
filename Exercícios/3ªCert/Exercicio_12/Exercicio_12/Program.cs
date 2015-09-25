using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gerente> Gerentes = new List<Gerente>();
            List<Empregado> Empregados = new List<Empregado>();
            List<Terceirizado> Terceirizados = new List<Terceirizado>();

            Console.WriteLine("Digite o número de funcionários.");
            int qtdFunc = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdFunc; i++)
            {
                Console.WriteLine("Digite seu 'cargo' na empresa. Gerente, Empregado ou Terceirizado.");
                string Func = Console.ReadLine();

                if(Func == "Gerente")
                {
                    Gerente gerente = new Gerente();
                    Console.Write("Nome: ");
                    gerente.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    gerente.CPF = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    gerente.DataNasc = DateTime.Parse(Console.ReadLine());
                    Console.Write("Matricula: ");
                    gerente.Matricula = Console.ReadLine();
                    Console.Write("Salário: ");
                    gerente.Salario = double.Parse(Console.ReadLine());
                    Console.Write("Área: ");
                    gerente.Area = Console.ReadLine();
                    Console.Write("Valor adicional pela área: ");
                    gerente.ValorAd = double.Parse(Console.ReadLine());

                    Gerentes.Add(gerente);
                }

                if(Func == "Empregado")
                {
                    Empregado empregado = new Empregado();
                    Console.Write("Nome: ");
                    empregado.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    empregado.CPF = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    empregado.DataNasc = DateTime.Parse(Console.ReadLine());
                    Console.Write("Matricula: ");
                    empregado.Matricula = Console.ReadLine();
                    Console.Write("Salário: ");
                    empregado.Salario = double.Parse(Console.ReadLine());

                    Empregados.Add(empregado);
                }

                if(Func == "Terceirizado")
                {
                    Terceirizado terceirizado = new Terceirizado();
                    Console.Write("Nome: ");
                    terceirizado.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    terceirizado.CPF = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    terceirizado.DataNasc = DateTime.Parse(Console.ReadLine());
                    Console.Write("Matricula: ");
                    terceirizado.Matricula = Console.ReadLine();
                    Console.Write("CNPJ: ");
                    terceirizado.CNPJ = Console.ReadLine();

                    Terceirizados.Add(terceirizado);
                }
            }

            Console.WriteLine("");
            foreach(Empregado empregado in Empregados)
            {
                Console.WriteLine("Cargo de empregado. Nome: " + empregado.Nome + ". Matrícula: " + empregado.Matricula + ". Salário: " + (empregado.Salario + empregado.ValeAlimentacao));
            }

            foreach (Gerente gerente in Gerentes)
            {
                Console.WriteLine("Cargo de gerente." + gerente);
            }



            double salarioEmpregado = 0;
            double salarioGerente = 0;
            foreach (Empregado empregado in Empregados)
            {
                salarioEmpregado += empregado.Salario + empregado.ValeAlimentacao;
            }


            foreach (Gerente gerente in Gerentes)
            {
                salarioGerente += gerente.SalarioTotal + gerente.ValeAlimentacao;
            }

            double salarioTotal = salarioEmpregado + salarioGerente;
            Console.WriteLine("A folha salarial (total) da empresa é de {0} Reais", salarioTotal);
        }
    }
}
