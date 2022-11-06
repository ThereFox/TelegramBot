using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp2.Controllers
{
    public class APICommand
    {
        private Lazy<HttpClient> _client = new();

        public async Task<string> Execute()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://v2.jokeapi.dev/joke/Programming?format=txt&type=single");

            var response = await _client.Value.SendAsync(request);


            return await response.Content.ReadAsStringAsync();
    }


    }
}
