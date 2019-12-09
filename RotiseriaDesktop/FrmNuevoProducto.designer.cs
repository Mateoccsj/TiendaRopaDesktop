namespace RotiseriaDesktop
{
    partial class FrmNuevoProducto
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
            this.txtColor = new System.Windows.Forms.TextBox();
            this.nudPrecioEfectivo = new System.Windows.Forms.NumericUpDown();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cboTalle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(159, 173);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(182, 20);
            this.txtColor.TabIndex = 54;
            // 
            // nudPrecioEfectivo
            // 
            this.nudPrecioEfectivo.DecimalPlaces = 2;
            this.nudPrecioEfectivo.Location = new System.Drawing.Point(161, 278);
            this.nudPrecioEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecioEfectivo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrecioEfectivo.Name = "nudPrecioEfectivo";
            this.nudPrecioEfectivo.Size = new System.Drawing.Size(181, 20);
            this.nudPrecioEfectivo.TabIndex = 53;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(159, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(182, 20);
            this.txtMarca.TabIndex = 52;
            // 
            // cboTalle
            // 
            this.cboTalle.FormattingEnabled = true;
            this.cboTalle.Location = new System.Drawing.Point(160, 125);
            this.cboTalle.Name = "cboTalle";
            this.cboTalle.Size = new System.Drawing.Size(182, 21);
            this.cboTalle.TabIndex = 51;
            this.cboTalle.Text = "Seleccione el talle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Talle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Color";
            // 
            // nudPrecioCompra
            // 
            this.nudPrecioCompra.DecimalPlaces = 2;
            this.nudPrecioCompra.Location = new System.Drawing.Point(160, 224);
            this.nudPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecioCompra.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrecioCompra.Name = "nudPrecioCompra";
            this.nudPrecioCompra.Size = new System.Drawing.Size(181, 20);
            this.nudPrecioCompra.TabIndex = 47;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(159, 16);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(182, 21);
            this.cboTipoProducto.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tipo de producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Precio de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Precio venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(266, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(41, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // FrmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 386);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.nudPrecioEfectivo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cboTalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPrecioCompra);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.NumericUpDown nudPrecioEfectivo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cboTalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrecioCompra;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}