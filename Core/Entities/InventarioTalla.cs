using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Entities
{
    public class InventarioTalla
    {
        public int IdInv { get; set; }
        public int IdTalla { get; set; }
        public int Cantidad { get; set; }
        public Inventario Inventarios { get; set; }
        public Talla Tallas { get; set; }
    }
}