using Newtonsoft.Json;

namespace Taks22DexSwaggerApi
{
    internal class AllPlayers
    {
        [JsonProperty("data")]
        public IEnumerable<Player> Players { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }

    }
}
