namespace RotiseriaDesktop
{
    partial class FrmBuscarCliente
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(17, 19);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 25;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(82, 16);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(244, 20);
            this.txtBusqueda.TabIndex = 24;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown_1);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(20, 49);
            this.gridClientes.Margin = new System.Windows.Forms.Padding(2);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.RowTemplate.Height = 24;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(642, 295);
            this.gridClientes.TabIndex = 23;
            this.gridClientes.DoubleClick += new System.EventHandler(this.gridClientes_DoubleClick);
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 375);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.gridClientes);
            this.Name = "FrmBuscarCliente";
            this.Text = "Buscar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView gridClientes;
    }
}