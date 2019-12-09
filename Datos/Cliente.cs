using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required]
        public String Domicilio { get; set; }
        [Required]
        public String Telefono { get; set; }
        public int Saldo { get; set; }
    }
}
