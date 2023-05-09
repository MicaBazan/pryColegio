
namespace pryColegio
{
    partial class frmPrincipal
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queFrutasLeGustaAlAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlumnoPorDNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosLosAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasFrutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queFrutasLeGustanAUnAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queFrutasNoLeGustanAUnAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aQueAlumnoLeGustaUnaFrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolitoFrutasAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolitoAlumnosFrutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msPrincipal.Size = new System.Drawing.Size(724, 28);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoBarrioToolStripMenuItem,
            this.nuevaFrutaToolStripMenuItem,
            this.nuevoAlumnoToolStripMenuItem,
            this.queFrutasLeGustaAlAlumnoToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // nuevoBarrioToolStripMenuItem
            // 
            this.nuevoBarrioToolStripMenuItem.Name = "nuevoBarrioToolStripMenuItem";
            this.nuevoBarrioToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.nuevoBarrioToolStripMenuItem.Text = "Nuevo Barrio";
            this.nuevoBarrioToolStripMenuItem.Click += new System.EventHandler(this.nuevoBarrioToolStripMenuItem_Click);
            // 
            // nuevaFrutaToolStripMenuItem
            // 
            this.nuevaFrutaToolStripMenuItem.Name = "nuevaFrutaToolStripMenuItem";
            this.nuevaFrutaToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.nuevaFrutaToolStripMenuItem.Text = "Nueva Fruta";
            this.nuevaFrutaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFrutaToolStripMenuItem_Click);
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            this.nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            this.nuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.nuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno";
            this.nuevoAlumnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlumnoToolStripMenuItem_Click);
            // 
            // queFrutasLeGustaAlAlumnoToolStripMenuItem
            // 
            this.queFrutasLeGustaAlAlumnoToolStripMenuItem.Name = "queFrutasLeGustaAlAlumnoToolStripMenuItem";
            this.queFrutasLeGustaAlAlumnoToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.queFrutasLeGustaAlAlumnoToolStripMenuItem.Text = "Qué Frutas le gusta al Alumno";
            this.queFrutasLeGustaAlAlumnoToolStripMenuItem.Click += new System.EventHandler(this.queFrutasLeGustaAlAlumnoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAlumnoPorDNIToolStripMenuItem,
            this.consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem,
            this.verTodosLosAlumnosToolStripMenuItem,
            this.verTodasLasFrutasToolStripMenuItem,
            this.queFrutasLeGustanAUnAlumnoToolStripMenuItem,
            this.queFrutasNoLeGustanAUnAlumnoToolStripMenuItem,
            this.aQueAlumnoLeGustaUnaFrutaToolStripMenuItem,
            this.aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem,
            this.arbolitoFrutasAlumnosToolStripMenuItem,
            this.arbolitoAlumnosFrutasToolStripMenuItem,
            this.verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarAlumnoPorDNIToolStripMenuItem
            // 
            this.consultarAlumnoPorDNIToolStripMenuItem.Name = "consultarAlumnoPorDNIToolStripMenuItem";
            this.consultarAlumnoPorDNIToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.consultarAlumnoPorDNIToolStripMenuItem.Text = "Consultar alumno por DNI";
            this.consultarAlumnoPorDNIToolStripMenuItem.Click += new System.EventHandler(this.consultarAlumnoPorDNIToolStripMenuItem_Click);
            // 
            // consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem
            // 
            this.consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem.Name = "consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem";
            this.consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem.Text = "Consultar alumno por parte de su nombre";
            this.consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem.Click += new System.EventHandler(this.consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem_Click);
            // 
            // verTodosLosAlumnosToolStripMenuItem
            // 
            this.verTodosLosAlumnosToolStripMenuItem.Name = "verTodosLosAlumnosToolStripMenuItem";
            this.verTodosLosAlumnosToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.verTodosLosAlumnosToolStripMenuItem.Text = "Ver todos los alumnos";
            this.verTodosLosAlumnosToolStripMenuItem.Click += new System.EventHandler(this.verTodosLosAlumnosToolStripMenuItem_Click);
            // 
            // verTodasLasFrutasToolStripMenuItem
            // 
            this.verTodasLasFrutasToolStripMenuItem.Name = "verTodasLasFrutasToolStripMenuItem";
            this.verTodasLasFrutasToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.verTodasLasFrutasToolStripMenuItem.Text = "Ver todas las frutas";
            // 
            // queFrutasLeGustanAUnAlumnoToolStripMenuItem
            // 
            this.queFrutasLeGustanAUnAlumnoToolStripMenuItem.Name = "queFrutasLeGustanAUnAlumnoToolStripMenuItem";
            this.queFrutasLeGustanAUnAlumnoToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.queFrutasLeGustanAUnAlumnoToolStripMenuItem.Text = "Que frutas le gustan a un alumno";
            // 
            // queFrutasNoLeGustanAUnAlumnoToolStripMenuItem
            // 
            this.queFrutasNoLeGustanAUnAlumnoToolStripMenuItem.Name = "queFrutasNoLeGustanAUnAlumnoToolStripMenuItem";
            this.queFrutasNoLeGustanAUnAlumnoToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.queFrutasNoLeGustanAUnAlumnoToolStripMenuItem.Text = "Que frutas no le gustan a un alumno";
            // 
            // aQueAlumnoLeGustaUnaFrutaToolStripMenuItem
            // 
            this.aQueAlumnoLeGustaUnaFrutaToolStripMenuItem.Name = "aQueAlumnoLeGustaUnaFrutaToolStripMenuItem";
            this.aQueAlumnoLeGustaUnaFrutaToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.aQueAlumnoLeGustaUnaFrutaToolStripMenuItem.Text = "A que alumno le gusta una fruta";
            // 
            // aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem
            // 
            this.aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem.Name = "aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem";
            this.aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem.Text = "A que alumno no le gusta una fruta";
            // 
            // arbolitoFrutasAlumnosToolStripMenuItem
            // 
            this.arbolitoFrutasAlumnosToolStripMenuItem.Name = "arbolitoFrutasAlumnosToolStripMenuItem";
            this.arbolitoFrutasAlumnosToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.arbolitoFrutasAlumnosToolStripMenuItem.Text = "Arbolito frutas alumnos";
            // 
            // arbolitoAlumnosFrutasToolStripMenuItem
            // 
            this.arbolitoAlumnosFrutasToolStripMenuItem.Name = "arbolitoAlumnosFrutasToolStripMenuItem";
            this.arbolitoAlumnosFrutasToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.arbolitoAlumnosFrutasToolStripMenuItem.Text = "Arbolito alumnos frutas";
            // 
            // verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem
            // 
            this.verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem.Name = "verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem";
            this.verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem.Size = new System.Drawing.Size(578, 26);
            this.verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem.Text = "Ver todas las frutas y la cantidad total de alumnos que le gusta cada fruta";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 417);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFrutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queFrutasLeGustaAlAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlumnoPorDNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarQuéFrutasLeGustanAlAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosLosAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasFrutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queFrutasLeGustanAUnAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queFrutasNoLeGustanAUnAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aQueAlumnoLeGustaUnaFrutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aQueAlumnoNoLeGustaUnaFrutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolitoFrutasAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolitoAlumnosFrutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasFrutasYLaCantidadTotalDeAlumnosQueLeGustaCadaFrutaToolStripMenuItem;
    }
}

