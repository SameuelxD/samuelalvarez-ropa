using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICargoRepository Cargos { get; }
        IClienteRepository Clientes { get; }
        IColorRepository Colores { get; }
        IDepartamentoRepository Departamentos { get; }
        IDetalleOrdenRepository DetallesOrden { get; }
        IEmpleadoRepository Empleados { get; }
        IEmpresaRepository Empresas { get; }
        IEstadoRepository Estados { get; }
        IFormaPagoRepository FormasPago { get; }
        IGeneroRepository Generos { get; }
        IInsumoRepository Insumos { get; }
        IInventarioRepository Inventarios { get; }
        IMunicipioRepository Municipios { get; }
        IPaisRepository Paises { get; }
        IPrendaRepository Prendas { get; }
        IProveedorRepository Proveedores { get; }
        ITallaRepository Tallas { get; }
        ITipoEstadoRepository TiposEstado { get; }
        ITipoPersonaRepository TiposPersona { get; }
        ITipoProteccionRepository TiposProteccion { get; }
        IVentaRepository Ventas { get; }
    }
}