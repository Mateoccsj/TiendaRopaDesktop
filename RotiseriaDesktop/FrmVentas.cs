using Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDesktop
{
    public partial class FrmVentas : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        Venta venta = new Venta();
        Cliente cliente = new Cliente();
        DetalleVenta detalleVenta;

        public FrmVentas()
        {
            InitializeComponent();
            cargarComboCliente(0);
            cargarComboProductos(0);
            actualizarGrilla();
        }

        private void cargarComboCliente(int idSeleccionar)
        {
            cboCliente.DataSource = db.Clientes.ToList();
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "Id";
            cboCliente.SelectedValue = idSeleccionar;

            //***********PREPARAMOS EL AUTOCOMPLETADO DEL COMBO
            AutoCompleteStringCollection autoCompletadoCbo = new AutoCompleteStringCollection();
            //recorremos el datatable y vamos llenando el autoCompletado
            foreach (Cliente cliente in db.Clientes)
            {
                autoCompletadoCbo.Add(cliente.Nombre);
            }
            //configuramos el combo para que utilice el autoCompletado
            cboCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboCliente.AutoCompleteCustomSource = autoCompletadoCbo;
        }

        private void cargarComboProductos(int idSeleccionar)
        {
            cboProductos.DataSource = db.Productos.ToList();
            cboProductos.DisplayMember = "Marca";
            cboProductos.ValueMember = "Id";
            cboProductos.SelectedValue = idSeleccionar;

            //***********PREPARAMOS EL AUTOCOMPLETADO DEL COMBO
            AutoCompleteStringCollection autoCompletadoCbo = new AutoCompleteStringCollection();
            //recorremos el datatable y vamos llenando el autoCompletado
            foreach (Producto producto in db.Productos)
            {
                autoCompletadoCbo.Add(producto.Marca);
            }
            //configuramos el combo para que utilice el autoCompletado
            cboProductos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboProductos.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboProductos.AutoCompleteCustomSource = autoCompletadoCbo;
        }

        private void actualizarGrilla()
        {
            if (venta.DetalleVentas != null)
            {
                var productosVendidos = from detalleVenta in venta.DetalleVentas
                                        select new { id = detalleVenta.Producto.Id, Marca = detalleVenta.Producto.Marca, TipoProducto = detalleVenta.Producto.TipoProducto.Nombre, Talle =detalleVenta.Producto.Talle, Color = detalleVenta.Producto.Color, precio = detalleVenta.Producto.PrecioVenta };
                gridDetalleVenta.DataSource = productosVendidos.ToList();
            }
        }


        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cboCliente.SelectedIndex > -1 && cboCliente.SelectedValue.GetType() == typeof(Int32))
            {
                pnlDetalleVenta.Enabled = true;
            }
        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudPrecio.Value-(nudPrecio.Value * nudDescuento.Value);
        }

        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudPrecio.Value - (nudPrecio.Value * nudDescuento.Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            detalleVenta = new DetalleVenta();
            detalleVenta.Producto = db.Productos.Find((int)cboProductos.SelectedValue);
            detalleVenta.ProductoId = (int)cboProductos.SelectedValue;
            detalleVenta.PrecioVenta = nudPrecio.Value;
            detalleVenta.Descuento = nudDescuento.Value;
            detalleVenta.Total = nudTotal.Value;
            if (venta.DetalleVentas == null)
                venta.DetalleVentas = new ObservableCollection<DetalleVenta>();
            venta.DetalleVentas.Add(detalleVenta);
            actualizarGrilla();
            limpiarPanel();
            calcularTotales();
        }

        private void limpiarPanel()
        {
            cboProductos.SelectedValue = 0;
            nudDescuento.Value = 0;
            nudPrecio.Value = 0;
            nudTotal.Value = 0;
            cboProductos.Focus();
        }

        private void calcularTotales()
        {
            float total = 0;
            foreach (DetalleVenta detalleVenta in venta.DetalleVentas)
            {
                total += (float)detalleVenta.Total;
            }
            venta.Total = total;

            txtTotal.Text = venta.Total.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = (string)gridDetalleVenta.CurrentRow.Cells[1].Value;
            string mensaje = "¿Está seguro que desea eliminar el producto: " + productoSeleccionado + "?";
            string titulo = "Eliminación de un producto";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                int detalleSeleccionado = gridDetalleVenta.CurrentRow.Index;
                venta.DetalleVentas.RemoveAt(detalleSeleccionado);
                actualizarGrilla();
                calcularTotales();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int detalleSeleccionado = gridDetalleVenta.CurrentRow.Index;
            DetalleVenta detalleVenta = venta.DetalleVentas[detalleSeleccionado];
            cboProductos.SelectedValue = detalleVenta.Producto.Id;
            nudDescuento.Value = detalleVenta.Descuento;
            nudPrecio.Value = detalleVenta.PrecioVenta;
            nudTotal.Value = detalleVenta.Total;
            venta.DetalleVentas.RemoveAt(detalleSeleccionado);
            actualizarGrilla();
            calcularTotales();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = db.Clientes.Find(cboCliente.SelectedValue);
            venta.Cliente = cliente;
            venta.ClienteId = cliente.Id;
            venta.Fecha = dtpFecha.Value;
            db.Ventas.Add(this.venta);
            db.SaveChanges();
            FrmFacturaVenta frmFacturaVenta = new FrmFacturaVenta(this.venta.Id);
            frmFacturaVenta.ShowDialog();
            

            this.Close();
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Producto producto = db.Productos.Find(cboProductos.SelectedValue);
                nudPrecio.Value = producto.PrecioVenta;
            }
            catch
            {
                //nada
            }
        }

        private void cboCliente_KeyDown(object sender, KeyEventArgs argumento)
        {
            if (argumento.KeyCode == Keys.F2)
            {
                FrmBuscarCliente frmBuscarCliente = new FrmBuscarCliente(cboCliente.Text);
                frmBuscarCliente.ShowDialog();
                if (frmBuscarCliente.idSeleccionado > 0)
                {
                    cboCliente.SelectedValue = frmBuscarCliente.idSeleccionado;
                }
            }
        }

        private void cboProductos_KeyDown(object sender, KeyEventArgs argumento)
        {
            if (argumento.KeyCode == Keys.F2)
            {
                FrmBuscarProducto frmBuscarProducto = new FrmBuscarProducto(cboProductos.Text);
                frmBuscarProducto.ShowDialog();
                if (frmBuscarProducto.idSeleccionado > 0)
                {
                    cboProductos.SelectedValue = frmBuscarProducto.idSeleccionado;
                }
            }
        }
    }
}
