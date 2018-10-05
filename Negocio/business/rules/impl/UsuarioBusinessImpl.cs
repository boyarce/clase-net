using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao.entity;
using Negocio.business.rules.generic;

namespace Negocio.business.rules.impl
{
    public class UsuarioBusinessImpl : UsuarioBusiness
    {
        public void create(UsuarioEntity user)
        {
            EmptyRule empty = new EmptyRule();
            empty.isEmpty("Nombre Usuario", user.User);
            empty.isEmpty("Password", user.Password);
            MaxLengthRule maxLength = new MaxLengthRule();
           // maxLength.isValid("Nombre Usuario", user.User, );


        }

        public void delete(UsuarioEntity user)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public void update(UsuarioEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
