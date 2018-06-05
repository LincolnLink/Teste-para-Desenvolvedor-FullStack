using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;
using Projeto.BLL.Exceptions.Usuarios;
using Projeto.Util;

namespace Projeto.BLL
{
    public class UsuarioBusiness
    {
        //método para cadastrar um usuario no banco de dados..
        public void CriarConta(Usuario u)
        {
            //verificar se o login do usuario ja existe no banco de dados..
            UsuarioRepositorio rep = new UsuarioRepositorio();
            if (!rep.HasLogin(u.Login))
            //se login não existe no banco de dados..
            {
                //encriptar a senha do usuário..
                Criptografia c = new Criptografia();
                u.Senha = c.EncriptarSenha(u.Senha);

                rep.Insert(u); //gravando..
            }
            else
            {
                throw new LoginJaExisteException();
            }
        }
        //método para retornar um usuario pelo login e senha..
        public Usuario Autenticar(string login, string senha)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();            
            Criptografia c = new Criptografia();

            //buscar o usuario no banco de dados..
            Usuario u = rep.Find(login, c.EncriptarSenha(senha));

            //verificar se o usuario foi encontrado..
            if (u != null)
            {
                return u; //retornando o usuario..
            }
            else
            {
                throw new AcessoNegadoException();
            }
        }
    }
}
