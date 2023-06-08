using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetshopMobileProgreso2.Models;
using PetshopMobileProgreso2.Services;


namespace PetshopMobileProgreso2.Utils
{
    class ListaGlobal
    {
        
        static public List<Producto> listaGlobalProductos = new List<Producto>();

        public void AgregarAListaGlobal(Producto producto)
        {
            producto.Cantidad = 1;
            listaGlobalProductos.Add(producto);
        }

        public double Sumatoria()
        {
            double sum = 0;
            foreach (Producto product in listaGlobalProductos)
            {
                sum = product.Precio + sum;
            }
            return sum;
        }

        
    }
}
