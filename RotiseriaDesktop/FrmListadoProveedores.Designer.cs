namespace RotiseriaDesktop
{
    partial class FrmListadoProveedores
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
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rwListadoProveedores = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(Datos.Proveedor);
            // 
            // rwListadoProveedores
            // 
            this.rwListadoProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.proveedorBindingSource;
            this.rwListadoProveedores.LocalReport.DataSources.Add(reportDataSource1);
            this.rwListadoProveedores.LocalReport.ReportEmbeddedResource = "RotiseriaDesktop.ListadoProveedores.rdlc";
            this.rwListadoProveedores.Location = new System.Drawing.Point(0, 0);
            this.rwListadoProveedores.Name = "rwListadoProveedores";
            this.rwListadoProveedores.Size = new System.Drawing.Size(800, 450);
            this.rwListadoProveedores.TabIndex = 0;
            // 
            // FrmListadoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rwListadoProveedores);
            this.Name = "FrmListadoProveedores";
            this.Text = "Listado de proveedores";
            this.Load += new System.EventHandler(this.FrmListadoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwListadoProveedores;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
    }
}