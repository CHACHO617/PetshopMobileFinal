using PetshopMobileProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopMobileProgreso2.Services
{
    public interface IServicioApiPro
    {
        public Task<List<Producto>> ListarProductos();
        public Task<Producto> ObtenerProducto(int id);
        public Task<string> GuardarProducto(Producto producto);
        public Task<string> EditarProducto(int id, Producto producto);
        public Task<string> EliminarProducto(int id);
    }
}
