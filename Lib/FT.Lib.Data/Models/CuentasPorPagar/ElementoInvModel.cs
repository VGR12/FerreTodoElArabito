using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Lib.Data.Models.CuentasPorPagar
{
    public class ElementoInvModel
    {
        public int NumeroDocumento { get; set; }
        public DateTime FechaEmision { get; set; }
        public string MontoDocumento { get; set; }
        public string EmisorFactura { get; set; }
        public string ReceptorFactura { get; set; }
        public bool TipoDocumento {  get; set; }

    }
}
