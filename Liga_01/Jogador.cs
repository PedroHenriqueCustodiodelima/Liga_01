using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_01
{
    public class Jogador
    {
        public int Id { get; set; }
        public int IdTime { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Idade} anos - {Posicao} - #{Numero}";
        }
    }
}
