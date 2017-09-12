using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
     class DatabaseDict : IDatabase
    {
        private static Dictionary<string, Pessoa> db = new Dictionary<string, Pessoa>(); 
        public void Salvar(Pessoa p)
        {
            db.Add(p.Cpf, p);
        }

        public void Editar(Pessoa p)
        {
        }

        public void Remover(string cpf)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> Listar()
        {
            List<Pessoa> lista = new List<Pessoa>();
            foreach(KeyValuePair<string,Pessoa> b in db)
            {
                lista.Add(b.Value);
            }

            return lista;
        }

        public Pessoa Read(string cpf)
        {
            foreach(KeyValuePair<string,Pessoa> v in db)
            {
                if (v.Key == cpf)
                {
                    return v.Value;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
