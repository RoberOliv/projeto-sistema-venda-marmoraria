using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._2_ConexaoSQL
{
    public class ConexaoSQL
    {
        private SqlConnection con = new SqlConnection();

        public ConexaoSQL()
        {
            con.ConnectionString = @"Data Source=DESKTOP-SCOEKP8\SQLEXPRESS;Initial Catalog=Marmoraria;Persist Security Info=True;User ID=sa;Password=12345";
        }

        public SqlConnection ConectarBancoDados()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void DesconectarBancoDados()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}