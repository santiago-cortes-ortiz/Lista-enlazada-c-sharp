namespace AplicacionListaEmpleadosFinal
{
    partial class GUIMostrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1Mostrar = new System.Windows.Forms.Button();
            this.button1Salir = new System.Windows.Forms.Button();
            this.grillaLista = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de empleados";
            // 
            // button1Mostrar
            // 
            this.button1Mostrar.Location = new System.Drawing.Point(505, 328);
            this.button1Mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.button1Mostrar.Name = "button1Mostrar";
            this.button1Mostrar.Size = new System.Drawing.Size(77, 44);
            this.button1Mostrar.TabIndex = 2;
            this.button1Mostrar.Text = "Mostrar";
            this.button1Mostrar.UseVisualStyleBackColor = true;
            this.button1Mostrar.Click += new System.EventHandler(this.button1Mostrar_Click);
            // 
            // button1Salir
            // 
            this.button1Salir.Location = new System.Drawing.Point(163, 328);
            this.button1Salir.Margin = new System.Windows.Forms.Padding(2);
            this.button1Salir.Name = "button1Salir";
            this.button1Salir.Size = new System.Drawing.Size(77, 44);
            this.button1Salir.TabIndex = 3;
            this.button1Salir.Text = "Salir";
            this.button1Salir.UseVisualStyleBackColor = true;
            this.button1Salir.Click += new System.EventHandler(this.button1Salir_Click);
            // 
            // grillaLista
            // 
            this.grillaLista.AllowUserToDeleteRows = false;
            this.grillaLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Cedula,
            this.Nombre,
            this.Fecha,
            this.Telefono});
            this.grillaLista.Location = new System.Drawing.Point(2, 31);
            this.grillaLista.Name = "grillaLista";
            this.grillaLista.ReadOnly = true;
            this.grillaLista.RowHeadersWidth = 51;
            this.grillaLista.RowTemplate.Height = 24;
            this.grillaLista.Size = new System.Drawing.Size(763, 292);
            this.grillaLista.TabIndex = 4;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.MinimumWidth = 6;
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.Width = 60;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // GUIMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 383);
            this.Controls.Add(this.grillaLista);
            this.Controls.Add(this.button1Salir);
            this.Controls.Add(this.button1Mostrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GUIMostrar";
            this.Text = "Mostrar";
            ((System.ComponentModel.ISupportInitialize)(this.grillaLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Mostrar;
        private System.Windows.Forms.Button button1Salir;
        private System.Windows.Forms.DataGridView grillaLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}