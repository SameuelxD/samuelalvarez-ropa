using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork, IDisposable
    {
        private ICargoRepository _cargos;
        private IClienteRepository _clientes; 
        private IColorRepository _colores; 
        private IDepartamentoRepository _departamentos; 
        private IDetalleOrdenRepository _detallesorden; 
        public IDetalleVentaRepository _detallesventa;
        private IEmpleadoRepository _empleados; 
        private IEmpresaRepository _empresas; 
        private IEstadoRepository _estados; 
        private IFormaPagoRepository _formaspago; 
        private IGeneroRepository _generos; 
        private IInsumoRepository _insumos; 
        private IInventarioRepository _inventarios; 
        private IMunicipioRepository _municipios; 
        private IPaisRepository _paises; 
        private IPrendaRepository _prendas; 
        private IProveedorRepository _proveedores; 
        private ITallaRepository _tallas; 
        private RopaContext _context;

        public UnitOfWork()
        {
        }

        public ICargoRepository Cargos
        {
            get
            {
                if (_cargos == null)
                {
                    _cargos = new CargoRepository(_context);
                }
                return _cargos;
            }
        }
        public IClienteRepository Cliente
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(_context);
                }
                return _clientes;
            }
        }
        public IColorRepository Color
        {
            get
            {
                if (_colores == null)
                {
                    _colores = new ColorRepository(_context);
                }
                return _colores;
            }
        }
        public IDepartamentoRepository Departamentos
        {
            get
            {
                if (_departamentos== null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;
            }
        }
        public IDetalleOrdenRepository DetallesOrden
        {
            get
            {
                if (_detallesorden == null)
                {
                    _detallesorden = new DetalleOrdenRepository(_context);
                }
                return _detallesorden;
            }
        }
        public IDetalleVentaRepository DetallesVenta
        {
            get
            {
                if (_detallesventa == null)
                {
                    _detallesventa = new DetalleVentaRepository(_context);
                }
                return _detallesventa;
            }
        }
        public IEmpleadoRepository Empleados
        {
            get
            {
                if (_empleados == null)
                {
                    _empleados = new EmpleadoRepository(_context);
                }
                return _empleados;
            }
        }
        public IEmpresaRepository Empresas
        {
            get
            {
                if (_empresas == null)
                {
                    _empresas = new EmpresaRepository(_context);
                }
                return _empresas;
            }
        }
        public IEstadoRepository Estados
        {
            get
            {
                if (_estados == null)
                {
                    _estados = new EstadoRepository(_context);
                }
                return _estados;
            }
        }
        public IFormaPagoRepository FormasPago
        {
            get
            {
                if (_formaspago == null)
                {
                    _formaspago = new FormaPagoRepository(_context);
                }
                return _formaspago;
            }
        }
        public IGeneroRepository Generos
        {
            get
            {
                if (_generos == null)
                {
                    _generos = new GeneroRepository(_context);
                }
                return _generos;
            }
        }
        public IInsumoRepository Insumos
        {
            get
            {
                if (_insumos == null)
                {
                    _insumos = new InsumoRepository(_context);
                }
                return _insumos;
            }
        }
        public IInventarioRepository Inventarios
        {
            get
            {
                if (_inventarios == null)
                {
                    _inventarios = new InventarioRepository(_context);
                }
                return _inventarios;
            }
        }
        public IMunicipioRepository Municipios
        {
            get
            {
                if (_municipios == null)
                {
                    _municipios = new MunicipioRepository(_context);
                }
                return _municipios;
            }
        }
        public IPaisRepository Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context);
                }
                return _paises;
            }
        }
        public IPrendaRepository Prendas
        {
            get
            {
                if (_prendas == null)
                {
                    _prendas = new PrendaRepository(_context);
                }
                return _prendas;
            }
        }
        public IProveedorRepository Proveedores
        {
            get
            {
                if (_proveedores == null)
                {
                    _proveedores = new ProveedorRepository(_context);
                }
                return _proveedores;
            }
        }
        public ITallaRepository Tallas
        {
            get
            {
                if (_tallas == null)
                {
                    _tallas  = new TallaRepository(_context);
                }
                return _tallas ;
            }
        }
        public UnitOfWork(RopaContext context){
            _context = context;
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}