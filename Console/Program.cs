using ProjetoConsole.Models;


Pessoa p1 = new Pessoa("João", 25);
Pessoa p2 = new Pessoa("Maria", 30);
Pessoa p3 = new Pessoa("Ítalo", 22);

Curso curso = new Curso();
Aluno aluno = new Aluno();

curso.NomeCurso = "C# Básico";

Console.WriteLine("\n");
aluno.AdicionarAluno(p1);
Console.WriteLine("\n");
aluno.AdicionarAluno(p2);
Console.WriteLine("\n");
aluno.AdicionarAluno(p3);
Console.WriteLine("\n");
aluno.ObterAlunos();
Console.WriteLine("\n");
aluno.RemoverAluno(p1);
Console.WriteLine("\n");
aluno.ObterAlunos();
Console.WriteLine("\n");


aluno.AdicionarAluno(p1);

Aluno a1 = new Aluno("Deyvisson", 19, 0123456789);
Aluno a2 = new Aluno("Rafael", 19, 0213456789);
Aluno a3 = new Aluno("Lima", 19, 0312456789);
Aluno a4 = new Aluno("Silva", 19, 0412356789);

Console.WriteLine("\n");

aluno.AdicionarAluno(a1);
aluno.AdicionarAluno(a2);
aluno.AdicionarAluno(a3);
aluno.AdicionarAluno(a4);
Console.WriteLine("\n");

aluno.ObterAlunos();
Console.WriteLine("\n");
aluno.RemoverAluno(a2);
Console.WriteLine("\n");
aluno.ObterAlunos();


Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

p1.Apresentar();
a1.Apresentar();

Professor prof1 = new Professor("Ana", 40, "Matemática");

Console.WriteLine("\n");
prof1.Apresentar();