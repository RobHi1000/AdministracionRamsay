namespace AdministracionRamsay
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioDeSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesMorososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguimientoDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.archivoToolStripMenuItem1,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioDeSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.archivoToolStripMenuItem.Text = "Inicio";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // inicioDeSesionToolStripMenuItem
            // 
            this.inicioDeSesionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioDeSesionToolStripMenuItem.Image")));
            this.inicioDeSesionToolStripMenuItem.Name = "inicioDeSesionToolStripMenuItem";
            this.inicioDeSesionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.inicioDeSesionToolStripMenuItem.Text = "Inicio de Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClientesToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem,
            this.registroDeSoporteToolStripMenuItem,
            this.ventaDeProductosToolStripMenuItem1});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeClientesToolStripMenuItem.Image")));
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeProductosToolStripMenuItem.Image")));
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            // 
            // registroDeSoporteToolStripMenuItem
            // 
            this.registroDeSoporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeSoporteToolStripMenuItem.Image")));
            this.registroDeSoporteToolStripMenuItem.Name = "registroDeSoporteToolStripMenuItem";
            this.registroDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.registroDeSoporteToolStripMenuItem.Text = "Registro de Soporte";
            // 
            // ventaDeProductosToolStripMenuItem1
            // 
            this.ventaDeProductosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ventaDeProductosToolStripMenuItem1.Image")));
            this.ventaDeProductosToolStripMenuItem1.Name = "ventaDeProductosToolStripMenuItem1";
            this.ventaDeProductosToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.ventaDeProductosToolStripMenuItem1.Text = "Venta de Productos";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeClientesToolStripMenuItem,
            this.clientesMorososToolStripMenuItem,
            this.seguimientoDeSoporteToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeClientesToolStripMenuItem.Image")));
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // clientesMorososToolStripMenuItem
            // 
            this.clientesMorososToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesMorososToolStripMenuItem.Image")));
            this.clientesMorososToolStripMenuItem.Name = "clientesMorososToolStripMenuItem";
            this.clientesMorososToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.clientesMorososToolStripMenuItem.Text = "Clientes Morosos";
            // 
            // seguimientoDeSoporteToolStripMenuItem
            // 
            this.seguimientoDeSoporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seguimientoDeSoporteToolStripMenuItem.Image")));
            this.seguimientoDeSoporteToolStripMenuItem.Name = "seguimientoDeSoporteToolStripMenuItem";
            this.seguimientoDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.seguimientoDeSoporteToolStripMenuItem.Text = "Seguimiento de Soporte";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 548);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Principal";
            this.Text = "Administracion Ramsay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesMorososToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inicioDeSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeSoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguimientoDeSoporteToolStripMenuItem;
    }
}

