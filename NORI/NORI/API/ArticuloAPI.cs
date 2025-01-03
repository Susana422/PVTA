using NoriSDK;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace NORI.API
{
    public class ArticuloAPI
    {
        private HttpClient client = new HttpClient();

        private string path = Program.Nori.Configuracion.api_url + "articulos";

        public Articulo articulo { get; set; }

        public List<Articulo.Precio> precios { get; set; }

        public List<Articulo.Inventario> inventario { get; set; }

        public ArticuloAPI()
        {
            precios = new List<Articulo.Precio>();
            inventario = new List<Articulo.Inventario>();
        }

        public async Task<List<Articulo>> Obtener()
        {
            List<Articulo> articulos = new List<Articulo>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                articulos = await HttpContentExtensions.ReadAsAsync<List<Articulo>>(response.Content);
            }
            return articulos;
        }

        public async Task<Articulo> Obtener(int id)
        {
            Articulo articulo = new Articulo();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}");
            if (response.IsSuccessStatusCode)
            {
                articulo = await HttpContentExtensions.ReadAsAsync<Articulo>(response.Content);
            }
            return articulo;
        }

        public async Task<List<Articulo.Precio>> Precios(int id)
        {
            List<Articulo.Precio> precios = new List<Articulo.Precio>();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}/precios");
            if (response.IsSuccessStatusCode)
            {
                precios = await HttpContentExtensions.ReadAsAsync<List<Articulo.Precio>>(response.Content);
            }
            return precios;
        }

        public async Task<List<Articulo.Inventario>> Inventario(int id)
        {
            List<Articulo.Inventario> inventarios = new List<Articulo.Inventario>();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}/inventario");
            if (response.IsSuccessStatusCode)
            {
                inventarios = await HttpContentExtensions.ReadAsAsync<List<Articulo.Inventario>>(response.Content);
            }
            return inventarios;
        }

        public async Task<List<Articulo.CodigoBarras>> CodigosBarras(int id)
        {
            List<Articulo.CodigoBarras> codigos_barras = new List<Articulo.CodigoBarras>();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}/codigos-barras");
            if (response.IsSuccessStatusCode)
            {
                codigos_barras = await HttpContentExtensions.ReadAsAsync<List<Articulo.CodigoBarras>>(response.Content);
            }
            return codigos_barras;
        }

        public async Task<Articulo> Agregar(Articulo articulo)
        {
            HttpResponseMessage response = await HttpClientExtensions.PostAsJsonAsync<Articulo>(client, path, articulo);
            if (response.IsSuccessStatusCode)
            {
                articulo = await HttpContentExtensions.ReadAsAsync<Articulo>(response.Content);
            }
            return articulo;
        }

        public async Task<bool> Actualizar(Articulo articulo)
        {
            return (await HttpClientExtensions.PostAsJsonAsync<Articulo>(client, $"{path}/{articulo.id}", articulo)).IsSuccessStatusCode ? true : false;
        }

        public async Task<List<ArticuloAPI>> ActualizadosAPI(DateTime fecha)
        {
            List<ArticuloAPI> articulos = new List<ArticuloAPI>();
            string url = $"{path}/actualizados-api?fecha={fecha.ToString()}";
            client.Timeout = TimeSpan.FromMilliseconds(-1.0);
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                articulos = await HttpContentExtensions.ReadAsAsync<List<ArticuloAPI>>(response.Content);
            }
            return articulos;
        }

        public async Task<List<Articulo.Precio>> PreciosActualizados(DateTime fecha)
        {
            List<Articulo.Precio> precios = new List<Articulo.Precio>();
            string url = $"{path}/precios/actualizados?fecha={fecha.ToString()}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                precios = await HttpContentExtensions.ReadAsAsync<List<Articulo.Precio>>(response.Content);
            }
            return precios;
        }

        public async Task<List<Descuento>> DescuentosActualizados(DateTime fecha)
        {
            List<Descuento> descuentos = new List<Descuento>();
            string url = $"{path}/descuentos/actualizados?fecha={fecha.ToString()}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                descuentos = await HttpContentExtensions.ReadAsAsync<List<Descuento>>(response.Content);
            }
            return descuentos;
        }

        public async Task<List<Descuento.Periodo>> DescuentosPeriodoActualizados(DateTime fecha)
        {
            List<Descuento.Periodo> descuentos = new List<Descuento.Periodo>();
            string url = $"{path}/descuentos/periodo/actualizados?fecha={fecha.ToString()}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                descuentos = await HttpContentExtensions.ReadAsAsync<List<Descuento.Periodo>>(response.Content);
            }
            return descuentos;
        }

        public async Task<List<Descuento.Cantidad>> DescuentosCantidadActualizados(DateTime fecha)
        {
            List<Descuento.Cantidad> descuentos = new List<Descuento.Cantidad>();
            string url = $"{path}/descuentos/cantidad/actualizados?fecha={fecha.ToString()}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                descuentos = await HttpContentExtensions.ReadAsAsync<List<Descuento.Cantidad>>(response.Content);
            }
            return descuentos;
        }

        public async Task<List<Articulo.Inventario>> InventariosActualizados(DateTime fecha)
        {
            List<Articulo.Inventario> inventarios = new List<Articulo.Inventario>();
            string url = $"{path}/inventario/actualizados?fecha={fecha.ToString()}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                inventarios = await HttpContentExtensions.ReadAsAsync<List<Articulo.Inventario>>(response.Content);
            }
            return inventarios;
        }

        public async Task<List<Articulo.CodigoBarras>> CodigosBarrasActualizados(DateTime fecha)
        {
            List<Articulo.CodigoBarras> codigos_barras = new List<Articulo.CodigoBarras>();
            string url = $"{path}/codigos-barras/actualizados?fecha={fecha.ToString()}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                codigos_barras = await HttpContentExtensions.ReadAsAsync<List<Articulo.CodigoBarras>>(response.Content);
            }
            return codigos_barras;
        }
    }
}
