namespace BankAccount
{
    public static class TestForHomeworkTwo
    {
        /// <summary>
        /// Запуск тестовых примеров
        /// </summary>
        public static void Start()
        {
            BankAccounts account1 = new();
            BankAccounts account2 = new(-25); 
            BankAccounts account3 = new(BankAccountType.Current);
            BankAccounts account4 = new(34, BankAccountType.Deposit);

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
