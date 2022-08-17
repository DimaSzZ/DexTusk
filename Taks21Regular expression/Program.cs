using System.Text.RegularExpressions;

class MyRegexClass
{
    public MyRegexClass(string text, Regex regex)
    {
        Text = text;
        Regex = regex;
    }
    public string Text { get; set; }
    public Regex Regex { get; set; }
    static void Main()
    {
        MyRegexClass? TestClass = null;
        MatchCollection? matches = null;
        TestClass = Console.ReadLine() switch
        {
            "1" => SelectNum(),
            "2" => QueryStringParameter(),
            "3" => RemoveWhiteSpaceToken(),
            "4" => SelectNumber(),
            _ => TestClass
        };
        matches = TestClass?.Regex.Matches(TestClass.Text);
        if (matches == null) return;
        foreach (Match zxc in matches)
        {
            Console.WriteLine(zxc.Groups[0].Value);
        }
    }
    public static MyRegexClass? SelectNum()
    {
        var text = "На 1  квадратном сантиметре  кожи могут жить 1000000 микроорганизмов. А вот вам десятичное число 100.23";
        var regex = new Regex(@"(1 |1000000|100.23)", RegexOptions.Compiled);
        return new MyRegexClass(text, regex);
    }

    public static MyRegexClass? QueryStringParameter()
    {
        var text = "http://ya.ru/api?r=1&x=23";
        var regex = new Regex(@"=([0-9]{0,5})");
        return new MyRegexClass(text, regex);
    }
    public static MyRegexClass? RemoveWhiteSpaceToken()
    {
        var text = "gvhlr534y3;ioy rew gujio;rehgv;orehvferhv rpe rjge rgjheio iogheiorthgberoi";
        var regex = new Regex(@"\s+(?!rew)");
        var zxc= regex.Replace(text, "");
        Console.WriteLine(zxc);
        return null;
    }
    public static MyRegexClass? SelectNumber()
    {
        var text = "Сергей:+373 77767852 Анатолий:77757899" +
                   "Дмитрий:0(777) 67852) Николай:+681 77755533";
        var regex = new Regex(@"([0-9]{8}$)|(\+373\s+([0-9]{8}))|(0\([0-9]{3}\)\s+([0-9]{5}))"); 
        return new MyRegexClass(text,regex);
    }
}
