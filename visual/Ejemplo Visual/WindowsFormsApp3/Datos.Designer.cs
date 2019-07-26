namespace WindowsFormsApp3
{
    partial class Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            this.DtgUsuario = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.BtInsertar = new System.Windows.Forms.Button();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.BtActualizar = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.RdId = new System.Windows.Forms.RadioButton();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.RdApellido = new System.Windows.Forms.RadioButton();
            this.RdTelefono = new System.Windows.Forms.RadioButton();
            this.RdDireccion = new System.Windows.Forms.RadioButton();
            this.BtLupa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgUsuario
            // 
            this.DtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgUsuario.Location = new System.Drawing.Point(78, 254);
            this.DtgUsuario.Name = "DtgUsuario";
            this.DtgUsuario.RowTemplate.Height = 24;
            this.DtgUsuario.Size = new System.Drawing.Size(837, 281);
            this.DtgUsuario.TabIndex = 2;
            this.DtgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgUsuario_CellContentClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(174, 28);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(158, 22);
            this.TxtId.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(174, 72);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(359, 22);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(174, 161);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(359, 22);
            this.TxtDireccion.TabIndex = 10;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(174, 117);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(359, 22);
            this.TxtApellido.TabIndex = 8;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(174, 207);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(158, 22);
            this.TxtTelefono.TabIndex = 12;
            // 
            // BtInsertar
            // 
            this.BtInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtInsertar.Location = new System.Drawing.Point(749, 66);
            this.BtInsertar.Name = "BtInsertar";
            this.BtInsertar.Size = new System.Drawing.Size(159, 36);
            this.BtInsertar.TabIndex = 13;
            this.BtInsertar.Text = "Insertar";
            this.BtInsertar.UseVisualStyleBackColor = true;
            this.BtInsertar.Click += new System.EventHandler(this.BtInsertar_Click);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevo.Location = new System.Drawing.Point(749, 18);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(159, 36);
            this.BtNuevo.TabIndex = 14;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // BtActualizar
            // 
            this.BtActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtActualizar.Location = new System.Drawing.Point(749, 112);
            this.BtActualizar.Name = "BtActualizar";
            this.BtActualizar.Size = new System.Drawing.Size(159, 36);
            this.BtActualizar.TabIndex = 16;
            this.BtActualizar.Text = "Actualizar";
            this.BtActualizar.UseVisualStyleBackColor = true;
            this.BtActualizar.Click += new System.EventHandler(this.BtActualizar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.Location = new System.Drawing.Point(749, 207);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(159, 36);
            this.BtBuscar.TabIndex = 15;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.Location = new System.Drawing.Point(749, 161);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(159, 36);
            this.BtEliminar.TabIndex = 17;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // RdId
            // 
            this.RdId.AutoSize = true;
            this.RdId.Enabled = false;
            this.RdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdId.Location = new System.Drawing.Point(65, 29);
            this.RdId.Name = "RdId";
            this.RdId.Size = new System.Drawing.Size(42, 21);
            this.RdId.TabIndex = 18;
            this.RdId.TabStop = true;
            this.RdId.Text = "Id";
            this.RdId.UseVisualStyleBackColor = true;
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Enabled = false;
            this.RdNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdNombre.Location = new System.Drawing.Point(65, 74);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(85, 21);
            this.RdNombre.TabIndex = 19;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            // 
            // RdApellido
            // 
            this.RdApellido.AutoSize = true;
            this.RdApellido.Enabled = false;
            this.RdApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdApellido.Location = new System.Drawing.Point(65, 117);
            this.RdApellido.Name = "RdApellido";
            this.RdApellido.Size = new System.Drawing.Size(87, 21);
            this.RdApellido.TabIndex = 20;
            this.RdApellido.TabStop = true;
            this.RdApellido.Text = "Apellido";
            this.RdApellido.UseVisualStyleBackColor = true;
            // 
            // RdTelefono
            // 
            this.RdTelefono.AutoSize = true;
            this.RdTelefono.Enabled = false;
            this.RdTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdTelefono.Location = new System.Drawing.Point(65, 208);
            this.RdTelefono.Name = "RdTelefono";
            this.RdTelefono.Size = new System.Drawing.Size(93, 21);
            this.RdTelefono.TabIndex = 22;
            this.RdTelefono.TabStop = true;
            this.RdTelefono.Text = "Telefono";
            this.RdTelefono.UseVisualStyleBackColor = true;
            // 
            // RdDireccion
            // 
            this.RdDireccion.AutoSize = true;
            this.RdDireccion.Enabled = false;
            this.RdDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdDireccion.Location = new System.Drawing.Point(65, 161);
            this.RdDireccion.Name = "RdDireccion";
            this.RdDireccion.Size = new System.Drawing.Size(97, 21);
            this.RdDireccion.TabIndex = 21;
            this.RdDireccion.TabStop = true;
            this.RdDireccion.Text = "Dirección";
            this.RdDireccion.UseVisualStyleBackColor = true;
            // 
            // BtLupa
            // 
            this.BtLupa.Image = ((System.Drawing.Image)(resources.GetObject("BtLupa.Image")));
            this.BtLupa.Location = new System.Drawing.Point(557, 72);
            this.BtLupa.Name = "BtLupa";
            this.BtLupa.Size = new System.Drawing.Size(159, 139);
            this.BtLupa.TabIndex = 23;
            this.BtLupa.UseVisualStyleBackColor = true;
            this.BtLupa.Click += new System.EventHandler(this.BtLupa_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 586);
            this.Controls.Add(this.BtLupa);
            this.Controls.Add(this.RdTelefono);
            this.Controls.Add(this.RdDireccion);
            this.Controls.Add(this.RdApellido);
            this.Controls.Add(this.RdNombre);
            this.Controls.Add(this.RdId);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtActualizar);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.BtInsertar);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DtgUsuario);
            this.Name = "Datos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgUsuario;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Button BtInsertar;
        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.Button BtActualizar;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.RadioButton RdId;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.RadioButton RdApellido;
        private System.Windows.Forms.RadioButton RdTelefono;
        private System.Windows.Forms.RadioButton RdDireccion;
        private System.Windows.Forms.Button BtLupa;
    }
}