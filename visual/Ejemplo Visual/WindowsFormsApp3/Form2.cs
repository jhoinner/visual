using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Uri Url { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Navigate(toolStripTextBox1.Text);
        }
        private void Navigate(String address)
        {

            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ToolStripTextBox1_KeyDown(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Navigate(toolStripTextBox1.Text);
            //}
        }
        private void webBrowser1_Navigated(object sender,WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
        }
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
