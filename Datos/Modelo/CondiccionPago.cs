using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class CondiccionPago
    {
        [Key]
        public int CondicionPagoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Dias { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
