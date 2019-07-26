using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    class ClentesDAL
    {
        //public static int Agregar(Cliente pCliente, string sql1)
        //{

        //    int retorno = 0;

        //    MySqlCommand comando = new MySqlCommand(string.Format(sql1, pCliente.id, pCliente.nombre, pCliente.apellido, pCliente.direccion, pCliente.telefono), BdComun.ObtenerConexion());
        //    retorno = comando.ExecuteNonQuery();

        //    return retorno;
        //}
        //public static DataTable Consultas3(string query, int t)
        //{
        //    //DataSet dsRetorno = new DataSet();
        //    DataTable dtRetorno = new DataTable();
        //    MySqlCommand sqlCmd = new MySqlCommand();
        //    using (sqlCmd)
        //    {
        //        sqlCmd.Connection = BdComun.ObtenerConexion();
        //        sqlCmd.CommandType = CommandType.StoredProcedure;
        //        sqlCmd.CommandText = query;
        //        sqlCmd.Parameters.AddWithValue("id_u", t);
        //    }
        //    using (MySqlDataAdapter sqlDA = new MySqlDataAdapter(sqlCmd))
        //    {
        //        sqlDA.Fill(dtRetorno);
        //    }
        //    return dtRetorno;
        //}

    }
}
