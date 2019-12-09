namespace RotiseriaDesktop
{
    partial class FrmVentas
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
            this.pnlDetalleVenta = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDetalleVenta = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetalleVenta
            // 
            this.pnlDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetalleVenta.Controls.Add(this.label8);
            this.pnlDetalleVenta.Controls.Add(this.btnCancelar);
            this.pnlDetalleVenta.Controls.Add(this.btnAgregar);
            this.pnlDetalleVenta.Controls.Add(this.nudTotal);
            this.pnlDetalleVenta.Controls.Add(this.label6);
            this.pnlDetalleVenta.Controls.Add(this.nudDescuento);
            this.pnlDetalleVenta.Controls.Add(this.label5);
            this.pnlDetalleVenta.Controls.Add(this.nudPrecio);
            this.pnlDetalleVenta.Controls.Add(this.label4);
            this.pnlDetalleVenta.Controls.Add(this.label3);
            this.pnlDetalleVenta.Controls.Add(this.cboProductos);
            this.pnlDetalleVenta.Enabled = false;
            this.pnlDetalleVenta.Location = new System.Drawing.Point(11, 88);
            this.pnlDetalleVenta.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetalleVenta.Name = "pnlDetalleVenta";
            this.pnlDetalleVenta.Size = new System.Drawing.Size(797, 63);
            this.pnlDetalleVenta.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(720, 32);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(720, 5);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(65, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Location = new System.Drawing.Point(588, 15);
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
            this.label6.Location = new System.Drawing.Point(553, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total";
            // 
            // nudDescuento
            // 
            this.nudDescuento.DecimalPlaces = 2;
            this.nudDescuento.Location = new System.Drawing.Point(459, 17);
            this.nudDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.nudDescuento.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(90, 20);
            this.nudDescuento.TabIndex = 10;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descuento";
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
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            this.cboProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboProductos_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(93, 21);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(159, 21);
            this.cboCliente.TabIndex = 9;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            this.cboCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCliente_KeyDown);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(640, 26);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(92, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            // 
            // gridDetalleVenta
            // 
            this.gridDetalleVenta.AllowUserToOrderColumns = true;
            this.gridDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleVenta.Location = new System.Drawing.Point(11, 174);
            this.gridDetalleVenta.Margin = new System.Windows.Forms.Padding(2);
            this.gridDetalleVenta.Name = "gridDetalleVenta";
            this.gridDetalleVenta.RowTemplate.Height = 24;
            this.gridDetalleVenta.Size = new System.Drawing.Size(740, 180);
            this.gridDetalleVenta.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(313, 369);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(113, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "TOTAL";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(733, 367);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(65, 23);
            this.btnFinalizar.TabIndex = 27;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(763, 251);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 23);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(763, 208);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Presiona \"F2\" para abri lista de clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Presiona \"F2\" para abri listado de productos";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 404);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridDetalleVenta);
            this.Controls.Add(this.pnlDetalleVenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.pnlDetalleVenta.ResumeLayout(false);
            this.pnlDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetalleVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDetalleVenta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}