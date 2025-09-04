using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoConsole.Models;

namespace ProjetoConsole.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            Console.WriteLine("Funcionou ...");
            saldo += valor;
        }
    }
}