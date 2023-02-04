using ChallangeApp;

var user1 = new Employee("Kazik", "Kowalski", "45 lat");
var user2 = new Employee("Jolanta", "Malinowska", "23 lat");
var user3 = new Employee("Edek", "Zkrainykredek", "58 lat");

user1.AddScore(10);
user1.AddScore(10);
user1.AddScore(10);
user1.AddScore(10);
user1.AddScore(10);

user2.AddScore(8);
user2.AddScore(9);
user2.AddScore(10);
user2.AddScore(2);
user2.AddScore(10);

user3.AddScore(10);
user3.AddScore(10);
user3.AddScore(10);
user3.AddScore(2);
user3.AddScore(10);

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
        maxResult = user.Result;
        userWithMaxResult = user;
    }
}

Console.WriteLine("Pracownik, który otrzymał najwiekszą ilość punktów: " +
    userWithMaxResult.Name+" "+userWithMaxResult.Surname+" "+userWithMaxResult.Age);
Console.WriteLine("Punkty: "+ userWithMaxResult.Result);


Console.ReadLine();

