using PetshopMobileProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;

namespace PetshopMobileProgreso2.Services
{
    public class ServicioApiPro : IServicioApiPro
    {
        private static string Url = "http://10.0.2.2:5062/";

        public ServicioApiPro() 
        {

        }

        public async Task<string> EditarProducto(int id, Producto producto)
        {
            string httpsResponseCode = HttpStatusCode.BadRequest.ToString();
            HttpClient clienteHttp = new HttpClient();  
            clienteHttp.BaseAddress = new Uri(Url);
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await clienteHttp.PutAsync("api/Producto/"+id, content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync(); 
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                httpsResponseCode = resultado.httpResponseCode;
            }
            return httpsResponseCode;
        }

        public async Task<string> EliminarProducto(int id)
        {
            string httpsResponseCode = HttpStatusCode.BadRequest.ToString();
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri(Url);
            var response = await clienteHttp.DeleteAsync("api/Producto/" + id);
            if(response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                httpsResponseCode = resultado.httpResponseCode;
            }
            return httpsResponseCode;
        }


        public async Task<string> GuardarProducto(Producto producto)
        {
            string httpsResponseCode = HttpStatusCode.BadRequest.ToString();
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri(Url);
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await clienteHttp.PostAsync("api/Producto", content);
            if(response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                httpsResponseCode = resultado.httpResponseCode;
            }
            return httpsResponseCode;
        }

        public async Task<List<Producto>> ListarProductos()
        {
            List<Producto> productos = new List<Producto>();
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri(Url);
            var response = await clienteHttp.GetAsync("api/Producto");
            if(response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                productos = resultado.listaProductos;
            }
            return productos;
        }

        public async Task<Producto> ObtenerProducto(int id)
        {
            Producto producto = new Producto(); 
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri(Url);
            var response = await clienteHttp.GetAsync("api/Producto/"+id);
            if(response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi> (json_response);  
                producto = resultado.producto;
            }
            return producto;
        }

     }
}
