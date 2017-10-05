using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    interface IDAO
    {
        void Salvar(object o);

        void Remover(object o);

        List<object> Listar();

        object Read(object nome);

        void Editar(object o);
    }
}
