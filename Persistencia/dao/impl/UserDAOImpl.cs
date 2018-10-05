using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.MySiteDataSetTableAdapters;

namespace Persistencia.dao.impl
{
    public class UserDAOImpl : UserDAO
    {
        private UsuarioTableAdapter adapter;

        public UserDAOImpl() {
            adapter = new UsuarioTableAdapter();
        }

        public bool autentication(string user, string pass)
        {
            int value = adapter.Autentication(user, pass)??0;

            if (value == 1)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
