using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.BLL;
using Projeto.Entidades;

namespace Projeto.WEB.AreaRestrita
{
    public partial class EdicaoPC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( ! IsPostBack)
            {
                try
                {
                    //Pegando id da URL
                    int id = int.Parse(Request.QueryString["id"]);

                    //Instalando objetos
                    ComputadorBusiness business = new ComputadorBusiness();
                    Computador c = new Computador();

                    //Pegando valores dos campos
                    c = business.ConsultarPorId(id);

                    txtId.Text = c.IdComputador.ToString();
                    txtMarca.Text = c.Marca.ToString();
                    txtModelo.Text = c.Modelo.ToString();
                    txtPmae.Text = c.PlacaMae.ToString();
                    txtRam.Text = c.MemoriaRAM.ToString();
                    txtHd.Text = c.HdArmazenamento.ToString();
                    txtmhd.Text = c.HdMarca.ToString();
                    txtVp.Text = c.VelocidadeProcessador.ToString();

                    imgUsuario.ImageUrl = "/Imagens/" + c.Foto;
                }
                catch(Exception ex)
                {
                   lblMensagem.Text = ex.Message;
                }
            }

        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    //Pegando id da URL
                    int id = int.Parse(Request.QueryString["id"]);

                    //Instalando objetos
                    ComputadorBusiness business = new ComputadorBusiness();
                    Computador c = new Computador();

                    //alimentando o objeto
                    c.Marca = txtMarca.Text;
                    c.Modelo = txtModelo.Text;
                    c.PlacaMae = txtPmae.Text;
                    c.MemoriaRAM = int.Parse(txtRam.Text);
                    c.HdArmazenamento = int.Parse(txtHd.Text);
                    c.HdMarca = txtmhd.Text;

                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }

            }
        }

        public bool ValidarCampos()
        {
            bool resultado = true;
            //confirmar cada campo se esta vazio ou não.
            
            return resultado;
        }
    }
}