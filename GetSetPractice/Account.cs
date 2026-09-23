public class Account
{
    public string Owner { get; set; } = "Owner";
    private int _balance;
    public int Balance
    {
        get { return _balance; }
        private set
        {
            if (value >= 0)
            {
                _balance = value;
            }
        }
    }
    public void Deposit()
    {
        Console.WriteLine($"Какую сумму вы хотите внести? Ваш счёт: {Balance}$");
        int amount;
        bool isNumber = int.TryParse(Console.ReadLine(), out amount);

        if (!isNumber)
        {
            Console.WriteLine("Введите число.");
            return;
        }
        if (amount > 0)
        {
            Balance = (amount + Balance);
            Console.WriteLine($"Вы ввели {amount}$, теперь на вашем счету {Balance}$");
        }
        else
        {
            Console.WriteLine("Введите корректную сумму.");
        }
    }
    public void Withdraw()
    {
        Console.WriteLine($"Какую сумму вы хотите снять? Ваш счёт: {Balance}$");
        int withdrawAmount;
        bool isNumber = int.TryParse(Console.ReadLine(), out withdrawAmount);

        if (!isNumber)
        {
            Console.WriteLine("Введите число.");
            return;
        }
        if (withdrawAmount > 0 && withdrawAmount <= Balance)
        {
            Balance = (Balance - withdrawAmount);
            Console.WriteLine($"Вы ввели {withdrawAmount}$, теперь на вашем счету {Balance}$");
        }
        else
        {
            Console.WriteLine("Введите корректную сумму");
        }
    }
}
