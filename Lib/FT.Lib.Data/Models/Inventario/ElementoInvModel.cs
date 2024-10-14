using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Lib.Data.Models.Inventario
{
    public class ElementoInvModel
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Codigo { get; set; }
        public bool Cantidad { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
