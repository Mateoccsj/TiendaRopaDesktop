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
    public partial class FrmBuscarTipoProducto : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();

        public int idSeleccionado = 0;

        public FrmBuscarTipoProducto(string textoABuscar)
        {
            InitializeComponent();
            actualizarGrilla();
            txtBusqueda.Text = textoABuscar;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }

        private void actualizarGrilla()
        {
            var tipoProductoAListar = from tipoProducto in db.TipoProductos
                                     select new { id = tipoProducto.Id, Nombre = tipoProducto.Nombre};
            grid.DataSource = tipoProductoAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var tipoProductoAListar = from tipoProducto in db.TipoProductos
                                      select new { id = tipoProducto.Id, Nombre = tipoProducto.Nombre };
            grid.DataSource = tipoProductoAListar.Where(t => t.Nombre.Contains(textoABuscar)).ToList();
        }

        private object obtenerCeldaGrilla(int nroCelda)
        {
            DataGridViewCellCollection celdasFilaActual = grid.CurrentRow.Cells;
            return celdasFilaActual[nroCelda].Value;
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs argumento)
        {
            if (argumento.KeyCode == Keys.Enter)
            {
                idSeleccionado = (int)obtenerCeldaGrilla(0);
                this.Close();
            }
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            idSeleccionado = (int)obtenerCeldaGrilla(0);
            this.Close();
        }
    }
}
