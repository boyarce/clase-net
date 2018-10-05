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
    public partial class comuna : System.Web.UI.Page
    {
        private static readonly 
            ComunaBusiness comunaBusiness =
            new ComunaBusinessImpl();

        private List<RegionEntity> regiones;

        protected void Page_Load(object sender, EventArgs e)
        {
            regiones = (List<RegionEntity>)Session["regiones"];
            if (!IsPostBack) {
                cmb_regiones.DataSource = regiones;
                cmb_regiones.DataBind();
            }

        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            //Creando objeto para almacenar en la bd
            ComunaEntity newComuna = new ComunaEntity();
            newComuna.Codigo = txt_codigo.Text;
            newComuna.Nombre = txt_nombre.Text;
            newComuna.Region = regiones.FirstOrDefault(
                region => region.Codigo == cmb_regiones.SelectedValue);
            //Agregar objeto a la bd
            comunaBusiness.create(newComuna);
            //Limpiar formulario
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            cmb_regiones.SelectedIndex = 0;
            //Refrescar tabla
            refreshTable(); 
        }

        private void refreshTable() {
            tbl_comunas.DataSource = comunaBusiness.listComuna();
            tbl_comunas.DataBind();
        }

        protected void tbl_comunas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow) {

                //Cargando DropDownList para las columnas de la tabla
                ComunaEntity seletedComuna = (ComunaEntity)e.Row.DataItem;
                DropDownList cmb_regiones_tbl = (e.Row.FindControl("cmb_regiones_tbl") as DropDownList);
                cmb_regiones_tbl.DataSource = regiones;
                cmb_regiones_tbl.DataTextField = "Nombre";
                cmb_regiones_tbl.DataValueField = "Codigo";
                //Actualizar tabla con de comunas
                cmb_regiones_tbl.DataBind();

                //Seleccionar elemento combobox
                if (cmb_regiones_tbl.Items.FindByValue(seletedComuna.Region.Codigo) != null) {
                    cmb_regiones_tbl.Items.FindByValue(seletedComuna.Region.Codigo).Selected = true;
                }
                //deshabilitar lista desplegable
                cmb_regiones_tbl.Enabled = false;
            }
        }

        protected void tbl_comunas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Habilitar campos para editar en la tabla
            tbl_comunas.EditIndex = e.NewEditIndex;
            //Refrescando tabla
            refreshTable();
            //Obteniendo fila modificada
            GridViewRow row = tbl_comunas.Rows[e.NewEditIndex];
            //Obteniendo lista de regiones
            DropDownList cmb_regiones_tbl = (row.FindControl("cmb_regiones_tbl") as DropDownList);
            //deshabilitar lista desplegable
            cmb_regiones_tbl.Enabled = true;
        }

        protected void tbl_comunas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Deshabilitar campos para editar en la tabla
            tbl_comunas.EditIndex = -1;
            //Refrescando tabla
            refreshTable();
            //Obteniendo fila modificada
            GridViewRow row = tbl_comunas.Rows[e.RowIndex];
            //Obteniendo lista de regiones
            DropDownList cmb_regiones_tbl = (row.FindControl("cmb_regiones_tbl") as DropDownList);
            //deshabilitar lista desplegable
            cmb_regiones_tbl.Enabled = false;
        }

        protected void tbl_comunas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Obteniendo fila modificada
            GridViewRow row = (GridViewRow)tbl_comunas.Rows[e.RowIndex];
            //Obteniendo el codigo de la región
            string codigo = row.Cells[0].Text;
            //Obteniendo nuevo valor del nombre
            string nombre = e.NewValues[0].ToString();
            string regiont = e.NewValues[0].ToString();

            //Creando objeto para modificar en la bd
            ComunaEntity updateComuna = new ComunaEntity();
            updateComuna.Codigo = codigo;
            updateComuna.Nombre = nombre;
            //Obteniendo lista de regiones
            DropDownList cmb_regiones_tbl = (row.FindControl("cmb_regiones_tbl") as DropDownList);
            updateComuna.Region = regiones.FirstOrDefault(
                            region => region.Codigo == cmb_regiones_tbl.SelectedValue);

            //Modificando objeto a la bd
            comunaBusiness.update(updateComuna);
            //Deshabilitar campos para editar en la tabla
            tbl_comunas.EditIndex = -1;
            //Refrescando tabla
            refreshTable();
        }

        protected void tbl_comunas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Obteniendo fila modificada
            GridViewRow row = (GridViewRow)tbl_comunas.Rows[e.RowIndex];
            //Obteniendo el codigo de la región
            string codigo = row.Cells[0].Text;

            //Creando objeto para modificar en la bd
            ComunaEntity deleteComuna = new ComunaEntity();
            deleteComuna.Codigo = codigo;

            //Modificando objeto a la bd
            comunaBusiness.delete(deleteComuna);
            //Refrescando tabla
            refreshTable();
        }
    }
}