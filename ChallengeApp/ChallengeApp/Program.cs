using ChallengeApp;

Employee user1 = new Employee("Adam", "Nowak", 32, 0);
Employee user2 = new Employee("Zuza", "Kamińska", 35, 0);
Employee user3 = new Employee("Lena", "Kowalska", 29, 0);

List<Employee> users = new List<Employee>()
{
   user1, user2, user3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;
        maxResult = user.Result;
    }
}

user1.AddScore(5);
user1.AddScore(6);
user1.AddScore(8);

user2.AddScore(6);
user2.AddScore(7);
user2.AddScore(3);

user3.AddScore(2);
user3.AddScore(9);
user3.AddScore(4);

Console.WriteLine(userWithMaxResult.Name + " " + userWithMaxResult.Surname + " lat " + userWithMaxResult.Age +" ilość punktów " + userWithMaxResult.Result);



