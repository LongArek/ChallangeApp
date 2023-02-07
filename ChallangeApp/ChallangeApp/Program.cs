using ChallangeApp;

User user1 = new User("Kazik", "Kowalski");
User user2 = new User("Jolanta", "Malinowska");
User user3 = new User("Edek", "Zkrainykredek");

user1.AddScore(10);
user1.AddScore(10);
user1.AddMinusScore(10);
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

var result = user1.Result;
Console.WriteLine(result);

