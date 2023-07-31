using Newtonsoft.Json;
using PetshopMobileProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PetshopMobileProgreso2.Services
{
    public class ServicioApiCli : IServicioApiCli
    {
        private static string Url = "http://10.0.2.2:5062/";

        public ServicioApiCli()
        {
            
        }
        
        public async Task<string> EditarCliente(int id, Cliente cliente)
        {
            string httpsResponseCode = HttpStatusCode.BadRequest.ToString();
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri(Url);
            var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");
            var response = await clienteHttp.PutAsync("api/Cliente/" + id, content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                httpsResponseCode = resultado.httpResponseCode;
            }
            return httpsResponseCode;
        }

        public Task<string> EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GuardarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri(Url);
            var response = await clienteHttp.GetAsync("api/Cliente");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                clientes = resultado.listaClientes;
            }
            return clientes;
        }

        public Task<Cliente> ObtenerCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
