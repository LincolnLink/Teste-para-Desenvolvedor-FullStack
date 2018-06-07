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
                Computador c = new Computador();

                c.Marca = txtMarca.Text;
                c.Modelo = txtModelo.Text;
                c.PlacaMae = txtPmae.Text;
                c.MemoriaRAM = int.Parse(txtRam.Text);
                c.HdArmazenamento = int.Parse(txtHd.Text);
                c.HdMarca = txtmhd.Text;
                c.VelocidadeProcessador = txtVp.Text;
                c.Foto = txtFoto.FileName;
                c.Usuario = (Usuario)Session["usuario"]; //usuário autenticado..

                ComputadorBusiness business = new ComputadorBusiness();
                business.Cadastrar(c);

                lblMensagem.Text = "Tarefa " + c.Marca + ", cadastrado com sucesso.";

                //limpar os campos do formulário..
                txtMarca.Text = string.Empty; //vazio..
                txtModelo.Text = string.Empty; //vazio..
                txtPmae.Text = string.Empty; //vazio..
                txtRam.Text = string.Empty; //vazio..
                txtHd.Text = string.Empty; //vazio..
                txtmhd.Text = string.Empty; //vazio..
                txtVp.Text = string.Empty; //vazio..

            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
                lblMensagem.ForeColor = Color.Red;
            }

        }
    }
}