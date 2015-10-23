using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            BD bd = new BD();
            List<Pessoa> pessoas = new List<Pessoa>();

            Menu();

            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Pessoa pessoinha = new Pessoa();
                pessoinha.Nome = Console.ReadLine();
                pessoinha.Sobrenome = Console.ReadLine();
                pessoinha.Peso = double.Parse(Console.ReadLine());
                pessoinha.Altura = double.Parse(Console.ReadLine());
                pessoinha.Telefone = Console.ReadLine();


                string q = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone)VALUES ('{0}','{1}','{2}','{3}','{4}')", pessoinha.Nome, pessoinha.Sobrenome, pessoinha.Peso, pessoinha.Altura, pessoinha.Telefone);

                bd.InserirDado(q);
            }


            if (opcao == 2)
            {
                MenuConsulta();
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    string nome = Console.ReadLine();
                    string q = string.Format("SELECT Id, Nome, Sobrenome FROM Pessoa WHERE (Nome) VALUE ('{0}')", nome);
                    MySqlDataReader r = bd.SelecionarDados(q);

                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            Pessoa p = new Pessoa();
                            p.Id = r.GetInt31(0);
                            p.Nome = r.GetString(1);
                            p.Sobrenome = r.GetString(2);
                            p.Peso = r.GetDouble(3);
                            p.Altura = r.GetDouble(4);
                            p.Telefone = r.GetString(5);
                            pessoas.Add(p);
                        }
                        Console.WriteLine("{0}, {1} {2}", r.Id, r.Nome, r.Sobrenome);

                        if (r.ResultCount < 1)
                        {
                            Console.WriteLine("Digite o ID da pessoa desejada.");
                            int id = int.Parse(Console.ReadLine());
                            string query = string.Format("SELECT * FROM Pessoa WHERE (Id) VALUE ('{0}')", id);

                            Pessoa p = new Pessoa();
                            p.Id = r.GetInt31(0);
                            p.Nome = r.GetString(1);
                            p.Sobrenome = r.GetString(2);
                            p.Peso = r.GetDouble(3);
                            p.Altura = r.GetDouble(4);
                            p.Telefone = r.GetString(5);
                            pessoas.Add(p);
                            Console.WriteLine(r);
                        }




                    }

                    if (escolha == 2)
                    {
                        int id = int.Parse(Console.ReadLine());
                        string que = string.Format("SELECT * FROM Pessoa WHERE (ID) Value ('{0}')", id);
                        MySqlDataReader r = bd.SelecionarDados(q);

                        Pessoa p = new Pessoa();
                        p.Id = r.GetInt31(0);
                        p.Nome = r.GetString(1);
                        p.Sobrenome = r.GetString(2);
                        p.Peso = r.GetDouble(3);
                        p.Altura = r.GetDouble(4);
                        p.Telefone = r.GetString(5);
                        pessoas.Add(p);
                        Console.WriteLine(r);
                    }

                }
            }
        }


        public static void Menu()
        {
            Console.WriteLine("Cadastro e Consulta de Pessoas. Opções:");
            Console.WriteLine("1-Inserir dado");
            Console.WriteLine("2-Consultar");
            Console.WriteLine("0- Sair");
        }

        public static void MenuConsulta()
        {
            Console.WriteLine("Escolhas de consulta.");
            Console.WriteLine("1- Para consultar pelo nome.");
            Console.WriteLine("2- Para consultar pelo id.");
        }
    }
}
