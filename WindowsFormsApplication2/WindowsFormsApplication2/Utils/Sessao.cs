using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public static class Sessao
    {
        public static Login login = new Login();

        public static void Logoff()
        {
            login = new Login();
        }
    }
}
