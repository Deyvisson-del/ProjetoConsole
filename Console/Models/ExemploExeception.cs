using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole.Models
{
    public class ExemploExeception
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            //Queue<int> fila = new Queue<int>();
            //fila.Enqueue(1);
            //fila.Enqueue(2);
            //fila.Enqueue(3);
            //fila.Enqueue(4);
            //fila.Enqueue(5);
            //foreach (var item in fila)
            //{
            //    Console.WriteLine($"item da Fila: {item}");
            //}
            //fila.Dequeue();
            //foreach (var item in fila)
            //{
            //    Console.WriteLine($"item da Fila: {item}");
            //}

            //Stack<int> pilha = new Stack<int>();
            //pilha.Push(1);
            //pilha.Push(2);
            //pilha.Push(3);
            //pilha.Push(4);
            //pilha.Push(5);
            //foreach (var item in pilha)
            //{
            //    Console.WriteLine($"item da pilha: {item}");
            //}
            //Console.WriteLine("Depois do pop");
            //pilha.Pop();
            //foreach (var item in pilha)
            //{
            //    Console.WriteLine($"item da pilha: {item}");
            //}
        }
    }
}
