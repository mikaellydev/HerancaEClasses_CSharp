using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02
{
    public class Auxiliar2
    {
        // método para inserir dados dos funcionários
        public static Funcionario InserirDados()
        {
            // criando um objeto funcionário
            Funcionario umFuncionario = new Funcionario();

            Console.WriteLine("Vamos fazer uma verificação de dados na empresa!");

            Console.WriteLine("\nPor favor insira seu nome para identificação: "); // nome funcionario
            umFuncionario.Nome = Console.ReadLine();

            Console.WriteLine("\nInsira sua idade:"); // idade funcionario
            umFuncionario.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSalário:"); // salario funcionario
            umFuncionario.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados recebidos! obrigado pela colaboração"); // confirmação de dados

            // retorna objeto funcionario com todas as informações para ser armazenado na lista
            return umFuncionario; 
        }

        // exibir os dados inseridos pelo funcionário
        // ele recebe um objeto do tipo Funcionario, que contém nome, idade e salário.
        public static void ListarDados(Funcionario umFuncionario) 
        {
            Console.WriteLine($"Nome:  {umFuncionario.Nome}");
            Console.WriteLine($"idade: {umFuncionario.Idade}");
            Console.WriteLine($"Salário: {umFuncionario.Salario}");
            Console.WriteLine("---------------------------------");

        }

    }
}
