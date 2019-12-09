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
    public partial class FrmBuscarProveedor : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        
        public int idSeleccionado = 0;

        public FrmBuscarProveedor(string textoABuscar)
        {
            InitializeComponent();
            actualizarGrilla();
            txtBusqueda.Text = textoABuscar;
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

        private object obtenerCeldaGrilla(int nroCelda)
        {
            DataGridViewCellCollection celdasFilaActual = gridProveedores.CurrentRow.Cells;
            return celdasFilaActual[nroCelda].Value;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs argumento)
        {
            if(argumento.KeyCode == Keys.Enter)
            {
                idSeleccionado = (int)obtenerCeldaGrilla(0);
                this.Close();
            }
        }

        private void gridProveedores_DoubleClick(object sender, EventArgs e)
        {
            idSeleccionado = (int)obtenerCeldaGrilla(0);
            this.Close();
        }
    }
}
