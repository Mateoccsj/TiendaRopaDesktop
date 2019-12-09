using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public int TipoProductoId { get; set; }
        [Display(Name = "Tipo de producto")]
        public virtual TipoProducto TipoProducto { get; set; }
        [Required]
        public String Marca { get; set; }
        [Required]
        public String Talle { get; set; }
        [Required]
        public String Color { get; set; }
        [Required]
        [Display(Name = "Costo del producto")]
        [DataType(DataType.Currency)]
        public decimal PrecioCompra { get; set; }
        [Display(Name = "Precio de venta")]
        [DataType(DataType.Currency)]
        public decimal PrecioVenta { get; set; }
        [Required]
        [Display(Name = "Precio de venta")]
        [DataType(DataType.Currency)]
        public decimal Venta { get; set; }
    }
}
