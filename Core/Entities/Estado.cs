using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Estado:BaseEntity
    {
        public string Descripcion { get; set; }
        public int IdTipoEstado { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
        public ICollection<DetalleOrden> DetallesOrden { get; set; }
        public TipoEstado TiposEstado { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}