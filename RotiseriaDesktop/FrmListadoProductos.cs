using Datos;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmListadoProductos : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            var Productos = from producto in db.Productos
                                   select new { Id = producto.Id, Marca = producto.Marca, PrecioVenta = producto.PrecioVenta, TipoProducto = producto.TipoProducto.Nombre, PrecioCompra= producto.PrecioCompra, Talle = producto.Talle, Color = producto.Color };
            //ReportDataSource datosReporte = new ReportDataSource("Datos", productosAListar.ToList());
            //datosReporte.Name = "DataSetProductos";
            //this.reportViewer1.LocalReport.DataSources.Add(datosReporte);*/
            //var Productos= db.Productos.ToList();
            this.ProductoBindingSource.DataSource = Productos.ToList();
            this.reportViewerProductos.RefreshReport();
        }
    }
}
