using Negocio.business.exception;
using Negocio.business.rules;
using Negocio.business.rules.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_message_error.CssClass = "";
            lbl_message_error.Text = "";
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            LoginBusiness login = new LoginBusinessImpl();
            //Regla de Negocio que autentica un usuario
            try
            {
                login.autentication(txt_username.Text,
                txt_pass.Text);
                Response.Redirect("home.aspx");
            }
            catch (BusinessException ex) {

                lbl_message_error.Text =
                    ex.Message;
                lbl_message_error.CssClass = "message-error";
            }           
        }
    }
}