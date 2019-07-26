using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public int progress;
        public Form3()
        {
            InitializeComponent();
            progress = 0;
        }






        private void BtOpen_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido","Error de archivo");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        
        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
