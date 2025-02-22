using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02
{
    // criando a classe pessoa
    public class Pessoa 
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;

            this.Idade = idade;

        }

    }

    // criando a classe funcionario com herança de pessoa
    public class Funcionario : Pessoa
    {
        public float Salario;

        public Funcionario() { }

        public Funcionario(float salario, string nome, int idade)
        {
           this.Salario = salario;
           this.Nome = nome;   
           this.Idade = idade; 
        }

    }


}
