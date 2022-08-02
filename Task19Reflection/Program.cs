namespace Task19Reflection;
using  System.Reflection;

internal class Program
{
    private static void Main()
    {
        var typePrClass = typeof(PrivateTestClass);
        var secretName = typePrClass.GetField("SecretName", BindingFlags.NonPublic | BindingFlags.Instance);
        var secretNum = typePrClass.GetField("SecretNum", BindingFlags.NonPublic | BindingFlags.Instance);
        var privateClassObj = new PrivateTestClass();
        var secretMet = typePrClass.GetMethod("SecretMet", BindingFlags.Instance | BindingFlags.NonPublic);
        secretMet?.Invoke(privateClassObj, new[]{ secretName?.GetValue(privateClassObj), secretNum?.GetValue(privateClassObj)});
        var secretConstructor = typePrClass.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, new [] {typeof(string), typeof(int)});
        var mySecretClass = secretConstructor?.Invoke(new object[] {Console.ReadLine() ?? string.Empty,int.Parse(Console.ReadLine() ?? string.Empty)});
        Console.WriteLine(mySecretClass);
    }
}