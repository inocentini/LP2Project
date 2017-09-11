using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
     class DatabaseDict : IDatabase
    {
        private static Dictionary<long, Pessoa> db = new Dictionary<long, Pessoa>; 
        public void Salvar(Pessoa p)
        {
            throw new NotImplementedException();
        }

        public void Editar(Pessoa p)
        {
            throw new NotImplementedException();
        }

        public void Remover(long cpf)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
