using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Models
{
    public sealed class Funcionario : Pessoa
    {
        public int RecebeRE { get; set; }
        public string RecebeSenha { get; set; }
        public long Codigo { get; set; }
        public DateTime DataInicioAtividade { get; set; }
        public DateTime HoraInicioAtividade { get; set; }
        public DateTime HoraFimAtividade { get; set; }
        public string Atividade { get; set; }
        public DateTime RecebeDia { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public string Semana { get; set; }        

        /*CultureInfo idioma = new CultureInfo("en-US");

        public string HoraTrabEntrada()
        {
            string recebeEnt = HorarioTrabalhoEntrada.ToString("hh:mm tt");
            return recebeEnt;
        }

        public string HoraTrabSaida()
        {            
            string recebeSai = HorarioTrabalhoSaida.ToString("hh:mm tt");
            return recebeSai;
        }

        public string ReceberSalario()
        {
            string sal = Salario.ToString(idioma);
            return sal;
        }

        public string ReceberValorRefeicao()
        {
            string vRefeicao = ValorRefeicao.ToString(idioma);
            return vRefeicao;
        }*/
    }
}
