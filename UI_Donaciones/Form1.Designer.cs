namespace UI_Donaciones
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonadorNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuconsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevaDonacion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonacinesFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListadoDeDonadores = new System.Windows.Forms.ToolStripMenuItem();
            this.historialPorDonadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeDonacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListadoDeDonaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuariosSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatosEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenFondo = new System.Windows.Forms.PictureBox();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donadoresToolStripMenuItem,
            this.mnuDonaciones,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.mnuConfiguracion,
            this.mnuSalir,
            this.mnuUsuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donadoresToolStripMenuItem
            // 
            this.donadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDonadorNuevo,
            this.mnuconsultar,
            this.mnuVisitas});
            this.donadoresToolStripMenuItem.Name = "donadoresToolStripMenuItem";
            this.donadoresToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.donadoresToolStripMenuItem.Text = "Donadores";
            // 
            // mnuDonadorNuevo
            // 
            this.mnuDonadorNuevo.Name = "mnuDonadorNuevo";
            this.mnuDonadorNuevo.Size = new System.Drawing.Size(125, 22);
            this.mnuDonadorNuevo.Text = "Nuevo";
            this.mnuDonadorNuevo.Click += new System.EventHandler(this.mnuDonadorNuevo_Click);
            // 
            // mnuconsultar
            // 
            this.mnuconsultar.Name = "mnuconsultar";
            this.mnuconsultar.Size = new System.Drawing.Size(125, 22);
            this.mnuconsultar.Text = "Consultar";
            this.mnuconsultar.Click += new System.EventHandler(this.mnuconsultar_Click);
            // 
            // mnuVisitas
            // 
            this.mnuVisitas.Name = "mnuVisitas";
            this.mnuVisitas.Size = new System.Drawing.Size(125, 22);
            this.mnuVisitas.Text = "Visitas";
            this.mnuVisitas.Click += new System.EventHandler(this.mnuVisitas_Click);
            // 
            // mnuDonaciones
            // 
            this.mnuDonaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevaDonacion});
            this.mnuDonaciones.Name = "mnuDonaciones";
            this.mnuDonaciones.Size = new System.Drawing.Size(81, 20);
            this.mnuDonaciones.Text = "Donaciones";
            // 
            // mnuNuevaDonacion
            // 
            this.mnuNuevaDonacion.Name = "mnuNuevaDonacion";
            this.mnuNuevaDonacion.Size = new System.Drawing.Size(108, 22);
            this.mnuNuevaDonacion.Text = "Nueva";
            this.mnuNuevaDonacion.Click += new System.EventHandler(this.mnuNuevaDonacion_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDonacinesFecha});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem2.Text = "Estadísticas";
            // 
            // mnuDonacinesFecha
            // 
            this.mnuDonacinesFecha.Name = "mnuDonacinesFecha";
            this.mnuDonacinesFecha.Size = new System.Drawing.Size(189, 22);
            this.mnuDonacinesFecha.Text = "Donaciones por fecha";
            this.mnuDonacinesFecha.Click += new System.EventHandler(this.mnuDonacinesFecha_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListadoDeDonadores,
            this.mnuListadoDeDonaciones});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Reportes";
            // 
            // mnuListadoDeDonadores
            // 
            this.mnuListadoDeDonadores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialPorDonadorToolStripMenuItem,
            this.historialDeDonacionesToolStripMenuItem});
            this.mnuListadoDeDonadores.Name = "mnuListadoDeDonadores";
            this.mnuListadoDeDonadores.Size = new System.Drawing.Size(178, 22);
            this.mnuListadoDeDonadores.Text = "Donadores";
            // 
            // historialPorDonadorToolStripMenuItem
            // 
            this.historialPorDonadorToolStripMenuItem.Name = "historialPorDonadorToolStripMenuItem";
            this.historialPorDonadorToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.historialPorDonadorToolStripMenuItem.Text = "Lista de donadores";
            this.historialPorDonadorToolStripMenuItem.Click += new System.EventHandler(this.historialPorDonadorToolStripMenuItem_Click);
            // 
            // historialDeDonacionesToolStripMenuItem
            // 
            this.historialDeDonacionesToolStripMenuItem.Name = "historialDeDonacionesToolStripMenuItem";
            this.historialDeDonacionesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.historialDeDonacionesToolStripMenuItem.Text = "Historial de donaciones";
            this.historialDeDonacionesToolStripMenuItem.Click += new System.EventHandler(this.historialDeDonacionesToolStripMenuItem_Click);
            // 
            // mnuListadoDeDonaciones
            // 
            this.mnuListadoDeDonaciones.Name = "mnuListadoDeDonaciones";
            this.mnuListadoDeDonaciones.Size = new System.Drawing.Size(178, 22);
            this.mnuListadoDeDonaciones.Text = "Lista de donaciones";
            this.mnuListadoDeDonaciones.Click += new System.EventHandler(this.mnuListadoDeDonaciones_Click);
            // 
            // mnuConfiguracion
            // 
            this.mnuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuariosSistema,
            this.mnuDatosEmpresa});
            this.mnuConfiguracion.Name = "mnuConfiguracion";
            this.mnuConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.mnuConfiguracion.Text = "Configuración";
            // 
            // mnuUsuariosSistema
            // 
            this.mnuUsuariosSistema.Name = "mnuUsuariosSistema";
            this.mnuUsuariosSistema.Size = new System.Drawing.Size(180, 22);
            this.mnuUsuariosSistema.Text = "Usuarios Sistema";
            this.mnuUsuariosSistema.Click += new System.EventHandler(this.mnuUsuariosSistema_Click);
            // 
            // mnuDatosEmpresa
            // 
            this.mnuDatosEmpresa.Name = "mnuDatosEmpresa";
            this.mnuDatosEmpresa.Size = new System.Drawing.Size(180, 22);
            this.mnuDatosEmpresa.Text = "Datos de la empresa";
            this.mnuDatosEmpresa.Click += new System.EventHandler(this.mnuDatosEmpresa_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // imagenFondo
            // 
            this.imagenFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenFondo.Location = new System.Drawing.Point(0, 24);
            this.imagenFondo.Name = "imagenFondo";
            this.imagenFondo.Size = new System.Drawing.Size(781, 387);
            this.imagenFondo.TabIndex = 2;
            this.imagenFondo.TabStop = false;
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(34, 20);
            this.mnuUsuario.Text = "***";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(781, 411);
            this.Controls.Add(this.imagenFondo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDonadorNuevo;
        private System.Windows.Forms.ToolStripMenuItem mnuDonaciones;
        private System.Windows.Forms.ToolStripMenuItem mnuconsultar;
        private System.Windows.Forms.ToolStripMenuItem mnuConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuariosSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuDatosEmpresa;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitas;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuListadoDeDonadores;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevaDonacion;
        private System.Windows.Forms.ToolStripMenuItem mnuListadoDeDonaciones;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDonacinesFecha;
        private System.Windows.Forms.ToolStripMenuItem historialPorDonadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeDonacionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox imagenFondo;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
    }
}

