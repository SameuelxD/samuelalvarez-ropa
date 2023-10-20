using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
        public int IdEstado { get; set; }
        public ICollection<DetalleOrden> DetallesOrden { get; set; }
    }
}