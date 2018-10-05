using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface RegionDAO
    {
        /// <summary>
        /// Método encargado de listar
        /// todas las regiones del sistema
        /// </summary>
        /// <returns></returns>
        List<RegionEntity> findAll();

        /// <summary>
        /// Método encargado de crear una región
        /// </summary>
        /// <param name="region"></param>
        void create(RegionEntity region);

        /// <summary>
        /// Método encargado de borrar una región
        /// </summary>
        /// <param name="region"></param>
        void delete(RegionEntity region);

        /// <summary>
        /// Método en cargado de borrar una región
        /// </summary>
        /// <param name="region"></param>
        void update(RegionEntity region);

        /// <summary>
        /// Método en cargo de buscar 
        /// una región por código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        RegionEntity findByCodigo(string codigo);

    }
}
