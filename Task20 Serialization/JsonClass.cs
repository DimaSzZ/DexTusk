using System.Globalization;
using Newtonsoft.Json;
namespace Task20_Serialization
{
    internal class JsonClass
    {
        public const string Path = "Json.json";
        public static JsonSerializer _js = new();
        [Obsolete("Obsolete")]
        public static void Serialize(ListFigure figure)
        {
            try
            {
                var json = JsonConvert.SerializeObject(figure, Formatting.Indented,
                    new JsonSerializerSettings { Culture = CultureInfo.InvariantCulture, ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                File.WriteAllText(Path, json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
        }
    }
}
