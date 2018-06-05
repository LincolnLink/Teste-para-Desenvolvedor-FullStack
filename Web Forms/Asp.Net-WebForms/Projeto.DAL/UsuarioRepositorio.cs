using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.SqlClient;

namespace Projeto.DAL
{
    public class UsuarioRepositorio :Conexao
    {
        //método para inserir um usuario no banco de dados..
        public void Insert(Usuario u)
        {
            OpenConnection(); //abrir conexão
                              //escrever o comando SQL..
            string query = "insert into Usuario(Nome, Login, Senha, Empresa) " +
                " values(@Nome, @Login, @Senha, @Empresa) ";

            //executando o comando SQL..
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", u.Nome);
            cmd.Parameters.AddWithValue("@Login", u.Login);
            cmd.Parameters.AddWithValue("@Senha", u.Senha);
            cmd.Parameters.AddWithValue("@Empresa", u.Empresa);
            cmd.ExecuteNonQuery(); //executando..

            CloseConnection(); //fechar conexão
        }

        //método para buscar 1 usuario pelo login e senha..
        public Usuario Find(string login, string senha)
        {
            OpenConnection();

            string query = "select * from Usuario where Login = @Login and Senha = @Senha";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);
            dr = cmd.ExecuteReader(); //executando e lendo a consulta..
                                      //declarando um objeto da classe Usuario..

            Usuario u = null; //sem espaço de memória..

            if (dr.Read()) //se algum registro foi encontrado..
            {
                u = new Usuario(); //instanciando o objeto Usuario..
                u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                u.Nome = Convert.ToString(dr["Nome"]);
                u.Login = Convert.ToString(dr["Login"]);
                u.Senha = Convert.ToString(dr["Senha"]);
                u.Empresa = Convert.ToString(dr["Empresa"]);               
            }
            CloseConnection();
            return u; //retornando o usuario..
        }


        //método para verificar se um login ja esta cadastrado na tabela..
        public bool HasLogin(string login)
        {
            OpenConnection();

            string query = "select count(*) from Usuario where Login = @Login";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            CloseConnection();
            if (count > 0)
                return true; //login existe!
            else
                return false; //login não existe!
        }


    }
}
