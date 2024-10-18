using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Lib.Data.Models.Inventario
{
    public class ProductoModel
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }
        public int UbicacionDisponible { get; set; }
        public string TipoVentaId { get; set; }
        public string Modelo { get; set; }
        public int Cantidad { get; set; }

    }
}
