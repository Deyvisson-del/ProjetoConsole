//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjetoConsole.Models
//{
//    public class Aluno : Pessoa
//    {

//        public Aluno() { }
//        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
//        {
//            Matricula = matricula;
//        }
//        private int _matricula = 0;
//        public int Matricula
//        {
//            get => _matricula;
//            set
//            {
//                if (value == 0)
//                {
//                    throw new ArgumentException("Matrícula não pode ser vazia ou nula.");
//                }
//                else if (value < 0)
//                {
//                    throw new ArgumentException("Matrícula não pode ser negativa.");
//                }
//                else
//                    _matricula = value;
//            }
//        }
//        public override string ToString()
//        {
//            return base.ToString() + $", Matrícula: {Matricula}";
//        }

//        public override void Apresentar()
//        {
//            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha matrícula é {Matricula}.");
//        }

//        List<Pessoa> Alunos = new List<Pessoa>();
//        public void AdicionarAluno(Pessoa pessoa)
//        {
//            Alunos.Add(pessoa);
//            Console.WriteLine($"Pessoa {pessoa.Nome} adicionado com sucesso.");
//        }

//        public int ObterAlunos()
//        {
//            Alunos.ForEach(a => Console.WriteLine(a));
//            Console.WriteLine($"Total de pessoas do curso {Alunos.Count}:");
//            return Alunos.Count;
//        }

//        public void RemoverAluno(Pessoa pessoa)
//        {
//            if (Alunos.Contains(pessoa))
//            {
//                Alunos.Remove(pessoa);
//                Console.WriteLine($"Aluno {pessoa.Nome} removido com sucesso.");
//            }
//            else
//            {
//                throw new ArgumentException("Aluno não encontrado na lista.");
//            }
//        }
//    }
//}

