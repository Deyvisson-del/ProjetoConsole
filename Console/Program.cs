using ProjetoConsole.Models;
using System.Collections.Generic;
using System.Globalization;
using System;
using System.IO;



ExemploExeception exemplo = new ExemploExeception();

string basePath = AppDomain.CurrentDomain.BaseDirectory;
string projectPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
string filePath = Path.Combine(projectPath, "Arquivos", "arquivo.txt");

exemplo.LerArquivos(filePath);

var (Sucesso, linhas, QuantidadeLinhas) = exemplo.LerArquivos(filePath);

if (Sucesso)
{
    Console.WriteLine("\nlinhas do arquivo: " + QuantidadeLinhas);
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("\nA leitura falhou !!!");
}

//(int, string, string, decimal) tupla = (0, "nome-genérico", "sobrenome-genérico", 10.5M);



//Console.WriteLine($"ID:{tupla.Item1} \nNome:{tupla.Item2} \nSobrenome:{tupla.Item3} \nKM: {tupla.Item4}");



//Dictionary<string, string> estados = new Dictionary<string, string>();
//estados.Add("SP", "São Paulo");
//estados.Add("RJ", "Rio de Janeiro");
//estados.Add("MG", "Minas Gerais");


//foreach (var item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}       





//using System;
//using System.IO;

//try
//{
//    string basePath = AppDomain.CurrentDomain.BaseDirectory;
//    string projectPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
//    string filePath = Path.Combine(projectPath, "Arquivos", "arquivo.txt");
//    Console.WriteLine($"Caminho utilizado : {filePath}");

//    string[] linhas = File.ReadAllLines(filePath);
//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }

//    int divisor = 10;
//    int dividendo = 0;
//    int resultado = divisor / dividendo;
//    Console.WriteLine($"Resultado da divisão: {resultado}");
//    Console.WriteLine("Arquivo lido com sucesso!");
//}
//catch (FileNotFoundException e) { Console.WriteLine($"Arquivo não encontrado: {e.Message}"); }
//catch (DirectoryNotFoundException e) { Console.WriteLine($"Diretório não encontrado: {e.Message}"); }
//catch (Exception ex) { Console.WriteLine($"Ocorreu um erro genérico: {ex.Message}"); }

//finally { Console.WriteLine("Finalizando Conexão\nEncerrando Programa..."); }









//string data = "2005-18-18 23:00";

//bool sucesso = DateTime.TryParseExact(data, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataSaida);

//if (!sucesso)
//{
//    Console.WriteLine($"{dataSaida} Data em formato inválido");
//}
//else
//{
//    Console.WriteLine("Sucesso!!!\n"+dataSaida);
//}















//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//DateTime dateTime = DateTime.Now;


//Console.WriteLine(dateTime.ToShortDateString());
//Console.WriteLine("\n");
//Console.WriteLine(dateTime.ToShortTimeString());
//Console.WriteLine("\n");
//Console.WriteLine(dateTime.ToLongDateString());
//Console.WriteLine("\n");
//Console.WriteLine(dateTime.ToLongTimeString());


//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//double valor = 5.40;

//string mensagem = "Você tem ";




//float cpf = 12345678910;
//string format = @"###\.###\.###\-##";

//Console.WriteLine($"CPF: {cpf.ToString(format)}");

//float ipv4 = 19216800101;

//Console.WriteLine($"IPv4: {ipv4.ToString(format)}");










//Console.WriteLine($"{valor:C}");


//Console.WriteLine("Dólar: " + mensagem + valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " em sua conta.");
//Console.WriteLine("Euro: " + mensagem + valor.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR")) + " em sua conta.");
//Console.WriteLine("Libra: " + mensagem + valor.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")) + " em sua conta.");   


//Console.WriteLine($"{valor.ToString("N8")}");


//Pessoa p1 = new Pessoa("João", 25);
//Pessoa p2 = new Pessoa("Maria", 30);
//Pessoa p3 = new Pessoa("Ítalo", 22);

//Curso curso = new Curso();
//Aluno aluno = new Aluno();

//curso.NomeCurso = "C# Básico";

//Console.WriteLine("\n");
//aluno.AdicionarAluno(p1);
//Console.WriteLine("\n");
//aluno.AdicionarAluno(p2);
//Console.WriteLine("\n");
//aluno.AdicionarAluno(p3);
//Console.WriteLine("\n");
//aluno.ObterAlunos();
//Console.WriteLine("\n");
//aluno.RemoverAluno(p1);
//Console.WriteLine("\n");
//aluno.ObterAlunos();
//Console.WriteLine("\n");


//aluno.AdicionarAluno(p1);

//Aluno a1 = new Aluno("Deyvisson", 19, 0123456789);
//Aluno a2 = new Aluno("Rafael", 19, 0213456789);
//Aluno a3 = new Aluno("Lima", 19, 0312456789);
//Aluno a4 = new Aluno("Silva", 19, 0412356789);

//Console.WriteLine("\n");

//aluno.AdicionarAluno(a1);
//aluno.AdicionarAluno(a2);
//aluno.AdicionarAluno(a3);
//aluno.AdicionarAluno(a4);
//Console.WriteLine("\n");

//aluno.ObterAlunos();
//Console.WriteLine("\n");
//aluno.RemoverAluno(a2);
//Console.WriteLine("\n");
//aluno.ObterAlunos();


//Console.WriteLine("\n");
//Console.WriteLine("\n");
//Console.WriteLine("\n");

//p1.Apresentar();
//a1.Apresentar();

//Professor prof1 = new Professor("Ana", 40, "Matemática");

//Console.WriteLine("\n");
//prof1.Apresentar();