using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    class clsConexao
    {
        private SqlConnection Conectar()
        {
            string strConexao = "server=localhost;User Id=sa;database=loja; password=root";

            SqlConnection sqlCon = new SqlConnection(strConexao);

            sqlCon.Open();  

            return sqlCon;


        }

        public SqlDataReader Consulta(string cons) 
        {
            SqlDataReader dtDados;
            SqlConnection con1 = Conectar();
            SqlCommand comando = new SqlCommand(cons, con1);
            dtDados = comando.ExecuteReader();

            return dtDados;
        }

        public string InserirDados(String commandoInsert)
        {
            try
            {
                SqlConnection con1 = Conectar();
                SqlCommand insert = new SqlCommand(commandoInsert, con1);
                insert.ExecuteNonQuery();

                return "Inseriodo com susseço";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

    }
}
