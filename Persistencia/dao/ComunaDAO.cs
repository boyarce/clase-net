using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface ComunaDAO
    {
        void create(ComunaEntity comuna);

        void update(ComunaEntity comuna);

        void delete(ComunaEntity comuna);

        List<ComunaEntity> findAll();

    }
}
