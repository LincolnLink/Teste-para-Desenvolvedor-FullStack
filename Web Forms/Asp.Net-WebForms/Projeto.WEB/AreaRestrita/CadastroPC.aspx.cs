using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing; //paleta de desenho..
using Projeto.Entidades; //classes de entidade..
using Projeto.BLL; //camada de regras de negócio..
using System.IO;

namespace Projeto.WEB.AreaRestrita
{
    public partial class CadastroPC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarUpload())
                {
                    Computador c = new Computador();

                    c.Marca = txtMarca.Text;
                    c.Modelo = txtModelo.Text;
                    c.PlacaMae = txtPmae.Text;
                    c.MemoriaRAM = int.Parse(txtRam.Text);
                    c.HdArmazenamento = int.Parse(txtHd.Text);
                    c.HdMarca = txtmhd.Text;
                    c.VelocidadeProcessador = txtVp.Text;
                    /*c.Foto = txtFoto.FileName;*/
                    c.Usuario = (Usuario)Session["usuario"]; //usuário autenticado..

                    string nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(txtFoto.FileName);

                    c.Foto = c.Usuario.Login + "/" + nomeArquivo;

                    ComputadorBusiness business = new ComputadorBusiness();
                    business.Cadastrar(c);

                    //UPLOAD da imagem..
                    string path = HttpContext.Current.Server.MapPath("/Imagens/");

                    Directory.CreateDirectory(path + c.Usuario.Login);
                    //criando /Imagens/meuusuario
                    txtFoto.SaveAs(path + c.Foto);
                    //upload -> /Imagens/meuusuario/minhafoto.jpg

                    lblMensagem.Text = "Computador" + c.Marca + ", cadastrado com sucesso.";

                    //limpar os campos do formulário..
                    txtMarca.Text = string.Empty; //vazio..
                    txtModelo.Text = string.Empty; //vazio..
                    txtPmae.Text = string.Empty; //vazio..
                    txtRam.Text = string.Empty; //vazio..
                    txtHd.Text = string.Empty; //vazio..
                    txtmhd.Text = string.Empty; //vazio..
                    txtVp.Text = string.Empty; //vazio..
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
                lblMensagem.ForeColor = Color.Red;
            }

        }

        private bool ValidarUpload()
        {
            bool resultado = true;
            //obter a extensão do arquivo..
            string extensao = Path.GetExtension(txtFoto.FileName);
            int tamanho = txtFoto.PostedFile.ContentLength; //em bytes..
            if (!extensao.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
            && !extensao.Equals(".png", StringComparison.OrdinalIgnoreCase)
            && !extensao.Equals(".gif", StringComparison.OrdinalIgnoreCase))
            {
                lblMensagem.Text = "Por favor, envie apenas imagens jpg, png ou gif";
                lblMensagem.ForeColor = Color.Red;
                resultado = false; //erro..
            }
            else if (tamanho > Math.Pow(1024, 2)) //até 1MB
            {
                lblMensagem.Text = "Por favor, envie imagens de até 1MB de tamanho";
                lblMensagem.ForeColor = Color.Red;
                resultado = false; //erro..
            }
            //retornando..
            return resultado;
        }
    }
}