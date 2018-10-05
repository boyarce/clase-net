using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface UsuarioBusiness
    {
        void create(UsuarioEntity user);
        void update(UsuarioEntity user);
        void delete(UsuarioEntity user);
        List<UsuarioEntity> FindAll();
    }
}
