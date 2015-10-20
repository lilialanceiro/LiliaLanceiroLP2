using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            BD bd = new BD();

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

                    if(r.HasRows)
                    {
                        while(r.Read())
                        {

                        }
                    }
                    


                }

                if (escolha == 2)
                {
                    int id = int.Parse(Console.ReadLine());
                    string q = string.Format("SELECT * FROM Pessoa WHERE (ID) Value ('{0}')", id);
                    MySqlDataReader r = bd.SelecionarDados(q);
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
