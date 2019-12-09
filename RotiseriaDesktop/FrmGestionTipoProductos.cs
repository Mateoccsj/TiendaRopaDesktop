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
    public partial class FrmGestionTipoProductos : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();

        public FrmGestionTipoProductos()
        {
            InitializeComponent();
            grid.DataSource = db.TipoProductos.ToList();
        }

        private void actualizarGrilla()
        {
            var categoriasAListar = from tipoProducto in db.TipoProductos
                                   select new { id = tipoProducto.Id, nombre = tipoProducto.Nombre,  };
            grid.DataSource = categoriasAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var productosAListar = from producto in db.Productos
                                   select new { id = producto.Id, nombre = producto.Marca, precio = producto.PrecioVenta, categoria = producto.TipoProducto.Nombre };
            grid.DataSource = productosAListar.Where(p => p.nombre.Contains(textoABuscar)).ToList();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoTipoProducto frmNuevoTipoProducto = new FrmNuevoTipoProducto(db);
            frmNuevoTipoProducto.ShowDialog();
            //recargamos el listado de categorias
            grid.DataSource = db.TipoProductos.ToList();
        }
        private object obtenerCeldaGrilla(int nroCelda)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            return celdasFilaActual[nroCelda].Value;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            int idSeleccionado = (int)obtenerCeldaGrilla(0);
            string categoriaSeleccionada = (string)obtenerCeldaGrilla(1);

            string mensaje = "¿Está seguro que desea eliminar este tipo de producto: " + categoriaSeleccionada + "?";
            string titulo = "Eliminación de un tipo de producot";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                TipoProducto tipoProducto = db.TipoProductos.Find(idSeleccionado);
                db.TipoProductos.Remove(tipoProducto);
                db.SaveChanges();
                //recargamos el listado de categorias
                grid.DataSource = db.TipoProductos.ToList();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)obtenerCeldaGrilla(0);
            FrmNuevoTipoProducto frmNuevaCategoria = new FrmNuevoTipoProducto(idSeleccionado,db);
            frmNuevaCategoria.ShowDialog();
            //recargamos el listado de categorias
            //db = new RotiseriaDesktopContext();
            grid.DataSource = db.TipoProductos.ToList();

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = db.TipoProductos.Where(c => c.Nombre.Contains(txtBusqueda.Text)).ToList();
        }


    }
}
