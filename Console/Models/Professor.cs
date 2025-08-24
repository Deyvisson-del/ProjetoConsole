using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole.Models
{
    public class Professor : Pessoa
    {
        public Professor() { }
        public Professor(string nome, int idade, string especialidade) : base(nome, idade)
        {
            Especialidade = especialidade;
        }
        private string _especialidade = "";
        public string Especialidade
        {
            get => _especialidade;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Especialidade não pode ser vazia ou nula.");
                }
                _especialidade = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", Especialidade: {Especialidade}";
        }
        public override void Apresentar()
        {
           Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha especialidade é {Especialidade}.");
        }
  
    
    }
}
