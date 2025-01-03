using NoriSDK;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NORI.API
{
    public class DocumentoAPI
    {
        private HttpClient client = new HttpClient();

        private string path = Program.Nori.Configuracion.api_url + "documentos";

        public async Task<List<Documento>> Obtener()
        {
            List<Documento> documentos = new List<Documento>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                documentos = await HttpContentExtensions.ReadAsAsync<List<Documento>>(response.Content);
            }
            return documentos;
        }

        public async Task<Documento> Obtener(int id)
        {
            Documento documento = new Documento();
            HttpResponseMessage response = await client.GetAsync($"{path}/{id}");
            if (response.IsSuccessStatusCode)
            {
                documento = await HttpContentExtensions.ReadAsAsync<Documento>(response.Content);
            }
            return documento;
        }

        public async Task<Documento> Agregar(Documento documento)
        {
            HttpResponseMessage response = await HttpClientExtensions.PostAsJsonAsync<Documento>(client, path, documento);
            if (response.IsSuccessStatusCode)
            {
                documento = await HttpContentExtensions.ReadAsAsync<Documento>(response.Content);
            }
            return documento;
        }

        public async Task<bool> Actualizar(Documento documento)
        {
            return (await HttpClientExtensions.PostAsJsonAsync<Documento>(client, $"{path}/{documento.id}", documento)).IsSuccessStatusCode ? true : false;
        }
    }

}
