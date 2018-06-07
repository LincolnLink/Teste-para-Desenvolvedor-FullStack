using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Projeto.Entidades;
using Projeto.BLL;
using System.Drawing;
using System.Web.Security;

namespace Projeto.WEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                
                    //resgatar os dados do usuario..
                    Usuario u = new Usuario();

                    u.Nome = txtNome.Text;
                    u.Login = txtLoginAcesso.Text;
                    u.Senha = txtSenhaAcesso.Text;
                    u.Empresa = txtEmpresa.Text;

                    UsuarioBusiness business = new UsuarioBusiness();
                    business.CriarConta(u);

                    //mensagem de sucesso..
                    lblMensagem.Text = "Seja bem vindo " + u.Nome + ", sua conta foi criada com sucesso.";
                    lblMensagem.ForeColor = Color.Black;

                    //limpar os campos..
                    txtNome.Text = string.Empty;
                    txtLoginAcesso.Text = string.Empty;
                
            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro..
                lblMensagem.Text = ex.Message;
                lblMensagem.ForeColor = Color.Red;
            }
        }

        protected void BtnAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                //instanciar a classe de regras de negócio..
                UsuarioBusiness business = new UsuarioBusiness();
                //buscar o usuario pelo login e senha..
                Usuario u = business.Autenticar(txtLogin.Text, txtSenha.Text);

                //criando o ticket de acesso do usuario..
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(u.Login, false, 5);

                //gravar o ticket em cookie..
                HttpCookie cookie = new HttpCookie (FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                Response.Cookies.Add(cookie); //cookie está gravado..

                //gravar o usuario em sessão..
                Session["usuario"] = u;

                //redirecionar para a área restrita..
                Response.Redirect("/AreaRestrita/Home.aspx");
            }
            catch (Exception ex)
            {
                //exibir mensagem de erro..
                lblMensagem.Text = ex.Message;
                lblMensagem.ForeColor = Color.Red;
            }

        }
    }
}