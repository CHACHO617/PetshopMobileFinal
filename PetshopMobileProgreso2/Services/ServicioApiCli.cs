using PetshopMobileProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopMobileProgreso2.Services
{
    public class ServicioApiCli : IServicioApiCli
    {
        public Task<string> EditarCliente(int id, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<string> EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GuardarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> ListarClientes()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> ObtenerCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
