using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_01
{
    class Time
    {
        public int Id { get; set; }
        public int IdCampeonato { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Estado { get; set; }
        public override string ToString()
        {
            return $" {IdCampeonato} - {Sigla} - {Nome} - {Estado}";
        }
    }
}
