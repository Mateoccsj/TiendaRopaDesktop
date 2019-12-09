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
    public partial class FrmFacturaCompra : Form
    {
        TiendaDeRopaDesktopContext db = new TiendaDeRopaDesktopContext();
        public int idFactura;

        public FrmFacturaCompra(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;
        }

        private void FrmFacturaCompra_Load(object sender, EventArgs e)
        {
            var FacturaCompra = from compra in db.Compras
                                join detalleCompra in db.DetalleCompras
                                on compra.Id equals detalleCompra.CompraId
                                where compra.Id==this.idFactura
                               select new { Id = compra.Id,
                                   Fecha = compra.Fecha,
                                   Proveedor = compra.Proveedor.Razon_social,
                                   Total = compra.Total,
                                   Producto =detalleCompra.Producto.Marca,
                                   PrecioCompra =detalleCompra.PrecioCompra,
                                   Cantidad =detalleCompra.Cantidad,
                                   Subtotal =compra.Subtotal,
                                   Iva=compra.Iva
                                          }
                                   ;
            //var DetalleCompras = from detalleCompra in db.DetalleCompras.Where(d => d.CompraId == idFactura)
            //                    select new { Id = detalleCompra.Id, Producto = detalleCompra.Producto.Nombre, Cantidad = detalleCompra.Cantidad, Total = detalleCompra.Total };

            CompraBindingSource.DataSource = FacturaCompra.ToList();
            //DetalleCompraBindingSource.DataSource = DetalleCompras.ToList();
            this.reportViewer1.RefreshReport();
        }
    }
}
