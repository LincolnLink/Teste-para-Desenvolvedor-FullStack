using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using System.Web.Security;

namespace Projeto.WEB.AreaRestrita.Templates
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se a página esta sendo carregada pela 1º vez..
            if (!IsPostBack)
            {
                //trazer o usuário da sessão..
                Usuario u = (Usuario)Session["usuario"]; //casting..
                                                         //exibir os dados do usuario..

            }

        }

        //evento executado quando o botão é clicado..
        protected void BtnLogout_Click(object sender, EventArgs e)
        {            
          
            //destruir o ticket de acesso do usuario..
            FormsAuthentication.SignOut();
            //remover o conteudo do usuario da sessão..
            Session.Remove("usuario");
            Session.Abandon();
            //redirecionar para a página inicial..
            Response.Redirect("\\Default.aspx");
           

        }
    }
}