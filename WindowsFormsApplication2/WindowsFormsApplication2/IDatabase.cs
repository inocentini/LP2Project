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

        void Remover(long cpf);

        List<Pessoa> Listar();

    }
}
