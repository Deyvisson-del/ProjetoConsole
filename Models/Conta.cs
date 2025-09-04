using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoConsole.Models;

class test
{
    Console.WriteLine("teste bem sucessedido");
}

namespace ProjetoConsole.Models
{

    public abstract class Conta
    {
        protected decimal saldo;

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + saldo);
        }

        public abstract void Creditar(decimal valor);
    }

}