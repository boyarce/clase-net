using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface UserDAO
    {
        /// <summary>
        /// Método encargado de autenticar un usuario
        /// </summary>
        /// <param name="user">nombre de usuario</param>
        /// <param name="pass">password del usuario</param>
        /// <returns>retorna true si la autenteicación
        /// es correcta, en caso contrario false.
        /// </returns>
        bool autentication(String user, String pass);
    }
}
