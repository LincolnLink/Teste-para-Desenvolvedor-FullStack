using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Exceptions.Computador
{
    public class DataHoraInvalidaException : Exception
    {
        public override string Message 
        {
            get
            {
                return "Data e hora da tarefa são inválidos.";
            }
        }
    }
}
