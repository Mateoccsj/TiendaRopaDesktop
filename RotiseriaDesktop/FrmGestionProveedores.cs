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
    public partial class FrmGestionProveedores : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        Proveedor proveedor;

        public FrmGestionProveedores()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frmNuevoProveedor = new FrmNuevoProveedor();
            frmNuevoProveedor.ShowDialog();
            gridProveedores.DataSource = db.Proveedores.ToList();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = gridProveedores.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmNuevoProveedor frmNuevoProveedor = new FrmNuevoProveedor(db, idSeleccionado);
            frmNuevoProveedor.ShowDialog();
            //recargamos el listado de categorias
            actualizarGrilla();
        }




        private void actualizarGrilla()
        {
            var proveedoresAListar = from proveedor in db.Proveedores
                                     select new { id = proveedor.Id, Razon_social = proveedor.Razon_social, Domicilio = proveedor.Domicilio, telefono = proveedor.telefono, celular = proveedor.celular, observaciones = proveedor.observaciones };
            gridProveedores.DataSource = proveedoresAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var proveedoresAListar = from proveedor in db.Proveedores
                                     select new { id = proveedor.Id, Razon_social = proveedor.Razon_social, Domicilio = proveedor.Domicilio, telefono = proveedor.telefono, celular = proveedor.celular, observaciones = proveedor.observaciones };
            gridProveedores.DataSource = proveedoresAListar.Where(p => p.Razon_social.Contains(textoABuscar)).ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = gridProveedores.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string proveedorSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar el producto: " + proveedorSeleccionado + "?";
            string titulo = "Eliminación de un proveedor";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Proveedor proveedor = db.Proveedores.Find(idSeleccionado);
                db.Proveedores.Remove(proveedor);
                db.SaveChanges();
                //recargamos el listado de categorias
                actualizarGrilla();
            }
        }
    }
}
