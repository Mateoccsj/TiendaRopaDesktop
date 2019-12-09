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
    public partial class FrmBuscarCliente : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        public int idSeleccionado = 0;

        public FrmBuscarCliente(string textoABuscar)
        {
            InitializeComponent();
            txtBusqueda.Focus();
            actualizarGrilla();
            txtBusqueda.Text = textoABuscar;
        }

        private void actualizarGrilla()
        {
            var clientesAListar = from cliente in db.Clientes
                                  select new { id = cliente.Id, Nombre = cliente.Nombre, Apellido = cliente.Apellido, Domicilio = cliente.Domicilio, Telefono = cliente.Telefono };
            gridClientes.DataSource = clientesAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var clientesAListar = from cliente in db.Clientes
                                  select new { id = cliente.Id, Nombre = cliente.Nombre, Apellido = cliente.Apellido, Domicilio = cliente.Domicilio, Telefono = cliente.Telefono };
            gridClientes.DataSource = clientesAListar.Where(p => p.Nombre.Contains(textoABuscar)).ToList();
        }

        private object obtenerCeldaGrilla(int nroCelda)
        {
            DataGridViewCellCollection celdasFilaActual = gridClientes.CurrentRow.Cells;
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

        private void gridClientes_DoubleClick(object sender, EventArgs e)
        {
            idSeleccionado = (int)obtenerCeldaGrilla(0);
            this.Close();
        }
    }
}
