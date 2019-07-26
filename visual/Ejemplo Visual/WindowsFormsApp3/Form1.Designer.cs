namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Brasil");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bolivia");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Venezuela");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Peru");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Grupo A", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Paraguay");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Argentina");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Colombia");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Quatar");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Grupo B", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Uruguay");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Chile");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ecuador");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Japon");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Grupo C", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Brasil";
            treeNode1.Text = "Brasil";
            treeNode2.Name = "Bolivia";
            treeNode2.Text = "Bolivia";
            treeNode3.Name = "Venezuela";
            treeNode3.Text = "Venezuela";
            treeNode4.Name = "Peru";
            treeNode4.Text = "Peru";
            treeNode5.Name = "GrupoA";
            treeNode5.Text = "Grupo A";
            treeNode6.Name = "Paraguay";
            treeNode6.Text = "Paraguay";
            treeNode7.Name = "Argentina";
            treeNode7.Text = "Argentina";
            treeNode8.Name = "Colombia";
            treeNode8.Text = "Colombia";
            treeNode9.Name = "Quatar";
            treeNode9.Text = "Quatar";
            treeNode10.Name = "GrupoB";
            treeNode10.Text = "Grupo B";
            treeNode11.Name = "Uruguay";
            treeNode11.Text = "Uruguay";
            treeNode12.Name = "Chile";
            treeNode12.Text = "Chile";
            treeNode13.Name = "Ecuador";
            treeNode13.Text = "Ecuador";
            treeNode14.Name = "Japon";
            treeNode14.Text = "Japon";
            treeNode15.Name = "GrupoC";
            treeNode15.Text = "Grupo C";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(241, 455);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = " ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(551, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(34, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = " ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(551, 135);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(34, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = " ";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(241, 205);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(660, 250);
            this.webBrowser1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 455);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

