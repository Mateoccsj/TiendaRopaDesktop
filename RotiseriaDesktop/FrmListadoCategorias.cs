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
    public partial class FrmListadoCategorias : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();

        public FrmListadoCategorias()
        {
            InitializeComponent();
        }

        private void FrmListadoCategorias_Load(object sender, EventArgs e)
        {

            var ListadoTipoProductos = from tipoProductos in db.TipoProductos
                                select new { Id = tipoProductos.Id, Nombre = tipoProductos.Nombre.ToString()};

            this.CategoriaBindingSource.DataSource = ListadoTipoProductos.ToList();
            this.reportViewerCategorias.RefreshReport();
        }
    }
}
