using Negocio.business.exception;
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
    public partial class tregistrar_usuario : System.Web.UI.Page
    {

        private static readonly UsuarioBusiness usuarioBusiness = new UsuarioBusinessImpl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            UsuarioEntity usuario = new UsuarioEntity();
            usuario.User = txt_usuario.Text;
            usuario.Password = txt_password.Text;
            try
            {
                usuarioBusiness.create(usuario);
            }
            catch (BusinessException ex)
            {
                lbl_message_error.Text = ex.Message;
                throw;
            }
        }
    }
}