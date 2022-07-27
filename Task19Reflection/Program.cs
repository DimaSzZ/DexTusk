namespace Task19Reflection;
using  System.Reflection;
class Program
{
    static void Main()
    {
        var typePrClass = typeof(PrivateTestClass);
        var secretName = typePrClass.GetField("SecretName", BindingFlags.NonPublic | BindingFlags.Instance);
        var secretNum = typePrClass.GetField("SecretNum", BindingFlags.NonPublic | BindingFlags.Instance);
        var privateClassObj = new PrivateTestClass();
        var secretMet = typePrClass.GetMethod("SecretMet", BindingFlags.Instance | BindingFlags.NonPublic);
        secretMet?.Invoke(privateClassObj, new[]{ secretName?.GetValue(privateClassObj), secretNum?.GetValue(privateClassObj)});
    }
}