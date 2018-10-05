using Negocio.business.rules;
using Negocio.business.rules.impl;
using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class region : System.Web.UI.Page
    {
        private static readonly RegionBusiness
            regionBusiness = new RegionBusinessImpl();

        private void refreshTable() {
            //Obtener lista de regiones desde el
            //almacen de datos
            tbl_regiones.DataSource = regionBusiness.listRegiones();
            //Actualizar tabla
            tbl_regiones.DataBind();
            Session["regiones"] = regionBusiness.listRegiones();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                //Refrescando tabla
                refreshTable();
            }
        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            //Creando objeto para almacenar en la bd
            RegionEntity newRegion = new RegionEntity();
            newRegion.Codigo = txt_codigo.Text;
            newRegion.Nombre = txt_nombre.Text;
            //Agregando objeto a la bd
            regionBusiness.create(newRegion);
            //Limpiar Formulario
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            //Refrescando tabla
            refreshTable();
        }

        protected void tbl_regiones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Habilitar campos para editar en la tabla
            tbl_regiones.EditIndex = e.NewEditIndex;
            //Refrescando tabla
            refreshTable();
        }

        protected void tbl_regiones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Deshabilitar campos para editar en la tabla
            tbl_regiones.EditIndex = -1;
            //Refrescando tabla
            refreshTable();
        }

        protected void tbl_regiones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Obteniendo fila modificada
            GridViewRow row = (GridViewRow)tbl_regiones.Rows[e.RowIndex];
            //Obteniendo el codigo de la región
            string codigo = row.Cells[0].Text;
            //Obteniendo nuevo valor del nombre
            string nombre = e.NewValues[0].ToString();

            //Creando objeto para modificar en la bd
            RegionEntity updateRegion = new RegionEntity();
            updateRegion.Codigo = codigo;
            updateRegion.Nombre = nombre;

            //Modificando objeto a la bd
            regionBusiness.update(updateRegion);
            //Deshabilitar campos para editar en la tabla
            tbl_regiones.EditIndex = -1;
            //Refrescando tabla
            refreshTable();
        }

        protected void tbl_regiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Obteniendo fila modificada
            GridViewRow row = (GridViewRow)tbl_regiones.Rows[e.RowIndex];
            //Obteniendo el codigo de la región
            string codigo = row.Cells[0].Text;

            //Creando objeto para modificar en la bd
            RegionEntity deleteRegion = new RegionEntity();
            deleteRegion.Codigo = codigo;

            //Modificando objeto a la bd
            regionBusiness.delete(deleteRegion);
            //Refrescando tabla
            refreshTable();
        }
    }
}