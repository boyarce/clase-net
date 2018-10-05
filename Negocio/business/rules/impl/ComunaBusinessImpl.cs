using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao.entity;
using Persistencia.dao;
using Persistencia.dao.impl;

namespace Negocio.business.rules.impl
{
    public class ComunaBusinessImpl : ComunaBusiness
    {
        public static readonly ComunaDAO dao =
            new ComunaDAOImpl();

        public void create(ComunaEntity comuna)
        {
            dao.create(comuna);
        }

        public void delete(ComunaEntity comuna)
        {
            dao.delete(comuna);
        }

        public List<ComunaEntity> listComuna()
        {
            return dao.findAll();
        }

        public void update(ComunaEntity comuna)
        {
            dao.update(comuna);
        }
    }
}
