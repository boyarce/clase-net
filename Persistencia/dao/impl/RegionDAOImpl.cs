using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao.entity;
using Persistencia.MySiteDataSetTableAdapters;

namespace Persistencia.dao.impl
{
    /// <summary>
    /// Clase encargada de conectarse a la base
    /// de dato CRUD REGIÓN
    /// </summary>
    public class RegionDAOImpl : RegionDAO
    {
        private RegionTableAdapter adapter;
        

        public RegionDAOImpl() {
            adapter = new RegionTableAdapter();
        }
    
        public void create(RegionEntity region)
        {
            adapter.Insert(region.Codigo, region.Nombre);
        }

        public void delete(RegionEntity region)
        {
            adapter.DeleteByCodigo(region.Codigo);  
        }

        public List<RegionEntity> findAll()
        {
            //Lista de regiones
            List<RegionEntity> regiones = new
                List<RegionEntity>();

            //Recorrer filas de la tabla Región
            //(RegionRow)
            foreach (MySiteDataSet.RegionRow row in
                adapter.GetData().Rows)
            {
                //Creando objeto RegionEntity por cada
                //Fila encontrada
                RegionEntity region = new RegionEntity();
                region.Codigo = row.codigo;
                region.Nombre = row.nombre;
                //Agregando la región a la lista de regiones
                regiones.Add(region);
            }
                return regiones;
        }

        public void update(RegionEntity region)
        {
            adapter.UpdateByCodigo(region.Nombre,
                region.Codigo);
        }

        public RegionEntity findByCodigo(string codigo)
        {
            RegionEntity region = null;

            //Recorrer filas de la tabla Región
            //(RegionRow)
            foreach (MySiteDataSet.RegionRow row in
                adapter.FindByCodigo(codigo).Rows)
            {
                region = new RegionEntity();
                region.Codigo = row.codigo;
                region.Nombre = row.nombre;
            }

            return region;
        }
    }
}
