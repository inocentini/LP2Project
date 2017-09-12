using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    interface IDatabase
    {
        void Salvar(Pessoa p);

        void Editar(Pessoa p);

        void Remover(string cpf);

        List<Pessoa> Listar();

        Pessoa Read(string cpf);

    }
}
