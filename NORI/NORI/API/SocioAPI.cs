using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NoriSDK;

namespace NORI.API
{
    public class SocioAPI
    {
        private HttpClient client = new HttpClient();

        private string path = Program.Nori.Configuracion.api_url + "socios";

        public async Task<List<Socio>> Obtener()
        {
            List<Socio> socios = new List<Socio>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                socios = await HttpContentExtensions.ReadAsAsync<List<Socio>>(response.Content);
            }
            return socios;
        }

        public async Task<Socio> Obtener(int id)
        {
            Socio socio = new Socio();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}");
            if (response.IsSuccessStatusCode)
            {
                socio = await HttpContentExtensions.ReadAsAsync<Socio>(response.Content);
            }
            return socio;
        }

        public async Task<List<Socio.Direccion>> Direcciones(int id)
        {
            List<Socio.Direccion> direcciones = new List<Socio.Direccion>();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}/direcciones");
            if (response.IsSuccessStatusCode)
            {
                direcciones = await HttpContentExtensions.ReadAsAsync<List<Socio.Direccion>>(response.Content);
            }
            return direcciones;
        }

        public async Task<List<Socio.PersonaContacto>> PersonasContacto(int id)
        {
            List<Socio.PersonaContacto> personas_contacto = new List<Socio.PersonaContacto>();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}/personas-contacto");
            if (response.IsSuccessStatusCode)
            {
                personas_contacto = await HttpContentExtensions.ReadAsAsync<List<Socio.PersonaContacto>>(response.Content);
            }
            return personas_contacto;
        }

        public async Task<Socio> Agregar(Socio socio)
        {
            HttpResponseMessage response = await HttpClientExtensions.PostAsJsonAsync<Socio>(client, path, socio);
            if (response.IsSuccessStatusCode)
            {
                socio = await HttpContentExtensions.ReadAsAsync<Socio>(response.Content);
            }
            return socio;
        }

        public async Task<Socio.Direccion> AgregarDireccion(Socio.Direccion direccion)
        {
            HttpResponseMessage response = await HttpClientExtensions.PostAsJsonAsync<Socio.Direccion>(client, $"{path}/direccion", direccion);
            if (response.IsSuccessStatusCode)
            {
                direccion = await HttpContentExtensions.ReadAsAsync<Socio.Direccion>(response.Content);
            }
            return direccion;
        }

        public async Task<Socio.PersonaContacto> AgregarPersonaContacto(Socio.PersonaContacto persona_contacto)
        {
            HttpResponseMessage response = await HttpClientExtensions.PostAsJsonAsync<Socio.PersonaContacto>(client, $"{path}/persona-contacto", persona_contacto);
            if (response.IsSuccessStatusCode)
            {
                persona_contacto = await HttpContentExtensions.ReadAsAsync<Socio.PersonaContacto>(response.Content);
            }
            return persona_contacto;
        }

        public async Task<bool> Actualizar(Socio socio)
        {
            return (await HttpClientExtensions.PostAsJsonAsync<Socio>(client, $"{path}/{socio.id}", socio)).IsSuccessStatusCode ? true : false;
        }

        public async Task<List<Socio>> Actualizados(DateTime fecha)
        {
            List<Socio> socios = new List<Socio>();
            string url = $"{path}/actualizados?fecha={fecha.ToString()}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                socios = await HttpContentExtensions.ReadAsAsync<List<Socio>>(response.Content);
            }
            return socios;
        }
    }

}
