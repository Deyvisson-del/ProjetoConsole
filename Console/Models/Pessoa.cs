using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        private int _id;
        private string _nome = "";
        private int _idade = 0;

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
   
        public string Nome 
        {
            get => _nome.ToUpper();

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nome não pode ser vazio ou nulo.");
                }
                _nome = value;
            }
        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Idade deve ser maior que 18 anos.");
                }
                else
                {
                    _idade = value;
                }
            }
        }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos."); 
        }
    };
}