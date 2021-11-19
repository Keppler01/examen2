using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace examen2
{
    class alumnosM
    {
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");
            return client;
        }
        public async Task<IEnumerable<alumnos>> getUsuarios()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(App.url + "verUser.php");
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<alumnos>>(content);
            }
            return Enumerable.Empty<alumnos>();
        }

        public async Task<IEnumerable<alumnos>> TraerEstudiantes(string rne)
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(App.url + "verUser.php?rne=" + rne);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<alumnos>>(content);
            }
            return Enumerable.Empty<alumnos>();
        }
    }
}
