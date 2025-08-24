using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }

        List<Pessoa> Alunos = new List<Pessoa>();

    };
}
