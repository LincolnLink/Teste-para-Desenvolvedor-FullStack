using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto.DAL
{
    public class Conexao
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;

        protected void OpenConnection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\link7\Desktop\BlueOpex\Web Forms\Asp.Net-WebForms\Projeto.WEB\App_Data\banco.mdf;Integrated Security=True");
            con.Open(); //conectando!
        }

        protected void CloseConnection()
        {
            con.Close(); //desconectando
        }
    }
}
