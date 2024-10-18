using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Lib.Data.Models.Filtro
{
    public class FiltroInventario
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Sede { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
