#pragma warning disable CS8618

namespace BankAccount
{
    public class BankAccount
    {
        private string AccountId { get; set; }
        private int Balance { get; set; }
        private BankAccountType AccountType { get; set; }

        /// <summary>
        /// Конструктор по умолчанию, все значения будут приведены к нулю
        /// </summary>
        public BankAccount()
        {
            CreateAccount();
        }

        /// <summary>
        /// Конструктор, назначение начального баланса
        /// </summary>
        /// <param name="balance"></param>
        public BankAccount(int balance)
        {
            CreateAccount(balance);
        }

        /// <summary>
        /// Конструктор, назначение типа банковского счёта
        /// </summary>
        /// <param name="accountType"></param>
        public BankAccount(BankAccountType accountType)
        {
            CreateAccount(0, accountType);
        }

        /// <summary>
        /// Конструктор, назначение начального баланса и типа банковского счёта
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="accountType"></param>
        public BankAccount(int balance, BankAccountType accountType)
        {
            CreateAccount(balance, accountType);
        }

        private void CreateAccount(int balance = 0, BankAccountType accountType = BankAccountType.Current)
        {
            Balance = balance;
            AccountId = CreatorIdForBankAccount.GenerateId();
            AccountType = accountType;
        }

        /// <summary>
        /// Вывод информации об аккаунте 
        /// </summary>
        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Balance = {Balance}\n" +
                              $"Card account - {AccountId}\n" +
                              $"Type card account - {AccountType}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        /// <summary>
        /// Пополнение баланс
        /// </summary>
        /// <param name="money"></param>
        public void PutMoneyIn(int money)
        {
            Balance += money;
        }

        /// <summary>
        /// снятие средств с банковской карточки
        /// </summary>
        /// <param name="money"></param>
        public void Withdrawal(int money)
        {
            if (money < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Извивните, введите корректное значение!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else if (Balance - money < 0 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Извивните, у Вас недостаточно средств, пожалуйста, введите корректное значение!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Balance -= money;
            }
        }
    }
}
