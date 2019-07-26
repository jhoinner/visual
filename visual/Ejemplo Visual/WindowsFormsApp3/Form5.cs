using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //string confree = "db4free.net:3306";
        //string password = "46a23f51";
        //string usuario = "cperalta2019";
        //string bd = "bdcbn2019";
        string connectionString = "datasource=Localhost;port=3306;username=root;password=qwerty;database=pruebasena;";
        //string connectionString = "datasource=db4free.net;port=3306;username=cperalta2019;password=46a23f51;database=bdcbn2019;";
        //private string connex;

        private void Form5_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM usuarios";
            // Prepara la conexión
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand commando = new MySqlCommand(query, conexion);
            //commandDatabase.CommandTimeout = 60;
            MySqlDataAdapter da = new MySqlDataAdapter(commando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();


        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Id.Focus();
            //Limpiar de manera rapida
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = true;
                    //Enfoco en el primer TextBox
                    Id.Focus();
                }

            }
            

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            
            // Prepara la conexión
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            ////INSERT INTO pruebasena.usuarios (idusuario, nombre, apellido, direccion, telefono) VALUES (?idusuario, ?nombre, ?apellido, ?direccion, ?telefono);"
            {
                String query = "InsertUsuario";
                
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("?id_u", Convert.ToInt64(Id.Text));
                cmd.Parameters.AddWithValue("?no_u", Nombre.Text.ToUpper());
                cmd.Parameters.AddWithValue("?ap_u", Apellido.Text.ToUpper());
                cmd.Parameters.AddWithValue("?di_u", Direccion.Text.ToUpper());
                cmd.Parameters.AddWithValue("?te_u", Telefono.Text.ToUpper());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros ingresado");
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM usuarios";
            // Prepara la conexión
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand commando = new MySqlCommand(query, conexion);
            //commandDatabase.CommandTimeout = 60;
            MySqlDataAdapter da = new MySqlDataAdapter(commando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();


        }
    }
}
