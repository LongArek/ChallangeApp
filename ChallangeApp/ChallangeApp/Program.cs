using ChallangeApp;

var employee = new Employee("Arkadiusz", "Aleksiejuk");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statisctics = employee.GetStstistics();
Console.WriteLine($"Avarage: {statisctics.Average:N1}");
Console.WriteLine($"Min: {statisctics.Min}");
Console.WriteLine($"Max: {statisctics.Max}");





























//User user1 = new User("Kazik", "Kowalski");
//User user2 = new User("Jolanta", "Malinowska");
//User user3 = new User("Edek", "Zkrainykredek");

//user1.AddScore(10);
//user1.AddScore(10);
//user1.AddMinusScore(10);
//user1.AddScore(10);
//user1.AddScore(10);

//user2.AddScore(8);
//user2.AddScore(9);
//user2.AddScore(10);
//user2.AddScore(2);
//user2.AddScore(10);

//user3.AddScore(10);
//user3.AddScore(10);
//user3.AddScore(10);
//user3.AddScore(2);
//user3.AddScore(10);

//var result = user1.Result;
//Console.WriteLine(result);













//List<string> alphabet = new List<string>();

//alphabet.Add("a");
//alphabet.Add("b");
//alphabet.Add("c");
//alphabet.Add("d");
//alphabet.Add("e");
//alphabet.Add("f");
//alphabet.Add("g");
//alphabet.Add("h");
//alphabet.Add("i");
//alphabet.Add("j");
//alphabet.Add("k");
//alphabet.Add("l");
//alphabet.Add("m");
//alphabet.Add("n");
//alphabet.Add("o");
//alphabet.Add("p");
//alphabet.Add("r");
//alphabet.Add("s");
//alphabet.Add("t");
//alphabet.Add("u");
//alphabet.Add("w");
//alphabet.Add("y");
//alphabet.Add("z");


//foreach (var letters in alphabet)
//{
//    Console.WriteLine(letters);
//}
