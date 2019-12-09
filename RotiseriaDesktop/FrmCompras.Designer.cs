namespace RotiseriaDesktop
{
    partial class FrmCompras
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDetalleCompra = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.gridDetalleCompras = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNetoGravado = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(615, 24);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(92, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(79, 43);
            this.cboProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(159, 21);
            this.cboProveedor.TabIndex = 3;
            this.cboProveedor.SelectedIndexChanged += new System.EventHandler(this.cboProveedor_SelectedIndexChanged);
            this.cboProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboProveedor_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proveedor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDetalleCompra
            // 
            this.pnlDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetalleCompra.Controls.Add(this.btnCancelar);
            this.pnlDetalleCompra.Controls.Add(this.btnGuardar);
            this.pnlDetalleCompra.Controls.Add(this.nudTotal);
            this.pnlDetalleCompra.Controls.Add(this.label6);
            this.pnlDetalleCompra.Controls.Add(this.nudCantidad);
            this.pnlDetalleCompra.Controls.Add(this.label5);
            this.pnlDetalleCompra.Controls.Add(this.nudPrecio);
            this.pnlDetalleCompra.Controls.Add(this.label4);
            this.pnlDetalleCompra.Controls.Add(this.label3);
            this.pnlDetalleCompra.Controls.Add(this.cboProductos);
            this.pnlDetalleCompra.Enabled = false;
            this.pnlDetalleCompra.Location = new System.Drawing.Point(12, 110);
            this.pnlDetalleCompra.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetalleCompra.Name = "pnlDetalleCompra";
            this.pnlDetalleCompra.Size = new System.Drawing.Size(835, 63);
            this.pnlDetalleCompra.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(752, 33);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(752, 6);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Location = new System.Drawing.Point(602, 17);
            this.nudTotal.Margin = new System.Windows.Forms.Padding(2);
            this.nudTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(122, 20);
            this.nudTotal.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total";
            // 
            // nudCantidad
            // 
            this.nudCantidad.DecimalPlaces = 2;
            this.nudCantidad.Location = new System.Drawing.Point(447, 16);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidad.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(90, 20);
            this.nudCantidad.TabIndex = 10;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(289, 15);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(90, 20);
            this.nudPrecio.TabIndex = 8;
            this.nudPrecio.ValueChanged += new System.EventHandler(this.nudPrecio_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(79, 14);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(159, 21);
            this.cboProductos.TabIndex = 5;
            // 
            // gridDetalleCompras
            // 
            this.gridDetalleCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetalleCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleCompras.Location = new System.Drawing.Point(12, 205);
            this.gridDetalleCompras.Margin = new System.Windows.Forms.Padding(2);
            this.gridDetalleCompras.Name = "gridDetalleCompras";
            this.gridDetalleCompras.RowTemplate.Height = 24;
            this.gridDetalleCompras.Size = new System.Drawing.Size(740, 180);
            this.gridDetalleCompras.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(766, 233);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(766, 276);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(766, 405);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(65, 23);
            this.btnFinalizar.TabIndex = 17;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 408);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Neto gravado:";
            // 
            // txtNetoGravado
            // 
            this.txtNetoGravado.Location = new System.Drawing.Point(139, 408);
            this.txtNetoGravado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetoGravado.Name = "txtNetoGravado";
            this.txtNetoGravado.ReadOnly = true;
            this.txtNetoGravado.Size = new System.Drawing.Size(99, 20);
            this.txtNetoGravado.TabIndex = 20;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(302, 408);
            this.txtIva.Margin = new System.Windows.Forms.Padding(2);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(99, 20);
            this.txtIva.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 407);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "IVA";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(526, 408);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(113, 20);
            this.txtTotal.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "TOTAL";
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 453);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNetoGravado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gridDetalleCompras);
            this.Controls.Add(this.pnlDetalleCompra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.pnlDetalleCompra.ResumeLayout(false);
            this.pnlDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDetalleCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView gridDetalleCompras;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNetoGravado;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
    }
}