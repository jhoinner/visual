using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
 
namespace WindowsFormsApp3
{
    class BdComun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("datasource=Localhost;port=3306;username=root;password=qwerty;database=pruebasena;");
            conectar.Open();
            return conectar;
        }
        //public DataSet _return(String qry)
        //{
        //    MySqlConnection con = new MySqlConnection();
        //    con = ObtenerConexion();
        //    MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "usuarios");
        //    con.Close();
        //    return ds;

        //}

    }
}
