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
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario usuario;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void insertarUnaNuevaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoTipoProducto frmNuevaCategoria = new FrmNuevoTipoProducto(new TiendaDeRopaDesktopContext());
            frmNuevaCategoria.ShowDialog();
        }

        private void gestiónDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionTipoProductos frmGestionCategorias = new FrmGestionTipoProductos();
            frmGestionCategorias.ShowDialog();
        }

        private void insertarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.ShowDialog();
        }

        private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProductos frmGestionProductos = new FrmGestionProductos();
            frmGestionProductos.ShowDialog();
        }

        private void insertarNuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras frmCompras = new FrmCompras();
            frmCompras.ShowDialog();
        }

        private void insertarNuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frmNuevoProveedor = new FrmNuevoProveedor();
            frmNuevoProveedor.ShowDialog();
        }

        private void gestiónDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProveedores frmGestionProveedores = new FrmGestionProveedores();
            frmGestionProveedores.ShowDialog();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios();
            frmGestionUsuarios.ShowDialog();
        }

        private void gestiónDeTiposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionTipoUsuario frmGestionTipoUsuario = new FrmGestionTipoUsuario();
            frmGestionTipoUsuario.ShowDialog();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
           // FrmLogin frmLogin = new FrmLogin();
           // frmLogin.ShowDialog();
            //me fijo cual fue el usuario ingresado en frmLogin y si es
            //gerente habilito el menú usuarios.
           // usuario = frmLogin.usuario;
            //si logró loguearse
            if (usuario != null) { 
                if (usuario.TipoUsuario == TipoDeUsuarioEnum.Gerente)
                    usuariosToolStripMenuItem.Enabled = true;
                else
                    usuariosToolStripMenuItem.Enabled = false;
            }
            else
            {
              //  Application.Exit();
            }
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoProductos frmListadoProductos = new FrmListadoProductos();
            frmListadoProductos.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmListaUsuarios frmListaUsuarios = new FrmListaUsuarios();
            frmListaUsuarios.ShowDialog();
        }

        private void listadoDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCategorias frmListadoCategorias = new FrmListadoCategorias();
            frmListadoCategorias.ShowDialog();
        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoProveedores frmListadoProveedores = new FrmListadoProveedores();
            frmListadoProveedores.ShowDialog();
        }

        private void insertarNuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.ShowDialog();
        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            frmNuevoCliente.ShowDialog();
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionClientes frmGestionClientes = new FrmGestionClientes();
            frmGestionClientes.ShowDialog();
        }

        private void insertarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            frmNuevoUsuario.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
