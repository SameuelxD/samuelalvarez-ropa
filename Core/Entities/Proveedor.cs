using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Proveedor:BaseEntity
    {
        public string NitProveedor { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersona { get; set; }
        public int IdMunicipio { get; set; }
        public ICollection<InsumoProveedor> InsumosProveedor { get; set;}
        public TipoPersona TiposPersona { get; set; }
        public Municipio Municipios { get; set; } 
    }
}