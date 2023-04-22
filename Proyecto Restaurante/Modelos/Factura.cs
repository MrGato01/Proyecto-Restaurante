using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Factura
    {
        public DateTime Fecha { get; set; }
        public int NumFactura { get; set; }
        public string Cliente { get; set; }
        public string IdCliente { get; set; }
        public decimal  SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ISV { get; set; }
    }
}
