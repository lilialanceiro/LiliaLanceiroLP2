using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {

                MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=test;uid=root;pwd=");

                Console.WriteLine("Digite seu login:");
                string login = Console.ReadLine();
                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();

                try
                {
                    MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuario WHERE Login=@Login AND Senha=@Senha");
                    conexao.Open();
                    comando.Connection = conexao;
                    comando.Parameters.AddWithValue("@Login", login);
                    comando.Parameters.AddWithValue("@Senha", senha);

                    MySqlDataReader reader = comando.ExecuteReader();

                    reader.Read();

                    Usuario user = new Usuario(reader);

                    if (reader.HasRows)
                    {
                        Console.WriteLine("Logado");
                        Console.WriteLine("Bem Vindo, {0}", user.Nome);
                        Console.WriteLine("Digite 1 para ver seu ultimo acesso ou 2 para logout.");
                        int opcao = int.Parse(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.WriteLine("Seu último acesso foi em: {0}", user.DataUltimoAcesso);
                            Console.WriteLine("Digite 2 para logout.");
                            opcao = int.Parse(Console.ReadLine());
                        }

                        if (opcao == 2)
                        {
                            MySqlCommand cmd = new MySqlCommand("UPDATE Usuario SET DataUltimoAcesso=@att WHERE Login=@Login");
                            cmd.Parameters.AddWithValue("@att", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@Login", login);
                            cmd.Connection = conexao;
                            cmd.ExecuteNonQuery();

                            Console.WriteLine("Até mais tarde, {0}", user.Nome);

                            conexao.Close();
                            login = string.Empty;
                            senha = string.Empty;
                            Console.ReadKey();
                        }
                    }
                }


                catch (MySqlException)
                {
                    Console.WriteLine("Usuário ou senha inválidos.");
                }
            
        }
    }
}