using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_01
{
    class Campeonato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Temporada { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Temporada}";
        }
    }
}
