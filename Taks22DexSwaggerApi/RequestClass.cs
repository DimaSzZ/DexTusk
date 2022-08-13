using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Taks22DexSwaggerApi
{
    internal class RequestClass
    {
        public RequestClass(string? token)
        {
            Token = token;
        }

        public static string? Token { get; set; }

        public static async Task<AllPlayers?> GetPLayers()
        {
            AllPlayers? allPlayers;
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Bearer", Token);
            var responseMessage = await client.GetAsync("http://dev.trainee.dex-it.ru/api/Player/GetPlayers");
            responseMessage.EnsureSuccessStatusCode();
            var message = await responseMessage.Content.ReadAsStringAsync();
            allPlayers = JsonConvert.DeserializeObject<AllPlayers>(message);
            return allPlayers;
        }
        public static async void Add(Player player)
        {
            var serialisedTeam = JsonConvert.SerializeObject(player);
            var content = new StringContent(serialisedTeam, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue("Bearer", Token);
            await client.PostAsync("http://dev.trainee.dex-it.ru/api/Player/Add", content);
        }
    }
}
