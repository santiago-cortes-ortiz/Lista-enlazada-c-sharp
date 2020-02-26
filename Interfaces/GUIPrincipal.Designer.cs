namespace AplicacionListaEmpleadosFinal
{
    partial class GUIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoAlFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoAlInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoPorPosicionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUltimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPorPosicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoAlInicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoAlFinalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoPorPosicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(617, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarEmpleadoToolStripMenuItem,
            this.modificarEmpleadosToolStripMenuItem,
            this.mostrarEmpleadosToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoAlFinalToolStripMenuItem,
            this.agregarEmpleadoAlInicioToolStripMenuItem,
            this.agregarEmpleadoPorPosicionToolStripMenuItem1});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // agregarEmpleadoAlFinalToolStripMenuItem
            // 
            this.agregarEmpleadoAlFinalToolStripMenuItem.Name = "agregarEmpleadoAlFinalToolStripMenuItem";
            this.agregarEmpleadoAlFinalToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.agregarEmpleadoAlFinalToolStripMenuItem.Text = "Agregar empleado al final";
            this.agregarEmpleadoAlFinalToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoAlFinalToolStripMenuItem_Click_1);
            // 
            // agregarEmpleadoAlInicioToolStripMenuItem
            // 
            this.agregarEmpleadoAlInicioToolStripMenuItem.Name = "agregarEmpleadoAlInicioToolStripMenuItem";
            this.agregarEmpleadoAlInicioToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.agregarEmpleadoAlInicioToolStripMenuItem.Text = "Agregar empleado al inicio";
            this.agregarEmpleadoAlInicioToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoAlInicioToolStripMenuItem_Click);
            // 
            // agregarEmpleadoPorPosicionToolStripMenuItem1
            // 
            this.agregarEmpleadoPorPosicionToolStripMenuItem1.Name = "agregarEmpleadoPorPosicionToolStripMenuItem1";
            this.agregarEmpleadoPorPosicionToolStripMenuItem1.Size = new System.Drawing.Size(305, 26);
            this.agregarEmpleadoPorPosicionToolStripMenuItem1.Text = "Agregar empleado por posicion";
            this.agregarEmpleadoPorPosicionToolStripMenuItem1.Click += new System.EventHandler(this.agregarEmpleadoPorPosicionToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarUltimoToolStripMenuItem,
            this.eliminarInicioToolStripMenuItem,
            this.eliminarPorPosicionToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarUltimoToolStripMenuItem
            // 
            this.eliminarUltimoToolStripMenuItem.Name = "eliminarUltimoToolStripMenuItem";
            this.eliminarUltimoToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.eliminarUltimoToolStripMenuItem.Text = "Eliminar ultimo";
            this.eliminarUltimoToolStripMenuItem.Click += new System.EventHandler(this.eliminarUltimoToolStripMenuItem_Click);
            // 
            // eliminarInicioToolStripMenuItem
            // 
            this.eliminarInicioToolStripMenuItem.Name = "eliminarInicioToolStripMenuItem";
            this.eliminarInicioToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.eliminarInicioToolStripMenuItem.Text = "Eliminar inicio";
            this.eliminarInicioToolStripMenuItem.Click += new System.EventHandler(this.eliminarInicioToolStripMenuItem_Click);
            // 
            // eliminarPorPosicionToolStripMenuItem
            // 
            this.eliminarPorPosicionToolStripMenuItem.Name = "eliminarPorPosicionToolStripMenuItem";
            this.eliminarPorPosicionToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.eliminarPorPosicionToolStripMenuItem.Text = "Eliminar por posicion";
            this.eliminarPorPosicionToolStripMenuItem.Click += new System.EventHandler(this.eliminarPorPosicionToolStripMenuItem_Click);
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            this.buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            this.buscarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.buscarEmpleadoToolStripMenuItem.Text = "Buscar empleado";
            this.buscarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.buscarEmpleadoToolStripMenuItem_Click);
            // 
            // modificarEmpleadosToolStripMenuItem
            // 
            this.modificarEmpleadosToolStripMenuItem.Name = "modificarEmpleadosToolStripMenuItem";
            this.modificarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.modificarEmpleadosToolStripMenuItem.Text = "Modificar empleados";
            this.modificarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.modificarEmpleadosToolStripMenuItem_Click);
            // 
            // mostrarEmpleadosToolStripMenuItem
            // 
            this.mostrarEmpleadosToolStripMenuItem.Name = "mostrarEmpleadosToolStripMenuItem";
            this.mostrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.mostrarEmpleadosToolStripMenuItem.Text = "Mostrar empleados";
            this.mostrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEmpleadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // agregarEmpleadoAlInicioToolStripMenuItem1
            // 
            this.agregarEmpleadoAlInicioToolStripMenuItem1.Name = "agregarEmpleadoAlInicioToolStripMenuItem1";
            this.agregarEmpleadoAlInicioToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // agregarEmpleadoAlFinalToolStripMenuItem1
            // 
            this.agregarEmpleadoAlFinalToolStripMenuItem1.Name = "agregarEmpleadoAlFinalToolStripMenuItem1";
            this.agregarEmpleadoAlFinalToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // agregarEmpleadoPorPosicionToolStripMenuItem
            // 
            this.agregarEmpleadoPorPosicionToolStripMenuItem.Name = "agregarEmpleadoPorPosicionToolStripMenuItem";
            this.agregarEmpleadoPorPosicionToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacionListaEmpleadosFinal.Properties.Resources.Csharp_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GUIPrincipal";
            this.Text = "Lista Empleados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUltimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoAlInicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoAlFinalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoPorPosicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoAlFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoAlInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoPorPosicionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarPorPosicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

