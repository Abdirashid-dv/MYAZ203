BankAccount user = new BankAccount();

user.FirstName = "Abdirashid";
user.LastName = "Mowlid";
user.Deposit(400F);


user.Deposit(1000);
user.Withdraw(500);
user.AccountActivities();
user.CheckAccount();