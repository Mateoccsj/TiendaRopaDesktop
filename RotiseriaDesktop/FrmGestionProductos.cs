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
    public partial class FrmGestionProductos : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();

        public FrmGestionProductos()
        {
            InitializeComponent();
            actualizarGrilla();
        }
        
        private void actualizarGrilla()
        {
            var productosAListar = from producto in db.Productos
                                   select new { id = producto.Id, Marca = producto.Marca,  TipoProducto = producto.TipoProducto.Nombre, Talle = producto.Talle, PrecioCompra = producto.PrecioCompra, PrecioVenta = producto.PrecioVenta };
            gridProductos.DataSource = productosAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var productosAListar = from producto in db.Productos
                                   select new { id = producto.Id, Marca = producto.Marca, TipoProducto = producto.TipoProducto.Nombre, Talle = producto.Talle, PrecioCompra = producto.PrecioCompra, PrecioVenta = producto.PrecioVenta };
            gridProductos.DataSource = productosAListar.Where(p => p.Marca.Contains(textoABuscar)).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = gridProductos.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string productoSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar el producto: " + productoSeleccionado + "?";
            string titulo = "Eliminación de un producto";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Producto producto = db.Productos.Find(idSeleccionado);
                db.Productos.Remove(producto);
                db.SaveChanges();
                //recargamos el listado de categorias
                actualizarGrilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = gridProductos.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto(db, idSeleccionado);
            frmNuevoProducto.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }
    }
}
