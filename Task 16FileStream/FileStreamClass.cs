using System.Runtime.Serialization.Formatters.Binary;

namespace Task_16FileStream
{
    internal class FileStreamClass
    {
        [Obsolete("Obsolete")]
        public static void AddClientFile(string client)
        {
            List<string> clients;
            using var fs = new FileStream(@"C:\ClientsInfo\ClientsFio.dat", FileMode.OpenOrCreate);
            clients = (List<string>)new BinaryFormatter().Deserialize(fs);
            clients.Add(client);
            new BinaryFormatter().Serialize(fs, clients);
        }
        [Obsolete("Obsolete")]
        public static void SaveDictionaryClients(Dictionary<string, List<InfoValuteAccount>> allClients)
        {
            using var fs = new FileStream(@"C:\ClientsInfo\ClientsFullAccounts.dat", FileMode.OpenOrCreate);
            new BinaryFormatter().Serialize(fs, allClients);
        }
        [Obsolete("Obsolete")]
        public static Dictionary<string,List<InfoValuteAccount>> DropDictionaryClients()
        {
            using var fs = new FileStream(@"C:\ClientsInfo\ClientsFullAccounts.dat", FileMode.OpenOrCreate);
            var allClients = (Dictionary<string, List<InfoValuteAccount>>)new BinaryFormatter().Deserialize(fs);
            return allClients;
        }
    }
}
