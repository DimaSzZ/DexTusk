using System.Runtime.Serialization.Formatters.Binary;

namespace Task20_Serialization;

internal class Program
{
    [Obsolete("Obsolete")]
    private static void Main()
    {
        var listFigureObj = new ListFigure();
        var listEmptyObj = new ListFigure();
        listFigureObj.AddFig(new Figure("Треугольник", 228));
        listFigureObj.AddFig(new Figure("Квадрат", 322));
        listFigureObj.AddFig(new Figure("Пирамида", 777));
        Console.WriteLine("1-Бинарный 2-Json 3-Xml");
        switch (Console.ReadLine())
        {
            case "1":
                BinaryClass.Serialize(listFigureObj);
                listEmptyObj = SpecialDeserializeClass.Deserialize(BinaryClass.Path,BinaryClass._bin);
                break;
            case "2":
                JsonClass.Serialize(listFigureObj);
                listEmptyObj = SpecialDeserializeClass.Deserialize(JsonClass.Path, JsonClass._js);
                break;
            case "3":
                XmlClass.Serialize(listFigureObj);
                listEmptyObj = SpecialDeserializeClass.Deserialize(XmlClass.Path, XmlClass._xml);
                break;
        }
        foreach (var objFig in listEmptyObj.AllFig)
        {
            Console.WriteLine($"{objFig.Name} {objFig.Square}");
        }
    }
}