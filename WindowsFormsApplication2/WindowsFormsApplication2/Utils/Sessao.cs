using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManager
{
    public static class Sessao
    {
        //Classe estática sessão, onde é armazenado o login atual
        public static Login login = new Login();

        public static void Logoff()
        {
            login = new Login();
        }
    }
}
