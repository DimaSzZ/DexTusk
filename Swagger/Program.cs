using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

public class TeamService
{
    private readonly string _token;

    public TeamService(string token)
    {
        _token = token ?? throw new ArgumentNullException(nameof(token));
    }

    public async Task<TeamResponse> GetTeams()
    {
        TeamResponse teams;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue("Bearer", _token);


            HttpResponseMessage responseMessage =
                await client.GetAsync("http://dev.trainee.dex-it.ru/api/Team/GetTeams");
            responseMessage.EnsureSuccessStatusCode();
            string message = await responseMessage.Content.ReadAsStringAsync();

            teams = JsonConvert.DeserializeObject<TeamResponse>(message);
        }

        return teams;
    }
    public class TeamResponse
    {
        [JsonProperty("data")]
        public IEnumerable<Team> Teams { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoudationYer { get; set; }
        public string Division { get; set; }
        public string Conference { get; set; }
        public string ImageUrl { get; set; }
    }
    public async Task Add(Team team)
    {
        string serialisedTeam = JsonConvert.SerializeObject(team);

        var content = new StringContent(serialisedTeam, Encoding.UTF8, "application/json");
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _token);

            await client.PostAsync("http://dev.trainee.dex-it.ru/api/Team/Add", content);
        }
    }
}

class MyClass
{
    static void Main()
    {
        var service = new TeamService("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoi0JHQvtCz0LTQsNC9IiwidGVuYW50IjoiNzI5IiwibmJmIjoxNjYwMTY1NTIyLCJleHAiOjE2NjAyNTE5MjIsImlzcyI6IlRlc3QtQmFja2VuZC0xIiwiYXVkIjoiQmFza2V0QmFsbENsdWJTYW1wbGUifQ.GmTuwRbHjHYznLLci2AeRMLrlOfQwkK5fJ6ZgHP-rS8");
        var myCustomTeam = new TeamService.Team
        {
            Name = "Спарчсчясчяс",
            FoudationYer = new DateTime(1955, 4, 18),
            Division = "Aцуццуйцуйц",
            Conference = "Yesйцууйц  ",
            ImageUrl = "Stichцйуцу"
        };
        metAs(myCustomTeam,service);
        var zxc = service.GetTeams();
        var collection = zxc.Result.Teams;
        foreach (var mss in collection)
        {
            Console.WriteLine($"{mss.Id} {mss.Name} {mss.FoudationYer} {mss.Conference} {mss.ImageUrl} ");
        }
        Console.WriteLine();
        Console.WriteLine(zxc.Result.Count);
        
    }

    static async void metAs(TeamService.Team tst, TeamService ts)
    {
        await ts.Add(tst);
    }
}
