using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Models
{
    public abstract class Pessoa
    {
        public int RE { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }        
        public int DiasSemana { get; set; }
        public DateTime HorarioTrabalhoEntrada { get; set; }
        public DateTime HorarioTrabalhoSaida { get; set; }        
    }
}
