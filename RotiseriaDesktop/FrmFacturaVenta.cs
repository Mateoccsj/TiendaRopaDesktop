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
    public partial class FrmFacturaVenta : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        public int idFactura;

        public FrmFacturaVenta(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;
        }

        private void FrmFacturaVenta_Load(object sender, EventArgs e)
        {
            var FacturaVenta = from venta in db.Ventas
                               join detalleVenta in db.DetalleVentas
                               on venta.Id equals detalleVenta.VentaId
                               where venta.Id == this.idFactura
                               select new
                               {
                                   Id = venta.Id,
                                   Fecha = venta.Fecha,
                                   Cliente = venta.Cliente.Nombre+" "+
                                             venta.Cliente.Apellido,
                                   Total = venta.Total,
                                   Producto = detalleVenta.Producto.TipoProducto.Nombre+" "+
                                              detalleVenta.Producto.Marca+" "+
                                              detalleVenta.Producto.Talle,
                                   PrecioVenta = detalleVenta.PrecioVenta,

                                   Descuento = detalleVenta.Descuento,
                               };
            productoBindingSource.DataSource = FacturaVenta.ToList();
            detalleVentaBindingSource.DataSource = FacturaVenta.ToList();
            ventaBindingSource.DataSource = FacturaVenta.ToList();
             this.reportViewer1.RefreshReport();
        }
    }
}
