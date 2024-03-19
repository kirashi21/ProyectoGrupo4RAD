using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class CondiccionPago
    {
        public int CondicionPagold { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Dias { get;set; }
        public DateTime FechaCreacion { get; set; }
    }
}
