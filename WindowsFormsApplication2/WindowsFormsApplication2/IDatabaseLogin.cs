using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    interface IDatabaseLogin
    {
        bool Login(Login l);

        void Salvar(Login l);

        void Remover(string nome);

        List<Login> Listar();

        Login Read(string nome);
    }
}
