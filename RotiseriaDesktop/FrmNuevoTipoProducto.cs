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
    public partial class FrmNuevoTipoProducto : Form
    {
        //propiedades
        TiendaDeRopaDesktopContext db;
        TipoProducto tipoProducto;
        //constructor que no recibe parametros y se ejecuta cuando hacemos nuevo
        public FrmNuevoTipoProducto(TiendaDeRopaDesktopContext dbEnviado)
        {
            InitializeComponent();
            tipoProducto = new TipoProducto();
            db = dbEnviado;
        }

        //constructor que recibe parámetros y se ejecuta cuando hacemos el modificar
        public FrmNuevoTipoProducto(int idSeleccionado, TiendaDeRopaDesktopContext dbEnviado)
        {
            InitializeComponent();
            db = dbEnviado;
            tipoProducto = db.TipoProductos.Find(idSeleccionado);
            txtNombre.Text = tipoProducto.Nombre;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tipoProducto.Nombre = txtNombre.Text;
            if(tipoProducto.Id>0)
            {
                db.Entry(tipoProducto).State = EntityState.Modified;
            }
            else
            {
                db.TipoProductos.Add(tipoProducto);
            }
            db.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
