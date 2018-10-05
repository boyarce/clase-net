using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class RegionEntity
    {
        private string codigo;
        private string nombre;

        public RegionEntity()
        {
        }

        public string Codigo {
            set { codigo = value; }
            get { return codigo; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
    }
}
