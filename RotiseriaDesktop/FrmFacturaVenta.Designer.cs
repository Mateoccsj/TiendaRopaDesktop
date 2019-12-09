namespace RotiseriaDesktop
{
    partial class FrmFacturaVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(Datos.Venta);
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataSource = typeof(Datos.DetalleVenta);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "Venta";
            reportDataSource4.Value = this.ventaBindingSource;
            reportDataSource5.Name = "DetalleVenta";
            reportDataSource5.Value = this.detalleVentaBindingSource;
            reportDataSource6.Name = "Producto";
            reportDataSource6.Value = this.productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RotiseriaDesktop.FacturaVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Datos.Producto);
            // 
            // FrmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmFacturaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura de venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}