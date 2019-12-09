namespace RotiseriaDesktop
{
    partial class FrmListadoCategorias
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
            this.CategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerCategorias = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaBindingSource
            // 
            this.CategoriaBindingSource.DataSource = typeof(Datos.TipoProducto);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewerCategorias
            // 
            this.reportViewerCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Categorias";
            reportDataSource1.Value = this.CategoriaBindingSource;
            this.reportViewerCategorias.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCategorias.LocalReport.ReportEmbeddedResource = "RotiseriaDesktop.ListadoCategorias.rdlc";
            this.reportViewerCategorias.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCategorias.Name = "reportViewerCategorias";
            this.reportViewerCategorias.Size = new System.Drawing.Size(800, 450);
            this.reportViewerCategorias.TabIndex = 0;
            // 
            // FrmListadoCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerCategorias);
            this.Name = "FrmListadoCategorias";
            this.Text = "Listado de tipos de producto";
            this.Load += new System.EventHandler(this.FrmListadoCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCategorias;
        private System.Windows.Forms.BindingSource CategoriaBindingSource;
    }
}