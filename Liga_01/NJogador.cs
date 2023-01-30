using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Liga_01
{
    class NJogador
    {
        private static List<Jogador> jogadores = new List<Jogador>();
        public static void Inserir(Jogador t)
        { // C - Create
            Abrir();
            jogadores.Add(t);
            Salvar();
        }
        public static List<Jogador> Listar()
        { // R - Read
            Abrir();
            return jogadores;
        }
        public static Jogador Listar(int id)
        {
            
            foreach (Jogador obj in jogadores)
                if (obj.Id == id) return obj;
            return null;
        }
        public static void Atualizar(Jogador t)
        { // U - Update
            Abrir();
            Jogador obj = Listar(t.Id);
            obj.Nome = t.Nome;
            obj.Id = t.Id;
            obj.Numero = t.Numero;
            obj.IdTime = t.IdTime;
            obj.Posicao = t.Posicao;
            obj.Idade = t.Idade;
            Salvar();
        }
        public static void Excluir(Jogador t)
        { // D - Delete
            Abrir();
            jogadores.Remove(Listar(t.Id));
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Jogador>));
                f = new StreamReader("./jogador.xml");
                jogadores = (List<Jogador>)xml.Deserialize(f);
            }
            catch
            {
                jogadores = new List<Jogador>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Jogador>));
            StreamWriter f = new StreamWriter("./jogador.xml", false);
            xml.Serialize(f, jogadores);
            f.Close();
        }
        public static void Cadastrar(Jogador j, Time t)
        {
            j.IdTime = t.Id;
            Atualizar(j);
        }
        public static List<Jogador> Listar(Time t)
        {
            Abrir(); 
            List<Jogador> diario = new List<Jogador>(); 
            foreach (Jogador obj in jogadores)
                if (obj.IdTime == t.Id) diario.Add(obj);
            return diario;
        }
    }
}
