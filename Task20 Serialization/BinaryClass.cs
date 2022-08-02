using System.Runtime.Serialization.Formatters.Binary;

namespace Task20_Serialization
{
    internal class BinaryClass
    {
        public const string Path = "Binary.dat";
        public static BinaryFormatter _bin = new BinaryFormatter();
        [Obsolete("Obsolete")]
        public static void Serialize(ListFigure figure)
        {
            using var stream = new FileStream(Path, FileMode.OpenOrCreate);
            try
            {
                _bin.Serialize(stream, figure);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
        }
    }
}
