using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole.Models
{
    public class Corrente 
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}