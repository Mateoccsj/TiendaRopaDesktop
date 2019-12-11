using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDesktop
{
    public partial class FrmNuevoCliente : Form
    {
        TiendaDeRopaDesktopContext db;
        public Cliente cliente;
        public FrmNuevoCliente()
        {
            InitializeComponent();
            db = new TiendaDeRopaDesktopContext();
            cliente = new Cliente();
        }

        //nuevo
        public FrmNuevoCliente(TiendaDeRopaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            cliente = new Cliente();
        }
        //modificar
        public FrmNuevoCliente(TiendaDeRopaDesktopContext dbRecibido, int idModificar)
        {
            InitializeComponent();
            db = dbRecibido;
            cliente = db.Clientes.Find(idModificar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Domicilio = txtDomicilio.Text;
            cliente.Telefono = txtTelefono.Text;

            if (cliente.Id > 0)
            {
                db.Entry(cliente).State = EntityState.Modified;
            }
            else
            {
                db.Clientes.Add(cliente);
            }
            db.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
