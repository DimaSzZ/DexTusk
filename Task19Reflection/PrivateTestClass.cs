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
        public string NonSecret { get; set; }
    }
}
