﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();

            Form3 frm = new Form3();

            frm.ShowDialog();
        }

        private void TreewiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();

            Form1 frm = new Form1();

            frm.ShowDialog();

        }

        private void WebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();

            Form2 frm = new Form2();

            frm.ShowDialog();
        }

        private void FormulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
