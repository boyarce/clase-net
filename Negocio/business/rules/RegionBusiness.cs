using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface RegionBusiness
    {

        void create(RegionEntity region);

        void delete(RegionEntity region);

        void update(RegionEntity region);

        List<RegionEntity> listRegiones();
    }
}
