using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopMobileProgreso2.Models
{
    public class ResultadoApi
    {
        public string httpResponseCode { get; set; }

        public List<Producto> listaProductos { get; set; }

        public Producto producto { get; set; }

        public List<Cliente> listaClientes { get; set; }

        public Cliente cliente { get; set; }
    }
}
