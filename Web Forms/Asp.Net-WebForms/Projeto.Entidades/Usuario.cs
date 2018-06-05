using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Usuario
    {
        //Atributos
        private int idUsuario;
        private string nome;
        private string login;
        private string senha;
        private string empresa;
        private List<Computador> idComputador;

        public Usuario()
        {

        }
        
        public Usuario(int idUsuario, string nome, string login, string senha, string empresa)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Login = login;
            Senha = senha;
            Empresa = empresa;            
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }
            set
            {
                idUsuario = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        public string Empresa
        {
            get
            {
                return empresa;
            }
            set
            {
                empresa = value;
            }
        }
        

        public override string ToString()
        {
            return $"ID: { idUsuario }, Nome: { nome }, Login: { login }," +
                $" Senha: { senha }, Empresa: { empresa }";
        }


    }
}
