using System.Runtime.Serialization.Formatters.Binary;

namespace Task_16FileStream
{
    public class FileStreamClass
    {
        [Obsolete("Obsolete")]
        public static void AddClientFile(string client)
        {
            List<string>? clients = new();
            using var fs = new FileStream("ClientsFio.dat", FileMode.OpenOrCreate);
            try
            {
                clients = (List<string>)new BinaryFormatter().Deserialize(fs);
                if (clients!.All(x => x != client))
                {
                    clients!.Add(client);
                }
                new BinaryFormatter().Serialize(fs, clients);
            }
            catch (Exception)
            {
                clients.Add(client);
                new BinaryFormatter().Serialize(fs, clients);
            }
            
        }
        [Obsolete("Obsolete")]
        public static void SaveDictionaryClients(Dictionary<string, List<InfoValuteAccount>>? allClients)
        {
            using var fs = new FileStream("ClientsFullAccounts.dat", FileMode.OpenOrCreate);
            new BinaryFormatter().Serialize(fs, allClients);
        }
        [Obsolete("Obsolete")]
        public static Dictionary<string, List<InfoValuteAccount>>? DropDictionaryClients()
        {
            using (new FileStream("ClientsFullAccounts.dat", FileMode.OpenOrCreate)) ;
            if (File.ReadAllText("ClientsFullAccounts.dat").Length == 0)
            {
                Console.WriteLine("Вы первый клиент");
                return null;
            }
            else
            {
                using var fs = new FileStream("ClientsFullAccounts.dat", FileMode.OpenOrCreate);
                var allClients = (Dictionary<string, List<InfoValuteAccount>>)new BinaryFormatter().Deserialize(fs);
                return allClients;
            }
        }
    }
}
