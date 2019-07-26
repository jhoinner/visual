namespace WindowsFormsApp3
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treewiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            this.formulariosToolStripMenuItem.Click += new System.EventHandler(this.FormulariosToolStripMenuItem_Click);
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureBoxToolStripMenuItem,
            this.treewiToolStripMenuItem,
            this.webToolStripMenuItem});
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.PictureBoxToolStripMenuItem_Click);
            // 
            // treewiToolStripMenuItem
            // 
            this.treewiToolStripMenuItem.Name = "treewiToolStripMenuItem";
            this.treewiToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.treewiToolStripMenuItem.Text = "Treewi";
            this.treewiToolStripMenuItem.Click += new System.EventHandler(this.TreewiToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.webToolStripMenuItem.Text = "web";
            this.webToolStripMenuItem.Click += new System.EventHandler(this.WebToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treewiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
    }
}