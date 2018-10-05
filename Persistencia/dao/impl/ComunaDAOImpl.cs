using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao.entity;
using Persistencia.MySiteDataSetTableAdapters;

namespace Persistencia.dao.impl
{
    public class ComunaDAOImpl : ComunaDAO
    {
        private ComunaTableAdapter adapter;

        public ComunaDAOImpl() {
            //Adaptador encargado 
            //De conexión a bd y realización
            //Transacciones con tabla Comuna
            adapter = new ComunaTableAdapter();
        }

        public void create(ComunaEntity comuna)
        {
            //Insert
            adapter.Insert(
                comuna.Codigo, comuna.Nombre,
                comuna.Region.Codigo);
        }

        public void delete(ComunaEntity comuna)
        {
            //Delete
            adapter.DeleteByCodigo(
                comuna.Codigo);
        }

        public List<ComunaEntity> findAll()
        {
            List<ComunaEntity> comunas
                = new List<ComunaEntity>();
            //RegionDAOImpl
            RegionDAO daoR =
                new RegionDAOImpl();

            //Recorrer filas de la tabla Comuna
            //(ComunaRow)
            foreach (MySiteDataSet.ComunaRow row in
                adapter.GetData().Rows) {

                ComunaEntity comuna = new
                    ComunaEntity();
                comuna.Codigo = row.codigo;
                comuna.Nombre = row.nombre;
                comuna.Region = daoR.findByCodigo(
                    row.cod_region);
                //Agregar comuna a lista de comunas
                comunas.Add(comuna);
            }

                return comunas;
        }

        public void update(ComunaEntity comuna)
        {
            adapter.UpdateByCodigo(
                comuna.Nombre,
                comuna.Region.Codigo,
                comuna.Codigo);
        }
    }
}
