Account acc = new();
acc.username = "lorem123";
acc.password = "123456";

string Username = Console.ReadLine();
string Password = Console.ReadLine();
acc.login(Username, Password);