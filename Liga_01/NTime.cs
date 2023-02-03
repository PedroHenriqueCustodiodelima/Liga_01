using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Liga_01
{
    class NTime
    {
        private static List<Time> times = new List<Time>();
        public static void Inserir(Time t)
        {
            Abrir();
            int id = 0;
            foreach (Time obj in times)
                if (obj.Id > id) id = obj.Id;
            t.Id = id + 1;
            times.Add(t);
            Salvar();
        }
        public static List<Time> Listar()
        { // R - Read
            Abrir();
            return times;
        }
        public static Time Listar(int id)
        {

            foreach (Time obj in times)
                if (obj.Id == id) return obj;
            return null;
        }
        public static void Atualizar(Time t)
        { // U - Update
            Abrir();
            Time obj = Listar(t.Id);
            obj.IdCampeonato = t.IdCampeonato;
            obj.Nome = t.Nome;
            obj.Sigla = t.Sigla;
            obj.Estado = t.Estado;
            Salvar();
        }
        public static void Excluir(Time t)
        { // D - Delete
            Abrir();
            times.Remove(Listar(t.Id));
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Time>));
                f = new StreamReader("./time.xml");
                times = (List<Time>)xml.Deserialize(f);
            }
            catch
            {
                times = new List<Time>();
            }
            if (f != null) f.Close();
        }
        public static void Cadastrar(Time t, Campeonato c)
        {
            t.IdCampeonato = t.Id;
            Atualizar(t);
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Time>));
            StreamWriter f = new StreamWriter("./time.xml", false);
            xml.Serialize(f, times);
            f.Close();
        }
        public static List<Time> Listar(Campeonato c)
        {
            Abrir();
            List<Time> tabela = new List<Time>();
            foreach (Time obj in times)
                if (obj.IdCampeonato == c.Id) tabela.Add(obj);
            return tabela;
        }
    }
}
