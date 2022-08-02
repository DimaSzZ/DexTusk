using System.Threading.Channels;

namespace Task19Reflection
{
    internal class PrivateTestClass
    {
        private string? SecretName = "Medusa";

        private int SecretNum = 777;


        private void SecretMet(string SecretName, int SecretNum)
        {
            Console.WriteLine($"{SecretName} and {SecretNum}");
        }
        private PrivateTestClass(string name, int num )
        {
            SecretName = name;
            SecretNum = num;
            Console.WriteLine("Мы перезаписали 2 переменные");
        }
        public PrivateTestClass(){}
        public override string ToString()
        {
            return $"Имя {SecretName} номер {SecretNum}";
        }
    }
}
