using Negocio.business.exception;
using Negocio.business.rules.generic;
using Persistencia.dao;
using Persistencia.dao.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules.impl
{
    public class LoginBusinessImpl : LoginBusiness
    {
        public void autentication(string user, string password)
        {
            EmptyRule empty = new EmptyRule();
            empty.isEmpty("USER", user);
            empty.isEmpty("PASSWORD", password);
            
            UserDAO dao = new UserDAOImpl();
            if (!dao.autentication(user, password)) {

                throw new BusinessException(
                    "USUARIO O CONTRASEÑA " +
                    "INVÁLIDA");
            }

        }
    }
}
