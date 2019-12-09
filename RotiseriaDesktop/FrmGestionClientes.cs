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
    public partial class FrmGestionClientes : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        Cliente cliente;

        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            frmNuevoCliente.ShowDialog();
            gridClientes.DataSource = db.Clientes.ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = gridClientes.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            string clienteSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que desea eliminar este cliente " + clienteSeleccionado + "?";
            string titulo = "Eliminación de un cliente";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Cliente cliente = db.Clientes.Find(idSeleccionado);
                db.Clientes.Remove(cliente);
                db.SaveChanges();
                //recargamos el listado de categorias
                actualizarGrilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = gridClientes.CurrentRow.Cells;
            int idSeleccionado = (int)celdasFilaActual[0].Value;
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente(db, idSeleccionado);
            frmNuevoCliente.ShowDialog();
            //recargamos el listado
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            var clientesAListar = from cliente in db.Clientes
                                  select new { id = cliente.Id, Nombre = cliente.Nombre + " " + cliente.Apellido, Domicilio = cliente.Domicilio, Telefono = cliente.Telefono };
            gridClientes.DataSource = clientesAListar.ToList();
        }

        private void actualizarGrilla(string textoABuscar)
        {
            var clientesAListar = from cliente in db.Clientes
                                  select new
                                  {
                                      id = cliente.Id,
                                      Nombre = cliente.Nombre,
                                      Apellido = cliente.Apellido,
                                      Domicilio = cliente.Domicilio,
                                      Telefono = cliente.Telefono
                                  };
            gridClientes.DataSource = clientesAListar.Where(p => p.Nombre.Contains(textoABuscar)).ToList();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarGrilla(txtBusqueda.Text);
        }
    }
}
