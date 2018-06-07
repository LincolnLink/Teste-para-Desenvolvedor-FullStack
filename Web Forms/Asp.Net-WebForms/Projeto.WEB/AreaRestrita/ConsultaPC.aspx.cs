using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;

namespace Projeto.WEB.AreaRestrita
{
    public partial class ConsultaPC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                //recuperar o usuario da sessão..
                u = (Usuario)Session["usuario"]; //casting..
                                                         //resgatar as datas informadas nos campos..

                //executar a consulta..
                ComputadorBusiness business = new ComputadorBusiness();
                
                List<Computador> lista = business.Consultar(u.Empresa);
                Console.WriteLine(lista);
                //populando o gridview..
                gridPc.DataSource = lista; //populando o grid..
                gridPc.DataBind(); //exibindo o conteudo
            }
            catch (Exception ex)
            {
                //exibir mensagem de erro..
                lblMensagem.Text = ex.Message; Console.WriteLine("aki");
            }
        }
    }
}