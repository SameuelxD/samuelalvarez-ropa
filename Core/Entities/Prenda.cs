using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Prenda:BaseEntity
    {
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public double ValorUnitCop { get; set; }
        public double ValorUnitUsd { get; set; }
        public int IdEstado { get; set; }
        public int IdTipoProteccion { get; set; }
        public int IdGenero { get; set; }

        public Estado Estados { get; set; }
        public TipoProteccion TiposProteccion { get; set; }
        public Genero Generos { get; set; }
        public ICollection<InsumoPrenda> InsumosPrenda { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
        public ICollection<DetalleOrden> DetallesOrden { get; set; }
    }
}