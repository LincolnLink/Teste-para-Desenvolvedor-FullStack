using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.BLL.Exceptions.Computador;
using Projeto.DAL;

namespace Projeto.BLL
{
    public class ComputadorBusiness
    {
        //método para inserir uma computadores no banco de dados..
        public void Cadastrar(Computador c)
        {
            ComputadorRepositorio rep = new ComputadorRepositorio();
            rep.Insert(c); //gravando..
           
        }
        //método para listar as computadores..
        public List<Computador> Consultar(string empresa)
        {

            ComputadorRepositorio rep = new ComputadorRepositorio();

            return rep.Find(empresa); 
        }

        //método para listar as computadores pela marca!
        public List<Computador> ConsultarPelaMarca(string marca)
        {
            ComputadorRepositorio rep = new ComputadorRepositorio();

            return rep.findByMarca(marca);
        }

    }
}
