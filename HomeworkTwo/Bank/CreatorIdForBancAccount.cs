namespace BankAccount
{
    public static class CreatorIdForBankAccount
    {
        /// <summary>
        /// Генерация Id
        /// </summary>
        /// <returns></returns>
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
