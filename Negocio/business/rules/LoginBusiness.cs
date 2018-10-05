using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface LoginBusiness
    {
        /// <summary>
        /// Método encargado de verificar 
        /// y autenticar
        /// </summary>
        /// <param name="user">nombre de usuario</param>
        /// <param name="password">password del usuario</param>
        void autentication(string user,
            string password);
    }
}
