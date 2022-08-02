using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Task20_Serialization
{
    internal class SpecialDeserializeClass
    {
        [Obsolete("Obsolete")]
        public static ListFigure? Deserialize<T>(string path,T format)
        {
            ListFigure? items = null;
            try
            {
                 switch(format)
                {
                    case BinaryFormatter bin:
                        using (var stream = File.Open(path, FileMode.Open))
                        {
                            items = (ListFigure)bin.Deserialize(stream);
                        }
                        break;
                    case XmlSerializer xml:
                        using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(File.ReadAllText(path))))
                        {
                            var reader = XmlDictionaryReader.CreateTextReader(memoryStream, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                            var serializer = new DataContractSerializer(typeof(ListFigure));
                            items = serializer.ReadObject(reader) as ListFigure;
                        }
                        break;
                    case JsonSerializer js:
                        var jsonObj = File.ReadAllText(path);
                        items = JsonConvert.DeserializeObject<ListFigure>(jsonObj);
                        break;
                };
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            return items;
        }
    }
}
