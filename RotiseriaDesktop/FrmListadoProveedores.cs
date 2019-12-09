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
    public partial class FrmListadoProveedores : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        public FrmListadoProveedores()
        {
            InitializeComponent();
        }

        private void FrmListadoProveedores_Load(object sender, EventArgs e)
        {

            var ListadoProveedores = from proveedores in db.Proveedores
                                     select new { Id = proveedores.Id,
                                         Razon_social = proveedores.Razon_social,
                                         Domicilio = proveedores.Domicilio,
                                         celular = proveedores.celular,
                                         telefono = proveedores.telefono,
                                         observaciones = proveedores.observaciones };

            this.proveedorBindingSource.DataSource = ListadoProveedores.ToList();
            this.rwListadoProveedores.RefreshReport();


            this.rwListadoProveedores.RefreshReport();
        }
    }
}