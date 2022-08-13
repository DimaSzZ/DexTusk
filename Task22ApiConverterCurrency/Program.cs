using RestSharp;
using Newtonsoft.Json;
using Task22ApiConverterCurrency;

class MyClass
{
    [Obsolete("Obsolete")]
    static void Main()
    {
        Console.WriteLine("Выберете валюту донара");
        Console.WriteLine("1-Рубль 2-USD 3-Гривна");
        var donor = Console.ReadLine() switch
        {
            "1" => "RUB",
            "2" => "USD",
            "3" => "UAH",
        };
        Console.WriteLine("Выберете валюту для конвертации");
        Console.WriteLine("1-Рубль 2-USD 3-Гривна");
        var recipient = Console.ReadLine() switch
        {
            "1" => "RUB",
            "2" => "USD",
            "3" => "UAH",
        };
        Console.WriteLine("Введите количество денег для конвератции ");
        var cash = decimal.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        var infoUrl = $"https://api.apilayer.com/currency_data/convert?to={recipient}&from={donor}&amount={cash}";
        var client = new RestClient(infoUrl);
        client.Options.Timeout = -1;

        var request = new RestRequest(infoUrl);
        request.AddHeader("apikey", "Q6Sk5SSVyB199WioBZu4VTRZEer1siUF");

        var response = Post(client,request);
        Console.WriteLine(response.Result.Content);
        var requestGetData = JsonConvert.DeserializeObject<ClassDesJson>(response.Result.Content!);
        Console.WriteLine(requestGetData.result);
    }

    public static async Task<RestResponse> Post(RestClient client,RestRequest request)
    {
        var response = await client.ExecuteAsync(request);
        return response;
    }
}
