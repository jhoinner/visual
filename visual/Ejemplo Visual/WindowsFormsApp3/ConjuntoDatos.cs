using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp3
{
    class ConjuntoDatos
    {

        
        public static DataTable Consultas(string query)
        {
            // retornar datatable para llenar grilla
            //DataSet dsRetorno = new DataSet();
            DataTable dtRetorno = new DataTable();          
            using (MySqlCommand sqlCmd = new MySqlCommand(query, BdComun.ObtenerConexion()))
            using (MySqlDataAdapter sqlDA = new MySqlDataAdapter(sqlCmd))
            {
                sqlDA.Fill(dtRetorno);
            }
            return dtRetorno;
         }

        public static DataSet Consulta1(String qry, string t)
        {
            MySqlConnection con = new MySqlConnection();
            con = BdComun.ObtenerConexion();
            MySqlCommand sqlCmd = new MySqlCommand(qry, BdComun.ObtenerConexion());
            sqlCmd.Parameters.AddWithValue("@no_u", t) ;
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"nombre");
            con.Close();
            return ds;
        }
        public static DataTable Consultas2(string query,string t)
        {
            //DataSet dsRetorno = new DataSet();
            DataTable dtRetorno = new DataTable();
            MySqlCommand sqlCmd = new MySqlCommand();
            using (sqlCmd)
            {
                sqlCmd.Connection = BdComun.ObtenerConexion();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = query;
                sqlCmd.Parameters.AddWithValue("no_u", t);
            }
            using (MySqlDataAdapter sqlDA = new MySqlDataAdapter(sqlCmd))
            {
               sqlDA.Fill(dtRetorno);
            }
            if (dtRetorno.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro el registro", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtRetorno;
        }
        public static int Consultas3(string query, int i)
        {
            //DataSet dsRetorno = new DataSet();
            int retorno;
            DataTable dtRetorno = new DataTable();
            MySqlCommand sqlCmd = new MySqlCommand();
            using (sqlCmd)
            {
                sqlCmd.Connection = BdComun.ObtenerConexion();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = query;
                sqlCmd.Parameters.AddWithValue("id_u", i);
                //sqlCmd.Parameters.AddWithValue("no_u", n);
                //sqlCmd.Parameters.AddWithValue("ap_u", a);
                //sqlCmd.Parameters.AddWithValue("di_u", d);
                //sqlCmd.Parameters.AddWithValue("te_u", t);
                retorno = sqlCmd.ExecuteNonQuery();
            }
            using (MySqlDataAdapter sqlDA = new MySqlDataAdapter(sqlCmd))
            {
                sqlDA.Fill(dtRetorno);
            }
            return retorno;
        }
        public static int Consultas4(string query, int i, string n, string a, string d, string t)
        {
            //DataSet dsRetorno = new DataSet();
            int retorno;
            DataTable dtRetorno = new DataTable();
            MySqlCommand sqlCmd = new MySqlCommand();
            using (sqlCmd)
            {
                sqlCmd.Connection = BdComun.ObtenerConexion();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = query;
                sqlCmd.Parameters.AddWithValue("id_u", i);
                sqlCmd.Parameters.AddWithValue("no_u", n);
                sqlCmd.Parameters.AddWithValue("ap_u", a);
                sqlCmd.Parameters.AddWithValue("di_u", d);
                sqlCmd.Parameters.AddWithValue("te_u", t);
                retorno = sqlCmd.ExecuteNonQuery();
            }
            //using (MySqlDataAdapter sqlDA = new MySqlDataAdapter(sqlCmd))
            //{
            //    //sqlDA.Fill(dtRetorno);
                
            //}
            return retorno;
        }
    }
}
