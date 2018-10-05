using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class ComunaEntity
    {
        private string codigo;
        private string nombre;
        private RegionEntity region;

        public ComunaEntity()
        {
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public RegionEntity Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }
    }
}
