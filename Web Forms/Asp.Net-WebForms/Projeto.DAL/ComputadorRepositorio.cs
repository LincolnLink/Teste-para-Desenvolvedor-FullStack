using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.SqlClient;


namespace Projeto.DAL
{
    public class ComputadorRepositorio : Conexao
    {
        //método para gravar uma computadores no banco de dados..
        public void Insert(Computador c)
        {
            OpenConnection();

            string query = "insert into Computador(Marca, Modelo, PlacaMae, Mram, Hd, HdMarca, Vprocessador, Foto, IdUsuario) "
                + "values(@Marca, @Modelo, @PlacaMae, @Mram, @Hd, @HdMarca, @Vprocessador, @Foto, @IdUsuario)";

            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Marca", c.Marca);
            cmd.Parameters.AddWithValue("@Modelo", c.Modelo);
            cmd.Parameters.AddWithValue("@PlacaMae", c.PlacaMae);
            cmd.Parameters.AddWithValue("@Mram", c.MemoriaRAM);
            cmd.Parameters.AddWithValue("@Hd", c.HdArmazenamento);
            cmd.Parameters.AddWithValue("@HdMarca", c.HdMarca);
            cmd.Parameters.AddWithValue("@Vprocessador", c.VelocidadeProcessador);
            cmd.Parameters.AddWithValue("@Foto", c.Foto);
            cmd.Parameters.AddWithValue("@IdUsuario", c.Usuario.IdUsuario);


            cmd.ExecuteNonQuery(); //executando..
            CloseConnection();
        }

        public void update(Computador c)
        {
            OpenConnection();

            string query = "update Computador set Marca = @Marca, Modelo = @Modelo, " +
                " PlacaMae = @PlacaMae, Mram = @Mram, Hd = @Hd, HdMarca = @HdMarca " +
                " Vprocessador = @Vprocessador, Foto = @Foto ";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Marca", c.Marca);
            cmd.Parameters.AddWithValue("@Modelo", c.Modelo);
            cmd.Parameters.AddWithValue("@PlacaMae", c.PlacaMae);
            cmd.Parameters.AddWithValue("@Mram", c.MemoriaRAM);
            cmd.Parameters.AddWithValue("@Hd", c.HdArmazenamento);
            cmd.Parameters.AddWithValue("@HdMarca", c.HdMarca);
            cmd.Parameters.AddWithValue("@Vprocessador", c.VelocidadeProcessador);
            cmd.Parameters.AddWithValue("@Foto", c.Foto);

            cmd.ExecuteNonQuery();
            
            CloseConnection();
        }

        //método para listar as Computadores por data e por usuario..
        public List<Computador> Find(string empresa)
        {
            OpenConnection();

            string query = " select * from Computador where IdUsuario = (select IdUsuario from Usuario where Empresa = @Empresa) ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Empresa", empresa);           
            dr = cmd.ExecuteReader(); //executando e lendo..

            //criando uma lista de computadores..
            List<Computador> lista = new List<Computador>();
            while (dr.Read()) //percorrendo os registros do SqlDataReader..
            {
                Computador c = new Computador();
                c.Usuario = new Usuario();
                c.IdComputador = Convert.ToInt32(dr["IdComputador"]);
                c.Marca = Convert.ToString(dr["Marca"]);
                c.Modelo = Convert.ToString(dr["Modelo"]);
                c.PlacaMae = Convert.ToString(dr["PlacaMae"]);
                c.MemoriaRAM = Convert.ToInt32(dr["Mram"]);
                c.HdArmazenamento = Convert.ToInt32(dr["Hd"]);
                c.HdMarca = Convert.ToString(dr["HdMarca"]);
                c.VelocidadeProcessador = Convert.ToString(dr["Vprocessador"]);
                c.Foto = Convert.ToString(dr["Foto"]);
                c.Usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                lista.Add(c); //adicionar na lista..
            }
            CloseConnection();
            return lista;
        }

        public Computador FindById(int id)
        {
            OpenConnection();

            string query = "select * from Computador where IdComputador = @IdComputador";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdComputador", id);

            dr = cmd.ExecuteReader();

            Computador c = null;

            if (dr.Read())
            {
                c = new Computador();

                c.IdComputador = Convert.ToInt32(dr["IdComputador"]);
                c.Marca = Convert.ToString(dr["Marca"]);
                c.Modelo = Convert.ToString(dr["Modelo"]);
                c.PlacaMae = Convert.ToString(dr["PlacaMae"]);
                c.MemoriaRAM = Convert.ToInt32(dr["Mram"]);
                c.HdArmazenamento = Convert.ToInt32(dr["Hd"]);
                c.HdMarca = Convert.ToString(dr["HdMarca"]);
                c.VelocidadeProcessador = Convert.ToString(dr["Vprocessador"]);
                c.Foto = Convert.ToString(dr["Foto"]);
            }

            CloseConnection();

            return c;
        }

        public List<Computador> findByMarca(string marca)
        {
            OpenConnection();

            string query = "select * from Computador where Marca LIKE'%@Marca%'";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Marca", marca);
            dr = cmd.ExecuteReader(); //executando e lendo..

            //criando uma lista de computadores..
            List<Computador> lista = new List<Computador>();
            while (dr.Read()) //percorrendo os registros do SqlDataReader..
            {
                Computador c = new Computador();
                c.Usuario = new Usuario();

                c.IdComputador = Convert.ToInt32(dr["IdComputador"]);
                c.Marca = Convert.ToString(dr["Marca"]);
                c.Modelo = Convert.ToString(dr["Modelo"]);
                c.PlacaMae = Convert.ToString(dr["PlacaMae"]);
                c.MemoriaRAM = Convert.ToInt32(dr["Mram"]);
                c.HdArmazenamento = Convert.ToInt32(dr["Hd"]);
                c.HdMarca = Convert.ToString(dr["HdMarca"]);
                c.VelocidadeProcessador = Convert.ToString(dr["Vprocessador"]);
                c.Foto = Convert.ToString(dr["Foto"]);
                c.Usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                lista.Add(c); //adicionar na lista..
            }
                CloseConnection();
            return lista;
        }
    }
}
