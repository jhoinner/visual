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
    public partial class Form1 : Form
    {
        string a="";
        
        public Form1()
        {
         InitializeComponent();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

            
            
            
            //MessageBox.Show(e.Node.Text);

           if (checkBox1.Checked==true )
            {
                a = e.Node.Text;
                textBox1.Text = a;
            }

            if (checkBox2.Checked == true)
            {
                a = e.Node.Text;
                textBox2.Text = a;
            }





        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
