Account account = new Account();
account.Owner = "Alex";
Console.WriteLine(account.Owner);
Console.WriteLine($"{account.Balance}$");

account.Deposit();
account.Deposit();
account.Withdraw();
