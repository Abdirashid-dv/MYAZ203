Bank user = new Bank();

user.FirstName = "arlinda";
user.LastName = "Uruci";
user.Deposit(400F);


Console.WriteLine(user.FullName);
Console.WriteLine(user.CheckAccount());
Console.WriteLine(user.Balance);
Console.WriteLine(user.AccountDate);