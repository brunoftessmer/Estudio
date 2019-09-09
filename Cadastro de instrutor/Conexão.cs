using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Cadastro_de_instrutor
{
    class Conexão
    {
        public MySqlConnection cn = new MySqlConnection();

        public void conectar()
        {
            MySqlConnection conn;
            conn = new MySqlConnection("server=127.0.0.1;database=estudio;uid=root;pwd=;");
            conn.Open();


            }
    }
}
    

