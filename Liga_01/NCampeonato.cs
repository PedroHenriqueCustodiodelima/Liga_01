using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Liga_01
{
    class NCampeonato
    {
            private static List<Campeonato> campeonatos = new List<Campeonato>();
            public static void Inserir(Campeonato c)
            { // C - Create
                Abrir();
                campeonatos.Add(c);
                Salvar();
            }
            public static List<Campeonato> Listar()
            {
                Abrir();
                return campeonatos;
            }
            public static Campeonato Listar(int id)
            {

                foreach (Campeonato obj in campeonatos)
                    if (obj.Id == id) return obj;
                return null;
            }
            public static void Atualizar(Campeonato c)
            {
                Abrir();
                Campeonato obj = Listar(c.Id);
                obj.Id = c.Id;
                obj.Nome = c.Nome;
                obj.Temporada = c.Temporada;
                Salvar();
            }
            public static void Excluir(Campeonato c)
            {
                Abrir();
                campeonatos.Remove(Listar(c.Id));
                Salvar();
            }
            public static void Abrir()
            {
                StreamReader f = null;
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Campeonato>));
                    f = new StreamReader("./campeonato.xml");
                    campeonatos = (List<Campeonato>)xml.Deserialize(f);
                }
                catch
                {
                    campeonatos = new List<Campeonato>();
                }
                if (f != null) f.Close();
            }
            public static void Salvar()
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Campeonato>));
                StreamWriter f = new StreamWriter("./jogador.xml", false);
                xml.Serialize(f, campeonatos);
                f.Close();
            }
            public static List<Campeonato> Listar(Campeonato c)
            {
                Abrir();
                List<Campeonato> potiguar = new List<Campeonato>();
                foreach (Campeonato obj in campeonatos)
                    if (obj.Id == c.Id) potiguar.Add(obj);
                return potiguar;
            }
        }
}
