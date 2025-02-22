using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            // criar lista para armazenar objeto funcionario com os dados fornecidos
            List<Funcionario> listaFuncionarios = new List<Funcionario>();


            // loop par armazenar 5 objetos funcionários
            for (int i = 0; i < 5; i++) 
            {
                // chama o método inserir dados para coletar informações do funcionário
                Funcionario umFuncionario = Auxiliar2.InserirDados(); // 

                listaFuncionarios.Add( umFuncionario ); // add umfuncionario a lista funcionarios

                Console.Clear();

            }

            Console.WriteLine("Lista de Dados recebidos:");


            int cont = 1; // números de funciónarios

            //loop para listar os 5 funcionários armazenados na lista
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine("Funcionário " + cont++);
                Auxiliar2.ListarDados(listaFuncionarios[i]);

            }

            // avançar para etapa de busca
            Console.WriteLine("Pressione enter para avançar!");
            Console.ReadLine();
            Console.Clear(); // limpa tela


            // nome do funcionário para a busca
            Console.WriteLine("Digite um nome de funcionário para a busca: ");
            string nomeBusca = Console.ReadLine();

            // se o funcionário foi encontrado ou não
            bool nomeEncontrado = false;

            // percorre a listafuncionarios
            foreach(var buscar in listaFuncionarios)
            {
                // verifica se a lista de funcionarios existe o nome inserido pelo usuário
                if (nomeBusca == buscar.Nome)
                {
                    // se sim, aparece as informáções do funcionário encontrado
                    Console.WriteLine("Usuário encontrado!");
                    Console.WriteLine("\nNome: " + buscar.Nome);
                    Console.WriteLine("Idade: " + buscar.Idade);
                    Console.WriteLine("Salário: " + buscar.Salario);
                    nomeEncontrado = true; // nome encontrado fica como verdadeiro
                    break;
                }

            }

             // se não foi encontrado, apenas mostra a mensagem
            if (!nomeEncontrado)
            {
                Console.WriteLine("Usuário não encontrado !");
            }

            // avançar para próxima busca
            Console.WriteLine("\nPressione enter para avançar!");
            Console.ReadLine();
            Console.Clear(); // limpa tela


            // solicitar idade para a busca de idade entre funcionários
            Console.WriteLine("Digite uma idade de um funcionário para a busca: ");
            int idadeBusca = int.Parse(Console.ReadLine());

            // ideade encontrada está falso
            bool idadeEncontrada = false;

            // pecorre a lista funcionários 
            foreach (var buscar in listaFuncionarios)
            {
                // verifica se a idade fornecida é maior ou igual as existentes na lista
                if(buscar.Idade >= idadeBusca)
                {
                    // se sim, exibe os dados dos funcionários com idade igual ou superior 
                    Console.WriteLine("\nUsuário encontrado!");
                    Console.WriteLine("\nNome: " + buscar.Nome);
                    Console.WriteLine("Idade: " + buscar.Idade);
                    Console.WriteLine("Salário: " + buscar.Salario);
                    idadeEncontrada = true; // idade encontrada é verdadeira
                }
            }


            // se não, apenas exibe a mensagem !
            if(!idadeEncontrada)
            {
                Console.WriteLine("Idade de usuário não encontrada !");
            }



            Console.ReadKey();

        }
    }
}
