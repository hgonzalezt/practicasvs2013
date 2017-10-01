namespace Ejercicios_directorios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_validar = new System.Windows.Forms.Button();
            this.txt_salida = new System.Windows.Forms.TextBox();
            this.txt_detalles = new System.Windows.Forms.TextBox();
            this.btn_detalle_dir = new System.Windows.Forms.Button();
            this.dtgrid_servidor = new System.Windows.Forms.DataGridView();
            this.Servidor_ok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servidor_fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_ok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_servidor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(46, 38);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(109, 23);
            this.btn_validar.TabIndex = 0;
            this.btn_validar.Text = "Validar Directorio";
            this.btn_validar.UseVisualStyleBackColor = true;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // txt_salida
            // 
            this.txt_salida.AcceptsReturn = true;
            this.txt_salida.Location = new System.Drawing.Point(46, 78);
            this.txt_salida.Multiline = true;
            this.txt_salida.Name = "txt_salida";
            this.txt_salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_salida.Size = new System.Drawing.Size(204, 121);
            this.txt_salida.TabIndex = 1;
            // 
            // txt_detalles
            // 
            this.txt_detalles.AcceptsReturn = true;
            this.txt_detalles.Location = new System.Drawing.Point(269, 78);
            this.txt_detalles.Multiline = true;
            this.txt_detalles.Name = "txt_detalles";
            this.txt_detalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_detalles.Size = new System.Drawing.Size(550, 121);
            this.txt_detalles.TabIndex = 2;
            // 
            // btn_detalle_dir
            // 
            this.btn_detalle_dir.Location = new System.Drawing.Point(269, 38);
            this.btn_detalle_dir.Name = "btn_detalle_dir";
            this.btn_detalle_dir.Size = new System.Drawing.Size(114, 23);
            this.btn_detalle_dir.TabIndex = 3;
            this.btn_detalle_dir.Text = "Validar Detalle";
            this.btn_detalle_dir.UseVisualStyleBackColor = true;
            this.btn_detalle_dir.Click += new System.EventHandler(this.btn_detalle_dir_Click);
            // 
            // dtgrid_servidor
            // 
            this.dtgrid_servidor.AllowUserToAddRows = false;
            this.dtgrid_servidor.AllowUserToDeleteRows = false;
            this.dtgrid_servidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_servidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Servidor_ok,
            this.servidor_fallo,
            this.cantidad_ok,
            this.cantidad_fallo});
            this.dtgrid_servidor.Location = new System.Drawing.Point(46, 249);
            this.dtgrid_servidor.Name = "dtgrid_servidor";
            this.dtgrid_servidor.ReadOnly = true;
            this.dtgrid_servidor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgrid_servidor.Size = new System.Drawing.Size(443, 150);
            this.dtgrid_servidor.TabIndex = 4;
            // 
            // Servidor_ok
            // 
            this.Servidor_ok.HeaderText = "Nombre Servidor LOG OK";
            this.Servidor_ok.Name = "Servidor_ok";
            this.Servidor_ok.ReadOnly = true;
            this.Servidor_ok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Servidor_ok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // servidor_fallo
            // 
            this.servidor_fallo.HeaderText = "Nombre Servidor LOG FALLO";
            this.servidor_fallo.Name = "servidor_fallo";
            this.servidor_fallo.ReadOnly = true;
            this.servidor_fallo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.servidor_fallo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cantidad_ok
            // 
            this.cantidad_ok.HeaderText = "Cantidad OK";
            this.cantidad_ok.Name = "cantidad_ok";
            this.cantidad_ok.ReadOnly = true;
            this.cantidad_ok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cantidad_ok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cantidad_fallo
            // 
            this.cantidad_fallo.HeaderText = "Estado FALLO";
            this.cantidad_fallo.Name = "cantidad_fallo";
            this.cantidad_fallo.ReadOnly = true;
            this.cantidad_fallo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cantidad_fallo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 503);
            this.Controls.Add(this.dtgrid_servidor);
            this.Controls.Add(this.btn_detalle_dir);
            this.Controls.Add(this.txt_detalles);
            this.Controls.Add(this.txt_salida);
            this.Controls.Add(this.btn_validar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_servidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.TextBox txt_salida;
        private System.Windows.Forms.TextBox txt_detalles;
        private System.Windows.Forms.Button btn_detalle_dir;
        private System.Windows.Forms.DataGridView dtgrid_servidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor_ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn servidor_fallo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_fallo;
    }
}

