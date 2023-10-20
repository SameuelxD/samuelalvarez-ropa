using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente:BaseEntity
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersona { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdMunicipio { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
        public TipoPersona TiposPersona { get; set; }
        public Municipio Municipios { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}