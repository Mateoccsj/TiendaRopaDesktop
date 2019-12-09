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
    public partial class FrmNuevoProducto : Form
    {
        TiendaDeRopaDesktopContext db;
        Producto producto;
        public FrmNuevoProducto()
        {
            InitializeComponent();
            db = new TiendaDeRopaDesktopContext();
            producto = new Producto();
            cargarCombo(0);
            //tipoUsuario = new TipoUsuario();
            this.cargarTalle(0);
        }

        public FrmNuevoProducto(TiendaDeRopaDesktopContext dbRecibido)
        {
            InitializeComponent();
            db = dbRecibido;
            cargarCombo(0);
            producto = new Producto();
        }

        /// <summary>
        /// Constructor que se ejecuta cuando modificamos un producto
        /// </summary>
        /// <param name="dbRecibido">Objeto db entity framework que maneja la bbdd </param>
        /// <param name="idSeleccionado">id del producto a modificar</param>
        public FrmNuevoProducto(TiendaDeRopaDesktopContext dbRecibido, int idSeleccionado)
        {
            InitializeComponent();
            db = dbRecibido;
            producto = db.Productos.Find(idSeleccionado);
            cargarProducto();
            cargarCombo(producto.TipoProductoId);
        }

        private void cargarProducto()
        {
            cboTalle.SelectedValue = producto.Talle;
            txtColor.Text = producto.Color;
            txtMarca.Text = producto.Marca;
            nudPrecioCompra.Value = producto.PrecioCompra;
            nudPrecioEfectivo.Value = producto.PrecioVenta;
        }

        private void cargarCombo(int idTipoProducto)
        {
            cboTipoProducto.DataSource = db.TipoProductos.ToList();
            cboTipoProducto.DisplayMember = "Nombre";
            cboTipoProducto.ValueMember = "Id";
            cboTipoProducto.SelectedValue = idTipoProducto;
        }

        private void cargarTalle(int idSeleccionado)
        {
            cboTalle.DataSource = Enum.GetValues(typeof(TalleEnum));
            cboTalle.SelectedIndex = idSeleccionado;
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            producto.TipoProductoId = (int)cboTipoProducto.SelectedValue;
            producto.Marca = txtMarca.Text;
            producto.Talle = Convert.ToString((TalleEnum)cboTalle.SelectedIndex + 1);
            producto.Color = txtColor.Text;
            producto.PrecioCompra = nudPrecioCompra.Value;
            producto.PrecioVenta = nudPrecioEfectivo
                .Value;

            if (producto.Id > 0)
            {
                db.Entry(producto).State = EntityState.Modified;
            }
            else
            {
                db.Productos.Add(producto);
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
