using PetshopMobileProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopMobileProgreso2.Services
{
    public interface IServicioApiCli
    {
        public Task<List<Cliente>> ListarClientes();
        public Task<Cliente> ObtenerCliente(int id);
        public Task<string> GuardarCliente(Cliente cliente);
        public Task<string> EditarCliente(int id, Cliente cliente);
        public Task<string> EliminarCliente(int id);
    }


}
