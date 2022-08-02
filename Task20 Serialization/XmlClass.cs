using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Task20_Serialization
{
    internal class XmlClass
    {
        public const string Path = "XmlFile.XML";
        public static XmlSerializer _xml = new(typeof(ListFigure));
        [Obsolete("Obsolete")]
        public static void Serialize(ListFigure figure)
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
                    var dcs = new DataContractSerializer(typeof(ListFigure), dcss);
                    dcs.WriteObject(memoryStream, figure);
                    File.WriteAllText(Path, Encoding.UTF8.GetString(memoryStream.ToArray()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
        }
    }
}
