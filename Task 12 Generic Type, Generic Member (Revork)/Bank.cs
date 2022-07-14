namespace Task_9_Generic_Type__Generic_Member
{
    internal class Bank
    {
        public readonly List<Client> _clients = new List<Client>();
        public readonly List<Employee> _employes = new List<Employee>();
        public void Registarion_Logic<T>(T x)
        {
            switch (x)
            {
                case Client client:
                    _clients.Add(client);
                    break;
                case Employee employee:
                    _employes.Add(employee);
                    break;
            }
        }

        public void Search_Logic<T>(T x)
        {
            switch (x)
            {
                case Client:
                {
                    var client = _clients.First(z => z.Id == (x as Client).Id);
                    Console.WriteLine($"Работа велась с клиентом {client.Id} {client.Name} {client.Age}");
                    break;
                }
                case Employee:
                {
                    var employee = _employes.First(z => z.Id == ((x as Employee)!).Id);
                    Console.WriteLine($"Работа велась с работником {employee.Id} {employee.Name} {employee.Age}");
                    break;
                }
            }
        }
    }
}
