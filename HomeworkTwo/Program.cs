namespace BankAccount
{
    public class Program
    {
        public static void Main()
        {
            BankAccount account1 = new();
            BankAccount account2 = new(-25);
            BankAccount account3 = new(BankAccountType.Current);
            BankAccount account4 = new(34, BankAccountType.Deposit);

            account1.PutMoneyIn(24);
            account2.PutMoneyIn(24);
            account3.PutMoneyIn(24);
            account4.PutMoneyIn(24);

            account1.Withdrawal(25);
            account2.Withdrawal(25);
            account3.Withdrawal(25);
            account4.Withdrawal(25);
            
            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            account4.ShowInfo();
        }
    }
}
