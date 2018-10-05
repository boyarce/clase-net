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
    public class RegionBusinessImpl : RegionBusiness
    {
        public static readonly RegionDAO dao = 
            new RegionDAOImpl();


        public void create(RegionEntity region)
        {
            dao.create(region);
        }

        public void delete(RegionEntity region)
        {
            dao.delete(region);
        }

        public List<RegionEntity> listRegiones()
        {
            return dao.findAll();
        }

        public void update(RegionEntity region)
        {
            dao.update(region);
        }
    }
}
