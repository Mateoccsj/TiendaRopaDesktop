using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDesktop
{
    public partial class FrmBuscarProducto : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        public int idSeleccionado = 0;

        public FrmBuscarProducto(string textoABuscar)
        {
            InitializeComponent();
            
            actualizarGrilla();
            txtBusqueda.Focus();
            txtBusqueda.Text = textoABuscar;
        }

        private void actualizarGrilla()
        {
            var productosAListar = from producto in db.Productos
                                   select new { id = producto.Id, TipoProductoId = producto.TipoProducto.Nombre, Marca = producto.Marca, Talle = producto.Talle, Color = producto.Color, PrecioCompra = producto.PrecioCompra, PrecioVenta = producto.PrecioVenta };
            gridProductos.DataSource = productosAListar.ToList();
            txtBusqueda.Focus();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var productosAListar = from producto in db.Productos
                                   select new { id = producto.Id, TipoProductoId = producto.TipoProducto.Nombre, Marca = producto.Marca, Talle = producto.Talle, Color = producto.Color, PrecioCompra = producto.PrecioCompra, PrecioVenta = producto.PrecioVenta };
            gridProductos.DataSource = productosAListar.Where(p => p.TipoProductoId.Contains(textoABuscar)).ToList();
            txtBusqueda.Focus();
        }

        private object obtenerCeldaGrilla(int nroCelda)
        {
            DataGridViewCellCollection celdasFilaActual = gridProductos.CurrentRow.Cells;
            return celdasFilaActual[nroCelda].Value;
        }



        private void txtBusqueda_KeyDown_1(object sender, KeyEventArgs argumento)
        {
            if (argumento.KeyCode == Keys.Enter)
            {
                idSeleccionado = (int)obtenerCeldaGrilla(0);
                this.Close();
            }
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }

        private void gridProductos_DoubleClick(object sender, EventArgs e)
        {
            idSeleccionado = (int)obtenerCeldaGrilla(0);
            this.Close();
        }
    }
}
