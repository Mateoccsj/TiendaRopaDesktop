using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Venta
    {
        public int Id { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Currency)]
        public float Total { get; set; }

        //establece un vínculo entre la tabla compras y detalle de compras, haciendo que
        //cada vez que obtengamos una compra, también nos traiga como objetos, a todos sus
        //detalles de compras
        public virtual ObservableCollection<DetalleVenta> DetalleVentas { get; set; }
    }
}
