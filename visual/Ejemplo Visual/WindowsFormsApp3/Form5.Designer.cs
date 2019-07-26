namespace WindowsFormsApp3
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Insertar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(967, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(1170, 64);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 22);
            this.Id.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Enabled = false;
            this.Nombre.Location = new System.Drawing.Point(1170, 112);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 22);
            this.Nombre.TabIndex = 1;
            // 
            // Apellido
            // 
            this.Apellido.Enabled = false;
            this.Apellido.Location = new System.Drawing.Point(1170, 173);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 22);
            this.Apellido.TabIndex = 2;
            // 
            // Direccion
            // 
            this.Direccion.Enabled = false;
            this.Direccion.Location = new System.Drawing.Point(1170, 234);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 22);
            this.Direccion.TabIndex = 3;
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(812, 360);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(94, 33);
            this.Nuevo.TabIndex = 5;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(951, 360);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(94, 33);
            this.Insertar.TabIndex = 6;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(1090, 360);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(94, 33);
            this.Actualizar.TabIndex = 8;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(1213, 360);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(94, 33);
            this.Eliminar.TabIndex = 7;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(1346, 360);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(94, 33);
            this.Buscar.TabIndex = 9;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Telefono
            // 
            this.Telefono.Enabled = false;
            this.Telefono.Location = new System.Drawing.Point(1170, 290);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 22);
            this.Telefono.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1102, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1102, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1102, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1102, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Recargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}