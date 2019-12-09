namespace RotiseriaDesktop
{
    partial class FrmListadoProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(Datos.Producto);
            // 
            // reportViewerProductos
            // 
            this.reportViewerProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Productos";
            reportDataSource1.Value = this.ProductoBindingSource;
            this.reportViewerProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerProductos.LocalReport.ReportEmbeddedResource = "RotiseriaDesktop.ListadoProductos.rdlc";
            this.reportViewerProductos.Location = new System.Drawing.Point(0, 0);
            this.reportViewerProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewerProductos.Name = "reportViewerProductos";
            this.reportViewerProductos.Size = new System.Drawing.Size(600, 366);
            this.reportViewerProductos.TabIndex = 0;
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewerProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmListadoProductos";
            this.Text = "Listado de productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
    }
}