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
    public partial class Datos : Form
    {
        string t,n,a,d;
        int i,r;
        public Datos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BdComun.ObtenerConexion();

            MessageBox.Show("Usted se ha conectado con éxito a nuestra Base de datos de Mysql");

        }

        private void Datos_Load(object sender, EventArgs e)
        {
            DtgUsuario.DataSource = ConjuntoDatos.Consultas(("p_usuario"));
            

            //DateTime dt = DateTime.Now;
            //textBox1.Text = dt.ToShortDateString();ConjuntoDatos
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            //Limpiar de manera rapida
            foreach (Control c in this.Controls)
            {
                if (c is RadioButton)
                {
                    c.Enabled = true;
                    //Enfoco en el primer TextBox
                    
                }

            }
            //Limpiar de manera rapida
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = true;
                    //Enfoco en el primer TextBox
                    TxtId.Focus();
                }

            }
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            //Limpiar de manera rapida
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = true;
                    //Enfoco en el primer TextBox
                    TxtId.Focus();
                }

            }
        }

        private void BtInsertar_Click(object sender, EventArgs e)
        {
            //Cliente pCliente = new Cliente();
            //pCliente.id = Convert.ToInt32(TxtId.Text);
            //pCliente.nombre = TxtNombre.Text.ToUpper();
            //pCliente.apellido = TxtApellido.Text.ToUpper();
            //pCliente.direccion = TxtDireccion.Text.ToUpper();
            //pCliente.telefono = TxtTelefono.Text.ToUpper();

            //int resultado = ClentesDAL.Agregar(pCliente, "Insert into usuarios (idusuario, nombre, apellido, direccion, telefono) values ('{0}','{1}','{2}', '{3}', '{4}')");
            i = Convert.ToInt32(TxtId.Text);
            n = TxtNombre.Text.ToUpper();
            a = TxtApellido.Text.ToUpper();
            d = TxtDireccion.Text.ToUpper();
            t = TxtTelefono.Text.ToUpper();
            int resultado = ConjuntoDatos.Consultas4("InsertUsuario", i, n, a, d, t);

            if (resultado > 0)
            {
                MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DtgUsuario.DataSource = ConjuntoDatos.Consultas(("p_usuario"));
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DtgUsuario.DataSource = ConjuntoDatos.Consultas(("p_usuario"));

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            t = TxtNombre.Text;
            DtgUsuario.DataSource = ConjuntoDatos.Consultas2("SelectLike", t);
        }

        private void BtLupa_Click(object sender, EventArgs e)
        {

            t = TxtNombre.Text;
            DtgUsuario.DataSource = ConjuntoDatos.Consultas2("UsuarioBuscar", t);
            
        }

        private void DtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = DtgUsuario.CurrentRow.Cells[0].Value.ToString();
            TxtNombre.Text= DtgUsuario.CurrentRow.Cells[1].Value.ToString();
            TxtApellido.Text= DtgUsuario.CurrentRow.Cells[2].Value.ToString();
            TxtDireccion.Text= DtgUsuario.CurrentRow.Cells[3].Value.ToString();
            TxtTelefono.Text= DtgUsuario.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(TxtId.Text);
            n = TxtNombre.Text.ToUpper();
            a = TxtApellido.Text.ToUpper();
            d = TxtDireccion.Text.ToUpper();
            t = TxtTelefono.Text.ToUpper();
            int resultado = ConjuntoDatos.Consultas4("UpdateUser", i,n,a,d,t);
            if (resultado > 0)
            {
                MessageBox.Show("Registro Actualizado Con Exito!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DtgUsuario.DataSource = ConjuntoDatos.Consultas(("p_usuario"));
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar el registro", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DtgUsuario.DataSource = ConjuntoDatos.Consultas(("p_usuario"));
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
          i= Convert.ToInt32(TxtId.Text);
            //n = TxtNombre.Text;
            //a = TxtApellido.Text;
            //d = TxtDireccion.Text;
            //t = TxtTelefono.Text;
            int resultado=ConjuntoDatos.Consultas3("EliminarU", i); 
            if (resultado > 0)
            {
                MessageBox.Show("Registro Eliminado Con Exito!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DtgUsuario.DataSource = ConjuntoDatos.Consultas(("p_usuario"));
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DtgUsuario.DataSource = ConjuntoDatos.Consultas(("p_usuario"));
        }
    }
}
