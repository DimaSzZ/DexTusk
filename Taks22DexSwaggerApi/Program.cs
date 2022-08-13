using Taks22DexSwaggerApi;

class MyClass
{
    static void Main()
    {
        var reqParam = new RequestClass(
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoi0JHQvtCz0LTQsNC9IiwidGVuYW50IjoiNzI5IiwibmJmIjoxNjYwMzg3Njg1LCJleHAiOjE2NjA0NzQwODUsImlzcyI6IlRlc3QtQmFja2VuZC0xIiwiYXVkIjoiQmFza2V0QmFsbENsdWJTYW1wbGUifQ.GW5G237C4pT3fMW8Nxiqwgr55JIU21fNP_W3ABbUwvU");
        var player = new Player
        {
            Name = "MyTestUnit",
            Number = 455,
            Position = "Guard",
            Team = 1045,
            Birthday = new DateTime(2000, 5, 10),
            Height = "190",
            Weight = "50",
            AvatarUrl = "SomeText"
        };
        RequestClass.Add(player);
        var resultRequest = RequestClass.GetPLayers();
        foreach (var playerObj in resultRequest.Result.Players)
        {
            Console.WriteLine($"Имя:{playerObj.Name} Команда:{playerObj.Team} Рост:{playerObj.Height}");
        }
    }
}
